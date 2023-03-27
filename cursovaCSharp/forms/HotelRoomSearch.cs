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

namespace cursovaCSharp.forms
{
    public partial class SearchHotelRoom : Form
    {
        private Hotel hotel;
        private User user;
        private List<HotelRoom> searchRoom = new List<HotelRoom>();
        private bool bookingAvailable;
        private List<DateTime> alternativeStart = new List<DateTime>();
        private List<DateTime> alternativeFinish = new List<DateTime>();
        public SearchHotelRoom(Hotel hotel, User user/*користувач який залогінився*/)
        {
            this.user = user;
            this.hotel = hotel;
            InitializeComponent();
            SetInfoForUser();
        }
        private void UpdateHistory()
        {
            hotel.History.CountMinStar.Add(int.Parse(minCountStar.Value.ToString()));
            hotel.History.CountMinPrice.Add(int.Parse(numericUpDown1.Value.ToString()));
            hotel.History.CountMaxPrice.Add(int.Parse(numericUpDown2.Value.ToString()));
        }
        private void SearchRooms()
        {
            cmbBoxListRoom.Items.Clear();
            List<HotelRoom> rooms = hotel.SearchHotelRoom(((int)minCountStar.Value), ((int)numericUpDown2.Value), ((int)numericUpDown1.Value),
                dateTimePicker1.Value, dateTimePicker2.Value, out bookingAvailable, alternativeStart, alternativeFinish);//пошук номерів які підходять
            searchRoom = rooms;
            availebleRoomsContainer.Visible = true;
            for (int i = 0; i < rooms.Count; i++)
            {
                cmbBoxListRoom.Items.Add(i + 1);
            }
            amenitiesPanel.Visible = false;
            selectedRoomDetails.Visible = false;
            bookingStatusPanel.Visible = !bookingAvailable;
            //cmbBoxListRoom.SelectedIndex = 0;
        }
        public void SetInfoForUser()//показати інформацію про користувача
        {
            label6.Text = user.ToString();
        }
        private void BookRoomButtonClick(object sender, EventArgs e)//забронювати
        {
            if (bookingAvailable) hotel.Book(dateTimePicker1.Value, dateTimePicker2.Value, user, hotel.HotelRoom[cmbBoxListRoom.SelectedIndex]);
            else hotel.Book(alternativeStart[cmbBoxListRoom.SelectedIndex], alternativeFinish[cmbBoxListRoom.SelectedIndex], user, hotel.HotelRoom[cmbBoxListRoom.SelectedIndex]);
            MessageBox.Show("Заброньовано");
            SearchRooms();
        }

        private void SearchButtonClick(object sender, EventArgs e)//кнопка шукати
        {
            UpdateHistory();
            SearchRooms();
        }

        private void AccountSettingsButton(object sender, EventArgs e)//настройка акаунту
        {
            SettingAccount settingAccount = new SettingAccount(hotel, user);
            settingAccount.ShowDialog();
            SetInfoForUser();
        }

        private void OnRoomSelected(object sender, EventArgs e)//вибрали інший номер
        {
            ShowRoom(searchRoom[cmbBoxListRoom.SelectedIndex]);
            if (cmbBoxListRoom.SelectedIndex != -1) selectedRoomDetails.Visible = true;
        }
        public void ShowRoom(HotelRoom hotelRoom)//показати номер
        {
            availebleRoomsContainer.Visible = true;
            countStar.Text = hotelRoom.CountStar.ToString();
            countRoom.Text = hotelRoom.CountRoom.ToString();
            countPlace.Text = hotelRoom.CountPlace.ToString();
            price.Text = hotelRoom.Price.ToString();
            area.Text = hotelRoom.Area.ToString();
            countWindow.Text = hotelRoom.CountWindow.ToString();
            houseApplication.Text = hotelRoom.HouseholdAppliances;
            if (hotelRoom.CountStar == 5)
            {
                amenitiesPanel.Visible = true;
                Amenities.Text = hotelRoom.Amenities.ToString();
            }
            else amenitiesPanel.Visible = false;
            if (!bookingAvailable)
            {
                panel3.Visible = true;
                bookingStatusPanel.Visible = true;
                lblDateStart.Text = alternativeStart[cmbBoxListRoom.SelectedIndex].ToString().Remove(10);
                lblDateFinish.Text = alternativeFinish[cmbBoxListRoom.SelectedIndex].ToString().Remove(10);
            }
            else bookingStatusPanel.Visible = false;

        }
    }
}
