namespace TaleemDBManager
{
    partial class DeletePhase
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
            this.phaseBox = new MetroFramework.Controls.MetroTextBox();
            this.delBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.backBtn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(195, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(238, 186);
            this.dataGridView1.TabIndex = 0;
            // 
            // phaseBox
            // 
            this.phaseBox.Lines = new string[0];
            this.phaseBox.Location = new System.Drawing.Point(78, 63);
            this.phaseBox.MaxLength = 32767;
            this.phaseBox.Name = "phaseBox";
            this.phaseBox.PasswordChar = '\0';
            this.phaseBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.phaseBox.SelectedText = "";
            this.phaseBox.Size = new System.Drawing.Size(75, 23);
            this.phaseBox.TabIndex = 1;
            this.phaseBox.UseSelectable = true;
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(23, 92);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(130, 23);
            this.delBtn.TabIndex = 2;
            this.delBtn.Text = "Delete";
            this.delBtn.UseSelectable = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(22, 65);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Phase: ";
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(24, 122);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(129, 23);
            this.backBtn.TabIndex = 4;
            this.backBtn.Text = "Back";
            this.backBtn.UseSelectable = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // DeletePhase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 261);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.phaseBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DeletePhase";
            this.Text = "Delete a phase";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroTextBox phaseBox;
        private MetroFramework.Controls.MetroButton delBtn;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton backBtn;
    }
}