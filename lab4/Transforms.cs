namespace lab4
{
    internal static class Transforms
    {
        private static float[,] MultiplyMatrix(float[,] a, float[,] b)
        {
            float[,] result = new float[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < 3; k++)
                    {
                        result[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            return result;
        }

        private static void ApplyMatrix(List<Peak> peaks, float[,] matrix)
        {
            var result = new List<PointF>();
            foreach (var p in peaks)
            {
                float newX = p.X * matrix[0, 0] + p.Y * matrix[1, 0] + 1 * matrix[2, 0];
                float newY = p.X * matrix[0, 1] + p.Y * matrix[1, 1] + 1 * matrix[2, 1];
                p.X = newX;
                p.Y = newY;
            }
        }

        private static float[,] TranslationMatrix(float dx, float dy)
        {
            return new float[,]
            {
            { 1,  0,  0 },
            { 0,  1,  0 },
            { dx, dy, 1 }
            };
        }

        public static void Move(List<Peak> peaks, float dx, float dy)
        {
            float[,] m = TranslationMatrix(dx, -dy);
            ApplyMatrix(peaks, m);
        }

        public static void Scale(List<Peak> peaks, float sx, float sy)
        {
            float cx = peaks.Average(p => p.X);
            float cy = peaks.Average(p => p.Y);

            float[,] toOrigin = TranslationMatrix(-cx, -cy);
            float[,] scale = {
                { sx, 0,  0 },
                { 0,  sy, 0 },
                { 0,  0,  1 }
            };
            float[,] toCenter = TranslationMatrix(cx, cy);

            float[,] finalMatrix = MultiplyMatrix(MultiplyMatrix(toOrigin, scale), toCenter);
            ApplyMatrix(peaks, finalMatrix);
        }

        public static void Rotate(List<Peak> peaks, float angleDegrees)
        {
            float cx = peaks.Average(p => p.X);
            float cy = peaks.Average(p => p.Y);

            double angleRadians = angleDegrees * Math.PI / 180.0;
            float cosA = (float)Math.Cos(angleRadians);
            float sinA = (float)Math.Sin(angleRadians);

            float[,] toOrigin = TranslationMatrix(-cx, -cy);

            float[,] rotate = {
                {  cosA, -sinA, 0 },
                {  sinA,  cosA, 0 },
                {  0,     0,    1 }
            };
            float[,] toCenter = TranslationMatrix(cx, cy);

            float[,] finalMatrix = MultiplyMatrix(MultiplyMatrix(toOrigin, rotate), toCenter);
            ApplyMatrix(peaks, finalMatrix);
        }

        public static void ShearX(List<Peak> peaks, float shx)
        {
            float cx = peaks.Average(p => p.X);
            float cy = peaks.Average(p => p.Y);

            float[,] toOrigin = TranslationMatrix(-cx, -cy);
            float[,] shear = {
                { 1,   0, 0 },
                { shx, 1, 0 },
                { 0,   0, 1 }
            };
            float[,] toCenter = TranslationMatrix(cx, cy);
            ApplyMatrix(peaks, MultiplyMatrix(MultiplyMatrix(toOrigin, shear), toCenter));
        }

        public static void ShearY(List<Peak> peaks, float shy)
        {
            float cx = peaks.Average(p => p.X);
            float cy = peaks.Average(p => p.Y);

            float[,] toOrigin = TranslationMatrix(-cx, -cy);
            float[,] shear = {
                { 1, -shy, 0 },
                { 0, 1,    0 },
                { 0, 0,    1 }
            };
            float[,] toCenter = TranslationMatrix(cx, cy);
            ApplyMatrix(peaks, MultiplyMatrix(MultiplyMatrix(toOrigin, shear), toCenter));
        }
    }
}
