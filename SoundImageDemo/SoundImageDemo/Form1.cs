using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoundImageDemo
{
    public partial class Form1 : Form
    {
        private Monkey myMonkey;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myMonkey = new Monkey(SoundImageDemo.Properties.Resources.chimp, SoundImageDemo.Properties.Resources.chimpanzee_1, this.ClientRectangle); //don't forget about "this"
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            myMonkey.paint(e.Graphics);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (myMonkey.isHit(e.Location))
            {
                myMonkey.playSound();
                myMonkey.reLocate();
                Refresh();
            }
        }
    }
}
