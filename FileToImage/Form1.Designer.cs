namespace FileToImage
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            Log = new TextBox();
            LoadFile = new Button();
            ExportImage = new Button();
            SelectLoadImage = new OpenFileDialog();
            SaveExportFile = new SaveFileDialog();
            LoadImage = new Button();
            ExportFile = new Button();
            SelectLoadFile = new OpenFileDialog();
            SaveExportImage = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(25, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1090, 697);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Log
            // 
            Log.Location = new Point(1153, 115);
            Log.Multiline = true;
            Log.Name = "Log";
            Log.Size = new Size(712, 443);
            Log.TabIndex = 1;
            // 
            // LoadFile
            // 
            LoadFile.Location = new Point(55, 817);
            LoadFile.Name = "LoadFile";
            LoadFile.Size = new Size(193, 53);
            LoadFile.TabIndex = 2;
            LoadFile.Text = "Load File";
            LoadFile.UseVisualStyleBackColor = true;
            LoadFile.Click += LoadFile_Click;
            // 
            // ExportImage
            // 
            ExportImage.Location = new Point(348, 947);
            ExportImage.Name = "ExportImage";
            ExportImage.Size = new Size(193, 53);
            ExportImage.TabIndex = 3;
            ExportImage.Text = "Export Image\r\n";
            ExportImage.UseVisualStyleBackColor = true;
            ExportImage.Click += ExportImage_Click;
            // 
            // SelectLoadImage
            // 
            SelectLoadImage.FileName = "SelectLoadImage";
            SelectLoadImage.Title = "Select Load Image";
            SelectLoadImage.FileOk += SelectLoadImage_FileOk;
            // 
            // SaveExportFile
            // 
            SaveExportFile.Title = "Save Export File";
            SaveExportFile.FileOk += SaveExportFile_FileOk;
            // 
            // LoadImage
            // 
            LoadImage.Location = new Point(55, 947);
            LoadImage.Name = "LoadImage";
            LoadImage.Size = new Size(193, 53);
            LoadImage.TabIndex = 5;
            LoadImage.Text = "Load Image";
            LoadImage.UseVisualStyleBackColor = true;
            LoadImage.Click += LoadImage_Click;
            // 
            // ExportFile
            // 
            ExportFile.Location = new Point(348, 817);
            ExportFile.Name = "ExportFile";
            ExportFile.Size = new Size(193, 53);
            ExportFile.TabIndex = 6;
            ExportFile.Text = "Export File";
            ExportFile.UseVisualStyleBackColor = true;
            ExportFile.Click += ExportFile_Click;
            // 
            // SelectLoadFile
            // 
            SelectLoadFile.FileName = "SelectLoadFile";
            SelectLoadFile.Title = "Select Load File";
            SelectLoadFile.FileOk += SelectLoadFile_FileOk;
            // 
            // SaveExportImage
            // 
            SaveExportImage.Title = "Save Export Image";
            SaveExportImage.FileOk += SaveExportImage_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1900, 1076);
            Controls.Add(ExportFile);
            Controls.Add(LoadImage);
            Controls.Add(ExportImage);
            Controls.Add(LoadFile);
            Controls.Add(Log);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "File Image";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox Log;
        private Button LoadFile;
        private Button ExportImage;
        private OpenFileDialog SelectLoadImage;
        private SaveFileDialog SaveExportFile;
        private Button LoadImage;
        private Button ExportFile;
        private OpenFileDialog SelectLoadFile;
        private SaveFileDialog SaveExportImage;
    }
}