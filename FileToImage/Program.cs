

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
            // handle BuildNmber
            if (File.Exists("..\\..\\..\\BuildNumber.txt"))
            {
                int BuildNumber = Convert.ToInt32(File.ReadAllText("..\\..\\..\\BuildNumber.txt"));
                BuildNumber += 1;
                Console.WriteLine($"Current BuildNumber is: {BuildNumber}");
                File.WriteAllText("..\\..\\..\\BuildNumber.txt", Convert.ToString(BuildNumber));
            }

            bool debug = false;
            if (debug)
            {
                FileImage fileImage = new FileImage();

                fileImage.ImportFile("test.txt");
                fileImage.ExportImage("test.png");

                FileImage check = new FileImage();
                check.ImportImage("test.png");
                check.ExportFile("check.txt");
            }
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}