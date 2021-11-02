namespace AptekaKursovoy
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            this.label1 = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.info = new System.Windows.Forms.Label();
            this.addUserPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addUserPic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label1.Location = new System.Drawing.Point(91, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Напишите имя";
            // 
            // usernameBox
            // 
            this.usernameBox.Font = new System.Drawing.Font("Segoe UI", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameBox.Location = new System.Drawing.Point(38, 105);
            this.usernameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usernameBox.Multiline = true;
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(192, 29);
            this.usernameBox.TabIndex = 1;
            this.usernameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usernameBox_KeyDown);
            this.usernameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usernameBox_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::AptekaKursovoy.Properties.Resources.yes;
            this.pictureBox1.InitialImage = global::AptekaKursovoy.Properties.Resources.yes;
            this.pictureBox1.Location = new System.Drawing.Point(282, 198);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.Color.Transparent;
            this.info.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.info.ForeColor = System.Drawing.Color.White;
            this.info.Location = new System.Drawing.Point(72, 152);
            this.info.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(177, 77);
            this.info.TabIndex = 5;
            this.info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addUserPic
            // 
            this.addUserPic.BackColor = System.Drawing.Color.Transparent;
            this.addUserPic.Image = global::AptekaKursovoy.Properties.Resources.add;
            this.addUserPic.Location = new System.Drawing.Point(253, 102);
            this.addUserPic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addUserPic.Name = "addUserPic";
            this.addUserPic.Size = new System.Drawing.Size(30, 32);
            this.addUserPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addUserPic.TabIndex = 6;
            this.addUserPic.TabStop = false;
            this.addUserPic.Click += new System.EventHandler(this.addUserPic_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AptekaKursovoy.Properties.Resources.addUserBg;
            this.ClientSize = new System.Drawing.Size(322, 245);
            this.Controls.Add(this.addUserPic);
            this.Controls.Add(this.info);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить пользователя";
            this.Activated += new System.EventHandler(this.AddUser_Activated);
            this.Shown += new System.EventHandler(this.AddUser_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addUserPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.PictureBox addUserPic;
    }
}