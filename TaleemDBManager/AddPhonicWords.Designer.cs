namespace TaleemDBManager
{
    partial class AddPhonicWords
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.wordLabel = new MetroFramework.Controls.MetroLabel();
            this.submitWordBtn = new MetroFramework.Controls.MetroTile();
            this.clearWordBtn = new MetroFramework.Controls.MetroTile();
            this.testWordBtn = new MetroFramework.Controls.MetroTile();
            this.createWordBtn = new MetroFramework.Controls.MetroTile();
            this.wordPicbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.wordPicbox)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(24, 64);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(478, 177);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 244);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Word:";
            // 
            // wordLabel
            // 
            this.wordLabel.AutoSize = true;
            this.wordLabel.Location = new System.Drawing.Point(74, 244);
            this.wordLabel.Name = "wordLabel";
            this.wordLabel.Size = new System.Drawing.Size(70, 19);
            this.wordLabel.TabIndex = 2;
            this.wordLabel.Text = "wordLabel";
            // 
            // submitWordBtn
            // 
            this.submitWordBtn.ActiveControl = null;
            this.submitWordBtn.Location = new System.Drawing.Point(150, 295);
            this.submitWordBtn.Name = "submitWordBtn";
            this.submitWordBtn.Size = new System.Drawing.Size(121, 23);
            this.submitWordBtn.TabIndex = 3;
            this.submitWordBtn.Text = "Submit Word";
            this.submitWordBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.submitWordBtn.UseSelectable = true;
            this.submitWordBtn.Click += new System.EventHandler(this.submitWordBtn_Click);
            // 
            // clearWordBtn
            // 
            this.clearWordBtn.ActiveControl = null;
            this.clearWordBtn.Location = new System.Drawing.Point(23, 295);
            this.clearWordBtn.Name = "clearWordBtn";
            this.clearWordBtn.Size = new System.Drawing.Size(121, 23);
            this.clearWordBtn.TabIndex = 4;
            this.clearWordBtn.Text = "Clear Word";
            this.clearWordBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clearWordBtn.UseSelectable = true;
            this.clearWordBtn.Click += new System.EventHandler(this.clearWordBtn_Click);
            // 
            // testWordBtn
            // 
            this.testWordBtn.ActiveControl = null;
            this.testWordBtn.Location = new System.Drawing.Point(150, 266);
            this.testWordBtn.Name = "testWordBtn";
            this.testWordBtn.Size = new System.Drawing.Size(121, 23);
            this.testWordBtn.TabIndex = 5;
            this.testWordBtn.Text = "Test Word";
            this.testWordBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.testWordBtn.UseSelectable = true;
            this.testWordBtn.Click += new System.EventHandler(this.testWordBtn_Click);
            // 
            // createWordBtn
            // 
            this.createWordBtn.ActiveControl = null;
            this.createWordBtn.Location = new System.Drawing.Point(23, 266);
            this.createWordBtn.Name = "createWordBtn";
            this.createWordBtn.Size = new System.Drawing.Size(121, 23);
            this.createWordBtn.TabIndex = 6;
            this.createWordBtn.Text = "Create Word";
            this.createWordBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.createWordBtn.UseSelectable = true;
            this.createWordBtn.Click += new System.EventHandler(this.createWordBtn_Click);
            // 
            // wordPicbox
            // 
            this.wordPicbox.Location = new System.Drawing.Point(508, 63);
            this.wordPicbox.Name = "wordPicbox";
            this.wordPicbox.Size = new System.Drawing.Size(152, 108);
            this.wordPicbox.TabIndex = 7;
            this.wordPicbox.TabStop = false;
            // 
            // AddPhonicWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 331);
            this.Controls.Add(this.wordPicbox);
            this.Controls.Add(this.createWordBtn);
            this.Controls.Add(this.testWordBtn);
            this.Controls.Add(this.clearWordBtn);
            this.Controls.Add(this.submitWordBtn);
            this.Controls.Add(this.wordLabel);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "AddPhonicWords";
            this.Text = "Add Phonic Words";
            ((System.ComponentModel.ISupportInitialize)(this.wordPicbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel wordLabel;
        private MetroFramework.Controls.MetroTile submitWordBtn;
        private MetroFramework.Controls.MetroTile clearWordBtn;
        private MetroFramework.Controls.MetroTile testWordBtn;
        private MetroFramework.Controls.MetroTile createWordBtn;
        private System.Windows.Forms.PictureBox wordPicbox;
    }
}