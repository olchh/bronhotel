using bronhotel2;
using MySql.Data.MySqlClient;
using System;
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
    public partial class admBD : Form
    {
        private int rowIndex;

        public admBD()
        {
            InitializeComponent();

            DataBase dataBase = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `nomera`", dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table); //помещение введенных данных в таблицу 

            adm_dataTable.DataSource = table;

            if (table.Rows.Count > 0)
            {





            }
            else
            {
                MessageBox.Show("неверный логин/пароль..");
            }
        }

        private void delete_adm_button_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command2 = new MySqlCommand("DELETE FROM `nomera` WHERE `id` = @id", dataBase.getConnection());
            command2.Parameters.Add("@id", MySqlDbType.VarChar).Value = Convert.ToInt32(delete_id.Text);

            adapter.SelectCommand = command2;
            adapter.Fill(table); //помещение введенных данных в таблицу 

            MySqlCommand command1 = new MySqlCommand("SELECT * FROM `nomera`", dataBase.getConnection());

            adapter.SelectCommand = command1;
            adapter.Fill(table); //помещение введенных данных в таблицу 

            adm_dataTable.DataSource = table;
        }

        private void adm_dataTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                rowIndex = e.RowIndex;
                delete_id.Text = adm_dataTable.Rows[e.RowIndex].Cells["id"].Value.ToString();
            }
        }

        private void close_admBD_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void close_admBD_MouseEnter(object sender, EventArgs e)
        {
            close_admBD.ForeColor = Color.FromArgb(108, 105, 95); //при наведении меняется цвет
        }

        private void close_admBD_MouseLeave(object sender, EventArgs e)
        {
            close_admBD.ForeColor = Color.Black; //при убирании меняется цвет
        }
    }
}

