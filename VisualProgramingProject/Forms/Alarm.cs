using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
namespace HelpApp.Forms
{
    public partial class Alarm : Form
    {
        System.Timers.Timer timer;

        public Alarm()
        {
            InitializeComponent();
        }

        private void Alarm_Load(object sender, EventArgs e)
        {

            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
        }

        delegate void updateLabel(Label lbl, string value);
        void updateDataLabel(Label lbl, string value)
        {
            lbl.Text = value;
        }
        SoundPlayer player = new SoundPlayer();
        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            DateTime userTime = guna2DateTimePicker1.Value;
            if (currentTime.Hour == userTime.Hour && currentTime.Minute == userTime.Minute && currentTime.Second == userTime.Second)
            {
                timer.Stop();
                try
                {
                    updateLabel up = updateDataLabel;
                    if (lblStatus.InvokeRequired)
                    {
                        Invoke(up, lblStatus, "Stop");
                    }
                    
                    player.SoundLocation = @"Sound\afroto.wav";
                    player.PlayLooping();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            timer.Start();
            lblStatus.Text = "Running...";
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            lblStatus.Text = "Stop...";
            player.Stop();
        }
        private void btnBlack_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            this.ForeColor = Color.SandyBrown;
            this.groupBox1.BackColor = Color.Black;
        }

        private void btnWhite_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            this.groupBox1.BackColor = Color.White;
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }


    }
}
