using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AptekaKursovoy
{
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {
            InitializeComponent();
            this.MaximizeBox = false;


        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            DBConnection connectToDB = new DBConnection();
            if (connectToDB.isAvailible())
            {
                pictureBox1.Image = Properties.Resources.yes;
                connectToDB.openConection();
                connState.Visible = true;
                pictureBox1.Image = Properties.Resources.yes;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                DataTable users = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand query = new MySqlCommand("SELECT idUsers,Name FROM `users`;", connectToDB.getConnect());
                adapter.SelectCommand = query;
                adapter.Fill(users);
                if (users.Rows.Count > 0)
                {
                    userpicker.DataSource = users;
                    userpicker.DisplayMember = "Name";
                }
                connectToDB.closeConection();
            }
            else
            {
                pictureBox1.Image = Properties.Resources.connN;
                connState.Text = "Нет подключения к серверу";
                retryImg.Visible = true;
            }
        }


        private void Form1_Activated(object sender, EventArgs e)
        {
            Form1_Shown(sender,e);
        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            DBConnection conn = new DBConnection();
            MySqlCommand command = new MySqlCommand("delete from `users` where Name = @username;",conn.getConnect());
            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = userpicker.Text;
            DialogResult dialogResult = MessageBox.Show("Вы уверены ?", "Удаление пользователя", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (conn.isAvailible())
                {
                    conn.openConection();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Пользователь успешно удален");
                    }
                    else
                    {
                        MessageBox.Show("Пользователь не удален");
                    }
                }else {
                    MessageBox.Show("Нет подключения к базе данных");
                }
                conn.closeConection();
            }
        }

        private void userEdit_Click(object sender, EventArgs e)
        {
            EditUser editUser = new EditUser();
            editUser.Owner = this;
            editUser.ShowDialog();
        }

        private void retryImg_Click(object sender, EventArgs e)
        {
            DBConnection connect = new DBConnection();
            if (connect.isAvailible())
            {
                MessageBox.Show("Подключение установлено");
                retryImg.Visible = false;
                connState.Visible = false;
                this.Refresh();
            }
            else
            {
                connState.Text = "Нет подключения к серверу";
                this.Refresh();
            }
        }

        private void addUserPic_Click(object sender, EventArgs e)
        {
            AddUser addUserF = new AddUser();
            addUserF.ShowDialog();
        }

        private void addUserPic_MouseEnter(object sender, EventArgs e)
        {
            toolTipAdd.SetToolTip(addUserPic, "Добавить пользователя");
        }

        private void deleteUser_MouseEnter(object sender, EventArgs e)
        {
            toolTipDel.SetToolTip(deleteUser, "Удалить пользователя");
        }

        private void userEdit_MouseEnter(object sender, EventArgs e)
        {
            toolTipEdit.SetToolTip(userEdit, "Редактировать имя пользователя");
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            connectionStateTTP.SetToolTip(pictureBox1, "Состояние соединения с базой данных");
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            DBConnection conn = new DBConnection();
            if (conn.isAvailible())
            {
                this.Hide();
                Main main = new Main();
                main.Owner = this;
                main.Show();
            }
            else
            {
                MessageBox.Show("Нет соединения с базой данных, повторите попытку", "Ошибка");
            }

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeBtn_MouseEnter(object sender, EventArgs e)
        {
            closeBtn.Image = Properties.Resources.close2;
        }

        private void closeBtn_MouseLeave(object sender, EventArgs e)
        {
            closeBtn.Image = Properties.Resources.closeTransparent;
        }

        private void hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
