using ImageMagick;
using System;
using System.Collections.Generic;
using System.Text;

namespace AsciiArt
{
    public class ImageGetter : IImageGetter
    {
        public MagickImage GetDefaultImage(int height = 100, int width = 200)
        {
            return new MagickImage(@"C:\Users\884573\Documents\Repositories\UnitTestingPractice\AsciiArt\pics\asciipineapple.jpg");
        }
    }
}
