using ImageMagick;
using System;
using System.Collections.Generic;
using System.Text;

namespace AsciiArt
{
    public class ImgToAsciiConverter
    {
        public int Height { get; private set; }
        public int Width { get; private set; }

        public void SetDefaultImage()
        {
            using var img = new MagickImage(@"C:\Users\884573\Documents\Repositories\UnitTestingTutorial\ASCII_art\pics\asciipineapple.jpg");
            this.Height = img.Height;
            this.Width = img.Width;
        }
    }
}
