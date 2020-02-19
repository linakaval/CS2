using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseKeyboardDemo
{
    public partial class Form1 : Form
    {
        //make a private constant for paintball
        private const int SPEED = 50;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            moveLabel(e.KeyData);
        }

        private void button1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            moveLabel(e.KeyData);
        }

        private void moveLabel(Keys keys)
        {
            Point p = label1.Location;
            //don't use a label for paintball, draw something

            if (keys == Keys.Left)
            {
                p.Offset(-SPEED, 0);
            }
            else if (keys == Keys.Right)
            {
                p.Offset(SPEED, 0);
            }

            label1.Location = p;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            label2.Text = "The mouse is in the house.";
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            label2.Text = "The mouse has left the house.";
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            label2.Text = "The " + e.Button + " button was pressed at " + e.Location + ".";
        }
    }
}
