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
    public class Day
    {
        [JsonProperty("NumberDay")]
        public int NumberDay { get; set; }
        [JsonProperty("Mounth")]
        public int Mounth { get; set; }
        [JsonProperty("Year")]
        public int Year { get; set; }
        [JsonProperty("IsFree")]
        public bool IsFree { get; set; }
        [JsonProperty("HumanWhoReservation")]
        public User HumanWhoReservation { get; set; }
        public Day(int numberDay, int mounth, int year)
        {
            NumberDay = numberDay;
            Mounth = mounth;
            Year = year;
            IsFree = true;
            HumanWhoReservation = new User();
        }
        public Day()
        {
            NumberDay = 0;
            Mounth = 0;
            Year = 0;
            IsFree = true;
            HumanWhoReservation = new User();
        }
        public bool SetDayBooked(User human)//зробити день заброньованим
        {
            if (!IsFree) return false;
            IsFree = false;
            HumanWhoReservation = human;
            return true;
        }
    }
}
