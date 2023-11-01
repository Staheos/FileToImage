using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileToImage
{
    class FileImage
    {
        byte[] bytes;

        public FileImage()
        {

        }
        public void ImportFile(string path)
        {
            this.bytes = File.ReadAllBytes(path);
        }

        public void ImportImage(string path)
        {
            Bitmap bmp = new Bitmap(path);
            Console.WriteLine($"PixelFormat: {bmp.PixelFormat}");
            int width = bmp.Width;
            int height = bmp.Height;

            byte[] bytesData = new byte[bmp.Width * bmp.Height * 4];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Color pixel = bmp.GetPixel(j, i);
                    bytesData[(i * width + j) * 4] = pixel.A;
                    bytesData[(i * width + j) * 4 + 1] = pixel.R;
                    bytesData[(i * width + j) * 4 + 2] = pixel.G;
                    bytesData[(i * width + j) * 4 + 3] = pixel.B;
                    //Console.WriteLine($"Pixel: {i} {j} {i * width + j} {bytesData[(i * width + j) * 4]} {bytesData[(i * width + j) * 4 + 1]} {bytesData[(i * width + j) * 4 + 2]} {bytesData[(i * width + j) * 4 + 3]}");
                }
            }
            byte[] prefix = new byte[4];
            Array.Copy(bytesData, prefix, 4);

            int bytesLength = BitConverter.ToInt32(prefix, 0);
            this.bytes = new byte[bytesLength];

            Array.Copy(bytesData, 4, this.bytes, 0, bytesLength);

            Console.WriteLine($"Prefix: {prefix.Length}");
            Console.WriteLine($"Bytes: {bytes.Length}");

            Console.WriteLine($"Width: {width} Height: {height}");

            for (int i = 0; i < this.bytes.Length; i++)
            {
                //Console.Write(this.bytes[i].ToString());
            }
        }
        public void ExportImage(string path)
        {
            int width;
            int height;
            byte[] prefix;

            prefix = BitConverter.GetBytes(bytes.Length);

            //height = (int)Math.Ceiling((prefix.Length + bytes.Length) / (double)width);
            Console.WriteLine($"Prefix: {prefix.Length}");
            Console.WriteLine($"Bytes: {bytes.Length}");

            // every pixel stores 4 bytes
            //width = (int)Math.Ceiling(Math.Sqrt(prefix.Length + bytes.Length));
            width = (int)Math.Ceiling(Math.Sqrt((prefix.Length + bytes.Length) / (double)4));
            height = width;
            Console.WriteLine($"Width: {width} Height: {height}");

            //byte[] toWrite = new byte[prefix.Length + bytes.Length];
            byte[] toWrite = new byte[width * 4 * height];
            prefix.CopyTo(toWrite, 0);
            this.bytes.CopyTo(toWrite, prefix.Length);
            for (int i = 0; i < toWrite.Length; i++)
            {
                //Console.Write(toWrite[i].ToString());
            }

            Bitmap bmp = new Bitmap(width, height, PixelFormat.Format32bppArgb);

            for (int i = 0; i < height; i++) 
            {
                for (int j = 0; j < width; j++)
                {
                    //Console.WriteLine($"Pixel: {i} {j} {i * width + j} {toWrite[(i * width + j) * 4]} {toWrite[(i * width + j) * 4 + 1]} {toWrite[(i * width + j) * 4 + 2]} {toWrite[(i * width + j) * 4 + 3]}");
                    //bmp.SetPixel(j, i,
                    //    Color.FromArgb(toWrite[i * width + j], toWrite[i * width + j], toWrite[i * width + j])
                    //    );
                    bmp.SetPixel(j, i,
                        Color.FromArgb(toWrite[(i * width + j) * 4], toWrite[(i * width + j) * 4 + 1], toWrite[(i * width + j) * 4 + 2], toWrite[(i * width + j) * 4 + 3])
                        );
                }
            }   

            bmp.Save(path, ImageFormat.Png);
        }

        public void ExportFile(string path)
        {
            File.WriteAllBytes(path, this.bytes);
        }
    }
}
