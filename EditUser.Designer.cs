namespace AptekaKursovoy
{
    partial class EditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUser));
            this.usernamebox = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernamebox
            // 
            this.usernamebox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.usernamebox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.usernamebox.Location = new System.Drawing.Point(80, 36);
            this.usernamebox.Multiline = true;
            this.usernamebox.Name = "usernamebox";
            this.usernamebox.Size = new System.Drawing.Size(261, 39);
            this.usernamebox.TabIndex = 0;
            this.usernamebox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usernamebox_KeyPress);
            // 
            // cancel
            // 
            this.cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cancel.Location = new System.Drawing.Point(232, 113);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(155, 41);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "Отмена";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // change
            // 
            this.change.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.change.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.change.Location = new System.Drawing.Point(34, 113);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(155, 41);
            this.change.TabIndex = 1;
            this.change.Text = "Изменить";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AptekaKursovoy.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(421, 166);
            this.Controls.Add(this.change);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.usernamebox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить имя";
            this.Shown += new System.EventHandler(this.EditUser_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernamebox;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button change;
    }
}