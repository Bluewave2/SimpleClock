using System.Diagnostics;
using System.Text;

namespace SimpleClock
{
    public partial class Form1 : Form
    {
        private StringBuilder _sb = new StringBuilder();
        public Form1()
        {
            InitializeComponent();
            trackBar1.Value = timer1.Interval;
            lblInterval.Text = trackBar1.Value.ToString() + " ms";
            SetCultureLabel();
        }

        private void SetCultureLabel()
        {
            lblCulture.Text = "Current application culture: " + Application.CurrentCulture.EnglishName;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SetTime();
        }

        private void SetTime()
        {
            var temp = DateTime.Now;
            _sb.Append(temp.ToLongTimeString() + ":");
            _sb.Append(temp.Millisecond);
            lblTime.Text = _sb.ToString();
            _sb.Clear();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = trackBar1.Value;
            lblInterval.Text = trackBar1.Value.ToString() + " ms";
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                btnPause.Text = "Restart";
            }
            else
            {
                SetTime();
                timer1.Start();
                btnPause.Text = "Pause";
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://github.com/Bluewave2/SimpleClock";
            Process.Start(new ProcessStartInfo { FileName = url, UseShellExecute = true });
            linkLabel1.LinkVisited = true;
        }
    }
}
