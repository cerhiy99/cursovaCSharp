using cursovaCSharp.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cursovaCSharp.forms
{
    public partial class SearchHotelRoom : Form
    {
        private Hotel hotel;
        private User user;
        private List<HotelRoom> searchRoom = new List<HotelRoom>();
        private bool isSearchTrue;
        private List<DateTime> alternativeStart = new List<DateTime>();
        private List<DateTime> alternativeFinish = new List<DateTime>();
        public SearchHotelRoom(Hotel hotel, User user/*користувач який залогінився*/)
        {
            this.user = user;
            this.hotel = hotel;
            InitializeComponent();
            SetInfoForUser();
        }
        public void SetInfoForUser()//показати інформацію про користувача
        {
            label6.Text = user.ToString();
        }

        private void SearchRooms()
        {
            cmbBoxListRoom.Items.Clear();
            List<HotelRoom> rooms = hotel.SearchHotelRoom(((int)minCountStar.Value), ((int)numericUpDown2.Value), ((int)numericUpDown1.Value),
                dateTimePicker1.Value, dateTimePicker2.Value, out isSearchTrue, alternativeStart, alternativeFinish);//пошук номерів які підходять
            searchRoom = rooms;
            groupBox1.Visible = true;
            for (int i = 0; i < rooms.Count; i++)
            {
                cmbBoxListRoom.Items.Add(i + 1);
            }
            panelAmenities.Visible = false;
            panel1.Visible = false;
            panelAlternative.Visible = !isSearchTrue;
            //cmbBoxListRoom.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)//кнопка шукати
        {
            SearchRooms();
        }

        private void button1_Click(object sender, EventArgs e)//настройка акаунту
        {
            SettingAccount settingAccount = new SettingAccount(hotel, user);
            settingAccount.ShowDialog();
            SetInfoForUser();
        }

        private void cmbBoxListRoom_SelectedIndexChanged(object sender, EventArgs e)//вибрали інший номер
        {
            ShowRoom(searchRoom[cmbBoxListRoom.SelectedIndex]);
            if (cmbBoxListRoom.SelectedIndex != -1) panel1.Visible = true;
        }
        public void ShowRoom(HotelRoom hotelRoom)//показати номер
        {
            groupBox1.Visible = true;
            countStar.Text = hotelRoom.CountStar.ToString();
            countRoom.Text = hotelRoom.CountRoom.ToString();
            countPlace.Text = hotelRoom.CountPlace.ToString();
            price.Text = hotelRoom.Price.ToString();
            area.Text = hotelRoom.Area.ToString();
            countWindow.Text = hotelRoom.CountWindow.ToString();
            houseApplication.Text = hotelRoom.HouseholdAppliances;
            if (hotelRoom.CountStar == 5)
            {
                panelAmenities.Visible = true;
                Amenities.Text = hotelRoom.Amenities.ToString();
            }
            else panelAmenities.Visible = false;
            if (!isSearchTrue)
            {
                panel3.Visible = true;
                panelAlternative.Visible = true;
                lblDateStart.Text = alternativeStart[cmbBoxListRoom.SelectedIndex].ToString().Remove(10);
                lblDateFinish.Text = alternativeFinish[cmbBoxListRoom.SelectedIndex].ToString().Remove(10);
            }
            else panelAlternative.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)//забронювати
        {
            if (isSearchTrue) hotel.Book(dateTimePicker1.Value, dateTimePicker2.Value, user, hotel.HotelRoom[cmbBoxListRoom.SelectedIndex]);
            else hotel.Book(alternativeStart[cmbBoxListRoom.SelectedIndex], alternativeFinish[cmbBoxListRoom.SelectedIndex], user, hotel.HotelRoom[cmbBoxListRoom.SelectedIndex]);
            MessageBox.Show("Заброньовано");
            SearchRooms();
        }

    }
}
