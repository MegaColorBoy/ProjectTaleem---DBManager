namespace TaleemDBManager
{
    partial class AddDeleteWord
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.imgURLText = new MetroFramework.Controls.MetroTextBox();
            this.wordText = new MetroFramework.Controls.MetroTextBox();
            this.wordPicBox = new System.Windows.Forms.PictureBox();
            this.upldImgBtn = new MetroFramework.Controls.MetroButton();
            this.submitBtn = new MetroFramework.Controls.MetroButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.delWordText = new MetroFramework.Controls.MetroTextBox();
            this.delWordBtn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordPicBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(326, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(245, 187);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.submitBtn);
            this.groupBox1.Controls.Add(this.upldImgBtn);
            this.groupBox1.Controls.Add(this.wordPicBox);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.imgURLText);
            this.groupBox1.Controls.Add(this.wordText);
            this.groupBox1.Location = new System.Drawing.Point(24, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 122);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Word";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 29);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Word: ";
            // 
            // imgURLText
            // 
            this.imgURLText.Lines = new string[0];
            this.imgURLText.Location = new System.Drawing.Point(93, 58);
            this.imgURLText.MaxLength = 32767;
            this.imgURLText.Name = "imgURLText";
            this.imgURLText.PasswordChar = '\0';
            this.imgURLText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.imgURLText.SelectedText = "";
            this.imgURLText.Size = new System.Drawing.Size(75, 23);
            this.imgURLText.TabIndex = 1;
            this.imgURLText.UseSelectable = true;
            // 
            // wordText
            // 
            this.wordText.Lines = new string[0];
            this.wordText.Location = new System.Drawing.Point(61, 27);
            this.wordText.MaxLength = 32767;
            this.wordText.Name = "wordText";
            this.wordText.PasswordChar = '\0';
            this.wordText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.wordText.SelectedText = "";
            this.wordText.Size = new System.Drawing.Size(107, 23);
            this.wordText.TabIndex = 0;
            this.wordText.UseSelectable = true;
            // 
            // wordPicBox
            // 
            this.wordPicBox.Location = new System.Drawing.Point(174, 27);
            this.wordPicBox.Name = "wordPicBox";
            this.wordPicBox.Size = new System.Drawing.Size(108, 84);
            this.wordPicBox.TabIndex = 4;
            this.wordPicBox.TabStop = false;
            // 
            // upldImgBtn
            // 
            this.upldImgBtn.Location = new System.Drawing.Point(6, 58);
            this.upldImgBtn.Name = "upldImgBtn";
            this.upldImgBtn.Size = new System.Drawing.Size(81, 23);
            this.upldImgBtn.TabIndex = 5;
            this.upldImgBtn.Text = "Upload Image";
            this.upldImgBtn.UseSelectable = true;
            this.upldImgBtn.Click += new System.EventHandler(this.upldImgBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(6, 88);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(162, 23);
            this.submitBtn.TabIndex = 6;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseSelectable = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.delWordBtn);
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Controls.Add(this.delWordText);
            this.groupBox2.Location = new System.Drawing.Point(24, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 58);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete Word";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 21);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(49, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Word: ";
            // 
            // delWordText
            // 
            this.delWordText.Lines = new string[0];
            this.delWordText.Location = new System.Drawing.Point(61, 19);
            this.delWordText.MaxLength = 32767;
            this.delWordText.Name = "delWordText";
            this.delWordText.PasswordChar = '\0';
            this.delWordText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.delWordText.SelectedText = "";
            this.delWordText.Size = new System.Drawing.Size(107, 23);
            this.delWordText.TabIndex = 3;
            this.delWordText.UseSelectable = true;
            // 
            // delWordBtn
            // 
            this.delWordBtn.Location = new System.Drawing.Point(174, 19);
            this.delWordBtn.Name = "delWordBtn";
            this.delWordBtn.Size = new System.Drawing.Size(108, 23);
            this.delWordBtn.TabIndex = 5;
            this.delWordBtn.Text = "Delete word";
            this.delWordBtn.UseSelectable = true;
            this.delWordBtn.Click += new System.EventHandler(this.delWordBtn_Click);
            // 
            // AddDeleteWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 271);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AddDeleteWord";
            this.Text = "Add/Delete Word";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordPicBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox imgURLText;
        private MetroFramework.Controls.MetroTextBox wordText;
        private MetroFramework.Controls.MetroButton upldImgBtn;
        private System.Windows.Forms.PictureBox wordPicBox;
        private MetroFramework.Controls.MetroButton submitBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton delWordBtn;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox delWordText;
    }
}