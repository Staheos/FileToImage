

namespace FileToImage
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            FileImage fileImage = new FileImage();

            fileImage.ImportFile("test.txt");
            fileImage.ExportImage("test.bmp");

            FileImage check = new FileImage();
            check.ImportFile("test.bmp");
            fileImage.ExportFile("check.txt");

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}