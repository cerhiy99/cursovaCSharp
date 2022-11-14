using cursovaCSharp.classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace cursovaCSharp
{
    internal static class Program
    {

        public static void SaveHotel(Hotel hotel)//статичний метод для зберігання даних готелю в файл
        {
            string json = JsonConvert.SerializeObject(hotel);
            using (Stream stream = new FileStream("hotel.json", FileMode.Create))
            {
                using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                {
                    writer.WriteLine(json);
                }
            }
        }
        public static Hotel SetHotel()//статичний метод для діставання даних з файлу
        {
            string json = "";
            using (Stream stream = new FileStream("hotel.json", FileMode.Open))
            {
                using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                {
                    while (!reader.EndOfStream)
                    {
                        json += reader.ReadLine();
                    }
                }
            }
            Hotel bank = JsonConvert.DeserializeObject<Hotel>(json);
            return bank;
        }

        [STAThread]
        static void Main()
        {
            Hotel hotel = SetHotel();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogIn(hotel));
            SaveHotel(hotel);
        }
    }
}
