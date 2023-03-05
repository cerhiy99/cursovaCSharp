using cursovaCSharp.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Day = cursovaCSharp.classes.Day;

namespace cursovaCSharp.forms
{
    public partial class AdminPanel : Form
    {
        private Hotel hotel;
        private List<string> listUsers;
        public AdminPanel(Hotel hotel)
        {
            this.hotel = hotel;
            InitializeComponent();
            labelUserWhoLivesInHotelTheLongest.Text = hotel.GetUserWhoTheMostBooked();
            listUsers = hotel.GetUsersWhichBookedMoreTwoDay();
            for (int i = 0; i < listUsers.Count; i++)
            {
                listBox1.Items.Add(listUsers[i]);
            }
            label16.Text = hotel.History.GetAverageMinStar().ToString();
            label17.Text = hotel.History.GetAverageMinPrice().ToString();
            label20.Text = hotel.History.GetAverageMaxPrice().ToString();
        }

        private void nUpDwnCountStar_ValueChanged(object sender, EventArgs e)//Змінення кількості зірок
        {
            if (((NumericUpDown)sender).Value == 5)//якщо вибрана кількість зірок = 5, тоді зробити додаткові зручності видимими
            {
                label11.Visible = true;
                textBox1.Visible = true;
            }
            else
            {
                label11.Visible = false;
                textBox1.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Hotel.IsDateDayMore(dateStart.Value, new Day(dateFinish.Value.Day, dateFinish.Value.Month, dateFinish.Value.Year)))
            {
                MessageBox.Show("початковий день не може бути більший або рівний за кінцевий");
                return;
            }
            var startDateTemp = dateStart.Value;
            HotelRoom newHotelRoom;
            newHotelRoom = new HotelRoom(((int)nUpDwnCountRoom.Value), ((int)nUpDwnCountStar.Value), ((int)nUpDwnArea.Value),
                ((int)nUpDownCountWindow.Value), ((int)nUpDownCountPlace.Value), ((int)nUpDownPrice.Value), textBox2.Text, textBox1.Text);
            while (dateStart.Value.Day != dateFinish.Value.Day || dateStart.Value.Month != dateFinish.Value.Month ||
                dateStart.Value.Year != dateFinish.Value.Year)//поки початковий день != кінцевому дню добавити в кімнаті день в який можна записатися
            {
                Day newDay = new Day(dateStart.Value.Day, dateStart.Value.Month, dateStart.Value.Year);
                newHotelRoom.DateReservation.Add(newDay);
                dateStart.Value = dateStart.Value.AddDays(1);
            }
            hotel.AddHotelRoom(newHotelRoom);
            dateStart.Value = startDateTemp;
            MessageBox.Show("добавлено");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)//Вибрати конкретного користувача
        {
            labelSelectUsersWhoBookMore2HotelRoom.Text = ((ListBox)sender).Text;
        }
    }
}
