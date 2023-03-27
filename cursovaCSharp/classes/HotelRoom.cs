using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursovaCSharp.classes
{
    [Serializable]
    public class HotelRoom//клас номер готелю
    {

        [JsonProperty("CountRoom")]
        public int CountRoom { get; set; }

        [JsonProperty("CountStar")]
        public int CountStar { get; set; }

        [JsonProperty("Area")]
        public double Area { get; set; }

        [JsonProperty("CountWindow")]
        public int CountWindow { get; set; }

        [JsonProperty("CountPlace")]
        public int CountPlace { get; set; }

        [JsonProperty("Price")]
        public double Price { get; set; }

        [JsonProperty("HouseholdAppliances")]
        public string HouseholdAppliances { get; set; }

        [JsonProperty("DateReservation")]
        public List<BookingDayDetails> DateReservation { get; set; }//
        [JsonProperty("ListAmenities")]
        public string Amenities { get; set; }
        public HotelRoom()
        {
            CountRoom = 0;
            CountStar = 0;
            Area = 0;
            CountWindow = 0;
            CountPlace = 0;
            Price = 0;
            HouseholdAppliances = "";
        }
        public HotelRoom(int countRoom, int countStar, double area, int countWindow, int countPlace, double price,string householdAppliances, string amenities)
        {
            CountRoom = countRoom;
            CountStar = countStar;
            Area = area;
            CountWindow = countWindow;
            CountPlace = countPlace;
            Price = price;
            DateReservation = new List<BookingDayDetails>();
            HouseholdAppliances = householdAppliances;
            Amenities = amenities;
        }
    }
}
