using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PrjCountdown
{
    public partial class FormCountDown : Form
    {
        private bool titleMouseDown = false;
        private Point titleMousePoint;
        private DateTime ttl = DateTime.Now.AddSeconds(10);
        private bool _notice = false;
        private int _initHours = 4;
        private int _initMinutes = 0;
        private int _initSeconds = 0;
        private bool playSound = false;
        public FormCountDown()
        {
            InitializeComponent();
        }

        private void FormCountDown_Load(object sender, EventArgs e)
        {
            if (File.Exists("window.txt"))
            {
                int x;
                int y;
                string[] pos = File.ReadAllLines("window.txt");
                if (Int32.TryParse(pos[0], out x)) this.Left = x;
                if (Int32.TryParse(pos[1], out y)) this.Top = y;
            }
            timerTop.Enabled = true;
        }

        private void labelClock_MouseDown(object sender, MouseEventArgs e)
        {
            if (titleMouseDown) return;
            titleMouseDown = true;
            titleMousePoint = new Point(e.X, e.Y);
        }
        private void labelClock_MouseMove(object sender, MouseEventArgs e)
        {
            if (!titleMouseDown) return;
            this.Location = new Point(this.Left - (titleMousePoint.X - e.X), this.Top - (titleMousePoint.Y - e.Y));
        }
        private void labelClock_MouseUp(object sender, MouseEventArgs e)
        {
            if (titleMouseDown)
            {
                titleMouseDown = false;
                string[] pos = new string[2];
                pos[0] = this.Left.ToString();
                pos[1] = this.Top.ToString();
                File.WriteAllLines("window.txt", pos);
            }
        }

        private void pbControl_Click(object sender, EventArgs e)
        {
            playSound = false;
            ttl = DateTime.Now;
        }

        private void pbControl_DoubleClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timerTop_Tick(object sender, EventArgs e)
        {
            this.TopMost = true;
            if (DateTime.Now < ttl)
            {
                TimeSpan ts = (ttl - DateTime.Now);
                string text = String.Format("{0}:{1}:{2}", ts.Hours.ToString("0"), ts.Minutes.ToString("00"), ts.Seconds.ToString("00"));
                if (labelClock.Text != text) labelClock.Text = text;
            }
            else
            {
                if (!_notice)
                {
                    SoundPlayer sp = new SoundPlayer();
                    timerTop.Enabled = false;
                    _notice = true;
                    FormNotice notice = new FormNotice(_initHours, _initMinutes, _initSeconds);
                    if (playSound)
                    {
                        sp.SoundLocation = "alarm.wav";
                        sp.Play();
                    }
                    DialogResult res = notice.ShowDialog();
                    if (playSound)
                    {
                        sp.Stop();
                    }
                    else
                    {
                        playSound = true;
                    }
                    
                    if (res == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                    else
                    {
                        if (res == DialogResult.Retry)
                        {
                            int h, m, s;
                            Match match = Regex.Match(notice.From, "(?<h>[0-9]+) hours (?<m>[0-9]+) minutes (?<s>[0-9]+) seconds");
                            
                            Debug.WriteLine("Countdown from: " + notice.From);

                            if(!Int32.TryParse(match.Groups["h"].Value, out h)) h = 4;
                            if(!Int32.TryParse(match.Groups["m"].Value, out m)) m = 0;
                            if(!Int32.TryParse(match.Groups["s"].Value, out s)) s = 0;

                            _initHours = h;
                            _initMinutes = m;
                            _initSeconds = s;

                            Debug.WriteLine(String.Format("Parsed: {0}:{1}:{2}", h, m, s));

                            _notice = false;
                            
                            ttl = DateTime.Now.AddHours(h).AddMinutes(m).AddSeconds(s);
                            timerTop.Enabled = true;
                        }
                    }
                    
                }
            }
        }
    }
}
