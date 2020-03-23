using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageEditor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // открытие файла
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ImageOpen = new OpenFileDialog();
            if (ImageOpen.ShowDialog() == DialogResult.OK)
            {
                Bitmap tempImage = new Bitmap(ImageOpen.FileName);
                MainBox.Image = tempImage;
            }
        }

        private void MainBox_Click(object sender, EventArgs e)
        {

        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void BrightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap tempImage = new Bitmap(MainBox.Image);
            for (int i =0; i<tempImage.Height; i++)
                for (int j = 0; j < tempImage.Width; j++)
                {
                    Color pixelColor = tempImage.GetPixel(i, j);
                    Color newColor = Color.FromArgb(Math.Min(pixelColor.R+50,255), Math.Min(pixelColor.G + 50, 255), Math.Min(pixelColor.B + 50, 255));
                    tempImage.SetPixel(i, j, newColor);
                }
            MainBox.Image = tempImage;
        }

        private void ContrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap tempImage = new Bitmap(MainBox.Image);
            for (int i = 0; i < tempImage.Height; i++)
                for (int j = 0; j < tempImage.Width; j++)
                {
                    Color pixelColor = tempImage.GetPixel(i, j);
                    Color newColor = Color.FromArgb(Math.Min((int)(pixelColor.R * 0.6), 255), Math.Min((int)(pixelColor.G * 0.6), 255), Math.Min((int)(pixelColor.B * 0.6), 255));
                    tempImage.SetPixel(i, j, newColor);
                }
            MainBox.Image = tempImage;
        }
    }
}
