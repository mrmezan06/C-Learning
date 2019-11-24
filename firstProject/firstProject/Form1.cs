using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hey Akash,\nWhat's up?";
           // MessageBox.Show("Hey Buddy","User Greeting");
            for (int i = 0; i <= 100; i++)
            {
                bunifuSlider1.Value = i;
            }
            
        }

        private void btn1_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "Click to Get Greetings...";
        }

        private void btn1_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "Mouse Hover the button to find information";
        }
    }
}
