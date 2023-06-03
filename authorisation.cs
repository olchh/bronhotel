using bronhotel2;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bronhotel2
{
    public partial class authorisation : Form
    {
        public authorisation()
        {
            InitializeComponent();

            this.password_Auth.AutoSize = false; //автоматическое подстраивание координат отключено 
            this.password_Auth.Size = new Size(this.password_Auth.Size.Width, 40);
        }

        private void close_Auth_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void close_Auth_MouseEnter(object sender, EventArgs e)
        {
            close_Auth.ForeColor = Color.FromArgb(108, 105, 95); //при наведении меняется цвет
        }

        private void close_Auth_MouseLeave(object sender, EventArgs e)
        {
            close_Auth.ForeColor = Color.Black; //при убирании меняется цвет
        }



        Point lastPoint; //класс Point работает с координатами
        private void panel_Auth_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel_Auth_MouseDown(object sender, MouseEventArgs e)
        {

            lastPoint = new Point(e.X, e.Y);
        }

        private void enter_button_Auth_Click(object sender, EventArgs e)
        {
            if (login_Auth.Text == "admin")
            {
                if (password_Auth.Text == "1234")
                {
                    admBD f1 = new admBD();
                    f1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("неверный пароль..");
                }
            }

            else
            {
                DataBase dataBase = new DataBase();
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @userL AND `pass` = @userP", dataBase.getConnection());
                command.Parameters.Add("@userL", MySqlDbType.VarChar).Value = Convert.ToString(login_Auth.Text); //вместо заглушек
                command.Parameters.Add("@userP", MySqlDbType.VarChar).Value = Convert.ToString(password_Auth.Text);

                adapter.SelectCommand = command;
                adapter.Fill(table); //помещение введенных данных в таблицу 

                if (table.Rows.Count > 0)
                {
                    this.Hide(); //спрятать окно

                    user_window u_window = new user_window();
                    u_window.Show(); //открыли окно
                }
                else
                {
                    MessageBox.Show("неверный логин/пароль..");
                }
            }


            if (login_Auth.Text == "введите логин..") //функция проверки на пустоту
            {
                MessageBox.Show("вы не ввели логин..");
                return;
            }

            if (password_Auth.Text == "") //функция проверки на пустоту
            {
                MessageBox.Show("вы не ввели пароль..");
                return;
            }

        }

        private void login_Auth_Enter(object sender, EventArgs e)
        {
            if (login_Auth.Text == "введите логин..") //когда нажали на формочку
            {
                login_Auth.Text = "";
                login_Auth.ForeColor = Color.Black;
            }
        }

        private void login_Auth_Leave(object sender, EventArgs e)
        {
            if (login_Auth.Text == "") //когда вышли из формочки
            {
                login_Auth.Text = "введите логин..";
                login_Auth.ForeColor = Color.Gray;
            }
        }


    }
}

