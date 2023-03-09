using System.Net.Http.Headers;

namespace App9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Init.bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Init.pen = new Pen(Color.Black, 5);
            Init.picturebox = pictureBox1;
        }
    }
}