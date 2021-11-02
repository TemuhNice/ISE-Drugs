namespace AptekaKursovoy
{
    partial class AddCompany
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCompany));
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.street = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.house = new System.Windows.Forms.TextBox();
            this.connectionPic = new System.Windows.Forms.PictureBox();
            this.addComp = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.connectionPic)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.name.Location = new System.Drawing.Point(60, 108);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(283, 35);
            this.name.TabIndex = 0;
            this.name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(149, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(165, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Почта";
            // 
            // mail
            // 
            this.mail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mail.Location = new System.Drawing.Point(60, 354);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(283, 35);
            this.mail.TabIndex = 2;
            this.mail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mail_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(154, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Телефон";
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.phone.Location = new System.Drawing.Point(60, 229);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(283, 35);
            this.phone.TabIndex = 4;
            this.phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(506, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 30);
            this.label4.TabIndex = 12;
            this.label4.Text = "Город";
            // 
            // city
            // 
            this.city.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.city.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.city.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.city.Location = new System.Drawing.Point(405, 193);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(283, 35);
            this.city.TabIndex = 11;
            this.city.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.city_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(505, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "Улица";
            // 
            // street
            // 
            this.street.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.street.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.street.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.street.Location = new System.Drawing.Point(401, 293);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(283, 35);
            this.street.TabIndex = 9;
            this.street.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.street_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(501, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 30);
            this.label6.TabIndex = 8;
            this.label6.Text = "Страна";
            // 
            // country
            // 
            this.country.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.country.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.country.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.country.Location = new System.Drawing.Point(405, 88);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(283, 35);
            this.country.TabIndex = 7;
            this.country.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.country_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(475, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 30);
            this.label7.TabIndex = 14;
            this.label7.Text = "Номер дома";
            // 
            // house
            // 
            this.house.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.house.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.house.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.house.Location = new System.Drawing.Point(401, 388);
            this.house.Name = "house";
            this.house.Size = new System.Drawing.Size(283, 35);
            this.house.TabIndex = 13;
            this.house.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.house_KeyPress);
            // 
            // connectionPic
            // 
            this.connectionPic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.connectionPic.BackColor = System.Drawing.Color.Transparent;
            this.connectionPic.Image = global::AptekaKursovoy.Properties.Resources.yes;
            this.connectionPic.Location = new System.Drawing.Point(695, 448);
            this.connectionPic.Name = "connectionPic";
            this.connectionPic.Padding = new System.Windows.Forms.Padding(5);
            this.connectionPic.Size = new System.Drawing.Size(45, 45);
            this.connectionPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.connectionPic.TabIndex = 16;
            this.connectionPic.TabStop = false;
            // 
            // addComp
            // 
            this.addComp.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addComp.Location = new System.Drawing.Point(233, 459);
            this.addComp.Name = "addComp";
            this.addComp.Size = new System.Drawing.Size(127, 34);
            this.addComp.TabIndex = 19;
            this.addComp.Text = "Добавить";
            this.addComp.UseVisualStyleBackColor = true;
            this.addComp.Click += new System.EventHandler(this.addComp_Click);
            // 
            // cancel
            // 
            this.cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancel.Location = new System.Drawing.Point(393, 459);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(127, 34);
            this.cancel.TabIndex = 20;
            this.cancel.Text = "Отмена";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // AddCompany
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::AptekaKursovoy.Properties.Resources.addCompany;
            this.ClientSize = new System.Drawing.Size(752, 505);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.addComp);
            this.Controls.Add(this.connectionPic);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.house);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.city);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.street);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.country);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddCompany";
            this.Text = "Добавить производителя";
            this.Load += new System.EventHandler(this.AddCompany_Load);
            ((System.ComponentModel.ISupportInitialize)(this.connectionPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        protected System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.Label label3;
        protected System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label4;
        protected System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Label label5;
        protected System.Windows.Forms.TextBox street;
        private System.Windows.Forms.Label label6;
        protected System.Windows.Forms.TextBox country;
        private System.Windows.Forms.Label label7;
        protected System.Windows.Forms.TextBox house;
        protected System.Windows.Forms.PictureBox connectionPic;
        protected System.Windows.Forms.Button addComp;
        protected System.Windows.Forms.Button cancel;
    }
}