using bronhotel2;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bronhotel2
{
    public partial class miniForm : Form
    {
        int number;
        public miniForm(int number)
        {

            InitializeComponent();

            this.number = number; //передача номера отеля и его нельзя рдактировать
            mini_nomer.Text = number.ToString();
            mini_nomer.ReadOnly = true;

        }

        private void bron_button_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `nomera` WHERE `nomer` = @nom", dataBase.getConnection());
            command.Parameters.Add("@nom", MySqlDbType.VarChar).Value = Convert.ToString(number); //вместо заглушек


            adapter.SelectCommand = command;
            adapter.Fill(table); //помещение введенных данных в таблицу 

            if (table.Rows.Count > 0)
            {
                this.Close();
                MessageBox.Show("номер уже забронирован..");
            }
            else
            { //иначе бронируем номер
                if (mini_name.Text == "" || mini_data.Text == "" || mini_days.Text == "") //когда вышли из формочки
                {
                    MessageBox.Show("заполните все поля");

                }
                else
                {
                    try
                    {
                        //формирование запроса 
                        MySqlCommand command1 = new MySqlCommand("INSERT INTO `nomera` (`nomer`, `name`, `data`, `days`) VALUES ( @nome, @nam, @dat, @days )", dataBase.getConnection());

                        command1.Parameters.Add("@nome", MySqlDbType.VarChar).Value = Convert.ToString(number);
                        command1.Parameters.Add("@nam", MySqlDbType.VarChar).Value = Convert.ToString(mini_name.Text);
                        command1.Parameters.Add("@dat", MySqlDbType.VarChar).Value = Convert.ToString(mini_data.Text);
                        command1.Parameters.Add("@days", MySqlDbType.VarChar).Value = Convert.ToString(mini_days.Text);


                        //выполнение запроса
                        dataBase.openConnection();

                        if (command1.ExecuteNonQuery() == 1)
                            MessageBox.Show("номер забронирован..");

                        else
                            MessageBox.Show("номер не удалось забронировать..");

                        dataBase.closeConnection();
                        this.Close();

                        
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }

        private void close_miniForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void close_miniForm_MouseEnter(object sender, EventArgs e)
        {
            close_miniForm.ForeColor = Color.FromArgb(108, 105, 95); //при наведении меняется цвет
        }

        private void close_miniForm_MouseLeave(object sender, EventArgs e)
        {
            close_miniForm.ForeColor = Color.Black; //при убирании меняется цвет
        }
    }
}
