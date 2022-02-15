using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_project_admin
{
    public partial class Splash : Form
    {
        private int count1 = 0;
        private int count2 = 0;

        public Splash()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void Splash_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new 
                LinearGradientBrush(this.ClientRectangle, 
                Color.FromArgb(214, 49, 49), Color.FromArgb(11, 7, 17), 90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count1++;
            if (count1 == 20)
            {
                timer1.Stop();
                timer2.Start();
                timer2.Interval = 100;
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 100;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            count2++;
            progressBar1.Value = count2;
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer2.Stop();
                MainForm obj = new MainForm();
                Hide();
                obj.Show();
            }
        }
    }
}
