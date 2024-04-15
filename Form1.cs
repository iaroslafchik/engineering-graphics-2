using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphics_lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Image selectedImage;

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Выйти?" + Environment.NewLine + "Все несохраненные данные будут утеряны!", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void pNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogPNG = new OpenFileDialog();
            openFileDialogPNG.Filter = "PNG|*.png";
            if (openFileDialogPNG.ShowDialog() == DialogResult.OK)
            {
                selectedImage = Image.FromFile(openFileDialogPNG.FileName);
            }
            pictureBox1.Image = selectedImage;
            toolStripStatusLabel1.Text = openFileDialogPNG.FileName;
        }

        private void настройкиИзображенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form imageSettings = new ImageSettings();
            imageSettings.ShowDialog();
        }
    }
}
