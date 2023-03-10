using System.Net.Http.Headers;

namespace App9
{
    public partial class Form1 : Form
    {
        internal static List<Figure> figures = new List<Figure>();

        public Form1()
        {
            InitializeComponent();

            Init.bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Init.pen = new Pen(Color.Black, 5);
            Init.picturebox = pictureBox1;
        }

        private void Console_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && Console.Text != "")
            {
                if (Console.Text == "cls") 
                    History.Items.Clear();

                else if (Algorithm.InToPoland(Console.Text) && Algorithm.FromTo())
                        History.Items.Add(Console.Text + "  TRUE");

                else    
                    History.Items.Add(Console.Text + "  FALSE");

                Console.Text = String.Empty;
            }
        }
    }
}