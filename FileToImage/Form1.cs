using System.Windows.Forms;

namespace FileToImage
{
    public partial class Form1 : Form
    {
        FileImage? fileImage;
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadFile_Click(object sender, EventArgs e)
        {
            SelectLoadFile.ShowDialog();
        }
        private void SelectLoadFile_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.fileImage = new FileImage();
            fileImage.ImportFile(SelectLoadFile.FileName);
            Log.Text += $"Loading file {SelectLoadFile.FileName}\n";
        }
        private void LoadImage_Click(object sender, EventArgs e)
        {
            SelectLoadImage.ShowDialog();
        }
        private void SelectLoadImage_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.fileImage = new FileImage();
            fileImage.ImportImage(SelectLoadImage.FileName);

            pictureBox1.Image = new Bitmap(SelectLoadImage.FileName);
            Log.Text += $"Loading image {SelectLoadImage.FileName}\n";
        }
        private void ExportImage_Click(object sender, EventArgs e)
        {
            SaveExportImage.DefaultExt = ".png";
            SaveExportImage.AddExtension = true;
            SaveExportImage.ShowDialog();
        }
        private void SaveExportImage_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (this.fileImage != null)
            {
                fileImage.ExportImage(SaveExportImage.FileName);
                Log.Text += $"Exporting image {SaveExportImage.FileName}\n";
            }
            else
            {

            }
        }
        private void ExportFile_Click(object sender, EventArgs e)
        {
            SaveExportFile.DefaultExt = ".png";
            SaveExportFile.AddExtension = true;
            SaveExportFile.ShowDialog();
        }
        private void SaveExportFile_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (this.fileImage != null)
            {
                fileImage.ExportFile(SaveExportFile.FileName);
                Log.Text += $"Exporting file {SaveExportFile.FileName}\n";
            }
            else
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Log.Multiline = true;
        }
    }
}