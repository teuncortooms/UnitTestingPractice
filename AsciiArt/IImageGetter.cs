using ImageMagick;

namespace AsciiArt
{
    public interface IImageGetter
    {
        public MagickImage GetDefaultImage(int height = 100, int width = 200);
    }
}