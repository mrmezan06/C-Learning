using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipBoardProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(textBox1.Text);
            }
            catch
            {

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
                textBox2.Text = Clipboard.GetText();

                //iterator will clear the clipboard
              //  Clipboard.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //it is not working but why don't know
            pictureBox1.Image = Clipboard.GetImage();
        }
    }
}
