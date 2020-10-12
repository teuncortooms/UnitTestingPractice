using ImageMagick;
using System;
using System.Collections.Generic;
using System.Text;

namespace AsciiArt
{
    public class MockImageGetter : IImageGetter
    {
        public MagickImage GetDefaultImage(int height = 100, int width = 200)
        {
            var colour = new MagickColor(50, 110, 200);
            return new MagickImage(colour, width, height);
        }
    }
}
