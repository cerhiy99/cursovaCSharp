using cursovaCSharp.classes;
using cursovaCSharp.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cursovaCSharp
{
    public partial class LogIn : Form
    {
        private Hotel hotel;
        public LogIn(Hotel hotel)
        {
            this.hotel = hotel;
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//кнопка зареєструватися кидає на форму з реєстрацією
        {
            Register register = new Register(hotel);
            register.ShowDialog();
        }

        private void LoginButtonClick(object sender, EventArgs e)//кнопка увійти, провіряє логін і пароль і якщо логін з паролем правильні
                                                                //кидає або на форму адміна або на форму користувача
        {
            if (loginInput.Text == "admin" && passwordInput.Text == "admin")
            {
                AdminPanel adminPanel = new AdminPanel(hotel);
                adminPanel.ShowDialog();    
                return;
            }
            for (int i = 0; i < hotel.User.Count; i++)//цикл який визначає який це користувач і провіряє чи правильний пароль
            {
                if (hotel.User[i].Email == loginInput.Text)
                {
                    if (hotel.User[i].IsPasswordTrue(passwordInput.Text))
                    {
                        SearchHotelRoom searchHotelRoom = new SearchHotelRoom(hotel, hotel.User[i]);
                        searchHotelRoom.ShowDialog();
                        return;
                    }
                    else
                    {
                        labelError.Text = "не правильний пароль";
                        labelError.Visible = true;
                        return;
                    }
                }
            }
            labelError.Text = "не правильна почта";
            labelError.Visible = true;

        }

        private void passwordInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}