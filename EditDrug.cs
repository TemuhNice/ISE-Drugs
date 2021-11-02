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
using System.Windows.Forms;

namespace AptekaKursovoy
{
    public partial class EditDrug : Form
    {
        public EditDrug()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = false;
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            FormBorderStyle = FormBorderStyle.None;
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
        private void BackToMain_MouseEnter(object sender, EventArgs e)
        {
            BackToMain.LinkColor = Color.White;
        }

        private void BackToMain_MouseLeave(object sender, EventArgs e)
        {
            BackToMain.LinkColor = Color.Gray;
        }
        private void BackToMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
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
                else if (sposobprim.Text.Length > 1000 && pokazaniya.Text.Length > 700)
                {
                    MessageBox.Show("Количество введенных символов превышает допустимое количество", "Ошибка");
                }
                else
                {
                    Main main = this.Owner as Main;
                    connection.openConection();
                    int idAdr = Convert.ToInt32(office.Text.Substring(0, office.Text.IndexOf('.')));
                    connection.closeConection();
                        MySqlCommand command = new MySqlCommand("select idManufacturer from `manufacturer` where Name = @name and idManufAdr = @adrId;", connection.getConnect());
                        command.Parameters.Add("@name", MySqlDbType.VarChar).Value = chooseComp.Text;
                        command.Parameters.Add("@adrId", MySqlDbType.Int32).Value = idAdr;
                        connection.openConection();
                        int idOfManuf = Convert.ToInt32(command.ExecuteScalar());
                        connection.closeConection();
                        MySqlCommand update = new MySqlCommand("update `drug` set Title = @title, Pokazaniya = @pokaz,Sposobprim = @sposobprim,Shelflife = @shelf,Price = @price,idManufacturer = @manufId where idDrug = @drugid", connection.getConnect());
                        update.Parameters.Add("@title", MySqlDbType.VarChar).Value = title.Text;
                        update.Parameters.Add("@pokaz", MySqlDbType.VarChar).Value = pokazaniya.Text;
                        update.Parameters.Add("@sposobprim", MySqlDbType.VarChar).Value = sposobprim.Text;
                        update.Parameters.Add("@shelf", MySqlDbType.VarChar).Value = shelfl.Text;
                        update.Parameters.Add("@price", MySqlDbType.Double).Value = Convert.ToDouble(price.Text);
                        update.Parameters.Add("@manufId", MySqlDbType.Int32).Value = idOfManuf;
                        update.Parameters.Add("@drugid", MySqlDbType.Int32).Value = main.selectedRowCellValue;
                    connection.openConection();
                        if (update.ExecuteNonQuery() == 1)
                        {
                            System.Windows.MessageBox.Show("Информация обновлена !");
                        }
                        else
                        {
                            System.Windows.MessageBox.Show("Ошибка :(");
                        }
                        connection.closeConection();
                    }
            }
            else
            {
                System.Windows.MessageBox.Show("Отсутствует подключение к базе данных");
            }
        }
        private void pokazaniya_KeyDown(object sender, KeyEventArgs e)
        {
            if (pokazaniya.Text.Length > 700)
            {
                pokazaniya.ForeColor = Color.Red;
                infolabel.Text = "Максимальное количество символов -700";
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

        private void EditDrug_Load(object sender, EventArgs e)
        {
            Main main = this.Owner as Main;
            if(main != null)
            {
                DBConnection connection = new DBConnection();
                if (connection.isAvailible())
                {
                    int id = main.selectedRowCellValue;
                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand command = new MySqlCommand("select Title, Shelflife, price, Pokazaniya, Sposobprim,idManufacturer from `drug` where idDrug = @iddrug", connection.getConnect()); ;
                    command.Parameters.Add("@iddrug", MySqlDbType.Int32).Value = id;
                    adapter.SelectCommand = command;
                    adapter.Fill(dt);
                    title.Text = dt.Rows[0].Field<string>(0);
                    shelfl.Text = dt.Rows[0].Field<string>(1);
                    double priceofdrug = dt.Rows[0].Field<double>(2);
                    price.Text = priceofdrug.ToString();
                    pokazaniya.Text = dt.Rows[0].Field<string>(3);
                    sposobprim.Text = dt.Rows[0].Field<string>(4);
                    connStateBox.Image = Properties.Resources.yes;
                    MySqlCommand selectName = new MySqlCommand("select distinct Name from manufacturer;", connection.getConnect());
                    DataTable compName = new DataTable();
                    MySqlDataAdapter adapter2 = new MySqlDataAdapter();
                    adapter.SelectCommand = selectName;
                    adapter.Fill(compName);
                    if (compName.Rows.Count > 0)
                    {
                        chooseComp.DataSource = compName;
                        chooseComp.DisplayMember = "Name";
                        MySqlCommand getManufName = new MySqlCommand("select `manufacturer`.`Name` from `drug` inner join `manufacturer` on `drug`.`idManufacturer` = `manufacturer`.`idManufacturer` where idDrug = @id;", connection.getConnect());
                        getManufName.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
                        connection.openConection();
                        string nameOfComp = getManufName.ExecuteScalar().ToString();
                        connection.closeConection();
                        DataRow dr = compName.AsEnumerable()
                         .SingleOrDefault(r => r.Field<string>("Name") == nameOfComp);
                        int nameIndex = compName.Rows.IndexOf(dr);
                        chooseComp.SelectedIndex = nameIndex;
                        DataTable adressofcomp = new DataTable();
                        MySqlCommand command1 = new MySqlCommand("SELECT manufadress.idManufAdress, manufadress.Country, manufadress.City, manufadress.Street, manufadress.Building FROM manufacturer LEFT JOIN manufadress ON manufacturer.idManufAdr = manufadress.idManufAdress WHERE name = @nameOfComp;", connection.getConnect());
                        command1.Parameters.Add("@nameOfComp", MySqlDbType.VarChar).Value = chooseComp.Text;
                        MySqlDataAdapter adapter1 = new MySqlDataAdapter();
                        adapter1.SelectCommand = command1;
                        adapter1.Fill(adressofcomp);
                        adressofcomp.Columns.Add(
                            "FullAdress", typeof(string), "idManufAdress + '. ' + Country + ' г.' + City + ', ул.' + Street + ', зд.'+ Building");
                        office.DataSource = adressofcomp;
                        office.DisplayMember = "FullAdress";
                    }
                   
                }
            }
        }

        private void chooseComp_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBConnection connection = new DBConnection();
            if (connection.isAvailible())
            {
                DataTable adress = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand getAdress = new MySqlCommand("SELECT manufadress.idManufAdress, manufadress.Country, manufadress.City, manufadress.Street, manufadress.Building FROM manufacturer LEFT JOIN manufadress ON manufacturer.idManufAdr = manufadress.idManufAdress WHERE name = @nameOfComp;", connection.getConnect());
                getAdress.Parameters.Add("@nameOfComp", MySqlDbType.VarChar).Value = chooseComp.Text;
                adapter.SelectCommand = getAdress;
                adapter.Fill(adress);
                adress.Columns.Add(
                            "FullAdress", typeof(string), "idManufAdress + '. ' + Country + ' г.' + City + ', ул.' + Street + ', зд.'+ Building");
                office.DataSource = adress;
                office.DisplayMember = "FullAdress";
            }
        }

        private void title_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (title.Text.Length >= 100)
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

        private void price_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != ',')
            {
                e.Handled = true;
            }
        }
    }
}
