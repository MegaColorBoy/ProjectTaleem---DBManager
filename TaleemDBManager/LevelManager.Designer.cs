namespace TaleemDBManager
{
    partial class LevelManager
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
            this.AddPhaseBtn = new MetroFramework.Controls.MetroTile();
            this.DelPhaseBtn = new MetroFramework.Controls.MetroTile();
            this.SetPhaseBtn = new MetroFramework.Controls.MetroTile();
            this.addPhonicsBtn = new MetroFramework.Controls.MetroTile();
            this.delPhonicsBtn = new MetroFramework.Controls.MetroTile();
            this.addDelWordBtn = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // AddPhaseBtn
            // 
            this.AddPhaseBtn.ActiveControl = null;
            this.AddPhaseBtn.Location = new System.Drawing.Point(24, 132);
            this.AddPhaseBtn.Name = "AddPhaseBtn";
            this.AddPhaseBtn.Size = new System.Drawing.Size(253, 63);
            this.AddPhaseBtn.TabIndex = 0;
            this.AddPhaseBtn.Text = "Add Phase";
            this.AddPhaseBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddPhaseBtn.UseSelectable = true;
            this.AddPhaseBtn.Click += new System.EventHandler(this.AddPhaseBtn_Click);
            // 
            // DelPhaseBtn
            // 
            this.DelPhaseBtn.ActiveControl = null;
            this.DelPhaseBtn.Location = new System.Drawing.Point(283, 132);
            this.DelPhaseBtn.Name = "DelPhaseBtn";
            this.DelPhaseBtn.Size = new System.Drawing.Size(253, 63);
            this.DelPhaseBtn.TabIndex = 1;
            this.DelPhaseBtn.Text = "Delete Phase";
            this.DelPhaseBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DelPhaseBtn.UseSelectable = true;
            this.DelPhaseBtn.Click += new System.EventHandler(this.DelPhaseBtn_Click);
            // 
            // SetPhaseBtn
            // 
            this.SetPhaseBtn.ActiveControl = null;
            this.SetPhaseBtn.Location = new System.Drawing.Point(24, 200);
            this.SetPhaseBtn.Name = "SetPhaseBtn";
            this.SetPhaseBtn.Size = new System.Drawing.Size(253, 62);
            this.SetPhaseBtn.TabIndex = 2;
            this.SetPhaseBtn.Text = "Set Phase";
            this.SetPhaseBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SetPhaseBtn.UseSelectable = true;
            this.SetPhaseBtn.Click += new System.EventHandler(this.SetPhaseBtn_Click);
            // 
            // addPhonicsBtn
            // 
            this.addPhonicsBtn.ActiveControl = null;
            this.addPhonicsBtn.Location = new System.Drawing.Point(23, 63);
            this.addPhonicsBtn.Name = "addPhonicsBtn";
            this.addPhonicsBtn.Size = new System.Drawing.Size(253, 63);
            this.addPhonicsBtn.TabIndex = 3;
            this.addPhonicsBtn.Text = "Add Phonic Words";
            this.addPhonicsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addPhonicsBtn.UseSelectable = true;
            this.addPhonicsBtn.Click += new System.EventHandler(this.addPhonicsBtn_Click);
            // 
            // delPhonicsBtn
            // 
            this.delPhonicsBtn.ActiveControl = null;
            this.delPhonicsBtn.Location = new System.Drawing.Point(282, 63);
            this.delPhonicsBtn.Name = "delPhonicsBtn";
            this.delPhonicsBtn.Size = new System.Drawing.Size(253, 63);
            this.delPhonicsBtn.TabIndex = 4;
            this.delPhonicsBtn.Text = "Delete Phonic Words";
            this.delPhonicsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.delPhonicsBtn.UseSelectable = true;
            this.delPhonicsBtn.Click += new System.EventHandler(this.delPhonicsBtn_Click);
            // 
            // addDelWordBtn
            // 
            this.addDelWordBtn.ActiveControl = null;
            this.addDelWordBtn.Location = new System.Drawing.Point(283, 200);
            this.addDelWordBtn.Name = "addDelWordBtn";
            this.addDelWordBtn.Size = new System.Drawing.Size(253, 62);
            this.addDelWordBtn.TabIndex = 5;
            this.addDelWordBtn.Text = "Add/Delete Word (Spelling game)";
            this.addDelWordBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addDelWordBtn.UseSelectable = true;
            this.addDelWordBtn.Click += new System.EventHandler(this.addDelWordBtn_Click);
            // 
            // LevelManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 286);
            this.Controls.Add(this.addDelWordBtn);
            this.Controls.Add(this.delPhonicsBtn);
            this.Controls.Add(this.addPhonicsBtn);
            this.Controls.Add(this.SetPhaseBtn);
            this.Controls.Add(this.DelPhaseBtn);
            this.Controls.Add(this.AddPhaseBtn);
            this.Name = "LevelManager";
            this.Text = "Level Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile AddPhaseBtn;
        private MetroFramework.Controls.MetroTile DelPhaseBtn;
        private MetroFramework.Controls.MetroTile SetPhaseBtn;
        private MetroFramework.Controls.MetroTile addPhonicsBtn;
        private MetroFramework.Controls.MetroTile delPhonicsBtn;
        private MetroFramework.Controls.MetroTile addDelWordBtn;
    }
}