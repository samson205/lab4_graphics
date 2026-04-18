namespace lab4
{
    public partial class MainForm : Form
    {
        Bitmap mainBmp;
        Bitmap textureBmp;
        List<Peak> peaks = new List<Peak>();

        float globalBr = 1.0f, contrast = 1.0f;
        bool isLight = false;

        public MainForm()
        {
            InitializeComponent();
            mainBmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            pictureBox.Image = mainBmp;
            int cx = pictureBox.Width / 2;
            int cy = pictureBox.Height / 2;

            peaks.Add(new Peak(cx - 250, cy + 250, 0, 1, 1.7f)); // A
            peaks.Add(new Peak(cx - 250, cy - 250, 0, 0, 1.9f)); // B
            peaks.Add(new Peak(cx + 250, cy - 250, 1, 0, 1.3f)); // C
            peaks.Add(new Peak(cx + 250, cy + 250, 1, 1, 0.4f)); // D

            btnMoveLeft.Click += btnMoveLeft_Click;
            btnMoveRight.Click += btnSheerX_Click;
        }

        private void btnLoad_Click(object? sender, EventArgs? e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    textureBmp = new Bitmap(ofd.FileName);
                    Renderer.DrawObject(mainBmp, textureBmp, peaks, isLight, globalBr, contrast);
                    pictureBox.Invalidate();
                }
            }
        }

        private void btnLight_Click(object? sender, EventArgs? e)
        {
            isLight = !isLight;
            Renderer.DrawObject(mainBmp, textureBmp, peaks, isLight, globalBr, contrast);
            pictureBox.Invalidate();
        }

        private void btnMoveLeft_Click(object? sender, EventArgs? e)
        {
            Transforms.Move(peaks, -10, 0);
            Renderer.DrawObject(mainBmp, textureBmp, peaks, isLight, globalBr, contrast);
            pictureBox.Invalidate();
        }

        private void btnMoveRight_Click(object? sender, EventArgs? e)
        {
            Transforms.Move(peaks, 10, 0);
            Renderer.DrawObject(mainBmp, textureBmp, peaks, isLight, globalBr, contrast);
            pictureBox.Invalidate();
        }

        private void btnRotateRight_Click(object? sender, EventArgs? e)
        {
            Transforms.Rotate(peaks, 10);
            Renderer.DrawObject(mainBmp, textureBmp, peaks, isLight, globalBr, contrast);
            pictureBox.Invalidate();
        }

        private void btnSheerX_Click(object? sender, EventArgs? e)
        {
            Transforms.ShearX(peaks, 2);
            Renderer.DrawObject(mainBmp, textureBmp, peaks, isLight, globalBr, contrast);
            pictureBox.Invalidate();
        }

        private void trackGlobalBrightness_Scroll(object? sender, EventArgs e)
        {
            globalBr = trackGlobalBrightness.Value / 100.0f;
            Renderer.DrawObject(mainBmp, textureBmp, peaks, isLight, globalBr, contrast);
            pictureBox.Invalidate();
        }

        private void trackContrast_Scroll(object? sender, EventArgs e)
        {
            contrast = trackContrast.Value / 100.0f;
            Renderer.DrawObject(mainBmp, textureBmp, peaks, isLight, globalBr, contrast);
            pictureBox.Invalidate();
        }
    }
}
