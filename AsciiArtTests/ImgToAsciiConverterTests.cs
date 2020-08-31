using Microsoft.VisualStudio.TestTools.UnitTesting;
using AsciiArt;
using System.IO;

namespace AsciiArtTests
{
    [TestClass]
    public class ImgToAsciiConverterTests
    {
        [TestMethod]
        public void Get_width_and_height_for_default_image_should_return_bigger_than_0()
        {
            ImgToAsciiConverter c = new ImgToAsciiConverter();

            c.SetDefaultImage();

            Assert.IsTrue(0 < c.Height);
            Assert.IsTrue(0 < c.Width);
        }

        [TestMethod]
        public void Get_width_for_default_image_returns_700()
        {
            ImgToAsciiConverter c = new ImgToAsciiConverter();

            c.SetDefaultImage();

            Assert.AreEqual(700, c.Width);
        }

        [TestMethod]
        public void Get_height_for_default_image_returns_467()
        {
            ImgToAsciiConverter c = new ImgToAsciiConverter();

            c.SetDefaultImage();

            Assert.AreEqual(467, c.Height);
        }
    }
}
