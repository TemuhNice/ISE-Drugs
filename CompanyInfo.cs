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
    public partial class CompanyInfo : Form
    {
        public CompanyInfo()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.None;
        }

        private void close_MouseEnter(object sender, EventArgs e)
        {
            close.Image = Properties.Resources.close2;
        }
        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.Image = Properties.Resources.closeTransparent;
        }
        private void close_Click(object sender,EventArgs e)
        {
            this.Close();
        }

        private void CompanyInfo_Load(object sender, EventArgs e)
        {
            Main main = this.Owner as Main;
            DBConnection connection = new DBConnection();
            if (connection.isAvailible())
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable manuf = new DataTable();
                MySqlCommand command = new MySqlCommand("select name, phone, email, `manufadress`.`Country`, `manufadress`.`City`, `manufadress`.`Street`, `manufadress`.`Building` from `manufacturer` inner join `manufadress` on `manufacturer`.`idManufAdr` = `manufadress`.`idManufAdress` where idManufacturer = @idmanuf;",connection.getConnect());
                command.Parameters.Add("@idmanuf", MySqlDbType.Int32).Value = main.selectedRowCellValue;
                connection.openConection();
                adapter.SelectCommand = command;
                adapter.Fill(manuf);
                name.Text = manuf.Rows[0].Field<string>(0);
                phone.Text = manuf.Rows[0].Field<string>(1);
                mail.Text = manuf.Rows[0].Field<string>(2);
                manuf.Columns.Add("FullAdress", typeof(string), "Country + ', ' + City + ', ' + Street + ' '+ Building");
                adress.Text = manuf.Rows[0].Field<string>(7);
            }
        }

        private void mail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:" + mail.Text + "");
        }
    }
}
