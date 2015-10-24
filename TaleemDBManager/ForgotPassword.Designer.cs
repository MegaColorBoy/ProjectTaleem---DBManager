namespace TaleemDBManager
{
    partial class ForgotPassword
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
            this.usernameBox = new MetroFramework.Controls.MetroTextBox();
            this.enterPassBox = new MetroFramework.Controls.MetroTextBox();
            this.reEnterPassBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.submitBtn = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // usernameBox
            // 
            this.usernameBox.Lines = new string[0];
            this.usernameBox.Location = new System.Drawing.Point(176, 88);
            this.usernameBox.MaxLength = 32767;
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.PasswordChar = '\0';
            this.usernameBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.usernameBox.SelectedText = "";
            this.usernameBox.Size = new System.Drawing.Size(185, 23);
            this.usernameBox.TabIndex = 0;
            this.usernameBox.UseSelectable = true;
            // 
            // enterPassBox
            // 
            this.enterPassBox.Lines = new string[0];
            this.enterPassBox.Location = new System.Drawing.Point(176, 117);
            this.enterPassBox.MaxLength = 32767;
            this.enterPassBox.Name = "enterPassBox";
            this.enterPassBox.PasswordChar = '\0';
            this.enterPassBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.enterPassBox.SelectedText = "";
            this.enterPassBox.Size = new System.Drawing.Size(185, 23);
            this.enterPassBox.TabIndex = 1;
            this.enterPassBox.UseSelectable = true;
            // 
            // reEnterPassBox
            // 
            this.reEnterPassBox.Lines = new string[0];
            this.reEnterPassBox.Location = new System.Drawing.Point(176, 146);
            this.reEnterPassBox.MaxLength = 32767;
            this.reEnterPassBox.Name = "reEnterPassBox";
            this.reEnterPassBox.PasswordChar = '\0';
            this.reEnterPassBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.reEnterPassBox.SelectedText = "";
            this.reEnterPassBox.Size = new System.Drawing.Size(185, 23);
            this.reEnterPassBox.TabIndex = 2;
            this.reEnterPassBox.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 90);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Username:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 119);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(128, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Enter new password:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 148);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(149, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Re-enter new password:";
            // 
            // submitBtn
            // 
            this.submitBtn.ActiveControl = null;
            this.submitBtn.Location = new System.Drawing.Point(176, 175);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(185, 41);
            this.submitBtn.TabIndex = 7;
            this.submitBtn.Text = "Submit";
            this.submitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.submitBtn.UseSelectable = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 235);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.reEnterPassBox);
            this.Controls.Add(this.enterPassBox);
            this.Controls.Add(this.usernameBox);
            this.Name = "ForgotPassword";
            this.Text = "Forgot your password ?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox usernameBox;
        private MetroFramework.Controls.MetroTextBox enterPassBox;
        private MetroFramework.Controls.MetroTextBox reEnterPassBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTile submitBtn;
    }
}