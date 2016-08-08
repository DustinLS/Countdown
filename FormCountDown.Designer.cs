namespace PrjCountdown
{
    partial class FormCountDown
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCountDown));
            this.labelClock = new System.Windows.Forms.Label();
            this.pbControl = new System.Windows.Forms.PictureBox();
            this.timerTop = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbControl)).BeginInit();
            this.SuspendLayout();
            // 
            // labelClock
            // 
            this.labelClock.AutoSize = true;
            this.labelClock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelClock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClock.ForeColor = System.Drawing.Color.White;
            this.labelClock.Location = new System.Drawing.Point(23, 0);
            this.labelClock.Name = "labelClock";
            this.labelClock.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.labelClock.Size = new System.Drawing.Size(52, 21);
            this.labelClock.TabIndex = 0;
            this.labelClock.Text = "8:46 PM";
            this.labelClock.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelClock_MouseDown);
            this.labelClock.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelClock_MouseMove);
            this.labelClock.MouseUp += new System.Windows.Forms.MouseEventHandler(this.labelClock_MouseUp);
            // 
            // pbControl
            // 
            this.pbControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pbControl.Image = ((System.Drawing.Image)(resources.GetObject("pbControl.Image")));
            this.pbControl.Location = new System.Drawing.Point(-1, -1);
            this.pbControl.Name = "pbControl";
            this.pbControl.Padding = new System.Windows.Forms.Padding(3);
            this.pbControl.Size = new System.Drawing.Size(22, 22);
            this.pbControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbControl.TabIndex = 1;
            this.pbControl.TabStop = false;
            this.pbControl.Click += new System.EventHandler(this.pbControl_Click);
            this.pbControl.DoubleClick += new System.EventHandler(this.pbControl_DoubleClick);
            this.pbControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelClock_MouseDown);
            this.pbControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelClock_MouseMove);
            this.pbControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.labelClock_MouseUp);
            // 
            // timerTop
            // 
            this.timerTop.Interval = 150;
            this.timerTop.Tick += new System.EventHandler(this.timerTop_Tick);
            // 
            // FormCountDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(83, 21);
            this.Controls.Add(this.pbControl);
            this.Controls.Add(this.labelClock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCountDown";
            this.ShowInTaskbar = false;
            this.Text = "Countdown";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.FormCountDown_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelClock;
        private System.Windows.Forms.PictureBox pbControl;
        private System.Windows.Forms.Timer timerTop;
    }
}

