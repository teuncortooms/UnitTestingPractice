using Microsoft.VisualStudio.TestTools.UnitTesting;
using AsciiArt;
using System.IO;

namespace AsciiArtTests
{
    [TestClass]
    public class ImgToAsciiConverterTests
    {
        [TestMethod]
        public void Get_height()
        {
            IImageGetter g = new MockImageGetter();

            var img = g.GetDefaultImage(300, 600);

            Assert.AreEqual(300, img.Height);
        }

        [TestMethod]
        public void Get_width()
        {
            IImageGetter g = new MockImageGetter();

            var img = g.GetDefaultImage(300, 600);

            Assert.AreEqual(600, img.Width);
        }
    }
}
