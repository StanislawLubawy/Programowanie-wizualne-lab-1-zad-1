namespace edycja_obrazka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object? sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var img = Image.FromFile(openFileDialog1.FileName);
                    pictureBoxMain.Image?.Dispose();
                    pictureBoxMain.Image = new Bitmap(img);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to load image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnOnlyGreen_Click(object? sender, EventArgs e)
        {
            if (pictureBoxMain.Image == null)
            {
                MessageBox.Show("No image loaded", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var src = new Bitmap(pictureBoxMain.Image);
            var bmp = new Bitmap(src.Width, src.Height);
            for (int y = 0; y < src.Height; y++)
            {
                for (int x = 0; x < src.Width; x++)
                {
                    var c = src.GetPixel(x, y);

                    if (c.G > c.R + 30 && c.G > c.B + 30)
                    {
                        bmp.SetPixel(x, y, c);
                    }
                    else
                    {
                        bmp.SetPixel(x, y, Color.Black);
                    }
                }
            }

            pictureBoxMain.Image?.Dispose();
            src.Dispose();
            pictureBoxMain.Image = bmp;
        }
    }
}
