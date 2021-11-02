namespace AptekaKursovoy
{
    partial class Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.closeApp = new System.Windows.Forms.PictureBox();
            this.hide = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.username = new System.Windows.Forms.Label();
            this.userchange = new System.Windows.Forms.Label();
            this.connectionState = new System.Windows.Forms.PictureBox();
            this.search = new System.Windows.Forms.RichTextBox();
            this.searchImg = new System.Windows.Forms.PictureBox();
            this.companySearch = new System.Windows.Forms.CheckBox();
            this.pricelb = new System.Windows.Forms.Label();
            this.price1 = new System.Windows.Forms.TextBox();
            this.price2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.countrySelect = new System.Windows.Forms.DataGridView();
            this.cancelfilter = new System.Windows.Forms.PictureBox();
            this.filterCountry = new AptekaKursovoy.OvalPictureBox();
            this.filter = new AptekaKursovoy.RoundButton();
            this.deleteButton = new AptekaKursovoy.RoundButton();
            this.editButton = new AptekaKursovoy.RoundButton();
            this.roundButton1 = new AptekaKursovoy.RoundButton();
            this.addDrug = new AptekaKursovoy.RoundButton();
            this.ovalPictureBox1 = new AptekaKursovoy.OvalPictureBox();
            this.cancelPrice = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.closeApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countrySelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelfilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // closeApp
            // 
            this.closeApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeApp.BackColor = System.Drawing.Color.Transparent;
            this.closeApp.Image = global::AptekaKursovoy.Properties.Resources.closeTransparent;
            this.closeApp.InitialImage = global::AptekaKursovoy.Properties.Resources.close2;
            this.closeApp.Location = new System.Drawing.Point(1842, 10);
            this.closeApp.Margin = new System.Windows.Forms.Padding(2);
            this.closeApp.Name = "closeApp";
            this.closeApp.Padding = new System.Windows.Forms.Padding(4);
            this.closeApp.Size = new System.Drawing.Size(49, 31);
            this.closeApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeApp.TabIndex = 0;
            this.closeApp.TabStop = false;
            this.closeApp.Click += new System.EventHandler(this.closeApp_Click);
            this.closeApp.MouseEnter += new System.EventHandler(this.closeApp_MouseEnter);
            this.closeApp.MouseLeave += new System.EventHandler(this.closeApp_MouseLeave);
            // 
            // hide
            // 
            this.hide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hide.BackColor = System.Drawing.Color.Transparent;
            this.hide.Image = global::AptekaKursovoy.Properties.Resources.hide2;
            this.hide.Location = new System.Drawing.Point(1789, 10);
            this.hide.Margin = new System.Windows.Forms.Padding(2);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(49, 31);
            this.hide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hide.TabIndex = 1;
            this.hide.TabStop = false;
            this.hide.Click += new System.EventHandler(this.hide_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(401, 116);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 53;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1272, 811);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.username.ForeColor = System.Drawing.Color.White;
            this.username.Location = new System.Drawing.Point(96, 24);
            this.username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(176, 33);
            this.username.TabIndex = 5;
            this.username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userchange
            // 
            this.userchange.AutoSize = true;
            this.userchange.BackColor = System.Drawing.Color.Transparent;
            this.userchange.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.userchange.ForeColor = System.Drawing.Color.White;
            this.userchange.Location = new System.Drawing.Point(97, 73);
            this.userchange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userchange.Name = "userchange";
            this.userchange.Size = new System.Drawing.Size(77, 21);
            this.userchange.TabIndex = 6;
            this.userchange.Text = "Сменить";
            this.userchange.Click += new System.EventHandler(this.userchange_Click);
            this.userchange.MouseEnter += new System.EventHandler(this.userchange_MouseEnter);
            this.userchange.MouseLeave += new System.EventHandler(this.userchange_MouseLeave);
            // 
            // connectionState
            // 
            this.connectionState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.connectionState.BackColor = System.Drawing.Color.Transparent;
            this.connectionState.Location = new System.Drawing.Point(1852, 984);
            this.connectionState.Margin = new System.Windows.Forms.Padding(2);
            this.connectionState.Name = "connectionState";
            this.connectionState.Size = new System.Drawing.Size(39, 41);
            this.connectionState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.connectionState.TabIndex = 7;
            this.connectionState.TabStop = false;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.search.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search.Location = new System.Drawing.Point(72, 146);
            this.search.Margin = new System.Windows.Forms.Padding(2);
            this.search.Multiline = false;
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(210, 34);
            this.search.TabIndex = 9;
            this.search.Text = "";
            this.search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.search_KeyDown);
            // 
            // searchImg
            // 
            this.searchImg.BackColor = System.Drawing.Color.Transparent;
            this.searchImg.Image = global::AptekaKursovoy.Properties.Resources.search1;
            this.searchImg.Location = new System.Drawing.Point(295, 133);
            this.searchImg.Margin = new System.Windows.Forms.Padding(2);
            this.searchImg.Name = "searchImg";
            this.searchImg.Size = new System.Drawing.Size(56, 61);
            this.searchImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searchImg.TabIndex = 10;
            this.searchImg.TabStop = false;
            this.searchImg.Click += new System.EventHandler(this.searchImg_Click);
            this.searchImg.MouseEnter += new System.EventHandler(this.searchImg_MouseEnter);
            this.searchImg.MouseLeave += new System.EventHandler(this.searchImg_MouseLeave);
            // 
            // companySearch
            // 
            this.companySearch.AutoSize = true;
            this.companySearch.BackColor = System.Drawing.Color.Transparent;
            this.companySearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.companySearch.ForeColor = System.Drawing.SystemColors.Control;
            this.companySearch.Location = new System.Drawing.Point(72, 194);
            this.companySearch.Margin = new System.Windows.Forms.Padding(2);
            this.companySearch.Name = "companySearch";
            this.companySearch.Size = new System.Drawing.Size(216, 29);
            this.companySearch.TabIndex = 11;
            this.companySearch.Text = "Поиск по компаниям";
            this.companySearch.UseVisualStyleBackColor = false;
            this.companySearch.CheckedChanged += new System.EventHandler(this.companySearch_CheckedChanged);
            // 
            // pricelb
            // 
            this.pricelb.AutoSize = true;
            this.pricelb.BackColor = System.Drawing.Color.Transparent;
            this.pricelb.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.pricelb.ForeColor = System.Drawing.SystemColors.Control;
            this.pricelb.Location = new System.Drawing.Point(173, 238);
            this.pricelb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pricelb.Name = "pricelb";
            this.pricelb.Size = new System.Drawing.Size(59, 28);
            this.pricelb.TabIndex = 14;
            this.pricelb.Text = "Цена";
            // 
            // price1
            // 
            this.price1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.price1.Location = new System.Drawing.Point(72, 303);
            this.price1.Margin = new System.Windows.Forms.Padding(2);
            this.price1.Name = "price1";
            this.price1.Size = new System.Drawing.Size(76, 24);
            this.price1.TabIndex = 15;
            this.price1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price1_KeyPress);
            // 
            // price2
            // 
            this.price2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.price2.Location = new System.Drawing.Point(257, 303);
            this.price2.Margin = new System.Windows.Forms.Padding(2);
            this.price2.Name = "price2";
            this.price2.Size = new System.Drawing.Size(76, 24);
            this.price2.TabIndex = 15;
            this.price2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price2_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(94, 263);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 28);
            this.label2.TabIndex = 14;
            this.label2.Text = "от";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(278, 263);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 28);
            this.label3.TabIndex = 14;
            this.label3.Text = "до";
            // 
            // countrySelect
            // 
            this.countrySelect.AllowUserToAddRows = false;
            this.countrySelect.AllowUserToDeleteRows = false;
            this.countrySelect.AllowUserToResizeColumns = false;
            this.countrySelect.AllowUserToResizeRows = false;
            this.countrySelect.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.countrySelect.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.countrySelect.BackgroundColor = System.Drawing.SystemColors.Control;
            this.countrySelect.ColumnHeadersHeight = 30;
            this.countrySelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.countrySelect.DefaultCellStyle = dataGridViewCellStyle2;
            this.countrySelect.GridColor = System.Drawing.SystemColors.Control;
            this.countrySelect.Location = new System.Drawing.Point(72, 238);
            this.countrySelect.Margin = new System.Windows.Forms.Padding(2);
            this.countrySelect.Name = "countrySelect";
            this.countrySelect.ReadOnly = true;
            this.countrySelect.RowHeadersWidth = 53;
            this.countrySelect.RowTemplate.Height = 24;
            this.countrySelect.Size = new System.Drawing.Size(218, 146);
            this.countrySelect.TabIndex = 17;
            // 
            // cancelfilter
            // 
            this.cancelfilter.BackColor = System.Drawing.Color.Transparent;
            this.cancelfilter.Image = global::AptekaKursovoy.Properties.Resources.cancelfilter;
            this.cancelfilter.Location = new System.Drawing.Point(297, 326);
            this.cancelfilter.Margin = new System.Windows.Forms.Padding(2);
            this.cancelfilter.Name = "cancelfilter";
            this.cancelfilter.Size = new System.Drawing.Size(62, 58);
            this.cancelfilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cancelfilter.TabIndex = 19;
            this.cancelfilter.TabStop = false;
            this.cancelfilter.Visible = false;
            this.cancelfilter.Click += new System.EventHandler(this.cancelfilter_Click);
            // 
            // filterCountry
            // 
            this.filterCountry.BackColor = System.Drawing.Color.LightGray;
            this.filterCountry.Image = global::AptekaKursovoy.Properties.Resources.filter;
            this.filterCountry.Location = new System.Drawing.Point(306, 238);
            this.filterCountry.Margin = new System.Windows.Forms.Padding(2);
            this.filterCountry.Name = "filterCountry";
            this.filterCountry.Padding = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.filterCountry.Size = new System.Drawing.Size(45, 40);
            this.filterCountry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.filterCountry.TabIndex = 18;
            this.filterCountry.TabStop = false;
            this.filterCountry.Click += new System.EventHandler(this.filterCountry_Click);
            this.filterCountry.MouseEnter += new System.EventHandler(this.filterCountry_MouseEnter);
            this.filterCountry.MouseLeave += new System.EventHandler(this.filterCountry_MouseLeave);
            // 
            // filter
            // 
            this.filter.BackColor = System.Drawing.Color.Transparent;
            this.filter.Location = new System.Drawing.Point(132, 367);
            this.filter.Margin = new System.Windows.Forms.Padding(2);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(140, 42);
            this.filter.TabIndex = 16;
            this.filter.Text = "Фильтровать";
            this.filter.UseVisualStyleBackColor = false;
            this.filter.Click += new System.EventHandler(this.filter_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.Control;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 10.944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(72, 740);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(261, 75);
            this.deleteButton.TabIndex = 13;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.SystemColors.Control;
            this.editButton.Font = new System.Drawing.Font("Segoe UI", 10.944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editButton.Location = new System.Drawing.Point(72, 642);
            this.editButton.Margin = new System.Windows.Forms.Padding(2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(261, 75);
            this.editButton.TabIndex = 12;
            this.editButton.Text = "Редактировать";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.SystemColors.Control;
            this.roundButton1.Font = new System.Drawing.Font("Segoe UI", 10.944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundButton1.Location = new System.Drawing.Point(72, 544);
            this.roundButton1.Margin = new System.Windows.Forms.Padding(2);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(261, 75);
            this.roundButton1.TabIndex = 8;
            this.roundButton1.Text = "Добавить производителя";
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // addDrug
            // 
            this.addDrug.BackColor = System.Drawing.SystemColors.Control;
            this.addDrug.Font = new System.Drawing.Font("Segoe UI", 10.944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addDrug.Location = new System.Drawing.Point(72, 446);
            this.addDrug.Margin = new System.Windows.Forms.Padding(2);
            this.addDrug.Name = "addDrug";
            this.addDrug.Size = new System.Drawing.Size(261, 75);
            this.addDrug.TabIndex = 8;
            this.addDrug.Text = "Добавить препарат";
            this.addDrug.UseVisualStyleBackColor = false;
            this.addDrug.Click += new System.EventHandler(this.addDrug_Click);
            // 
            // ovalPictureBox1
            // 
            this.ovalPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.ovalPictureBox1.Image = global::AptekaKursovoy.Properties.Resources.user1;
            this.ovalPictureBox1.Location = new System.Drawing.Point(9, 10);
            this.ovalPictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.ovalPictureBox1.Name = "ovalPictureBox1";
            this.ovalPictureBox1.Size = new System.Drawing.Size(82, 84);
            this.ovalPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ovalPictureBox1.TabIndex = 4;
            this.ovalPictureBox1.TabStop = false;
            // 
            // cancelPrice
            // 
            this.cancelPrice.BackColor = System.Drawing.Color.Transparent;
            this.cancelPrice.Image = global::AptekaKursovoy.Properties.Resources.cancelfilter;
            this.cancelPrice.Location = new System.Drawing.Point(283, 363);
            this.cancelPrice.Name = "cancelPrice";
            this.cancelPrice.Size = new System.Drawing.Size(50, 50);
            this.cancelPrice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cancelPrice.TabIndex = 20;
            this.cancelPrice.TabStop = false;
            this.cancelPrice.Click += new System.EventHandler(this.cancelPrice_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AptekaKursovoy.Properties.Resources.bg_1jpg;
            this.ClientSize = new System.Drawing.Size(1902, 1036);
            this.Controls.Add(this.cancelPrice);
            this.Controls.Add(this.cancelfilter);
            this.Controls.Add(this.filterCountry);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.price2);
            this.Controls.Add(this.price1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pricelb);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.companySearch);
            this.Controls.Add(this.searchImg);
            this.Controls.Add(this.search);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.addDrug);
            this.Controls.Add(this.connectionState);
            this.Controls.Add(this.userchange);
            this.Controls.Add(this.username);
            this.Controls.Add(this.ovalPictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.hide);
            this.Controls.Add(this.closeApp);
            this.Controls.Add(this.countrySelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Activated += new System.EventHandler(this.Main_Activated);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Shown += new System.EventHandler(this.Main_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.closeApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countrySelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelfilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox closeApp;
        private System.Windows.Forms.PictureBox hide;
        private System.Windows.Forms.DataGridView dataGridView1;
        private OvalPictureBox ovalPictureBox1;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label userchange;
        private System.Windows.Forms.PictureBox connectionState;
        private RoundButton addDrug;
        private System.Windows.Forms.RichTextBox search;
        private System.Windows.Forms.PictureBox searchImg;
        private System.Windows.Forms.CheckBox companySearch;
        private RoundButton roundButton1;
        private RoundButton editButton;
        private RoundButton deleteButton;
        private System.Windows.Forms.Label pricelb;
        private System.Windows.Forms.TextBox price1;
        private System.Windows.Forms.TextBox price2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private RoundButton filter;
        private System.Windows.Forms.DataGridView countrySelect;
        private OvalPictureBox filterCountry;
        private System.Windows.Forms.PictureBox cancelfilter;
        private System.Windows.Forms.PictureBox cancelPrice;
    }
}