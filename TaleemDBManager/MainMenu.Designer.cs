namespace TaleemDBManager
{
    partial class MainMenu
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
            this.addStudentBtn = new MetroFramework.Controls.MetroTile();
            this.editStudentBtn = new MetroFramework.Controls.MetroTile();
            this.deleteStudentBtn = new MetroFramework.Controls.MetroTile();
            this.levelMngrBtn = new MetroFramework.Controls.MetroTile();
            this.exitBtn = new MetroFramework.Controls.MetroTile();
            this.refreshBtn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(222, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(615, 327);
            this.dataGridView1.TabIndex = 0;
            // 
            // addStudentBtn
            // 
            this.addStudentBtn.ActiveControl = null;
            this.addStudentBtn.Location = new System.Drawing.Point(23, 75);
            this.addStudentBtn.Name = "addStudentBtn";
            this.addStudentBtn.Size = new System.Drawing.Size(192, 55);
            this.addStudentBtn.TabIndex = 1;
            this.addStudentBtn.Text = "Add student";
            this.addStudentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addStudentBtn.UseSelectable = true;
            this.addStudentBtn.Click += new System.EventHandler(this.addStudentBtn_Click);
            // 
            // editStudentBtn
            // 
            this.editStudentBtn.ActiveControl = null;
            this.editStudentBtn.Location = new System.Drawing.Point(23, 143);
            this.editStudentBtn.Name = "editStudentBtn";
            this.editStudentBtn.Size = new System.Drawing.Size(192, 55);
            this.editStudentBtn.TabIndex = 2;
            this.editStudentBtn.Text = "Edit Student";
            this.editStudentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.editStudentBtn.UseSelectable = true;
            this.editStudentBtn.Click += new System.EventHandler(this.editStudentBtn_Click);
            // 
            // deleteStudentBtn
            // 
            this.deleteStudentBtn.ActiveControl = null;
            this.deleteStudentBtn.Location = new System.Drawing.Point(23, 211);
            this.deleteStudentBtn.Name = "deleteStudentBtn";
            this.deleteStudentBtn.Size = new System.Drawing.Size(192, 55);
            this.deleteStudentBtn.TabIndex = 3;
            this.deleteStudentBtn.Text = "Delete Student";
            this.deleteStudentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deleteStudentBtn.UseSelectable = true;
            this.deleteStudentBtn.Click += new System.EventHandler(this.deleteStudentBtn_Click);
            // 
            // levelMngrBtn
            // 
            this.levelMngrBtn.ActiveControl = null;
            this.levelMngrBtn.Location = new System.Drawing.Point(23, 279);
            this.levelMngrBtn.Name = "levelMngrBtn";
            this.levelMngrBtn.Size = new System.Drawing.Size(192, 55);
            this.levelMngrBtn.TabIndex = 4;
            this.levelMngrBtn.Text = "Level manager";
            this.levelMngrBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.levelMngrBtn.UseSelectable = true;
            this.levelMngrBtn.Click += new System.EventHandler(this.levelMngrBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.ActiveControl = null;
            this.exitBtn.Location = new System.Drawing.Point(23, 347);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(192, 55);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Exit";
            this.exitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitBtn.UseSelectable = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(762, 408);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshBtn.TabIndex = 6;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseSelectable = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 437);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.levelMngrBtn);
            this.Controls.Add(this.deleteStudentBtn);
            this.Controls.Add(this.editStudentBtn);
            this.Controls.Add(this.addStudentBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroTile addStudentBtn;
        private MetroFramework.Controls.MetroTile editStudentBtn;
        private MetroFramework.Controls.MetroTile deleteStudentBtn;
        private MetroFramework.Controls.MetroTile levelMngrBtn;
        private MetroFramework.Controls.MetroTile exitBtn;
        private MetroFramework.Controls.MetroButton refreshBtn;
    }
}