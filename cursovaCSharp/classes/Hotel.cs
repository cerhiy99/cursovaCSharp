using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using cursovaCSharp.classes;

namespace cursovaCSharp.classes
{
    [Serializable]
    public class Hotel
    {
        [JsonProperty("User")]
        public List<User> User { get; set; }

        [JsonProperty("HotelRoom")]
        public List<HotelRoom> HotelRooms { get; set; }

        [JsonProperty("History")]
        public History History { get; set; }
        public Hotel()
        {
            User = new List<User>();
            HotelRooms = new List<HotelRoom>();
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
            HotelRooms.Add(hotelRoom);
        }
        public static bool IsDateDayMore(DateTime date, BookingDateDetails day)//чи дата дня більша
        {
            if (date.Year != day.Year) return date.Year < day.Year;
            if (date.Month != day.Month) return date.Month < day.Month;
            if (date.Day != day.NumberDay) return date.Day < day.NumberDay;
            return false;
        }
        public bool isDateSame(DateTime date, BookingDateDetails day)
        {
            if (date.Year != day.Year) return false;
            if (date.Month != day.Month) return false;
            if (date.Day != day.NumberDay) return false;
            return true;
        }
        public List<HotelRoom> SearchAlternative(int minCountStar, int minPrice, int maxPrice, DateTime startDate,
            DateTime finishTime, List<DateTime> alternativeStartTime, List<DateTime> alternativeFinishTime)
        {
            List<HotelRoom> rooms = new List<HotelRoom>();
            for (int i = 0; i < HotelRooms.Count; i++)
            {
                if (minCountStar <= HotelRooms[i].CountStar && minPrice <= HotelRooms[i].Price && maxPrice >= HotelRooms[i].Price)
                {
                    List<(int idx, int idxI)> idx = new List<(int, int)>();
                    var tempDate = startDate;
                    while (tempDate.Day != finishTime.Day || tempDate.Month != finishTime.Month ||
                            tempDate.Year != finishTime.Year)
                    {
                        for (int j = 0; j < HotelRooms[i].DateReservation.Count; j++)
                        {
                            if (HotelRooms[i].DateReservation[j].IsFree && isDateSame(tempDate, HotelRooms[i].DateReservation[j]))
                            {
                                if (idx.Count == 0 || idx[idx.Count - 1].idxI != i)
                                {
                                    rooms.Add(HotelRooms[i]);
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
        public List<HotelRoom> SearchHotelRoom(int minCountStar, int minPrice, int maxPrice, DateTime startDate,
            DateTime finishTime)//пошук готелей які підходять по харектеристиці
        {
            List<HotelRoom> rooms = HotelRooms.FindAll(item => (minCountStar <= item.CountStar && minPrice <= item.Price && maxPrice >= item.Price));
            List<HotelRoom> roomsForDates = new List<HotelRoom>();
            foreach (var room in rooms)
            {
                bool roomAvailableForAllPeriod = false;
                var tempDate = startDate;
                while (tempDate.Day != finishTime.Day || tempDate.Month != finishTime.Month ||
                    tempDate.Year != finishTime.Year)
                {
                    roomAvailableForAllPeriod = false;
                    foreach (var dateReservation in room.DateReservation)
                    {
                        if (dateReservation.IsFree && isDateSame(tempDate, dateReservation))
                        {
                            tempDate = tempDate.AddDays(1);
                            roomAvailableForAllPeriod = true;
                            break;
                        }
                    }
                    if (!roomAvailableForAllPeriod) break;
                }
                if (roomAvailableForAllPeriod)
                {
                    roomsForDates.Add(room);
                }

            };
            return roomsForDates;
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
