namespace TaleemDBManager
{
    partial class AddPhase
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
            this.phaseBox = new MetroFramework.Controls.MetroTextBox();
            this.submitBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.letterLabel = new MetroFramework.Controls.MetroLabel();
            this.backBtn = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(23, 103);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(738, 228);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 76);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Phase: ";
            // 
            // phaseBox
            // 
            this.phaseBox.Lines = new string[0];
            this.phaseBox.Location = new System.Drawing.Point(71, 74);
            this.phaseBox.MaxLength = 32767;
            this.phaseBox.Name = "phaseBox";
            this.phaseBox.PasswordChar = '\0';
            this.phaseBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.phaseBox.SelectedText = "";
            this.phaseBox.Size = new System.Drawing.Size(90, 23);
            this.phaseBox.TabIndex = 2;
            this.phaseBox.UseSelectable = true;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(605, 72);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 3;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseSelectable = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(183, 76);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(54, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Letters: ";
            // 
            // letterLabel
            // 
            this.letterLabel.AutoSize = true;
            this.letterLabel.Location = new System.Drawing.Point(232, 76);
            this.letterLabel.Name = "letterLabel";
            this.letterLabel.Size = new System.Drawing.Size(0, 0);
            this.letterLabel.TabIndex = 5;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(686, 72);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 6;
            this.backBtn.Text = "Back";
            this.backBtn.UseSelectable = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // AddPhase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 344);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.letterLabel);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.phaseBox);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "AddPhase";
            this.Text = "Add a new phase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox phaseBox;
        private MetroFramework.Controls.MetroButton submitBtn;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel letterLabel;
        private MetroFramework.Controls.MetroButton backBtn;
    }
}