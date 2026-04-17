namespace lab4
{
    internal class Transforms
    {
        private List<PointF> vertices = new List<PointF>();
        public void SetVertices(IEnumerable<Peak> peaks)
        {
            if (peaks == null) return;

            vertices = peaks
                .Select(p => new PointF(p.X, p.Y))
                .ToList();
        }

        public Transforms(List<Peak> peaks)
        {
            foreach (Peak peak in peaks)
            {
                vertices.Add(new PointF(peak.X, peak.Y));
            }
        }

        private PointF GetCenter()
        {
            float cx = vertices.Average(p => p.X);
            float cy = vertices.Average(p => p.Y);
            return new PointF(cx, cy);
        }

        private float[,] MultiplyMatrix(float[,] a, float[,] b)
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

        private List<PointF> ApplyMatrix(float[,] matrix)
        {
            var result = new List<PointF>();
            foreach (var p in vertices)
            {
                float newX = p.X * matrix[0, 0] + p.Y * matrix[1, 0] + 1 * matrix[2, 0];
                float newY = p.X * matrix[0, 1] + p.Y * matrix[1, 1] + 1 * matrix[2, 1];
                result.Add(new PointF(newX, newY));
            }
            return result;
        }

        private float[,] TranslationMatrix(float dx, float dy)
        {
            return new float[,]
            {
            { 1,  0,  0 },
            { 0,  1,  0 },
            { dx, dy, 1 }
            };
        }

        public List<PointF> Move(float dx, float dy)
        {
            float[,] m = TranslationMatrix(dx, -dy);
            return ApplyMatrix(m);
        }

        public List<PointF> Scale(float sx, float sy)
        {
            var center = GetCenter();

            float[,] toOrigin = TranslationMatrix(-center.X, -center.Y);
            float[,] scale = {
                { sx, 0,  0 },
                { 0,  sy, 0 },
                { 0,  0,  1 }
            };
            float[,] toCenter = TranslationMatrix(center.X, center.Y);

            float[,] finalMatrix = MultiplyMatrix(MultiplyMatrix(toOrigin, scale), toCenter);
            return ApplyMatrix(finalMatrix);
        }

        public List<PointF> Rotate(float angleDegrees)
        {
            var center = GetCenter();
            double angleRadians = angleDegrees * Math.PI / 180.0;
            float cosA = (float)Math.Cos(angleRadians);
            float sinA = (float)Math.Sin(angleRadians);

            float[,] toOrigin = TranslationMatrix(-center.X, -center.Y);

            float[,] rotate = {
                {  cosA, -sinA, 0 },
                {  sinA,  cosA, 0 },
                {  0,     0,    1 }
            };
            float[,] toCenter = TranslationMatrix(center.X, center.Y);

            float[,] finalMatrix = MultiplyMatrix(MultiplyMatrix(toOrigin, rotate), toCenter);
            return ApplyMatrix(finalMatrix);
        }

        public List<PointF> ShearX(float shx)
        {
            var center = GetCenter();
            float[,] toOrigin = TranslationMatrix(-center.X, -center.Y);
            float[,] shear = {
                { 1,   0, 0 },
                { shx, 1, 0 },
                { 0,   0, 1 }
            };
            float[,] toCenter = TranslationMatrix(center.X, center.Y);
            return ApplyMatrix(MultiplyMatrix(MultiplyMatrix(toOrigin, shear), toCenter));
        }

        public List<PointF> ShearY(float shy)
        {
            var center = GetCenter();
            float[,] toOrigin = TranslationMatrix(-center.X, -center.Y);
            float[,] shear = {
                { 1, -shy, 0 },
                { 0, 1,    0 },
                { 0, 0,    1 }
            };
            float[,] toCenter = TranslationMatrix(center.X, center.Y);
            return ApplyMatrix(MultiplyMatrix(MultiplyMatrix(toOrigin, shear), toCenter));
        }
    }
}
