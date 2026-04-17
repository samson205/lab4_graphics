namespace lab4
{
    public partial class MainForm : Form
    {
        Bitmap mainBmp;
        Bitmap imgBmp;
        List<Peak> peaks2 = new List<Peak>();

        public MainForm()
        {
            InitializeComponent();
            mainBmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            pictureBox.Image = mainBmp;

            peaks2.Add(new Peak(50, 300, 0, 1)); // A
            peaks2.Add(new Peak(50, 50, 0, 0)); // B
            peaks2.Add(new Peak(300, 50, 1, 0)); // C
            peaks2.Add(new Peak(300, 300, 1, 1)); // D

            DrawBorder();
            pictureBox.Invalidate();
        }

        private void btnLoad_Click(object? sender, EventArgs? e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                    imgBmp = new Bitmap(ofd.FileName);
                    FillTriangle();
                    DrawBorder();
                    pictureBox.Invalidate();
            }
        }

        private void btnApplyTexture_Click(object sender, EventArgs e)
        {
            FillTriangle();
            DrawBorder();
            pictureBox.Invalidate();
        }

        private void DrawBorder()
        {
            using (Graphics g = Graphics.FromImage(mainBmp))
            {
                Pen pen = new Pen(Color.Red);
                Peak p0 = peaks2[0];
                Peak p1 = peaks2[1];
                Peak p2 = peaks2[2];
                Peak p3 = peaks2[3];

                g.DrawLine(pen, new Point(p0.X, p0.Y), new Point(p1.X, p1.Y));
                g.DrawLine(pen, new Point(p1.X, p1.Y), new Point(p2.X, p2.Y));
                g.DrawLine(pen, new Point(p2.X, p2.Y), new Point(p3.X, p3.Y));
                g.DrawLine(pen, new Point(p0.X, p0.Y), new Point(p3.X, p3.Y));
            }
        }

        private void FillTriangle()
        {
            int minX = peaks2.Min(p => p.X);
            int maxX = peaks2.Max(p => p.X);

            int minY = peaks2.Min(p => p.Y);
            int maxY = peaks2.Max(p => p.Y);
            for (int y = minY; y <= maxY; y++)
            {
                for (int x = minX; x <= maxX; x++)
                {
                    Point p = new Point(x, y);
                    int isPointIn = IsPointInTriangle(p, out float w1, out float w2, out float w3);
                    if (isPointIn != 0)
                    {
                        float u = w1 * peaks2[0].U + w2 * peaks2[1].U + w3 * peaks2[2].U;
                        float v = w1 * peaks2[0].V + w2 * peaks2[1].V + w3 * peaks2[2].V;
                        if (isPointIn == 2)
                        {
                            u = w1 * peaks2[0].U + w2 * peaks2[3].U + w3 * peaks2[2].U;
                            v = w1 * peaks2[0].V + w2 * peaks2[3].V + w3 * peaks2[2].V;
                        }

                        int textureX = (int)(u * (imgBmp.Width - 1));
                        int textureY = (int)(v * (imgBmp.Height - 1));
                        Color textureColor = imgBmp.GetPixel(textureX, textureY);
                        mainBmp.SetPixel(x, y, textureColor);
                    }
                }
            }
        }

        private int IsPointInTriangle(Point p, out float w1, out float w2, out float w3)
        {
            Point a = new Point(peaks2[0].X, peaks2[0].Y);
            Point b = new Point(peaks2[1].X, peaks2[1].Y);
            Point c = new Point(peaks2[2].X, peaks2[2].Y);
            Point d = new Point(peaks2[3].X, peaks2[3].Y);

            // 2S = (x1 - x3)(y2 - y3) - (x2 - x3)(y1 - y3)
            // ABC
            float abcS = (a.X - c.X) * (b.Y - c.Y) - (b.X - c.X) * (a.Y - c.Y);
            // PBC
            w1 = ((p.X - c.X) * (b.Y - c.Y) - (b.X - c.X) * (p.Y - c.Y)) / abcS;
            // APC
            w2 = ((a.X - c.X) * (p.Y - c.Y) - (p.X - c.X) * (a.Y - c.Y)) / abcS;
            // ABP
            w3 = 1.0f - w1 - w2;

            bool isIn = w1 >= 0 && w2 >= 0 && w3 >= 0;
            if (isIn) return 1;

            // ADC
            float adcS = (a.X - c.X) * (d.Y - c.Y) - (d.X - c.X) * (a.Y - c.Y);
            // PDC
            w1 = ((p.X - c.X) * (d.Y - c.Y) - (d.X - c.X) * (p.Y - c.Y)) / adcS;
            // APC
            w2 = ((a.X - c.X) * (p.Y - c.Y) - (p.X - c.X) * (a.Y - c.Y)) / adcS;
            // ADP
            w3 = 1.0f - w1 - w2;

            isIn = w1 >= 0 && w2 >= 0 && w3 >= 0;
            if (isIn) return 2;

            return 0;
        }
    }

    public struct Peak
    {
        public int X;
        public int Y;
        public float U;
        public float V;

        public Peak(int x, int y, float u, float v)
        {
            X = x;
            Y = y;
            U = u;
            V = v;
        }
    }
}
