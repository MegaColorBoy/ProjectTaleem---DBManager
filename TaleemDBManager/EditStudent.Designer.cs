namespace TaleemDBManager
{
    partial class EditStudent
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
            this.blindTxt = new MetroFramework.Controls.MetroTextBox();
            this.blindLabel = new MetroFramework.Controls.MetroLabel();
            this.EditBtn = new MetroFramework.Controls.MetroButton();
            this.idBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.submitBtn = new MetroFramework.Controls.MetroButton();
            this.colorBlindTxt = new MetroFramework.Controls.MetroTextBox();
            this.lastNameTxt = new MetroFramework.Controls.MetroTextBox();
            this.dobTxt = new MetroFramework.Controls.MetroTextBox();
            this.firstNameTxt = new MetroFramework.Controls.MetroTextBox();
            this.colorBlindLabel = new MetroFramework.Controls.MetroLabel();
            this.dobLabel = new MetroFramework.Controls.MetroLabel();
            this.lastNameLabel = new MetroFramework.Controls.MetroLabel();
            this.firstNameLabel = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // blindTxt
            // 
            this.blindTxt.Lines = new string[0];
            this.blindTxt.Location = new System.Drawing.Point(300, 185);
            this.blindTxt.MaxLength = 32767;
            this.blindTxt.Name = "blindTxt";
            this.blindTxt.PasswordChar = '\0';
            this.blindTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.blindTxt.SelectedText = "";
            this.blindTxt.Size = new System.Drawing.Size(45, 23);
            this.blindTxt.TabIndex = 50;
            this.blindTxt.UseSelectable = true;
            // 
            // blindLabel
            // 
            this.blindLabel.AutoSize = true;
            this.blindLabel.Location = new System.Drawing.Point(217, 187);
            this.blindLabel.Name = "blindLabel";
            this.blindLabel.Size = new System.Drawing.Size(72, 19);
            this.blindLabel.TabIndex = 49;
            this.blindLabel.Text = "Blind(Y/N):";
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(267, 60);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(78, 23);
            this.EditBtn.TabIndex = 48;
            this.EditBtn.Text = "Press to Edit";
            this.EditBtn.UseSelectable = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // idBox
            // 
            this.idBox.Lines = new string[0];
            this.idBox.Location = new System.Drawing.Point(176, 60);
            this.idBox.MaxLength = 32767;
            this.idBox.Name = "idBox";
            this.idBox.PasswordChar = '\0';
            this.idBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.idBox.SelectedText = "";
            this.idBox.Size = new System.Drawing.Size(75, 23);
            this.idBox.TabIndex = 47;
            this.idBox.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(72, 19);
            this.metroLabel1.TabIndex = 46;
            this.metroLabel1.Text = "Student ID:";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(176, 216);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 45;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseSelectable = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // colorBlindTxt
            // 
            this.colorBlindTxt.Lines = new string[0];
            this.colorBlindTxt.Location = new System.Drawing.Point(176, 187);
            this.colorBlindTxt.MaxLength = 32767;
            this.colorBlindTxt.Name = "colorBlindTxt";
            this.colorBlindTxt.PasswordChar = '\0';
            this.colorBlindTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.colorBlindTxt.SelectedText = "";
            this.colorBlindTxt.Size = new System.Drawing.Size(30, 23);
            this.colorBlindTxt.TabIndex = 44;
            this.colorBlindTxt.UseSelectable = true;
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Lines = new string[0];
            this.lastNameTxt.Location = new System.Drawing.Point(176, 126);
            this.lastNameTxt.MaxLength = 32767;
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.PasswordChar = '\0';
            this.lastNameTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lastNameTxt.SelectedText = "";
            this.lastNameTxt.Size = new System.Drawing.Size(298, 23);
            this.lastNameTxt.TabIndex = 42;
            this.lastNameTxt.UseSelectable = true;
            // 
            // dobTxt
            // 
            this.dobTxt.Lines = new string[0];
            this.dobTxt.Location = new System.Drawing.Point(176, 158);
            this.dobTxt.MaxLength = 32767;
            this.dobTxt.Name = "dobTxt";
            this.dobTxt.PasswordChar = '\0';
            this.dobTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dobTxt.SelectedText = "";
            this.dobTxt.Size = new System.Drawing.Size(111, 23);
            this.dobTxt.TabIndex = 41;
            this.dobTxt.UseSelectable = true;
            // 
            // firstNameTxt
            // 
            this.firstNameTxt.Lines = new string[0];
            this.firstNameTxt.Location = new System.Drawing.Point(176, 92);
            this.firstNameTxt.MaxLength = 32767;
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.PasswordChar = '\0';
            this.firstNameTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.firstNameTxt.SelectedText = "";
            this.firstNameTxt.Size = new System.Drawing.Size(298, 23);
            this.firstNameTxt.TabIndex = 40;
            this.firstNameTxt.UseSelectable = true;
            // 
            // colorBlindLabel
            // 
            this.colorBlindLabel.AutoSize = true;
            this.colorBlindLabel.Location = new System.Drawing.Point(22, 189);
            this.colorBlindLabel.Name = "colorBlindLabel";
            this.colorBlindLabel.Size = new System.Drawing.Size(109, 19);
            this.colorBlindLabel.TabIndex = 39;
            this.colorBlindLabel.Text = "Color blind(Y/N):";
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Location = new System.Drawing.Point(22, 158);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(133, 19);
            this.dobLabel.TabIndex = 37;
            this.dobLabel.Text = "Date of Birth(D/M/Y):";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(22, 126);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(74, 19);
            this.lastNameLabel.TabIndex = 36;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(22, 92);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(76, 19);
            this.firstNameLabel.TabIndex = 35;
            this.firstNameLabel.Text = "First Name:";
            // 
            // EditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 258);
            this.Controls.Add(this.blindTxt);
            this.Controls.Add(this.blindLabel);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.colorBlindTxt);
            this.Controls.Add(this.lastNameTxt);
            this.Controls.Add(this.dobTxt);
            this.Controls.Add(this.firstNameTxt);
            this.Controls.Add(this.colorBlindLabel);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Name = "EditStudent";
            this.Text = "Edit Student Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox blindTxt;
        private MetroFramework.Controls.MetroLabel blindLabel;
        private MetroFramework.Controls.MetroButton EditBtn;
        private MetroFramework.Controls.MetroTextBox idBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton submitBtn;
        private MetroFramework.Controls.MetroTextBox colorBlindTxt;
        private MetroFramework.Controls.MetroTextBox lastNameTxt;
        private MetroFramework.Controls.MetroTextBox dobTxt;
        private MetroFramework.Controls.MetroTextBox firstNameTxt;
        private MetroFramework.Controls.MetroLabel colorBlindLabel;
        private MetroFramework.Controls.MetroLabel dobLabel;
        private MetroFramework.Controls.MetroLabel lastNameLabel;
        private MetroFramework.Controls.MetroLabel firstNameLabel;

    }
}