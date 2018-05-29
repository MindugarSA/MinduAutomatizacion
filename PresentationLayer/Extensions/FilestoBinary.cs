using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer
{
    class FilestoBinary
    {
        public static byte[] GenerateByteArray(string ubicacion)
        {
            byte[] contenido = null;
            if (File.Exists(ubicacion))
                contenido = File.ReadAllBytes(ubicacion);

            return contenido;
        }

        public static void CreateFileFromBinary(byte[] FileByte, string ubicacion)
        {
            if (Directory.Exists(ubicacion))
                File.WriteAllBytes(ubicacion, FileByte);
        }

        public static byte[] GenerateByteArrayFileStream(string ubicacion)
        {
            byte[] contenido = null;
            if (File.Exists(ubicacion))
            {
                FileInfo finfo = new FileInfo(ubicacion);
                FileStream fstream = new FileStream(ubicacion, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                contenido = br.ReadBytes(Convert.ToInt32(finfo.Length));
                br.Close();
                fstream.Close();
                fstream.Dispose();
            }

            return contenido;
        }
    }
}
