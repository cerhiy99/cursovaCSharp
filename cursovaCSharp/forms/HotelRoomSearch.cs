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
        private List<HotelRoom> availableRooms = new List<HotelRoom>();
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
            availableRooms = hotel.SearchHotelRoom(((int)minCountStar.Value), ((int)numericUpDown2.Value), ((int)numericUpDown1.Value),
                dateTimePicker1.Value, dateTimePicker2.Value);//пошук номерів які підходять
            if (availableRooms.Count == 0)
            {
                bookingAvailable = false;
                availableRooms = hotel.SearchAlternative(((int)minCountStar.Value), ((int)numericUpDown2.Value), ((int)numericUpDown1.Value), dateTimePicker1.Value, dateTimePicker2.Value, alternativeStart, alternativeFinish);
            }
            else
            {
                bookingAvailable = true;
            }
            UpdateSearchWindowUi();
        }

        private void UpdateSearchWindowUi()
        {
            availebleRoomsContainer.Visible = true;
            for (int i = 0; i < availableRooms.Count; i++)
            {
                cmbBoxListRoom.Items.Add(i + 1);
            }
            amenitiesPanel.Visible = false;
            selectedRoomDetails.Visible = false;
            bookingStatusPanel.Visible = !bookingAvailable;
        }

        public void SetInfoForUser()//показати інформацію про користувача
        {
            label6.Text = user.ToString();
        }
        private void BookRoomButtonClick(object sender, EventArgs e)//забронювати
        {
            if (bookingAvailable)
            {
                hotel.Book(dateTimePicker1.Value, dateTimePicker2.Value, user, hotel.HotelRooms[cmbBoxListRoom.SelectedIndex]);
            }
            else
            {
                hotel.Book(alternativeStart[cmbBoxListRoom.SelectedIndex], alternativeFinish[cmbBoxListRoom.SelectedIndex], user, hotel.HotelRooms[cmbBoxListRoom.SelectedIndex]);
            }
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
            ShowRoom(availableRooms[cmbBoxListRoom.SelectedIndex]);
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
