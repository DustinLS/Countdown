namespace PrjCountdown
{
    partial class FormNotice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNotice));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.selectHours = new System.Windows.Forms.ComboBox();
            this.selectMinutes = new System.Windows.Forms.ComboBox();
            this.selectSeconds = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.selectCountdown = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(211, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Countdown Complete";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 59);
            this.label2.TabIndex = 2;
            this.label2.Text = "Countdown has completed. This four hour work block is now finished.\r\n\r\nIt is now " +
                "time to take a break.";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(156, 146);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "Exit Program";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.button2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(35, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 27);
            this.button2.TabIndex = 4;
            this.button2.Text = "Restart Countdown";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // selectHours
            // 
            this.selectHours.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectHours.FormattingEnabled = true;
            this.selectHours.Items.AddRange(new object[] {
            "0 hours",
            "1 hours",
            "2 hours",
            "3 hours",
            "4 hours",
            "5 hours",
            "6 hours",
            "7 hours",
            "8 hours",
            "9 hours",
            "11 hours",
            "12 hours",
            "13 hours",
            "14 hours",
            "15 hours",
            "16 hours",
            "17 hours",
            "18 hours",
            "19 hours",
            "20 hours",
            "21 hours",
            "22 hours",
            "23 hours"});
            this.selectHours.Location = new System.Drawing.Point(17, 116);
            this.selectHours.Name = "selectHours";
            this.selectHours.Size = new System.Drawing.Size(60, 21);
            this.selectHours.TabIndex = 5;
            this.selectHours.Text = "4 hours";
            // 
            // selectMinutes
            // 
            this.selectMinutes.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectMinutes.FormattingEnabled = true;
            this.selectMinutes.Items.AddRange(new object[] {
            "0 hours",
            "1 hours",
            "2 hours",
            "3 hours",
            "4 hours",
            "5 hours",
            "6 hours",
            "7 hours",
            "8 hours",
            "9 hours",
            "11 hours",
            "12 hours",
            "13 hours",
            "14 hours",
            "15 hours",
            "16 hours",
            "17 hours",
            "18 hours",
            "19 hours",
            "20 hours",
            "21 hours",
            "22 hours",
            "23 hours"});
            this.selectMinutes.Location = new System.Drawing.Point(83, 116);
            this.selectMinutes.Name = "selectMinutes";
            this.selectMinutes.Size = new System.Drawing.Size(75, 21);
            this.selectMinutes.TabIndex = 6;
            this.selectMinutes.Text = "0 minutes";
            // 
            // selectSeconds
            // 
            this.selectSeconds.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectSeconds.FormattingEnabled = true;
            this.selectSeconds.Items.AddRange(new object[] {
            "0 hours",
            "1 hours",
            "2 hours",
            "3 hours",
            "4 hours",
            "5 hours",
            "6 hours",
            "7 hours",
            "8 hours",
            "9 hours",
            "11 hours",
            "12 hours",
            "13 hours",
            "14 hours",
            "15 hours",
            "16 hours",
            "17 hours",
            "18 hours",
            "19 hours",
            "20 hours",
            "21 hours",
            "22 hours",
            "23 hours"});
            this.selectSeconds.Location = new System.Drawing.Point(163, 116);
            this.selectSeconds.Name = "selectSeconds";
            this.selectSeconds.Size = new System.Drawing.Size(80, 21);
            this.selectSeconds.TabIndex = 7;
            this.selectSeconds.Text = "0 seconds";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Set count down from:";
            // 
            // selectCountdown
            // 
            this.selectCountdown.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectCountdown.FormattingEnabled = true;
            this.selectCountdown.Items.AddRange(new object[] {
            "15 minutes",
            "20 minutes",
            "30 minutes",
            "1 hour",
            "1 hour, 30 minutes",
            "4 hours",
            "6 hours",
            "8 hours"});
            this.selectCountdown.Location = new System.Drawing.Point(12, 217);
            this.selectCountdown.Name = "selectCountdown";
            this.selectCountdown.Size = new System.Drawing.Size(225, 21);
            this.selectCountdown.TabIndex = 9;
            this.selectCountdown.Text = "4 hours";
            this.selectCountdown.Visible = false;
            // 
            // FormNotice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 185);
            this.Controls.Add(this.selectCountdown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selectSeconds);
            this.Controls.Add(this.selectMinutes);
            this.Controls.Add(this.selectHours);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNotice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Countdown Complete";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormNotice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox selectHours;
        private System.Windows.Forms.ComboBox selectMinutes;
        private System.Windows.Forms.ComboBox selectSeconds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox selectCountdown;
    }
}