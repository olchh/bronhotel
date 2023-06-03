using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace bronhotel2
{
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
            this.password_Reg.AutoSize = false; //автоматическое подстраивание координат отключено 
            this.password_Reg.Size = new Size(this.password_Reg.Size.Width, 45);

            login_Reg.Text = "введите логин..";
            login_Reg.ForeColor = Color.Gray;
        }

        private void close_Reg_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Point lastPoint;
        private void panel_Reg_MouseMove(object sender, MouseEventArgs e) //функция передвижения формочки
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel_Reg_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void close_Reg_MouseEnter(object sender, EventArgs e) //при наведении меняется цвет
        {
            close_Reg.ForeColor = Color.FromArgb(108, 105, 95);
        }

        private void close_Reg_MouseLeave(object sender, EventArgs e) //при убирании меняется цвет
        {
            close_Reg.ForeColor = Color.Black;
        }

        private void enter_button_Reg_Click(object sender, EventArgs e)
        {
            if (login_Reg.Text == "введите логин..") //функция проверки на пустоту
            {
                MessageBox.Show("вы не ввели логин..");
                return;
            }

            if (password_Reg.Text == "") //функция проверки на пустоту
            {
                MessageBox.Show("вы не ввели пароль..");
                return;
            }






            if (poisk_User()) //вызов проверки есть ли такой пользователь в бд
                return;
            else
            {
                try
                {
                    //формирование запроса 
                    DataBase dataBase = new DataBase();
                    MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `pass`) VALUES ( @login, @pass )", dataBase.getConnection());

                    command.Parameters.Add("@login", MySqlDbType.VarChar).Value = Convert.ToString(login_Reg.Text);
                    command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = Convert.ToString(password_Reg.Text);


                    //выполнение запроса
                    dataBase.openConnection();

                    if (command.ExecuteNonQuery() == 1)
                        MessageBox.Show("аккаунт был создан..");
                    else
                        MessageBox.Show("аккаунт не был создан..");

                    dataBase.closeConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void login_Reg_Enter(object sender, EventArgs e)
        {
            if (login_Reg.Text == "введите логин..") //когда нажали на формочку
            {
                login_Reg.Text = "";
                login_Reg.ForeColor = Color.Black;
            }
        }

        private void login_Reg_Leave(object sender, EventArgs e)
        {
            if (login_Reg.Text == "") //когда вышли из формочки
            {
                login_Reg.Text = "введите логин..";
                login_Reg.ForeColor = Color.Gray;
            }
        }
        public Boolean poisk_User() //проверка есть ли такой пользователь в бд
        {
            DataBase dataBase = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @userL", dataBase.getConnection());
            command.Parameters.Add("@userL", MySqlDbType.VarChar).Value = Convert.ToString(login_Reg.Text); //вместо заглушек

            adapter.SelectCommand = command;
            adapter.Fill(table); //помещение введенных данных в таблицу 

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("такой пользователь уже есть..");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void yche_ect_button_Click(object sender, EventArgs e)
        {
            this.Hide(); //спрятать окно

            authorisation auth = new authorisation();
            auth.Show(); //открыли окно
        }

        private void yche_ect_button_MouseEnter(object sender, EventArgs e)
        {
            yche_ect_button.ForeColor = Color.FromArgb(108, 105, 95);
        }

        private void yche_ect_button_MouseLeave(object sender, EventArgs e)
        {
            yche_ect_button.ForeColor = Color.Black;
        }
    }
}
     
        

