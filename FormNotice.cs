using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace PrjCountdown
{
    public partial class FormNotice : Form
    {
        private int _initHours = 4;
        private int _initMinutes = 0;
        private int _initSeconds = 0;

        public string From
        {
            get
            {
                return String.Format("{0} {1} {2}", selectHours.Text, selectMinutes.Text, selectSeconds.Text);
            }
        }

        public FormNotice()
        {
            InitializeComponent();
        }

        public FormNotice(int hours, int minutes, int seconds)
        {
            _initHours = hours;
            _initMinutes = minutes;
            _initSeconds = seconds;
            InitializeComponent();
        }

        private void FormNotice_Load(object sender, EventArgs e)
        {
            selectMinutes.Items.Clear();
            selectSeconds.Items.Clear();
            for (int i = 0; i < 60; i++)
            {
                selectMinutes.Items.Add(String.Format("{0} minutes", i.ToString()));
                selectSeconds.Items.Add(String.Format("{0} seconds", i.ToString()));
            }
            selectHours.SelectedIndex = _initHours;
            selectMinutes.SelectedIndex = _initMinutes;
            selectSeconds.SelectedIndex = _initSeconds;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
