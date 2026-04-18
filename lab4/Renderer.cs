using System.Drawing.Imaging;
using System.Runtime.InteropServices;
namespace lab4
{
    internal static class Renderer
    {
        private static byte[] mainPixels = Array.Empty<byte>();
        private static byte[] texturePixels = Array.Empty<byte>();

        public static void DrawObject(Bitmap mainBmp, Bitmap textureBmp,
            List<Peak> peaks, bool isLocalBr, float globalBr, float contrast)
        {
            FillFigure(mainBmp, textureBmp, peaks, isLocalBr, globalBr, contrast);
            DrawBorder(mainBmp, peaks);
        }

        private static void DrawBorder(Bitmap mainBmp, List<Peak> peaks)
        {
            using (Graphics g = Graphics.FromImage(mainBmp))
            {
                using (Pen pen = new Pen(Color.Red))
                {
                    PointF[] points = new PointF[] 
                    {
                        new PointF(peaks[0].X, peaks[0].Y),
                        new PointF(peaks[1].X, peaks[1].Y),
                        new PointF(peaks[2].X, peaks[2].Y),
                        new PointF(peaks[3].X, peaks[3].Y)
                    };
                    g.DrawPolygon(pen, points);
                }
            }
        }

        private static void FillFigure(Bitmap mainBmp, Bitmap textureBmp,
            List<Peak> peaks, bool isLocalBr, float globalBr, float contrast)
        {
            int mW = mainBmp.Width, mH = mainBmp.Height;
            int tW = textureBmp.Width, tH = textureBmp.Height;

            int mainCount = mW * mH * 4;
            int textureCount = tW * tH * 4;

            if (mainPixels.Length < mainCount) mainPixels = new byte[mainCount];
            if (texturePixels.Length < textureCount) texturePixels = new byte[textureCount];

            BitmapData mainData = mainBmp.LockBits(new Rectangle(0, 0, mW, mH),
                ImageLockMode.WriteOnly, PixelFormat.Format32bppPArgb);
            BitmapData textureData = textureBmp.LockBits(new Rectangle(0, 0, tW, tH),
                ImageLockMode.ReadOnly, PixelFormat.Format32bppPArgb);

            Marshal.Copy(textureData.Scan0, texturePixels, 0, textureCount);
            Array.Clear(mainPixels, 0, mainCount);

            PointF pA = new PointF(peaks[0].X, peaks[0].Y);
            PointF pB = new PointF(peaks[1].X, peaks[1].Y);
            PointF pC = new PointF(peaks[2].X, peaks[2].Y);
            PointF pD = new PointF(peaks[3].X, peaks[3].Y);

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
                    PointF p = new PointF(x, y);
                    int isPointIn = IsPointInTriangle(p, pA, pB, pC, pD,
                        out float w1, out float w2, out float w3);

                    float u, v, localBr = 1;
                    if (isPointIn == 0) continue;
                    else if (isPointIn == 1)
                    {
                        u = w1 * peaks[0].U + w2 * peaks[1].U + w3 * peaks[2].U;
                        v = w1 * peaks[0].V + w2 * peaks[1].V + w3 * peaks[2].V;
                        if (isLocalBr)
                            localBr = w1 * peaks[0].Br + w2 * peaks[1].Br + w3 * peaks[2].Br;
                    }
                    else
                    {
                        u = w1 * peaks[0].U + w2 * peaks[3].U + w3 * peaks[2].U;
                        v = w1 * peaks[0].V + w2 * peaks[3].V + w3 * peaks[2].V;
                        if (isLocalBr)
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

        private static int IsPointInTriangle(PointF p, PointF pA, PointF pB, PointF pC, PointF pD,
            out float w1, out float w2, out float w3)
        {
            BarycentricCoordinates(p, pA, pB, pC, out w1, out w2, out w3);
            bool isIn = w1 >= -0.001f && w2 >= -0.001f && w3 >= -0.001f;
            if (isIn) return 1;
            
            BarycentricCoordinates(p, pA, pD, pC, out w1, out w2, out w3);
            isIn = w1 >= -0.001f && w2 >= -0.001f && w3 >= -0.001f;
            if (isIn) return 2;

            return 0;
        }

        private static void BarycentricCoordinates(PointF p,
            PointF x1, PointF x2, PointF x3,
            out float w1, out float w2, out float w3) 
        {
            // 2S = (x1 - x3)(y2 - y3) - (x2 - x3)(y1 - y3)
            float triangleS = (x1.X - x3.X) * (x2.Y - x3.Y) - (x2.X - x3.X) * (x1.Y - x3.Y);
            if (Math.Abs(triangleS) < 0.0001f)
            {
                w1 = w2 = w3 = 0;
                return;
            }
            w1 = ((p.X - x3.X) * (x2.Y - x3.Y) - (x2.X - x3.X) * (p.Y - x3.Y)) / triangleS;
            w2 = ((x1.X - x3.X) * (p.Y - x3.Y) - (p.X - x3.X) * (x1.Y - x3.Y)) / triangleS;
            w3 = 1.0f - w1 - w2;
        }
    }
}
