using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bronhotel2
{
    public partial class user_window : Form
    {
        public user_window()
        {
            InitializeComponent();
            List<Label> labels = new List<Label>() { one_nomer1, two_nomer1, three_nomer1, four_nomer1, five_nomer1, six_nomer1, 
                seven_nomer1, eight_nomer1, nine_nomer2, ten_nomer2, eleven_nomer2,twelve_nomer2, theeteen_nomer2, fourteen_nomer2, 
                fifteen_nomer2, sixteen_nomer2, seventeen_nomerL, eighteen_nomerL, nineteen_nomerL, twenty_nomerL } ;
            DataTable table = new DataTable();

            DataBase dataBase = new DataBase();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            for (int i = 1; i < 21; i++) {
                table.Clear();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `nomera` WHERE `nomer` = @nom", dataBase.getConnection());
                command.Parameters.Add("@nom", MySqlDbType.VarChar).Value = Convert.ToString(i); //вместо заглушек

                adapter.SelectCommand = command;
                adapter.Fill(table); //помещение введенных данных в таблицу 

                if (table.Rows.Count > 0)
                {
                    labels[i - 1].ForeColor = Color.FromArgb(255, 255, 255, 255);

                }
            }
        }
        //одноместные номера
        private void one_nomer1_Click(object sender, EventArgs e)
        {
            miniForm form = new miniForm(1);
            form.Show(); //открыли окно

        }

        private void two_nomer1_Click(object sender, EventArgs e)
        {
            miniForm form = new miniForm(2);
            form.Show(); //открыли окно
        }
        
        private void three_nomer1_Click(object sender, EventArgs e)
        {
            miniForm form = new miniForm(3);
            form.Show(); //открыли окно
        }


        private void four_nomer1_Click(object sender, EventArgs e)
        {
            miniForm form = new miniForm(4);
            form.Show(); //открыли окно
        }
        private void five_nomer1_Click(object sender, EventArgs e)
        {
            miniForm form = new miniForm(5);
            form.Show(); //открыли окно
        }
        
        private void six_nomer1_Click(object sender, EventArgs e)
        {
            miniForm form = new miniForm(6);
            form.Show(); //открыли окно
        }
        
        private void seven_nomer1_Click(object sender, EventArgs e)
        {
            miniForm form = new miniForm(7);
            form.Show(); //открыли окно
        }
        private void eight_nomer1_Click(object sender, EventArgs e)
        {
            miniForm form = new miniForm(8);
            form.Show(); //открыли окно
        }

        //двуместные номера
        private void nine_nomer2_Click(object sender, EventArgs e)
        {
            miniForm form = new miniForm(9);
            form.Show(); //открыли окно
        }

        private void ten_nomer2_Click(object sender, EventArgs e)
        {
            miniForm form = new miniForm(10);
            form.Show(); //открыли окно
        }

        private void eleven_nomer2_Click(object sender, EventArgs e)
        {
            miniForm form = new miniForm(11);
            form.Show(); //открыли окно
        }

        private void twelve_nomer2_Click(object sender, EventArgs e)
        {
            miniForm form = new miniForm(12);
            form.Show(); //открыли окно
        }

        private void theeteen_nomer2_Click(object sender, EventArgs e)
        {
            miniForm form = new miniForm(13);
            form.Show(); //открыли окно
        }

        private void fourteen_nomer2_Click(object sender, EventArgs e)
        {
            miniForm form = new miniForm(14);
            form.Show(); //открыли окно
        }

        private void fifteen_nomer2_Click(object sender, EventArgs e)
        {
            miniForm form = new miniForm(15);
            form.Show(); //открыли окно
        }

        private void sixteen_nomer2_Click(object sender, EventArgs e)
        {
            miniForm form = new miniForm(16);
            form.Show(); //открыли окно
        }
        //люкс-местные номера
        private void seventeen_nomerL_Click(object sender, EventArgs e)
        {
            miniForm form = new miniForm(17);
            form.Show(); //открыли окно
        }

        private void eighteen_nomerL_Click(object sender, EventArgs e)
        {
            miniForm form = new miniForm(18);
            form.Show(); //открыли окно
        }

        private void nineteen_nomerL_Click(object sender, EventArgs e)
        {
            miniForm form = new miniForm(19);
            form.Show(); //открыли окно
        }

        private void twenty_nomerL_Click(object sender, EventArgs e)
        {
            miniForm form = new miniForm(20);
            form.Show(); //открыли окно
        }

        private void close_user_window_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void close_user_window_MouseEnter(object sender, EventArgs e)
        {
            close_user_window.ForeColor = Color.FromArgb(108, 105, 95); //при наведении меняется цвет
        }

        private void close_user_window_MouseLeave(object sender, EventArgs e)
        {
            close_user_window.ForeColor = Color.Black; //при убирании меняется цвет
        }

        
    }
}

