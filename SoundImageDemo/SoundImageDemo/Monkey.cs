using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Media;

namespace SoundImageDemo
{
    class Monkey
    {
        private Image myImage;
        private Rectangle myRectangle;
        private Rectangle myBounds;
        private SoundPlayer myWavPlayer;
        private static Random gen = new Random();

        public Monkey(Image anImage, System.IO.Stream aSound, Rectangle bounds) //ctor tab tab to make a constructor
        {
            myImage = anImage;
            myWavPlayer = new SoundPlayer();
            myWavPlayer.Stream = aSound;
            myWavPlayer.Load();
            myBounds = bounds;

            reLocate();        
        }

        public void paint(Graphics g)
        {
            g.DrawImage(myImage, myRectangle);
        }

        public bool isHit(Point location)
        {
            return myRectangle.Contains(location); //boolean methods should be just return and whatever you need to return
        }

        public void reLocate()
        {
            myRectangle = new Rectangle(gen.Next(myBounds.Width - myRectangle.Width), gen.Next(myBounds.Height - myRectangle.Height), myImage.Width, myImage.Height); 

        }

        public void playSound()
        {
            myWavPlayer.Play();
        }
    }
}
