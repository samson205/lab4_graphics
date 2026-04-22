namespace lab4
{
    internal static class DrawLine
    {
        public static void BresenhamLine(byte[] pixels, int stride,
                        int x0, int y0, int x1, int y1, Color color, int width, int height)
        {
            int dx = Math.Abs(x1 - x0), sx = x0 < x1 ? 1 : -1;
            int dy = Math.Abs(y1 - y0), sy = y0 < y1 ? 1 : -1;
            int err = dx - dy;

            while (true)
            {
                PutPixel(pixels, stride, x0, y0, color, width, height);

                if (x0 == x1 && y0 == y1) break;

                int e2 = 2 * err;

                if (e2 > -dy) { err -= dy; x0 += sx; }
                if (e2 < dx) { err += dx; y0 += sy; }
            }
        }

        static void PutPixel(byte[] pixels, int stride, int x, int y, Color color, int width, int height)
        {
            if (x < 0 || x >= width || y < 0 || y >= height)
                return;

            int index = y * stride + x * 4;

            pixels[index] = color.B;
            pixels[index + 1] = color.G;
            pixels[index + 2] = color.R;
            pixels[index + 3] = 255;
        }

    }
}
