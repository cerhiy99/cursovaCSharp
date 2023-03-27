using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace cursovaCSharp.classes
{
    [Serializable]
    public class Hotel
    {
        [JsonProperty("User")]
        public List<User> User { get; set; }

        [JsonProperty("HotelRoom")]
        public List<HotelRoom> HotelRoom { get; set; }

        [JsonProperty("History")]
        public History History { get; set; }
        public Hotel()
        {
            User = new List<User>();
            HotelRoom = new List<HotelRoom>();
            History = new History();
        }
        public bool IsEmailFree(string email)
        {
            for (int i = 0; i < User.Count; i++)
            {
                if (User[i].Email == email) return false;
            }
            return true;
        }
        public void AddUser(User newUser)
        {
            User.Add(newUser);
        }
        public void AddHotelRoom(HotelRoom hotelRoom)
        {
            HotelRoom.Add(hotelRoom);
        }
        public static bool IsDateDayMore(DateTime date, BookingDayDetails day)//чи дата дня більша
        {
            if (date.Year != day.Year) return date.Year < day.Year;
            if (date.Month != day.Month) return date.Month < day.Month;
            if (date.Day != day.NumberDay) return date.Day < day.NumberDay;
            return false;
        }
        public bool isDateSame(DateTime date, BookingDayDetails day)
        {
            if (date.Year != day.Year) return false;
            if (date.Month != day.Month) return false;
            if (date.Day != day.NumberDay) return false;
            return true;
        }
        public List<HotelRoom> SearchHotelRoom(int minCountStar, int minPrice, int maxPrice, DateTime startDate,
            DateTime finishTime, out bool isSearchTrue, List<DateTime> alternativeStartTime, List<DateTime> alternativeFinishTime)//пошук готелей які підходять по харектеристиці
        {
            List<HotelRoom> rooms = new List<HotelRoom>();//номера які підходять
            for (int i = 0; i < HotelRoom.Count; i++)
            {
                if (minCountStar <= HotelRoom[i].CountStar && minPrice <= HotelRoom[i].Price && maxPrice >= HotelRoom[i].Price)
                {
                    bool isRoomTrue = false;
                    var tempDate = startDate;
                    while (tempDate.Day != finishTime.Day || tempDate.Month != finishTime.Month ||
                        tempDate.Year != finishTime.Year)
                    {
                        isRoomTrue = false;
                        for (int j = 0; j < HotelRoom[i].DateReservation.Count; j++)
                        {
                            if (HotelRoom[i].DateReservation[j].IsFree && isDateSame(tempDate, HotelRoom[i].DateReservation[j]))
                            {
                                tempDate = tempDate.AddDays(1);
                                isRoomTrue = true;
                                break;
                            }
                        }
                        if (!isRoomTrue) break;
                    }
                    if (isRoomTrue)
                    {
                        rooms.Add(HotelRoom[i]);
                    }
                }
            }
            if (rooms.Count == 0)//якщо не було знайдено номерів які повнісью влаштовують то шукається альтернатива яка частково влаштує
            {
                isSearchTrue = false;
                for (int i = 0; i < HotelRoom.Count; i++)
                {
                    if (minCountStar <= HotelRoom[i].CountStar && minPrice <= HotelRoom[i].Price && maxPrice >= HotelRoom[i].Price)
                    {
                        List<(int idx, int idxI)> idx = new List<(int, int)>();
                        var tempDate = startDate;
                        while (tempDate.Day != finishTime.Day || tempDate.Month != finishTime.Month ||
                                tempDate.Year != finishTime.Year)
                        {
                            for (int j = 0; j < HotelRoom[i].DateReservation.Count; j++)
                            {
                                if (HotelRoom[i].DateReservation[j].IsFree && isDateSame(tempDate, HotelRoom[i].DateReservation[j]))
                                {
                                    if (idx.Count == 0 || idx[idx.Count - 1].idxI != i)
                                    {
                                        rooms.Add(HotelRoom[i]);
                                        alternativeStartTime.Add(tempDate);
                                        idx.Add((idx.Count + 1, i));
                                    }
                                    if (alternativeStartTime.Count > alternativeFinishTime.Count) alternativeFinishTime.Add(tempDate);
                                    else alternativeFinishTime[alternativeFinishTime.Count - 1] = tempDate;
                                    break;
                                }
                            }
                            tempDate = tempDate.AddDays(1);
                        }
                    }
                }
                return rooms;
            }
            else
            {
                isSearchTrue = true;
                return rooms;
            }
        }
        public void Book(DateTime startDate, DateTime finishDate, User user, HotelRoom room)//бронювати
        {
            DateTime tempDate = startDate;
            while (tempDate.Day != finishDate.Day || tempDate.Month != finishDate.Month ||
                        tempDate.Year != finishDate.Year)
            {
                bool isExit = false;
                for (int i = 0; i < room.DateReservation.Count; i++)
                {
                    if (isDateSame(tempDate, room.DateReservation[i]))
                    {
                        user.CountReservation++;
                        if (room.DateReservation[i].SetDayBooked(user))
                        {
                            isExit = true;
                        }
                        break;
                    }
                }
                if (!isExit) break;
                tempDate = tempDate.AddDays(1);
            }
        }
        public string GetUserWhoTheMostBooked()
        {
            if (User.Count == 0) return "Поки не було жодного клієнта";
            int max = int.MinValue;
            int idx = 0;
            for (int i = 0; i < User.Count; i++)
            {
                if (User[i].CountReservation > max)
                {
                    max = User[i].CountReservation;
                    idx = i;
                }
            }
            return User[idx].ToString();
        }
        public List<string> GetUsersWhichBookedMoreTwoDay()
        {
            List<string> users = new List<string>();
            for (int i = 0; i < User.Count; i++)
            {
                if (User[i].CountReservation > 2) users.Add(User[i].ToString());
            }
            return users;
        }
    }
}
