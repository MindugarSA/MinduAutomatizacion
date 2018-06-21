using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer
{
    public static class ImageExtensions
    {
        public static byte[] imageToByteArray(this System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            try
            {
                imageIn.Save(ms, imageIn.RawFormat);
            }
            catch {}
            return ms.ToArray();
        }

        public static Image byteArrayToImage(this byte[] byteArrayIn)
        {
            Image returnImage = null;
            MemoryStream ms = new MemoryStream(byteArrayIn);
            try
            {
                returnImage = Image.FromStream(ms);
            }
            catch {}
            return returnImage;

        }
    }
}
