namespace TaleemDBManager
{
    partial class DeleteStudent
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
            this.deleteBtn = new MetroFramework.Controls.MetroButton();
            this.idTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.idNumLabel = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(65, 111);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(93, 23);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseSelectable = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // idTxtBox
            // 
            this.idTxtBox.Lines = new string[0];
            this.idTxtBox.Location = new System.Drawing.Point(65, 82);
            this.idTxtBox.MaxLength = 32767;
            this.idTxtBox.Name = "idTxtBox";
            this.idTxtBox.PasswordChar = '\0';
            this.idTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.idTxtBox.SelectedText = "";
            this.idTxtBox.Size = new System.Drawing.Size(93, 23);
            this.idTxtBox.TabIndex = 4;
            this.idTxtBox.UseSelectable = true;
            // 
            // idNumLabel
            // 
            this.idNumLabel.AutoSize = true;
            this.idNumLabel.Location = new System.Drawing.Point(58, 60);
            this.idNumLabel.Name = "idNumLabel";
            this.idNumLabel.Size = new System.Drawing.Size(106, 19);
            this.idNumLabel.TabIndex = 3;
            this.idNumLabel.Text = "Enter Student ID:";
            // 
            // DeleteStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 151);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.idTxtBox);
            this.Controls.Add(this.idNumLabel);
            this.Name = "DeleteStudent";
            this.Text = "Delete a student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton deleteBtn;
        private MetroFramework.Controls.MetroTextBox idTxtBox;
        private MetroFramework.Controls.MetroLabel idNumLabel;
    }
}