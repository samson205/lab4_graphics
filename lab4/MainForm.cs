namespace lab4
{
    public partial class MainForm : Form
    {
        Bitmap mainBmp;
        Bitmap textureBmp;
        List<Peak> peaks = new List<Peak>();

        float globalBr = 1.0f, contrast = 1.0f;
        Point lastPos;
        bool isLight = false;
        bool isDraggin = false;

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

            btnMoveRight.Click += btnSheerX_Click;
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && Renderer.IsMouseOver(e.Location, peaks))
            {
                isDraggin = true;
                lastPos = e.Location;
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isDraggin)
            {
                pictureBox.Cursor = Renderer.IsMouseOver(e.Location, peaks) ? Cursors.Hand : Cursors.Default;
                return;
            }

            if (isDraggin)
            {
                float dx = e.X - lastPos.X;
                float dy = e.Y - lastPos.Y;
                Transforms.Move(peaks, dx, -dy);
                lastPos = e.Location;
                pictureBox.Invalidate();
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isDraggin = false;
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(pictureBox.BackColor);
            Renderer.DrawObject(mainBmp, textureBmp, peaks, isLight, globalBr, contrast);
            e.Graphics.DrawImage(mainBmp, 0, 0);
        }

        private void btnLoad_Click(object? sender, EventArgs? e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    textureBmp = new Bitmap(ofd.FileName);
                    pictureBox.Invalidate();
                }
            }
        }

        private void btnLight_Click(object? sender, EventArgs? e)
        {
            isLight = !isLight;
            pictureBox.Invalidate();
        }

        private void btnRotateLeft_Click(object? sender, EventArgs? e)
        {
            Transforms.Rotate(peaks, 10);
            pictureBox.Invalidate();
        }

        private void btnSheerX_Click(object? sender, EventArgs? e)
        {
            Transforms.ShearX(peaks, 2);
            pictureBox.Invalidate();
        }

        private void trackGlobalBrightness_Scroll(object? sender, EventArgs e)
        {
            globalBr = trackGlobalBrightness.Value / 100.0f;
            pictureBox.Invalidate();
        }

        private void trackContrast_Scroll(object? sender, EventArgs e)
        {
            contrast = trackContrast.Value / 100.0f;
            pictureBox.Invalidate();
        }
    }
}
