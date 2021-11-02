using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace AptekaKursovoy
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void usrAddtoDB()
        {
            DBConnection connect = new DBConnection();
            MySqlCommand query1 = new MySqlCommand("INSERT INTO `users`(`Name`) VALUES (@name);", connect.getConnect());
            query1.Parameters.Add("@name", MySqlDbType.VarChar).Value = usernameBox.Text;
            connect.openConection();
            if (query1.ExecuteNonQuery() == 1)
            {
               MessageBox.Show("Пользователь успешно добавлен");
            }
            else
            {
                MessageBox.Show("Пользователь не был добавлен");
            }
            connect.closeConection();
        }


        private void AddUser_Shown(object sender, EventArgs e)
        {
            DBConnection connect = new DBConnection();
            if (connect.isAvailible())
            {
                pictureBox1.Image = Properties.Resources.yes;
            }
            else
            {
                MessageBox.Show("Ошибка: нет подключения к базе данных");
                pictureBox1.Image = Properties.Resources.yes;
            }
        }

        private void AddUser_Activated(object sender, EventArgs e)
        {
            info.Text = "";
            this.Refresh();
        }

        private void addUserPic_Click(object sender, EventArgs e)
        {
            DBConnection connect = new DBConnection();
            if (connect.isAvailible())
            {
                pictureBox1.Image = Properties.Resources.yes;
                DataTable users = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand query = new MySqlCommand("SELECT Name FROM `users`;", connect.getConnect());
                adapter.SelectCommand = query;
                adapter.Fill(users);
                if (usernameBox.Text != String.Empty)
                {
                    string username = usernameBox.Text;
                    DataRow[] dr = users.Select("Name='" + username + "'");
                    var name = "";
                    foreach (DataRow row in dr)
                    {
                        name = row["Name"].ToString();
                    }
                    if (name != string.Empty)
                    {
                        info.Text = "Имя уже есть в списке";
                        this.Refresh();
                    }
                    else
                    {
                        usrAddtoDB();
                        usernameBox.Clear();
                    }

                }
                else
                {
                    info.Text = "Поле пустое, введите имя !";
                }
            }
            else
            {
                pictureBox1.Image = Properties.Resources.connN;
                info.Text = "Нет подключения к Базе данных";
            }
        }

        private void usernameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (usernameBox.Text.Length >= 45)
            {
                if (e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }
        }

        private void usernameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                addUserPic_Click(sender, e);
            }
        }
    }
}
