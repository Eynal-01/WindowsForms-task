using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms_task.Properties;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Label bakuLbl = new Label();
        Label bakuDate = new Label();
        Label londonLbl = new Label();
        Label londonDate = new Label();
        Timer mytimer = new Timer();
        Timer londonTimer = new Timer();
        Timer bakuTimer = new Timer();
        public Form1()
        {
            InitializeComponent();
            mytimer.Interval = 1000;
            mytimer.Tick += BakuTimer_Tick;
            mytimer.Start();
        }
        private void BakuTimer_Tick(object sender, EventArgs e)
        {
            bakuLbl.Text = DateTime.Now.ToLongTimeString();
        }
        private void LondonTimer_Tick(object sender, EventArgs e)
        {
            londonLbl.Text = DateTime.Now.AddHours(-4).ToLongTimeString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void londonbtn_MouseClick(object sender, MouseEventArgs e)
        {
            mytimer.Stop();
            bakuTimer.Stop();

            foreach (var control in Controls)
            {
                if (control is Label)
                {
                    (control as Label).Visible = false;
                }
            }
            this.BackgroundImage = Resources.London;
            londonLbl.Text = "London";
            londonLbl.ForeColor = Color.Black;
            londonLbl.BackColor = Color.Transparent;
            londonLbl.Location = new Point(15, 10);
            londonLbl.AutoSize = true;
            londonLbl.Font = new Font("Bodoni MT", 30, FontStyle.Bold);
            londonLbl.Visible = true;
            this.Controls.Add(londonLbl);
            this.Controls.Add(londonDate);
            londonTimer.Interval = 1000;
            londonTimer.Tick += LondonTimer_Tick;
            londonTimer.Start();
        }
        private void bakubtn_MouseClick_1(object sender, MouseEventArgs e)
        {
            mytimer.Stop();
            londonTimer.Stop();
            foreach (var control in Controls)
            {
                if (control is Label)
                {
                    (control as Label).Visible = false;
                }
            }
            this.BackgroundImage = Resources.Baku_photo;
            bakuLbl.Text = "Baku";
            bakuLbl.ForeColor = Color.LightBlue;
            bakuLbl.BackColor = Color.Transparent;
            bakuLbl.Location = new Point(15, 10);
            bakuLbl.AutoSize = true;
            bakuLbl.Font = new Font("Bodoni MT", 30, FontStyle.Bold);
            bakuLbl.Visible = true;
            this.Controls.Add(bakuLbl);
            this.Controls.Add(bakuDate);
            bakuTimer.Interval = 1000;
            bakuTimer.Tick += BakuTimer_Tick;
            bakuTimer.Start();
        }
    }
}
