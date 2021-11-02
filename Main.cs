using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace AptekaKursovoy
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = false;
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            FormBorderStyle = FormBorderStyle.None;
            
        }


        string usrname;

        private void hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeApp_MouseEnter(object sender, EventArgs e)
        {
            closeApp.Image = Properties.Resources.close2;
        }

        private void closeApp_MouseLeave(object sender, EventArgs e)
        {
            closeApp.Image = Properties.Resources.closeTransparent;
        }

        private void userchange_MouseEnter(object sender, EventArgs e)
        {
            userchange.ForeColor = Color.Blue;
        }

        private void userchange_MouseLeave(object sender, EventArgs e)
        {
            userchange.ForeColor = Color.White;
        }

        private void userchange_Click(object sender, EventArgs e)
        {
            this.Close();
            WelcomeScreen form = new WelcomeScreen();
            form.Show();
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            countrySelect.Visible = false;
            filterCountry.Visible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            WelcomeScreen form = this.Owner as WelcomeScreen;
            if (form != null)
            {
                username.Text = form.userpicker.Text;
            }
            DBConnection conn = new DBConnection();
            if (conn.isAvailible())
            {
                connectionState.Image = Properties.Resources.yes;
                DataSet ds = new DataSet();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand query = new MySqlCommand("select idDrug as id Товара, Title as Название, Price as Цена грн,Shelflife as Срок Хранения, manufacturer.Name as Производитель, manufadress.Country as Страна производитель from Drug inner join manufacturer on drug.idManufacturer = manufacturer.idManufacturer inner join `manufadress` on `manufacturer`.`idManufAdr` = `manufadress`.`idManufAdress`;", conn.getConnect());
                adapter.SelectCommand = query;
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.ReadOnly = true;
                dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 9);
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9);
                dataGridView1.RowHeadersVisible = false;
                
                conn.closeConection();
            }
            else
            {
                connectionState.Image = Properties.Resources.connN;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            WelcomeScreen form = this.Owner as WelcomeScreen;
            if (form != null)
            {
                usrname = form.userpicker.Text;
                username.Text = usrname;
                if(usrname.Last() == 'а' || usrname.Last() == 'я' || usrname.Last() == 'и')
                {
                    ovalPictureBox1.Image = Properties.Resources.user3;
                }
                else
                {
                    ovalPictureBox1.Image = Properties.Resources.user2;
                }
            }

        }
        void Main_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Brushes.White, 4);
            pen.LineJoin = LineJoin.Bevel;
            pen.MiterLimit = 4;
            g.DrawRectangle(pen, new Rectangle(search.Location.X - 1, search.Location.Y - 1, search.Width + 3, search.Height + 3));
        }


        private void searchImg_Click(object sender, EventArgs e)
        {
            DBConnection connection = new DBConnection();
            if (connection.isAvailible())
            {
                connection.openConection();
                if (companySearch.Checked == false)
                {
                    filterCountry.Visible = false;
                    MySqlCommand query = new MySqlCommand("select idDrug as id Товара, Title as Название, Price as Цена грн,Shelflife as Срок Хранения, manufacturer.Name as Производитель, manufadress.Country as Страна производитель from Drug inner join manufacturer on drug.idManufacturer = manufacturer.idManufacturer inner join `manufadress` on `manufacturer`.`idManufAdr` = `manufadress`.`idManufAdress` where Title like @drugsearch;", connection.getConnect());
                    query.Parameters.Add("@drugsearch", MySqlDbType.VarChar).Value = search.Text + "%";
                    DataSet ds = new DataSet();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = query;
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    dataGridView1.ReadOnly = true;
                    dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10);
                    dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10);
                    connection.closeConection();
                }
                else
                {
                    MySqlCommand query = new MySqlCommand("select idManufacturer as idПроизводителя,Name as Название,Phone as Телефон, EMail as ЭлПочта,manufadress.Country as Страна from Manufacturer inner join Manufadress on manufacturer.idManufAdr = manufadress.idManufAdress where name like @manufsearch;", connection.getConnect());
                    query.Parameters.Add("@manufsearch", MySqlDbType.VarChar).Value = search.Text + "%";
                    DataSet ds = new DataSet();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = query;
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    dataGridView1.ReadOnly = true;
                    dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10);
                    dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10);
                    connection.closeConection();
                }
            }
        }

        private void searchImg_MouseEnter(object sender, EventArgs e)
        {
            searchImg.Image = Properties.Resources.search1;
        }

        private void searchImg_MouseLeave(object sender, EventArgs e)
        {
            searchImg.Image = Properties.Resources.search1T;
        }

        private void search_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                searchImg_Click(sender, e);
            }
        }

        private void companySearch_CheckedChanged(object sender, EventArgs e)
        {
            if (companySearch.Checked == true)
            {
                cancelfilter.Visible = true;
                filterCountry.Visible = true;
                countrySelect.Visible = true;
                cancelPrice.Visible = false;
                price1.Visible = false; price2.Visible=false; pricelb.Visible = false;filter.Visible = false; label2.Visible = false; label3.Visible = false;
                DBConnection connection = new DBConnection();
                if (connection.isAvailible())
                {

                    MySqlCommand query = new MySqlCommand("select idManufacturer as idПроизводителя,Name as Название,Phone as Телефон, EMail as ЭлПочта,manufadress.Country as Страна from Manufacturer inner join Manufadress on manufacturer.idManufAdr = manufadress.idManufAdress;", connection.getConnect());
                    DataSet ds = new DataSet();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = query;
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];;
                    dataGridView1.ReadOnly = true;
                    dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10);
                    dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10);
                    DataTable country = new DataTable();
                    query = new MySqlCommand("select distinct manufadress.Country as Страна производителя from Manufacturer inner join Manufadress on manufacturer.idManufAdr = manufadress.idManufAdress;", connection.getConnect());
                    adapter.SelectCommand = query;
                    adapter.Fill(country);
                    countrySelect.DataSource = country;
                    countrySelect.DefaultCellStyle.Font = new Font("Segoe UI", 9);
                    countrySelect.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9);
                    countrySelect.Columns[0].Width = 215;
                    countrySelect.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    countrySelect.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    countrySelect.RowHeadersVisible = false;
                    connection.closeConection();
                }
            }
            else
            {
                cancelfilter.Visible = false;
                filterCountry.Visible = false;
                countrySelect.Visible = false;
                cancelPrice.Visible = true;
                searchImg_Click(sender, e);
                price1.Visible = true; price2.Visible = true; pricelb.Visible = true; filter.Visible = true; label2.Visible = true; label3.Visible = true;
            }
        }

        private void addDrug_Click(object sender, EventArgs e)
        {
            AddDrug add = new AddDrug();
            add.ShowDialog();
        }

        private void Main_Activated(object sender, EventArgs e)
        {
            username.Text = usrname;
            if(companySearch.Checked == true)
            {
                companySearch_CheckedChanged(sender,e);
            }
            else
            {
                Main_Shown(sender, e);
            }

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            AddCompany add = new AddCompany();
            add.ShowDialog();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DBConnection connection = new DBConnection();
            if (companySearch.Checked == false)
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены ?", "Удаление препарата", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (dataGridView1.SelectedCells.Count > 0)
                    {
                        if (connection.isAvailible())
                        {
                            MySqlCommand command = new MySqlCommand("delete from Drug where idDrug = @idDrug", connection.getConnect());
                            command.Parameters.Add("idDrug", MySqlDbType.Int32).Value = selectedRowCellValue;
                            connection.openConection();
                            if (command.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Препарат удален !");
                                Main_Activated(sender, e);
                            }
                            else
                            {
                                MessageBox.Show("Произошла ошибка");
                            }
                            connection.closeConection();
                        }
                    }
                }
            }
            else
            {
                MySqlCommand command = new MySqlCommand("select Title from `drug` where idManufacturer = @idmanuf;", connection.getConnect());
                command.Parameters.Add("@idmanuf", MySqlDbType.Int32).Value = selectedRowCellValue;
                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                connection.openConection();
                adapter.SelectCommand = command;
                adapter.Fill(dt);
                connection.closeConection();
                if (dt.Rows.Count > 0)
                {
                    DialogResult dg = MessageBox.Show("Вы уверены ? У данного производителя есть добавленные препараты", "Удаление производителя", MessageBoxButtons.YesNo);
                    if (dg == DialogResult.Yes)
                    {
                        command = new MySqlCommand("delete from Manufacturer where idManufacturer = @idmanuf", connection.getConnect());
                        command.Parameters.Add("@idmanuf", MySqlDbType.Int32).Value = selectedRowCellValue;
                        connection.openConection();
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Производитель удален !");
                        }
                        else
                        {
                            MessageBox.Show("Произошла ошибка");
                        }
                        connection.closeConection();
                    }
                }
                else
                {
                    DialogResult dg = MessageBox.Show("Вы уверены ?", "Удаление производителя", MessageBoxButtons.YesNo);
                    if (dg == DialogResult.Yes)
                    {
                        command = new MySqlCommand("delete from Manufacturer where idManufacturer = @idmanuf", connection.getConnect());
                        command.Parameters.Add("@idmanuf", MySqlDbType.Int32).Value = selectedRowCellValue;
                        connection.openConection();
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Производитель удален !");
                        }
                        else
                        {
                            MessageBox.Show("Произошла ошибка");
                        }
                        connection.closeConection();
                    }
                }
            }
        }

        public int selectedRowCellValue;

        private void filter_Click(object sender, EventArgs e)
        {
            DBConnection connection = new DBConnection();
            if (connection.isAvailible())
            {
                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand query = new MySqlCommand("select idDrug as id Товара, Title as Название, Price as Цена грн,Shelflife as Срок Хранения, manufacturer.Name as Производитель, manufadress.Country as Страна производитель from Drug inner join manufacturer on drug.idManufacturer = manufacturer.idManufacturer inner join `manufadress` on `manufacturer`.`idManufAdr` = `manufadress`.`idManufAdress`;", connection.getConnect());
                if(string.IsNullOrEmpty(price1.Text) && string.IsNullOrEmpty(price2.Text))
                {
                    MessageBox.Show("Введите значения !");
                }
                else if (string.IsNullOrEmpty(price1.Text))
                {
                    query = new MySqlCommand("select idDrug as id Товара, Title as Название, Price as Цена грн,Shelflife as Срок Хранения, manufacturer.Name as Производитель, manufadress.Country as Страна производитель from Drug inner join manufacturer on drug.idManufacturer = manufacturer.idManufacturer inner join `manufadress` on `manufacturer`.`idManufAdr` = `manufadress`.`idManufAdress` where price < @pricedo;", connection.getConnect());
                    query.Parameters.Add("@pricedo", MySqlDbType.Double).Value = Convert.ToDouble(price2.Text);
                } else if (string.IsNullOrEmpty(price2.Text))
                {
                    query = new MySqlCommand("select idDrug as id Товара, Title as Название, Price as Цена грн,Shelflife as Срок Хранения, manufacturer.Name as Производитель, manufadress.Country as Страна производитель from Drug inner join manufacturer on drug.idManufacturer = manufacturer.idManufacturer inner join `manufadress` on `manufacturer`.`idManufAdr` = `manufadress`.`idManufAdress` where price > @priceot;", connection.getConnect());
                    query.Parameters.Add("@priceot", MySqlDbType.Double).Value = Convert.ToDouble(price1.Text);
                } else if(!string.IsNullOrEmpty(price1.Text) && !string.IsNullOrEmpty(price2.Text))
                {
                    query = new MySqlCommand("select idDrug as id Товара, Title as Название, Price as Цена грн,Shelflife as Срок Хранения, manufacturer.Name as Производитель, manufadress.Country as Страна производитель from Drug inner join manufacturer on drug.idManufacturer = manufacturer.idManufacturer inner join `manufadress` on `manufacturer`.`idManufAdr` = `manufadress`.`idManufAdress` where price between @priceot and @pricedo;", connection.getConnect());
                    query.Parameters.Add("@priceot", MySqlDbType.Double).Value = Convert.ToDouble(price1.Text);
                    query.Parameters.Add("@pricedo", MySqlDbType.Double).Value = Convert.ToDouble(price2.Text);

                }
                adapter.SelectCommand = query;
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                    dataGridView1.ReadOnly = true;
                    dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 9);
                    dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9);
                    dataGridView1.RowHeadersVisible = false;
                } else
                {
                    MessageBox.Show("По вашим параметрам ничего не найдено !");
                }
            }
        }

        private void price1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void price2_KeyPress(object sender, KeyPressEventArgs e)
        {
            price1_KeyPress(sender,e);
        }


        private void editButton_Click(object sender, EventArgs e)
        {
            selectedRowCellValue = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            if (companySearch.Checked == false)
            {
                EditDrug drug = new EditDrug();
                drug.Owner = this;
                if (selectedRowCellValue != 0)
                {
                    drug.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Выберите препарат для редактирования", "Ошибка");
                }
            }
            else
            {
                EditCompany editcomp = new EditCompany();
                editcomp.Owner = this;
                if(selectedRowCellValue != 0)
                {
                    editcomp.ShowDialog();  
                }
                else
                {
                    MessageBox.Show("Выберите компанию !", "Ошибка");
                }
            }
        }


        private void filterCountry_Click(object sender, EventArgs e)
        {
            DBConnection connection = new DBConnection();
            if (connection.isAvailible())
            {
                string country = countrySelect.CurrentCell.Value.ToString();
                if (string.IsNullOrEmpty(country) == false)
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand query = new MySqlCommand("select idManufacturer as idПроизводителя,Name as Название,Phone as Телефон, EMail as ЭлПочта,manufadress.Country as Страна from Manufacturer inner join Manufadress on manufacturer.idManufAdr = manufadress.idManufAdress where manufadress.Country = @ctr;", connection.getConnect());
                    query.Parameters.Add("@ctr", MySqlDbType.VarChar).Value = country;
                    connection.openConection();
                    adapter.SelectCommand = query;
                    adapter.Fill(dt);
                    connection.closeConection();
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Выберите страну !");
                }
            }
            else
            {
                MessageBox.Show("Проверьте соединение !", "Ошибка");
            }
        }

        private void filterCountry_MouseEnter(object sender, EventArgs e)
        {
            filterCountry.BackColor = Color.White;
        }
        private void filterCountry_MouseLeave(object sender,EventArgs e)
        {
            filterCountry.BackColor = Color.LightGray;
        }

        private void cancelfilter_Click(object sender, EventArgs e)
        {
            DBConnection connection = new DBConnection();
            if (connection.isAvailible())
            {
                search.Clear();
                companySearch_CheckedChanged(sender, e);
            }
            else
            {
                MessageBox.Show("Соединение потеряно !");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            selectedRowCellValue = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            if (companySearch.Checked == false)
            {
                DrugInfo drugInfo = new DrugInfo();
                drugInfo.Owner = this;
                drugInfo.ShowDialog();
            }
            else
            {
                CompanyInfo compInfo = new CompanyInfo();
                compInfo.Owner = this;
                compInfo.ShowDialog();
            }
        }


        private void cancelPrice_Click(object sender, EventArgs e)
        {
            price1.Clear();
            price2.Clear();
            search.Clear();
            Main_Shown(sender, e);
        }
    }
}
