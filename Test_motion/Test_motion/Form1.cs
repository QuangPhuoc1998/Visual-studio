using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_motion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Time_1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X + 10, pictureBox1.Location.Y);
            if (pictureBox1.Location.X > panel3.Size.Width - pictureBox1.Size.Width)
            {
                led1.On = true;
                //pictureBox1.Image = new Bitmap(Application.StartupPath + "\\picture\\white.png");
                pictureBox1.Location = new Point(0, 0 + 470);
                Timer_1.Stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(0, 0 + 470);
            pictureBox2.Parent = this;
            pictureBox2.Parent = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(Application.StartupPath + "\\picture\\car_lam.png");
            //Timer_1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(Application.StartupPath + "\\picture\\white.png");
        }
    }
}
