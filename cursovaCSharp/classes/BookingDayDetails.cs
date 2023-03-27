using Newtonsoft.Json;
using NuGet.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursovaCSharp.classes
{
    [Serializable]
    public class BookingDateDetails

    {
        [JsonProperty("NumberDay")]
        public int NumberDay { get; set; }
        [JsonProperty("Month")]
        public int Month { get; set; }
        [JsonProperty("Year")]
        public int Year { get; set; }
        [JsonProperty("IsFree")]
        public bool IsFree { get; set; }
        [JsonProperty("HumanWhoReservation")]
        public User User { get; set; }
        public BookingDateDetails(int numberDay, int mounth, int year)
        {
            NumberDay = numberDay;
            Month = mounth;
            Year = year;
            IsFree = true;
            User = new User();
        }
        public BookingDateDetails()
        {
            NumberDay = 0;
            Month = 0;
            Year = 0;
            IsFree = true;
            User = new User();
        }
        public bool SetDayBooked(User human)//зробити день заброньованим
        {
            if (!IsFree) return false;
            IsFree = false;
            User = human;
            return true;
        }
    }
}
