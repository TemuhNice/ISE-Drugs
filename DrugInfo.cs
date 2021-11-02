using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AptekaKursovoy
{
    public partial class DrugInfo : Form
    {
        public DrugInfo()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = false;
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            FormBorderStyle = FormBorderStyle.None;
        }


        private void back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void DrugInfo_Load(object sender, EventArgs e)
        {
            Main main = this.Owner as Main;
            DBConnection connection = new DBConnection();
            if (connection.isAvailible())
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable info = new DataTable();
                MySqlCommand command = new MySqlCommand("select Title, Pokazaniya,Sposobprim,Shelflife,Price,idmanufacturer from `drug` where idDrug = @iddrug;", connection.getConnect());
                command.Parameters.Add("@iddrug", MySqlDbType.Int32).Value = main.selectedRowCellValue;
                connection.openConection();
                adapter.SelectCommand = command;
                adapter.Fill(info);
                title.Text = info.Rows[0].Field<string>(0);
                pokazaniya.Text = info.Rows[0].Field<string>(1);
                sposobprim.Text = info.Rows[0].Field<string>(2);
                shelf.Text = info.Rows[0].Field<string>(3) + " месяца(ев)";
                price.Text = info.Rows[0].Field<double>(4).ToString() + " грн";
                command = new MySqlCommand("select Name, Phone, Email, `manufadress`.`Country`, `manufadress`.`City`, `manufadress`.`Street`,  `manufadress`.`Building` from `manufacturer` inner join manufadress on `manufacturer`.idManufAdr = manufadress.idManufAdress where idManufacturer = @idmanuf;", connection.getConnect());
                command.Parameters.Add("@idmanuf", MySqlDbType.Int32).Value = info.Rows[0].Field<int>(5);
                DataTable company = new DataTable();
                adapter.SelectCommand = command;
                adapter.Fill(company);
                company.Columns.Add("FullAdress", typeof(string), "Country + ', ' + City + ', ' + Street + ' '+ Building");
                manufacturer.Text = company.Rows[0].Field<string>(0);
                phone.Text = company.Rows[0].Field<string>(1);
                mail.Text = company.Rows[0].Field<string>(2);
                adress.Text = company.Rows[0].Field<string>(7);

            }
            else
            {
                MessageBox.Show("Пропала связь с сервером","Ошибка");
            }
        }

        private void mail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:"+mail.Text+"");
        }
    }
}
