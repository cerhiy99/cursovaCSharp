using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursovaCSharp.classes
{
    [Serializable]
    public class History
    {
        [JsonProperty("CountMinStar")]
        public List<int> CountMinStar { get; set; }

        [JsonProperty("CountMinPrice")]
        public List<int> CountMinPrice { get; set; }

        [JsonProperty("CountMaxPrice")]
        public List<int> CountMaxPrice { get; set; }
        public int GetAverageMinStar()
        {
            if (CountMinStar.Count == 0) return 0;
            return CountMinStar.Sum() / CountMinStar.Count();
        }
        public int GetAverageMinPrice()
        {
            if (CountMinPrice.Count == 0) return 0;
            return CountMinPrice.Sum() / CountMinPrice.Count();
        }
        public int GetAverageMaxPrice()
        {
            if (CountMaxPrice.Count == 0) return 0;
            return CountMaxPrice.Sum() / CountMaxPrice.Count();
        }
        public History()
        {
            CountMinStar = new List<int>();
            CountMaxPrice = new List<int>();
            CountMinPrice = new List<int>();
        }
    }
}
