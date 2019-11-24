using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ScreenCaptureApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(Capturing);
            t.Start();
        }
        void Capturing() {
            for (;  ; ) {
                Bitmap b = new Bitmap(Screen.PrimaryScreen.WorkingArea.Width,Screen.PrimaryScreen.WorkingArea.Height);
                Graphics g = Graphics.FromImage(b);
                g.CopyFromScreen(Point.Empty, Point.Empty, Screen.PrimaryScreen.WorkingArea.Size);
                pictureBox1.Image = b;

            }
        }
    }
}
