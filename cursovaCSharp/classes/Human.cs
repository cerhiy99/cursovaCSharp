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
    public class Human
    {
        [JsonProperty("Name")]
        public string Name { get; set; }
        [JsonProperty("Surname")]
        public string Surname { get; set; }
        [JsonProperty("Age")]
        public int Age { get; set; }
        public Human()
        {
            Name = "";
            Surname = "";
            Age = 0;
        }
        public Human(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
        public override string ToString()
        {
            return $"ім'я: {Name}, прізцище: {Surname}, вік: {Age}";
        }
    }
}
