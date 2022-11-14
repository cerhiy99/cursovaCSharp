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
    public partial class SettingAccount : Form
    {
        private User user;
        private Hotel hotel;
        public SettingAccount(Hotel hotel,User user)
        {
            this.hotel = hotel;
            this.user = user;
            InitializeComponent();
            textBox1.Text = user.Name;
            textBox2.Text = user.Surname;
            textBox4.Text = user.Email;
            
        }

        private void button1_Click(object sender, EventArgs e)// змінити імя або прізвище
        {
            user.Name = textBox1.Text;
            user.Surname = textBox2.Text;
            string email = user.Email;
            user.Email = "";
            if (hotel.IsEmailFree(textBox4.Text))
            {
                user.Email = textBox4.Text;
                MessageBox.Show("змінено");
            }
            else
            {
                user.Email = email;
                MessageBox.Show("почта зайнята");
            }
        }

        private void button2_Click(object sender, EventArgs e)//змінити пароль
        {
            if (textBox3.Text != textBox6.Text)
            {
                MessageBox.Show("паролі не співпадають");
                return;
            }
            if (user.ChangePassword(textBox5.Text, textBox3.Text))
            {
                MessageBox.Show("пароль поміняний");
            }
            else MessageBox.Show("не вірний пароль");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
