using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Stopwatch : Form
    {
        DateTime date;
        public Stopwatch()
        {
            InitializeComponent();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (button2.Text == "Start")
            {
                button2.Text = "Stop";
                label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(84)))));
                label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(84)))));
                label1.Image = global::WindowsFormsApp2.Properties.Resources.timeract;
                date = DateTime.Now;
                Timer timer = new Timer();
                timer.Interval = 10;
                timer.Tick += new EventHandler(tickTimer);
                timer.Start();
            } else
            {
                button2.Text = "Start";
                label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                label1.Image = global::WindowsFormsApp2.Properties.Resources.timer;
                label1.Text = "00:00";
                label2.Text = "00";

            }
        }
        private void tickTimer(object sender, EventArgs e)
        {
            if (button2.Text == "Stop")
            {
                long tick = DateTime.Now.Ticks - date.Ticks;
                DateTime stopWatch = new DateTime();
                stopWatch = stopWatch.AddTicks(tick);
                label1.Text = String.Format("{0:mm:ss}", stopWatch);
                label2.Text = String.Format("{0:ff}", stopWatch);
            } 
            else
            {
                label1.Text = "00:00";
                label2.Text = "00";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Start")
            {
                button2.Text = "Stop";
                label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(84)))));
                label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(84)))));
                label1.Image = global::WindowsFormsApp2.Properties.Resources.timeract;
                date = DateTime.Now;
                Timer timer = new Timer();
                timer.Interval = 10;
                timer.Tick += new EventHandler(tickTimer);
                timer.Start();
            }
            else
            {
                button2.Text = "Старт";
                label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                label1.Image = global::WindowsFormsApp2.Properties.Resources.timer;
                label1.Text = "00:00";
                label2.Text = "00";

            }
        }
    }
}
