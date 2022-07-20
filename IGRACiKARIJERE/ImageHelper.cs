using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGRACiKARIJERE
{
    public class ImageHelper
    {
        public static byte[] FromImageToByte(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Jpeg);
            return ms.ToArray();
        }
        public static Image FromByteToImage(byte[] img)
        {
            MemoryStream ms = new MemoryStream(img);
            return Image.FromStream(ms);
        }
    }
}
