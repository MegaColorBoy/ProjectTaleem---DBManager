namespace TaleemDBManager
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.userTextBox = new MetroFramework.Controls.MetroTextBox();
            this.passTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.loginBtn = new MetroFramework.Controls.MetroTile();
            this.createNewAcBtn = new MetroFramework.Controls.MetroTile();
            this.forgotPassBtn = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userTextBox
            // 
            this.userTextBox.Lines = new string[0];
            this.userTextBox.Location = new System.Drawing.Point(348, 340);
            this.userTextBox.MaxLength = 32767;
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.PasswordChar = '\0';
            this.userTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userTextBox.SelectedText = "";
            this.userTextBox.Size = new System.Drawing.Size(159, 23);
            this.userTextBox.TabIndex = 0;
            this.userTextBox.UseSelectable = true;
            // 
            // passTextBox
            // 
            this.passTextBox.Lines = new string[0];
            this.passTextBox.Location = new System.Drawing.Point(348, 374);
            this.passTextBox.MaxLength = 32767;
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.PasswordChar = '\0';
            this.passTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passTextBox.SelectedText = "";
            this.passTextBox.Size = new System.Drawing.Size(159, 23);
            this.passTextBox.TabIndex = 1;
            this.passTextBox.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(250, 340);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Username:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(250, 374);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Password:";
            // 
            // loginBtn
            // 
            this.loginBtn.ActiveControl = null;
            this.loginBtn.Location = new System.Drawing.Point(250, 406);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(257, 55);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Login";
            this.loginBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginBtn.UseSelectable = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // createNewAcBtn
            // 
            this.createNewAcBtn.ActiveControl = null;
            this.createNewAcBtn.Location = new System.Drawing.Point(250, 467);
            this.createNewAcBtn.Name = "createNewAcBtn";
            this.createNewAcBtn.Size = new System.Drawing.Size(257, 30);
            this.createNewAcBtn.TabIndex = 5;
            this.createNewAcBtn.Text = "Create new account";
            this.createNewAcBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.createNewAcBtn.UseSelectable = true;
            this.createNewAcBtn.Click += new System.EventHandler(this.createNewAcBtn_Click);
            // 
            // forgotPassBtn
            // 
            this.forgotPassBtn.ActiveControl = null;
            this.forgotPassBtn.Location = new System.Drawing.Point(250, 503);
            this.forgotPassBtn.Name = "forgotPassBtn";
            this.forgotPassBtn.Size = new System.Drawing.Size(257, 30);
            this.forgotPassBtn.TabIndex = 6;
            this.forgotPassBtn.Text = "Forgot your password ?";
            this.forgotPassBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.forgotPassBtn.UseSelectable = true;
            this.forgotPassBtn.Click += new System.EventHandler(this.forgotPassBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(760, 520);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.forgotPassBtn);
            this.Controls.Add(this.createNewAcBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LoginForm";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox userTextBox;
        private MetroFramework.Controls.MetroTextBox passTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile loginBtn;
        private MetroFramework.Controls.MetroTile createNewAcBtn;
        private MetroFramework.Controls.MetroTile forgotPassBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

