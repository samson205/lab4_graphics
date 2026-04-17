using System.Drawing.Imaging;
using System.Runtime.InteropServices;

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

            DrawBorder();
            pictureBox.Invalidate();

            btnMoveLeft.Click += btnMoveLeft_Click;
            btnMoveRight.Click += btnSheerX_Click;
        }

        private void btnLoad_Click(object? sender, EventArgs? e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                    textureBmp = new Bitmap(ofd.FileName);
                    FillFigure(isLight);
                    DrawBorder();
                    pictureBox.Invalidate();
            }
        }

        private void btnLight_Click(object? sender, EventArgs? e)
        {
            isLight = !isLight;
            FillFigure(isLight);
            DrawBorder();
            pictureBox.Invalidate();
        }

        private void btnMoveLeft_Click(object? sender, EventArgs? e)
        {
            Transforms.Move(peaks, -10, 0);

            FillFigure(isLight);
            DrawBorder();
            pictureBox.Invalidate();
        }

        private void btnMoveRight_Click(object? sender, EventArgs? e)
        {
            Transforms.Move(peaks, 10, 0);

            FillFigure(isLight);
            DrawBorder();
            pictureBox.Invalidate();
        }

        private void btnRotateRight_Click(object? sender, EventArgs? e)
        {
            Transforms.Rotate(peaks, 10);

            FillFigure(isLight);
            DrawBorder();
            pictureBox.Invalidate();
        }

        private void btnSheerX_Click(object? sender, EventArgs? e)
        {
            Transforms.ShearX(peaks, 2);

            FillFigure(isLight);
            DrawBorder();
            pictureBox.Invalidate();
        }

        private void trackGlobalBrightness_Scroll(object? sender, EventArgs e)
        {
            globalBr = trackGlobalBrightness.Value / 100.0f;
            FillFigure(isLight);
            DrawBorder();
            pictureBox.Invalidate();
        }

        private void trackContrast_Scroll(object? sender, EventArgs e)
        {
            contrast = trackContrast.Value / 100.0f;
            FillFigure(isLight);
            DrawBorder();
            pictureBox.Invalidate();
        }

        private void DrawBorder()
        {
            using (Graphics g = Graphics.FromImage(mainBmp))
            {
                Pen pen = new Pen(Color.Red);
                Peak p0 = peaks[0];
                Peak p1 = peaks[1];
                Peak p2 = peaks[2];
                Peak p3 = peaks[3];

                g.DrawLine(pen, new PointF(p0.X, p0.Y), new PointF(p1.X, p1.Y));
                g.DrawLine(pen, new PointF(p1.X, p1.Y), new PointF(p2.X, p2.Y));
                g.DrawLine(pen, new PointF(p2.X, p2.Y), new PointF(p3.X, p3.Y));
                g.DrawLine(pen, new PointF(p0.X, p0.Y), new PointF(p3.X, p3.Y));
            }
        }

        private void FillFigure(bool localBrightness)
        {
            int mW = mainBmp.Width, mH = mainBmp.Height;
            int tW = textureBmp.Width , tH = textureBmp.Height;

            BitmapData mainData = mainBmp.LockBits(new Rectangle(0, 0, mW, mH),
                ImageLockMode.WriteOnly, PixelFormat.Format32bppPArgb);
            BitmapData textureData = textureBmp.LockBits(new Rectangle(0, 0, tW, tH),
                ImageLockMode.ReadOnly, PixelFormat.Format32bppPArgb);

            int mainCount = mainData.Stride * mH;
            byte[] mainPixels = new byte[mainCount];
            int textureCount = textureData.Stride * tH;
            byte[] texturePixels = new byte[textureCount];

            Array.Clear(mainPixels, 0, mainPixels.Length);
            Marshal.Copy(mainData.Scan0, mainPixels, 0, mainCount);
            Marshal.Copy(textureData.Scan0, texturePixels, 0, textureCount);

            int minX = (int)Math.Floor(peaks.Min(p => p.X));
            int maxX = (int)Math.Ceiling(peaks.Max(p => p.X));
            int minY = (int)Math.Floor(peaks.Min(p => p.Y));
            int maxY = (int)Math.Ceiling(peaks.Max(p => p.Y));
            for (int y = minY; y <= maxY; y++)
            {
                if (y < 0 || y >= mH) continue;
                for (int x = minX; x <= maxX; x++)
                {
                    if (x < 0 || x >= mW) continue;
                    Point p = new Point(x, y);
                    int isPointIn = IsPointInTriangle(p, out float w1, out float w2, out float w3);

                    float u, v, localBr = 1;
                    if (isPointIn == 0) continue;
                    else if (isPointIn == 1)
                    {
                        u = w1 * peaks[0].U + w2 * peaks[1].U + w3 * peaks[2].U;
                        v = w1 * peaks[0].V + w2 * peaks[1].V + w3 * peaks[2].V;
                        if (localBrightness)
                            localBr = w1 * peaks[0].Br + w2 * peaks[1].Br + w3 * peaks[2].Br;
                    }
                    else
                    {
                        u = w1 * peaks[0].U + w2 * peaks[3].U + w3 * peaks[2].U;
                        v = w1 * peaks[0].V + w2 * peaks[3].V + w3 * peaks[2].V;
                        if (localBrightness)
                            localBr = w1 * peaks[0].Br + w2 * peaks[3].Br + w3 * peaks[2].Br;
                    }

                    int textureX = Math.Clamp((int)(u * (tW - 1)), 0, tW - 1);
                    int textureY = Math.Clamp((int)(v * (tH - 1)), 0, tH - 1);
                    int textureInd = textureY * textureData.Stride + textureX * 4;
                    int mainInd = y * mainData.Stride + x * 4;

                    float b = ((float)texturePixels[textureInd] - 128f) * contrast + 128f;
                    float g = ((float)texturePixels[textureInd + 1] - 128f) * contrast + 128f;
                    float r = ((float)texturePixels[textureInd + 2] - 128f) * contrast + 128f;

                    float br = localBr * globalBr;
                    mainPixels[mainInd] = (byte)Math.Clamp(b * br, 0, 255);
                    mainPixels[mainInd + 1] = (byte)Math.Clamp(g * br, 0, 255);
                    mainPixels[mainInd + 2] = (byte)Math.Clamp(r * br, 0, 255);
                    mainPixels[mainInd + 3] = 255;
                }
            }
            Marshal.Copy(mainPixels, 0, mainData.Scan0, mainCount);
            mainBmp.UnlockBits(mainData);
            textureBmp.UnlockBits(textureData);
        }

        private int IsPointInTriangle(Point p, out float w1, out float w2, out float w3)
        {
            PointF a = new PointF(peaks[0].X, peaks[0].Y);
            PointF b = new PointF(peaks[1].X, peaks[1].Y);
            PointF c = new PointF(peaks[2].X, peaks[2].Y);
            PointF d = new PointF(peaks[3].X, peaks[3].Y);

            // 2S = (x1 - x3)(y2 - y3) - (x2 - x3)(y1 - y3)
            // ABC
            float abcS = (a.X - c.X) * (b.Y - c.Y) - (b.X - c.X) * (a.Y - c.Y);
            // PBC
            w1 = ((p.X - c.X) * (b.Y - c.Y) - (b.X - c.X) * (p.Y - c.Y)) / abcS;
            // APC
            w2 = ((a.X - c.X) * (p.Y - c.Y) - (p.X - c.X) * (a.Y - c.Y)) / abcS;
            // ABP
            w3 = 1.0f - w1 - w2;

            bool isIn = w1 >= -0.001f && w2 >= -0.001f && w3 >= -0.001f;
            if (isIn) return 1;

            // ADC
            float adcS = (a.X - c.X) * (d.Y - c.Y) - (d.X - c.X) * (a.Y - c.Y);
            // PDC
            w1 = ((p.X - c.X) * (d.Y - c.Y) - (d.X - c.X) * (p.Y - c.Y)) / adcS;
            // APC
            w2 = ((a.X - c.X) * (p.Y - c.Y) - (p.X - c.X) * (a.Y - c.Y)) / adcS;
            // ADP
            w3 = 1.0f - w1 - w2;

            isIn = w1 >= -0.001f && w2 >= -0.001f && w3 >= -0.001f;
            if (isIn) return 2;

            return 0;
        }
    }

    public class Peak
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float U { get; set; }
        public float V { get; set; }
        public float Br { get; set; }

        public Peak(int x, int y, float u, float v, float br)
        {
            X = x;
            Y = y;
            U = u;
            V = v;
            Br = br;
        }
    }
}
