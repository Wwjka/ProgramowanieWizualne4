using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pw4
{
    public partial class Form1: Form
    {
        private Bitmap originalBitmap;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Bitmap files (*.bmp)|*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    originalBitmap = new Bitmap(ofd.FileName);
                    pbImage.Image = originalBitmap;
                }
            }
        }
    }
}
