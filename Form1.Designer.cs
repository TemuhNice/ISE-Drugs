using System.Drawing;

namespace AptekaKursovoy
{
    partial class WelcomeScreen
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeScreen));
            this.userpicker = new System.Windows.Forms.ComboBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aptekaDataSet = new AptekaKursovoy.aptekaDataSet();
            this.welcome = new System.Windows.Forms.Label();
            this.chooseuser = new System.Windows.Forms.Label();
            this.connState = new System.Windows.Forms.Label();
            this.usersTableAdapter = new AptekaKursovoy.aptekaDataSetTableAdapters.usersTableAdapter();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userEdit = new System.Windows.Forms.PictureBox();
            this.deleteUser = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.enterBtn = new System.Windows.Forms.PictureBox();
            this.retryImg = new System.Windows.Forms.PictureBox();
            this.addUserPic = new System.Windows.Forms.PictureBox();
            this.toolTipAdd = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipDel = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipEdit = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipEnt = new System.Windows.Forms.ToolTip(this.components);
            this.connectionStateTTP = new System.Windows.Forms.ToolTip(this.components);
            this.medbazalabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.hide = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aptekaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retryImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addUserPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hide)).BeginInit();
            this.SuspendLayout();
            // 
            // userpicker
            // 
            this.userpicker.BackColor = System.Drawing.SystemColors.Highlight;
            this.userpicker.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.usersBindingSource, "Name", true));
            this.userpicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Name", true));
            this.userpicker.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.userpicker.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.userpicker.FormattingEnabled = true;
            this.userpicker.Location = new System.Drawing.Point(186, 180);
            this.userpicker.Margin = new System.Windows.Forms.Padding(2);
            this.userpicker.Name = "userpicker";
            this.userpicker.Size = new System.Drawing.Size(212, 33);
            this.userpicker.TabIndex = 0;
            this.userpicker.Text = "System.Data.DataViewManagerListItemTypeDescriptor";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.aptekaDataSet;
            // 
            // aptekaDataSet
            // 
            this.aptekaDataSet.DataSetName = "aptekaDataSet";
            this.aptekaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.BackColor = System.Drawing.Color.Transparent;
            this.welcome.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.welcome.Location = new System.Drawing.Point(123, 26);
            this.welcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(341, 46);
            this.welcome.TabIndex = 1;
            this.welcome.Text = "Добро пожаловать";
            this.welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chooseuser
            // 
            this.chooseuser.AutoSize = true;
            this.chooseuser.BackColor = System.Drawing.Color.Transparent;
            this.chooseuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseuser.Location = new System.Drawing.Point(147, 134);
            this.chooseuser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.chooseuser.Name = "chooseuser";
            this.chooseuser.Size = new System.Drawing.Size(289, 29);
            this.chooseuser.TabIndex = 2;
            this.chooseuser.Text = "Выберите пользователя";
            // 
            // connState
            // 
            this.connState.BackColor = System.Drawing.Color.Transparent;
            this.connState.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.connState.Location = new System.Drawing.Point(175, 350);
            this.connState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.connState.Name = "connState";
            this.connState.Size = new System.Drawing.Size(237, 64);
            this.connState.TabIndex = 4;
            this.connState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "users";
            this.usersBindingSource1.DataSource = this.aptekaDataSet;
            // 
            // userEdit
            // 
            this.userEdit.BackColor = System.Drawing.Color.Transparent;
            this.userEdit.Image = global::AptekaKursovoy.Properties.Resources.edit;
            this.userEdit.InitialImage = global::AptekaKursovoy.Properties.Resources.edit;
            this.userEdit.Location = new System.Drawing.Point(341, 222);
            this.userEdit.Margin = new System.Windows.Forms.Padding(2);
            this.userEdit.Name = "userEdit";
            this.userEdit.Size = new System.Drawing.Size(49, 49);
            this.userEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userEdit.TabIndex = 8;
            this.userEdit.TabStop = false;
            this.userEdit.Click += new System.EventHandler(this.userEdit_Click);
            this.userEdit.MouseEnter += new System.EventHandler(this.userEdit_MouseEnter);
            // 
            // deleteUser
            // 
            this.deleteUser.BackColor = System.Drawing.Color.Transparent;
            this.deleteUser.Image = global::AptekaKursovoy.Properties.Resources.delete;
            this.deleteUser.InitialImage = null;
            this.deleteUser.Location = new System.Drawing.Point(269, 223);
            this.deleteUser.Margin = new System.Windows.Forms.Padding(2);
            this.deleteUser.Name = "deleteUser";
            this.deleteUser.Size = new System.Drawing.Size(49, 49);
            this.deleteUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.deleteUser.TabIndex = 7;
            this.deleteUser.TabStop = false;
            this.deleteUser.Click += new System.EventHandler(this.deleteUser_Click);
            this.deleteUser.MouseEnter += new System.EventHandler(this.deleteUser_MouseEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::AptekaKursovoy.Properties.Resources.yes;
            this.pictureBox1.Location = new System.Drawing.Point(545, 399);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // enterBtn
            // 
            this.enterBtn.BackColor = System.Drawing.Color.Transparent;
            this.enterBtn.Image = ((System.Drawing.Image)(resources.GetObject("enterBtn.Image")));
            this.enterBtn.Location = new System.Drawing.Point(402, 176);
            this.enterBtn.Margin = new System.Windows.Forms.Padding(2);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(38, 41);
            this.enterBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enterBtn.TabIndex = 10;
            this.enterBtn.TabStop = false;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // retryImg
            // 
            this.retryImg.BackColor = System.Drawing.Color.Transparent;
            this.retryImg.Image = global::AptekaKursovoy.Properties.Resources.retryconnection;
            this.retryImg.Location = new System.Drawing.Point(503, 399);
            this.retryImg.Margin = new System.Windows.Forms.Padding(2);
            this.retryImg.Name = "retryImg";
            this.retryImg.Size = new System.Drawing.Size(38, 41);
            this.retryImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.retryImg.TabIndex = 11;
            this.retryImg.TabStop = false;
            this.retryImg.Visible = false;
            this.retryImg.Click += new System.EventHandler(this.retryImg_Click);
            // 
            // addUserPic
            // 
            this.addUserPic.BackColor = System.Drawing.Color.Transparent;
            this.addUserPic.Image = global::AptekaKursovoy.Properties.Resources.iconfinder_add_user_309049;
            this.addUserPic.InitialImage = global::AptekaKursovoy.Properties.Resources.adduser;
            this.addUserPic.Location = new System.Drawing.Point(198, 222);
            this.addUserPic.Margin = new System.Windows.Forms.Padding(2);
            this.addUserPic.Name = "addUserPic";
            this.addUserPic.Padding = new System.Windows.Forms.Padding(4);
            this.addUserPic.Size = new System.Drawing.Size(49, 49);
            this.addUserPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addUserPic.TabIndex = 9;
            this.addUserPic.TabStop = false;
            this.addUserPic.Click += new System.EventHandler(this.addUserPic_Click);
            this.addUserPic.MouseEnter += new System.EventHandler(this.addUserPic_MouseEnter);
            // 
            // medbazalabel
            // 
            this.medbazalabel.AutoSize = true;
            this.medbazalabel.BackColor = System.Drawing.Color.Transparent;
            this.medbazalabel.Font = new System.Drawing.Font("Segoe UI", 10.944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medbazalabel.Location = new System.Drawing.Point(74, 93);
            this.medbazalabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.medbazalabel.Name = "medbazalabel";
            this.medbazalabel.Size = new System.Drawing.Size(439, 23);
            this.medbazalabel.TabIndex = 12;
            this.medbazalabel.Text = "Информационная база «Медицинские препараты»";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::AptekaKursovoy.Properties.Resources.mainimg;
            this.pictureBox2.Location = new System.Drawing.Point(9, 10);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Image = global::AptekaKursovoy.Properties.Resources.closeTransparent;
            this.closeBtn.Location = new System.Drawing.Point(538, 10);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Padding = new System.Windows.Forms.Padding(4);
            this.closeBtn.Size = new System.Drawing.Size(39, 41);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeBtn.TabIndex = 14;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            this.closeBtn.MouseEnter += new System.EventHandler(this.closeBtn_MouseEnter);
            this.closeBtn.MouseLeave += new System.EventHandler(this.closeBtn_MouseLeave);
            // 
            // hide
            // 
            this.hide.BackColor = System.Drawing.Color.Transparent;
            this.hide.Image = global::AptekaKursovoy.Properties.Resources.hide2;
            this.hide.Location = new System.Drawing.Point(503, 10);
            this.hide.Margin = new System.Windows.Forms.Padding(2);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(38, 41);
            this.hide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hide.TabIndex = 15;
            this.hide.TabStop = false;
            this.hide.Click += new System.EventHandler(this.hide_Click);
            // 
            // WelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AptekaKursovoy.Properties.Resources.enterBG;
            this.ClientSize = new System.Drawing.Size(586, 448);
            this.Controls.Add(this.hide);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.medbazalabel);
            this.Controls.Add(this.retryImg);
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.addUserPic);
            this.Controls.Add(this.userEdit);
            this.Controls.Add(this.deleteUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.connState);
            this.Controls.Add(this.chooseuser);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.userpicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WelcomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информационная база «Медицинские препараты»";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aptekaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retryImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addUserPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Label chooseuser;
        private System.Windows.Forms.Label connState;
        private aptekaDataSet aptekaDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private aptekaDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox deleteUser;
        private System.Windows.Forms.PictureBox userEdit;
        protected internal System.Windows.Forms.ComboBox userpicker;
        private System.Windows.Forms.PictureBox enterBtn;
        private System.Windows.Forms.PictureBox retryImg;
        private System.Windows.Forms.PictureBox addUserPic;
        private System.Windows.Forms.ToolTip toolTipAdd;
        private System.Windows.Forms.ToolTip toolTipDel;
        private System.Windows.Forms.ToolTip toolTipEdit;
        private System.Windows.Forms.ToolTip toolTipEnt;
        private System.Windows.Forms.ToolTip connectionStateTTP;
        private System.Windows.Forms.Label medbazalabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox closeBtn;
        private System.Windows.Forms.PictureBox hide;
    }
}

