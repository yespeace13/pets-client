using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_5
{
    public partial class ScanView : Form
    {
        Bitmap _image;
        public ScanView(Bitmap image)
        {
            _image = image;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(image.Width, image.Height);
            pictureBox1.Image = image;
            
        }

        private void ScanView_Resize(object sender, EventArgs e)
        {
            //var coef = (int)((double)_image.Size.Width / _image.Height * 10);
            //var i = new Bitmap(_image, new Size(pictureBox1.Width, pictureBox1.Height * coef / 10));
            //pictureBox1.Image = i;
        }
    }
}
