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

        private void btnRotate_Click(object? sender, EventArgs e)
        {
            if (pictureBoxMain.Image == null)
            {
                MessageBox.Show("No image loaded", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            RotateFlipType flipType = RotateFlipType.RotateNoneFlipNone;
            if (rdo90.Checked) flipType = RotateFlipType.Rotate90FlipNone;
            else if (rdo180.Checked) flipType = RotateFlipType.Rotate180FlipNone;
            else if (rdo270.Checked) flipType = RotateFlipType.Rotate270FlipNone;

            var bmp = new Bitmap(pictureBoxMain.Image);
            bmp.RotateFlip(flipType);
            pictureBoxMain.Image?.Dispose();
            pictureBoxMain.Image = bmp;
        }
    }
}
