namespace AptekaKursovoy
{
    partial class EditDrug
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
            this.title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pokazaniya = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.sposobprim = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BackToMain = new System.Windows.Forms.LinkLabel();
            this.connStateBox = new System.Windows.Forms.PictureBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.chooseComp = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.infolabel = new System.Windows.Forms.Label();
            this.labelcomp = new System.Windows.Forms.Label();
            this.addcomp = new System.Windows.Forms.PictureBox();
            this.info1 = new System.Windows.Forms.PictureBox();
            this.info2 = new System.Windows.Forms.PictureBox();
            this.shelfl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.office = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.connStateBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addcomp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.info1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.info2)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.Location = new System.Drawing.Point(60, 221);
            this.title.MinimumSize = new System.Drawing.Size(450, 35);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(450, 35);
            this.title.TabIndex = 1;
            this.title.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.title_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(179, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название препарата";
            // 
            // pokazaniya
            // 
            this.pokazaniya.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pokazaniya.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.pokazaniya.Location = new System.Drawing.Point(1175, 130);
            this.pokazaniya.Name = "pokazaniya";
            this.pokazaniya.Size = new System.Drawing.Size(612, 371);
            this.pokazaniya.TabIndex = 3;
            this.pokazaniya.Text = "";
            this.pokazaniya.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pokazaniya_KeyDown);
            this.pokazaniya.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pokazaniya_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(1423, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Показания";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(233, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Цена, грн";
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price.Location = new System.Drawing.Point(122, 352);
            this.price.MinimumSize = new System.Drawing.Size(200, 35);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(328, 35);
            this.price.TabIndex = 5;
            this.price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price_KeyPress);
            // 
            // sposobprim
            // 
            this.sposobprim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sposobprim.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.sposobprim.Location = new System.Drawing.Point(1175, 634);
            this.sposobprim.Name = "sposobprim";
            this.sposobprim.Size = new System.Drawing.Size(612, 325);
            this.sposobprim.TabIndex = 7;
            this.sposobprim.Text = "";
            this.sposobprim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sposobprim_KeyDown);
            this.sposobprim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sposobprim_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(1376, 568);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Способ применения";
            // 
            // BackToMain
            // 
            this.BackToMain.ActiveLinkColor = System.Drawing.Color.Snow;
            this.BackToMain.AutoSize = true;
            this.BackToMain.BackColor = System.Drawing.Color.Transparent;
            this.BackToMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackToMain.LinkColor = System.Drawing.Color.Gray;
            this.BackToMain.Location = new System.Drawing.Point(24, 25);
            this.BackToMain.Name = "BackToMain";
            this.BackToMain.Size = new System.Drawing.Size(255, 25);
            this.BackToMain.TabIndex = 9;
            this.BackToMain.TabStop = true;
            this.BackToMain.Text = "<– Назад к главному экрану";
            this.BackToMain.Click += new System.EventHandler(this.BackToMain_Click);
            this.BackToMain.MouseEnter += new System.EventHandler(this.BackToMain_MouseEnter);
            this.BackToMain.MouseLeave += new System.EventHandler(this.BackToMain_MouseLeave);
            // 
            // connStateBox
            // 
            this.connStateBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.connStateBox.BackColor = System.Drawing.Color.Transparent;
            this.connStateBox.Image = global::AptekaKursovoy.Properties.Resources.yes;
            this.connStateBox.Location = new System.Drawing.Point(1845, 976);
            this.connStateBox.Name = "connStateBox";
            this.connStateBox.Padding = new System.Windows.Forms.Padding(5);
            this.connStateBox.Size = new System.Drawing.Size(45, 48);
            this.connStateBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.connStateBox.TabIndex = 10;
            this.connStateBox.TabStop = false;
            // 
            // addBtn
            // 
            this.addBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBtn.Location = new System.Drawing.Point(156, 437);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(259, 64);
            this.addBtn.TabIndex = 11;
            this.addBtn.Text = "Обновить информацию";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelBtn.Location = new System.Drawing.Point(738, 437);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(259, 64);
            this.cancelBtn.TabIndex = 12;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // chooseComp
            // 
            this.chooseComp.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.chooseComp.FormattingEnabled = true;
            this.chooseComp.Location = new System.Drawing.Point(678, 333);
            this.chooseComp.Name = "chooseComp";
            this.chooseComp.Size = new System.Drawing.Size(392, 31);
            this.chooseComp.TabIndex = 13;
            this.chooseComp.SelectedIndexChanged += new System.EventHandler(this.chooseComp_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(753, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Компания изготовитель";
            // 
            // infolabel
            // 
            this.infolabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.infolabel.BackColor = System.Drawing.Color.Transparent;
            this.infolabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.infolabel.ForeColor = System.Drawing.SystemColors.Control;
            this.infolabel.Location = new System.Drawing.Point(1059, 25);
            this.infolabel.Name = "infolabel";
            this.infolabel.Size = new System.Drawing.Size(280, 78);
            this.infolabel.TabIndex = 15;
            this.infolabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelcomp
            // 
            this.labelcomp.BackColor = System.Drawing.Color.Transparent;
            this.labelcomp.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelcomp.ForeColor = System.Drawing.SystemColors.Control;
            this.labelcomp.Location = new System.Drawing.Point(493, 333);
            this.labelcomp.Name = "labelcomp";
            this.labelcomp.Size = new System.Drawing.Size(152, 109);
            this.labelcomp.TabIndex = 16;
            this.labelcomp.Text = "Вы можете добавить отсутствующую компанию";
            this.labelcomp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addcomp
            // 
            this.addcomp.BackColor = System.Drawing.Color.Transparent;
            this.addcomp.Image = global::AptekaKursovoy.Properties.Resources.addCompanyT;
            this.addcomp.Location = new System.Drawing.Point(544, 455);
            this.addcomp.MaximumSize = new System.Drawing.Size(50, 50);
            this.addcomp.MinimumSize = new System.Drawing.Size(50, 50);
            this.addcomp.Name = "addcomp";
            this.addcomp.Size = new System.Drawing.Size(50, 50);
            this.addcomp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addcomp.TabIndex = 17;
            this.addcomp.TabStop = false;
            this.addcomp.Click += new System.EventHandler(this.addcomp_Click);
            this.addcomp.MouseEnter += new System.EventHandler(this.addcomp_MouseEnter);
            this.addcomp.MouseLeave += new System.EventHandler(this.addcomp_MouseLeave);
            // 
            // info1
            // 
            this.info1.Image = global::AptekaKursovoy.Properties.Resources.voz_info;
            this.info1.Location = new System.Drawing.Point(67, 562);
            this.info1.Name = "info1";
            this.info1.Size = new System.Drawing.Size(437, 415);
            this.info1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.info1.TabIndex = 18;
            this.info1.TabStop = false;
            // 
            // info2
            // 
            this.info2.Image = global::AptekaKursovoy.Properties.Resources.voz_info2;
            this.info2.Location = new System.Drawing.Point(623, 562);
            this.info2.Name = "info2";
            this.info2.Size = new System.Drawing.Size(437, 415);
            this.info2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.info2.TabIndex = 19;
            this.info2.TabStop = false;
            // 
            // shelfl
            // 
            this.shelfl.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.shelfl.Location = new System.Drawing.Point(678, 221);
            this.shelfl.Name = "shelfl";
            this.shelfl.Size = new System.Drawing.Size(392, 32);
            this.shelfl.TabIndex = 20;
            this.shelfl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.shelfl_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(796, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Срок хранения";
            // 
            // office
            // 
            this.office.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.office.FormattingEnabled = true;
            this.office.Location = new System.Drawing.Point(678, 390);
            this.office.Name = "office";
            this.office.Size = new System.Drawing.Size(392, 31);
            this.office.TabIndex = 22;
            // 
            // EditDrug
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::AptekaKursovoy.Properties.Resources.bg_1jpg;
            this.ClientSize = new System.Drawing.Size(1902, 1036);
            this.Controls.Add(this.office);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.shelfl);
            this.Controls.Add(this.info2);
            this.Controls.Add(this.info1);
            this.Controls.Add(this.addcomp);
            this.Controls.Add(this.labelcomp);
            this.Controls.Add(this.infolabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chooseComp);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.connStateBox);
            this.Controls.Add(this.BackToMain);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sposobprim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pokazaniya);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Name = "EditDrug";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDrug";
            this.Load += new System.EventHandler(this.EditDrug_Load);
            ((System.ComponentModel.ISupportInitialize)(this.connStateBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addcomp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.info1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.info2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox pokazaniya;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.RichTextBox sposobprim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel BackToMain;
        private System.Windows.Forms.PictureBox connStateBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ComboBox chooseComp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label infolabel;
        private System.Windows.Forms.Label labelcomp;
        private System.Windows.Forms.PictureBox addcomp;
        private System.Windows.Forms.PictureBox info1;
        private System.Windows.Forms.PictureBox info2;
        private System.Windows.Forms.TextBox shelfl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox office;
    }
}