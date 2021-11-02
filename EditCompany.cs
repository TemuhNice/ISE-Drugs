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
    public partial class EditCompany : Form
    {
        public EditCompany()
        {
            InitializeComponent();
        }

        private void EditCompany_Load(object sender, EventArgs e)
        {
            Main form = this.Owner as Main;
            if (form != null)
            {
                DBConnection connection = new DBConnection();
                if (connection.isAvailible())
                {
                    connectionPic.Image = Properties.Resources.yes;
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    DataTable company = new DataTable();
                    MySqlCommand getInfo = new MySqlCommand("select Name, Phone, Email, manufadress.Country,manufadress.City,manufadress.Street,manufadress.Building from manufacturer inner join manufadress on manufacturer.idManufAdr = manufadress.idManufAdress where idManufacturer = @idmanuf;", connection.getConnect());
                    getInfo.Parameters.Add("@idmanuf", MySqlDbType.Int32).Value = form.selectedRowCellValue;
                    connection.openConection();
                    adapter.SelectCommand = getInfo;
                    adapter.Fill(company);
                    connection.closeConection();
                    name.Text = company.Rows[0].Field<string>(0);
                    phone.Text = company.Rows[0].Field<string>(1);
                    mail.Text = company.Rows[0].Field<string>(2);
                    country.Text = company.Rows[0].Field<string>(3);
                    city.Text = company.Rows[0].Field<string>(4);
                    street.Text = company.Rows[0].Field<string>(5);
                    house.Text = company.Rows[0].Field<string>(6);
                    string[] countrydt = company
                    .AsEnumerable()
                    .Select<System.Data.DataRow, String>(x => x.Field<String>("Country"))
                    .ToArray();
                    string[] citydt = company
                        .AsEnumerable()
                        .Select<System.Data.DataRow, String>(x => x.Field<String>("City"))
                        .ToArray();
                    string[] streetdt = company
                        .AsEnumerable()
                        .Select<System.Data.DataRow, String>(x => x.Field<String>("Street"))
                        .ToArray();
                    string[] builddt = company
                        .AsEnumerable()
                        .Select<System.Data.DataRow, String>(x => x.Field<String>("Building"))
                        .ToArray();
                    var countries = new AutoCompleteStringCollection();
                    countries.AddRange(countrydt);
                    country.AutoCompleteCustomSource = countries;
                    var cities = new AutoCompleteStringCollection();
                    cities.AddRange(citydt);
                    city.AutoCompleteCustomSource = cities;
                    var streets = new AutoCompleteStringCollection();
                    streets.AddRange(streetdt);
                    street.AutoCompleteCustomSource = streets;
                    var builds = new AutoCompleteStringCollection();
                    builds.AddRange(builddt);
                    house.AutoCompleteCustomSource = builds;
                }
                else
                {
                    connectionPic.Image = Properties.Resources.connN;
                }
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updComp_Click(object sender, EventArgs e)
        {
            Main form = this.Owner as Main;
            DBConnection connection = new DBConnection();
            if (connection.isAvailible())
            {
                int idOfComp = form.selectedRowCellValue;
                MySqlCommand getAdrID = new MySqlCommand("select idManufAdr from `manufacturer` where idManufacturer = @idManuf;", connection.getConnect());
                getAdrID.Parameters.Add("@idManuf", MySqlDbType.Int32).Value = idOfComp;
                connection.openConection();
                int idOfAdr = Convert.ToInt32(getAdrID.ExecuteScalar());
                connection.closeConection();
                MySqlCommand updateAdr = new MySqlCommand("update Manufadress set Country = @ctr,City = @cty, Street = @str, Building = @bld where idManufAdress = @idofadr;", connection.getConnect());
                updateAdr.Parameters.Add("@ctr", MySqlDbType.VarChar).Value = country.Text;
                updateAdr.Parameters.Add("@cty", MySqlDbType.VarChar).Value = city.Text;
                updateAdr.Parameters.Add("@str", MySqlDbType.VarChar).Value = street.Text;
                updateAdr.Parameters.Add("@bld", MySqlDbType.VarChar).Value = house.Text;
                updateAdr.Parameters.Add("@idofadr", MySqlDbType.Int32).Value = idOfAdr;
                MySqlCommand updateInfo = new MySqlCommand("update Manufacturer set Name = @name, Phone = @phone, Email = @email where idManufacturer = @idmanuf;", connection.getConnect());
                updateInfo.Parameters.Add("@name", MySqlDbType.VarChar).Value = name.Text;
                updateInfo.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone.Text;
                updateInfo.Parameters.Add("@email", MySqlDbType.VarChar).Value = mail.Text;
                updateInfo.Parameters.Add("@idmanuf", MySqlDbType.Int32).Value = idOfComp;
                connection.openConection();
                updateAdr.ExecuteNonQuery();
                if(updateInfo.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Данные обновлены !");
                }
                else
                {
                    MessageBox.Show("Ошибка !");
                }
                connection.closeConection();
            }
            else
            {
                MessageBox.Show("Восстановите соединение !", "Ошибка");
            }
        }

        private void name_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (name.Text.Length >= 45)
            {
                if (e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }
        }

        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (phone.Text.Length >= 45)
            {
                if (e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }
        }

        private void mail_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (mail.Text.Length >= 45)
            {
                if (e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }
        }

        private void country_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (country.Text.Length >= 45)
            {
                if (e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }
        }

        private void city_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (city.Text.Length >= 45)
            {
                if (e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }
        }

        private void street_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (street.Text.Length >= 45)
            {
                if (e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }
        }

        private void house_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (house.Text.Length >= 45)
            {
                if (e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
