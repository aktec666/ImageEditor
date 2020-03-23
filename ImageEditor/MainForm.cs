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

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ImageOpen = new OpenFileDialog();
            if (ImageOpen.ShowDialog() == DialogResult.OK)
            {
                Bitmap tempImage = new Bitmap(ImageOpen.FileName);
                MainBox.BackgroundImage = tempImage;
            }
        }
    }
}
