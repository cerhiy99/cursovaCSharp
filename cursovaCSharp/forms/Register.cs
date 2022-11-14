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
    public partial class Register : Form
    {
        private Hotel hotel;
        public Register(Hotel hotel)
        {
            this.hotel = hotel;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)//кнопка зареєструвати
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)//кнопка зареєстуватися
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
                //провіряє чи користувач ввів дані
            {
                labelError.Text = "всі поля повинні бути заповнені";
                labelError.Visible = true;
                return;
            }
            if (textBox5.Text != textBox6.Text)//провірка на то чи співпадають паролі
            {
                labelError.Text = "паролі повинні співпадати";
                labelError.Visible = true;
                return;
            }
            if (!hotel.IsEmailFree(textBox4.Text))//провірка на то чи почта ще не використовується
            {
                labelError.Text = "почта вже зайнята";
                labelError.Visible = true;
                return;
            }
            string name = textBox1.Text;
            string surname = textBox2.Text;
            int age = ((int)numericUpDown1.Value);
            string email = textBox4.Text;
            string password = textBox5.Text;
            User user = new User(name, surname, age, password, email);//свторення нового користувача
            hotel.AddUser(user);//добавлення нового користувача
            Close();
        }
    }
}
