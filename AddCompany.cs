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
    public partial class AddCompany : Form
    {
        public AddCompany()
        {
            InitializeComponent();
        }

        private void AddCompany_Load(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Zoom;
            this.BackgroundImageLayout = ImageLayout.Center;
            DBConnection connection = new DBConnection();
            if (connection.isAvailible())
            {
                connectionPic.Image = Properties.Resources.yes;
                DataTable dt = new DataTable();
                MySqlCommand command = new MySqlCommand("select Country,City,Street,Building from ManufAdress;", connection.getConnect());
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(dt);
                connection.closeConection();
                string[] countrydt = dt
                    .AsEnumerable()
                    .Select<System.Data.DataRow, String>(x => x.Field<String>("Country"))
                    .ToArray();
                string[] citydt = dt
                    .AsEnumerable()
                    .Select<System.Data.DataRow, String>(x => x.Field<String>("City"))
                    .ToArray();
                string[] streetdt = dt
                    .AsEnumerable()
                    .Select<System.Data.DataRow, String>(x => x.Field<String>("Street"))
                    .ToArray();
                string[] builddt = dt
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

        private void addComp_Click(object sender, EventArgs e)
        {
            DBConnection connection = new DBConnection();
            if (connection.isAvailible())
            {
                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("select * from manufadress where Country = @ctr and City = @cty and Street = @str and Building = @bld;", connection.getConnect());
                command.Parameters.Add("@ctr", MySqlDbType.VarChar).Value = country.Text;
                command.Parameters.Add("@cty", MySqlDbType.VarChar).Value = city.Text;
                command.Parameters.Add("@str", MySqlDbType.VarChar).Value = street.Text;
                command.Parameters.Add("@bld", MySqlDbType.VarChar).Value = house.Text;
                adapter.SelectCommand = command;
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    int idOfAdr = dt.Rows[0].Field<int>(0);
                    MySqlCommand command2 = new MySqlCommand("INSERT INTO manufacturer(Name,Phone,Email,idManufAdr) values (@name,@phone,@email,@id);", connection.getConnect());
                    command2.Parameters.Add("@name", MySqlDbType.VarChar).Value = name.Text;
                    command2.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone.Text;
                    command2.Parameters.Add("@email", MySqlDbType.VarChar).Value = mail.Text;
                    command2.Parameters.Add("@id", MySqlDbType.Int32).Value = idOfAdr;
                    connection.openConection();
                    if(command2.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Компания успешно добавлена");
                    }
                    else
                    {
                        MessageBox.Show("Произошла ошибка");
                    }
                    connection.closeConection();
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(name.Text))
                    {
                        MessageBox.Show("Введите Название");
                    }
                    else if (string.IsNullOrWhiteSpace(country.Text))
                    {
                        MessageBox.Show("Введите страну производителя");
                    }
                    else if (string.IsNullOrWhiteSpace(city.Text))
                    {
                        MessageBox.Show("Введите город");
                    }
                    else
                    {
                        MySqlCommand command1 = new MySqlCommand("insert into ManufAdress(Country,City,Street,Building) values (@ctr,@cty,@str,@bld);",connection.getConnect());
                        command1.Parameters.Add("@ctr", MySqlDbType.VarChar).Value = country.Text;
                        command1.Parameters.Add("@cty", MySqlDbType.VarChar).Value = city.Text;
                        command1.Parameters.Add("@str", MySqlDbType.VarChar).Value = street.Text;
                        command1.Parameters.Add("@bld", MySqlDbType.VarChar).Value = house.Text;
                        connection.openConection();
                        command1.ExecuteNonQuery();
                        connection.closeConection();
                        MySqlCommand getAdrId = new MySqlCommand("select idManufAdress from ManufAdress order by idManufAdress desc limit 1;",connection.getConnect());
                        connection.openConection();
                        int idOfLastAdr = Convert.ToInt32(getAdrId.ExecuteScalar());
                        connection.closeConection();
                        MySqlCommand add = new MySqlCommand("INSERT INTO manufacturer(Name,Phone,Email,idManufAdr) values (@name,@phone,@email,@id);",connection.getConnect());
                        add.Parameters.Add("@name", MySqlDbType.VarChar).Value = name.Text;
                        add.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone.Text;
                        add.Parameters.Add("@email", MySqlDbType.VarChar).Value = mail.Text;
                        add.Parameters.Add("@id", MySqlDbType.Int32).Value = idOfLastAdr;
                        connection.openConection();
                        if (add.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Компания успешно добавлена");
                        }
                        else
                        {
                            MessageBox.Show("Произошла ошибка");
                        }
                        connection.closeConection();

                    }
                }
            }
            else
            {
                MessageBox.Show("Проверьте подключение к базе данных","Ошибка", MessageBoxButtons.OK);
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
