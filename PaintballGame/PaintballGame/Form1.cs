using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintballGame
{
    public partial class Form1 : Form
    {
        private Target myTarget;
        private static Random gen = new Random();
        private const int SPEED = 100;
        private Rectangle myTargetRect;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        { 
            myTarget = new Target();
            myTargetRect = new Rectangle(gen.Next(pictureBox1.Width), gen.Next(pictureBox1.Height), 20, 20);
            myTarget.paint(e.Graphics, myTargetRect);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            moveTarget(e.KeyData);
        }

        private void moveTarget(Keys keyData)
        {          
            if (keyData == Keys.Left)
            {
                myTargetRect.Offset(-SPEED, 0);
            }
            else if (keyData == Keys.Right)
            {
                myTargetRect.Offset(SPEED, 0);
            }
            else if (keyData == Keys.Down)
            {
                myTargetRect.Offset(0, -SPEED);
            }
            else if (keyData == Keys.Up)
            {
                myTargetRect.Offset(0, SPEED);
            }
        }

        private void pictureBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            moveTarget(e.KeyData);
        }
    }
}
