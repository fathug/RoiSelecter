using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoiSelecter
{
    public partial class Form1 : Form
    {
        // 变量申明
        private Bitmap loadedImage; // 用于存储加载的图像


        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                loadedImage = new Bitmap(openFileDialog1.FileName);

                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image = loadedImage;
            }
        }
    }
}
