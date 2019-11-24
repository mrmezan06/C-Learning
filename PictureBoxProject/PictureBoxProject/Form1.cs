using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBoxProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Another way
                Image img = Image.FromFile(ofd.FileName);
                pictureBox1.Image = img;

                // pictureBox1.ImageLocation = ofd.FileName;

                // Another way to load url image
               // pictureBox1.ImageLocation = "Here-the-url-of-image";
            }
        }
    }
}
