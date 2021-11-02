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

namespace AptekaKursovoy
{
    public partial class EditUser : Form
    {
        public EditUser()
        {
            InitializeComponent();
            
        }

        private void EditUser_Shown(object sender, EventArgs e)  
        {
            WelcomeScreen form = this.Owner as WelcomeScreen;
            if(form != null)
            {
                usernamebox.Text = form.userpicker.Text;
            }
            
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void change_Click(object sender, EventArgs e)
        {
            WelcomeScreen form = this.Owner as WelcomeScreen;
            string oldname = form.userpicker.Text;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            DBConnection conn = new DBConnection();
            MySqlCommand name = new MySqlCommand("select Name from users where Name = @newname;", conn.getConnect());
            name.Parameters.Add("@newname", MySqlDbType.VarChar).Value = usernamebox.Text;
            MySqlCommand command = new MySqlCommand("update `users` set name=@newname where name=@oldname;", conn.getConnect());
            command.Parameters.Add("@oldname", MySqlDbType.VarChar).Value = oldname;
            command.Parameters.Add("@newname", MySqlDbType.VarChar).Value = usernamebox.Text;
            adapter.SelectCommand = name;
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь с таким именем уже существует", "Ошибка");
            }
            else
            {
                conn.openConection();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Редактирование успешно");
                }
                else
                {
                    MessageBox.Show("Редактирование не удалось");
                }
            }
        }

        private void usernamebox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (usernamebox.Text.Length >= 45)
            {
                if(e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }
            if(e.KeyChar == 13)
            {
                change_Click(sender, e);
            }
        }
    }
}
