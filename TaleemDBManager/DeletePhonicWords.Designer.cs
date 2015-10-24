namespace TaleemDBManager
{
    partial class DeletePhonicWords
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.wordBox = new MetroFramework.Controls.MetroTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.delBtn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Word: ";
            // 
            // wordBox
            // 
            this.wordBox.Lines = new string[0];
            this.wordBox.Location = new System.Drawing.Point(79, 58);
            this.wordBox.MaxLength = 32767;
            this.wordBox.Name = "wordBox";
            this.wordBox.PasswordChar = '\0';
            this.wordBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.wordBox.SelectedText = "";
            this.wordBox.Size = new System.Drawing.Size(75, 23);
            this.wordBox.TabIndex = 5;
            this.wordBox.UseSelectable = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(196, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(238, 186);
            this.dataGridView1.TabIndex = 4;
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(24, 87);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(130, 23);
            this.delBtn.TabIndex = 7;
            this.delBtn.Text = "Delete";
            this.delBtn.UseSelectable = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // DeletePhonicWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 272);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.wordBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DeletePhonicWords";
            this.Text = "Delete Phonic Words";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox wordBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton delBtn;
    }
}