using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace AptekaKursovoy
{
    public partial class AddDrug : Form
    {
        public AddDrug()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = false;
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            FormBorderStyle = FormBorderStyle.None;
        }
        
        private void AddDrug_Load(object sender, EventArgs e)
        {
            DBConnection connection = new DBConnection();
            if (connection.isAvailible())
            {
                connStateBox.Image = Properties.Resources.yes;
                MySqlCommand command = new MySqlCommand("select distinct Name from manufacturer;", connection.getConnect());
                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    chooseComp.DataSource = dt;
                    chooseComp.DisplayMember = "Name";
                    DataTable adress = new DataTable();
                    MySqlCommand command1 = new MySqlCommand("SELECT manufadress.idManufAdress, manufadress.Country, manufadress.City, manufadress.Street, manufadress.Building FROM manufacturer LEFT JOIN manufadress ON manufacturer.idManufAdr = manufadress.idManufAdress WHERE name = @nameOfComp;", connection.getConnect());
                    command1.Parameters.Add("@nameOfComp", MySqlDbType.VarChar).Value = chooseComp.SelectedItem.ToString();
                    MySqlDataAdapter adapter1 = new MySqlDataAdapter();
                    adapter1.SelectCommand = command1;
                    adapter1.Fill(adress);
                    adress.Columns.Add(
                        "FullAdress", typeof(string), "idManufAdress + '. ' + Country + ' г.' + City + ', ул.' + Street + ', зд.'+ Building");
                    office.DataSource = adress;
                    office.DisplayMember = "FullAdress";
                }

            }
            else
            {
                connStateBox.Image = Properties.Resources.connN;
            }
        }

        private void BackToMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            if (string.IsNullOrEmpty(title.Text) == false)
            {
                DialogResult dialogResult = System.Windows.Forms.MessageBox.Show("У вас есть несохраненные данные, Вы уверены ?", "Предупреждение", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else if (string.IsNullOrEmpty(price.Text) == false)
            {
                DialogResult dialogResult = System.Windows.Forms.MessageBox.Show("У вас есть несохраненные данные, Вы уверены ?", "Предупреждение", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else if (string.IsNullOrEmpty(sposobprim.Text) == false)
            {
                DialogResult dialogResult = System.Windows.Forms.MessageBox.Show("У вас есть несохраненные данные, Вы уверены ?", "Предупреждение", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else if (string.IsNullOrEmpty(pokazaniya.Text) == false)
            {
                DialogResult dialogResult = System.Windows.Forms.MessageBox.Show("У вас есть несохраненные данные, Вы уверены ?", "Предупреждение", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void pokazaniya_KeyDown(object sender, KeyEventArgs e)
        {
            if (pokazaniya.Text.Length > 700)
            {
                pokazaniya.ForeColor = Color.Red;
                infolabel.Text = "Максимальное количество символов - 700";
            }
            else
            {
                pokazaniya.ForeColor = Color.Black;
                infolabel.Text = "";
            }
        }

        private void sposobprim_KeyDown(object sender, KeyEventArgs e)
        {
            if (sposobprim.Text.Length > 1000)
            {
                sposobprim.ForeColor = Color.Red;
                infolabel.Text = "Максимальное количество символов - 1000";
            }
            else
            {
                sposobprim.ForeColor = Color.Black;
                infolabel.Text = "";
            }
        }

        private void BackToMain_MouseEnter(object sender, EventArgs e)
        {
            BackToMain.LinkColor = Color.White;
        }

        private void BackToMain_MouseLeave(object sender, EventArgs e)
        {
            BackToMain.LinkColor = Color.Gray;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            DBConnection connection = new DBConnection();
            if (connection.isAvailible())
            {
                if (string.IsNullOrWhiteSpace(title.Text))
                {
                    System.Windows.MessageBox.Show("Введите название !");
                }
                else if (string.IsNullOrWhiteSpace(price.Text))
                {
                    System.Windows.MessageBox.Show("Введите цену !");
                }
                else if(sposobprim.Text.Length > 1000 && pokazaniya.Text.Length > 700)
                {
                    System.Windows.MessageBox.Show("Количество введенных символов превышает допустимое колиество !", "Ошибка");
                }
                else
                {
                    connection.openConection();
                    int idAdr = Convert.ToInt32(office.Text.Substring(0, office.Text.IndexOf('.')));
                    connection.closeConection();
                    MySqlDataAdapter checkAdapter = new MySqlDataAdapter();
                    DataTable checkExist = new DataTable();
                    MySqlCommand check = new MySqlCommand("select Title, idManufacturer from Drug where Title = @checkname and idManufacturer = @manufid  ",connection.getConnect());
                    check.Parameters.Add("@checkname", MySqlDbType.VarChar).Value = title.Text;
                    check.Parameters.Add("@manufid", MySqlDbType.Int32).Value = idAdr;
                    checkAdapter.SelectCommand = check;
                    checkAdapter.Fill(checkExist);
                    if (checkExist.Rows.Count > 0)
                    {
                        System.Windows.MessageBox.Show("Препарат с таким производителем существует");
                    }
                    else
                    {
                        if (sposobprim.Text.Length <= 1000 && pokazaniya.Text.Length <= 700)
                        {
                            MySqlCommand command = new MySqlCommand("select idManufacturer from `manufacturer` where Name = @name and idManufAdr = @adrId;", connection.getConnect());
                            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = chooseComp.Text;
                            command.Parameters.Add("@adrId", MySqlDbType.Int32).Value = idAdr;
                            connection.openConection();
                            int idOfManuf = Convert.ToInt32(command.ExecuteScalar());
                            connection.closeConection();
                            MySqlCommand command2 = new MySqlCommand("insert into Drug(Title,Pokazaniya,Sposobprim,Shelflife,Price,idManufacturer) values (@title,@pokaz,@sposobprim,@shelf,@price,@manufId);", connection.getConnect());
                            command2.Parameters.Add("@title", MySqlDbType.VarChar).Value = title.Text;
                            command2.Parameters.Add("@pokaz", MySqlDbType.VarChar).Value = pokazaniya.Text;
                            command2.Parameters.Add("@sposobprim", MySqlDbType.VarChar).Value = sposobprim.Text;
                            command2.Parameters.Add("@shelf", MySqlDbType.VarChar).Value = shelfl.Text;
                            command2.Parameters.Add("@price", MySqlDbType.Double).Value = Convert.ToDouble(price.Text);
                            command2.Parameters.Add("@manufId", MySqlDbType.Int32).Value = idOfManuf;
                            connection.openConection();
                            if (command2.ExecuteNonQuery() == 1)
                            {
                                System.Windows.MessageBox.Show("Препарат добавлен !");
                                title.Text = "";
                                pokazaniya.Text = "";
                                sposobprim.Text = "";
                                shelfl.Text = "";
                                price.Text = "";
                            }
                            else
                            {
                                System.Windows.MessageBox.Show("Ошибка :(");
                            }
                            connection.closeConection();
                        }
                        else
                        {
                            System.Windows.MessageBox.Show("Превышение допустимого количества введенных символов","Ошибка");
                        }
                    }
                }
            }
            else
            {
                System.Windows.MessageBox.Show("Отсутствует подключение к базе данных");
            }
        }

        private void chooseComp_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBConnection connection = new DBConnection();
            if (connection.isAvailible())
            {
                
                MySqlCommand command1 = new MySqlCommand("SELECT manufadress.idManufAdress, manufadress.Country, manufadress.City, manufadress.Street, manufadress.Building FROM manufacturer LEFT JOIN manufadress ON manufacturer.idManufAdr = manufadress.idManufAdress WHERE name = @nameOfComp;", connection.getConnect());
                command1.Parameters.Add("@nameOfComp", MySqlDbType.VarChar).Value = chooseComp.Text;
                DataTable dt2 = new DataTable();
                MySqlDataAdapter adapter1 = new MySqlDataAdapter();
                adapter1.SelectCommand = command1;
                adapter1.Fill(dt2);
                dt2.Columns.Add(
                    "FullAdress", typeof(string), "idManufAdress + '. ' + Country + ' г.' + City + ', ул.' + Street + ', зд.'+ Building");
                office.DataSource = dt2;
                office.DisplayMember = "FullAdress";
            }
        }

        private void addcomp_Click(object sender, EventArgs e)
        {
            AddCompany addComp = new AddCompany();
            addComp.ShowDialog();

        }

        private void addcomp_MouseEnter(object sender, EventArgs e)
        {
            addcomp.Image = Properties.Resources.addcomp;
        }

        private void addcomp_MouseLeave(object sender, EventArgs e)
        {
            addcomp.Image = Properties.Resources.addCompanyT;
        }

        private void AddDrug_Activated(object sender, EventArgs e)
        {
            AddDrug_Load(sender, e);
        }

        private void price_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!char.IsDigit(ch) && ch != 8 && ch != ',')
            {
                e.Handled = true;
            }
        }

        private void title_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (shelfl.Text.Length >= 45)
            {
                if (e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }
        }

        private void shelfl_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (shelfl.Text.Length >= 45)
            {
                if (e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }
        }

        private void pokazaniya_TextChanged(object sender, EventArgs e)
        {
            if (pokazaniya.Text.Length > 700)
            {
                pokazaniya.ForeColor = Color.Red;
                infolabel.Text = "Максимальное количество символов - 700";
            }
            else
            {
                pokazaniya.ForeColor = Color.Black;
                infolabel.Text = "";
            }
        }

        private void sposobprim_TextChanged(object sender, EventArgs e)
        {
            if (sposobprim.Text.Length > 1000)
            {
                sposobprim.ForeColor = Color.Red;
                infolabel.Text = "Максимальное количество символов - 1000";
            }
            else
            {
                sposobprim.ForeColor = Color.Black;
                infolabel.Text = "";
            }
        }

        private void pokazaniya_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (pokazaniya.Text.Length >= 700)
            {
                if (e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }
        }

        private void sposobprim_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (sposobprim.Text.Length >= 1000)
            {
                if (e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }
        }
    }
    }
