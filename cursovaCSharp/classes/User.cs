using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursovaCSharp.classes
{
    [Serializable]
    public class User : Human
    {
        [JsonProperty("password")]
        private string password;

        [JsonProperty("Email")]
        public string Email { get; set; }

        [JsonProperty("CountReservation")]
        public int CountReservation { get; set; }
        public User(string name, string surname, int age, string password, string email) : base(name, surname, age)
        {
            this.password = password;
            Email = email;
            CountReservation = 0;
        }
        public User() : base()
        {
            password = "";
            Email = "";
            CountReservation = 0;
        }
        public bool ChangePassword(string oldPassword, string newPassword)
        {
            if (oldPassword != password) return false;
            else
            {
                password = newPassword;
                return true;
            }
        }
        public bool IsPasswordTrue(string pass)
        {
            return pass == password;
        }
        public override string ToString()
        {
            return base.ToString() + $", кількість бронювань: {CountReservation}, email: {Email}.";
        }
    }
}
