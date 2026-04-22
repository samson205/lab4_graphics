namespace lab4
{
    public class Peak
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float U { get; set; }
        public float V { get; set; }
        public float Br { get; set; }

        public Peak(float x, float y, float u, float v, float br)
        {
            X = x;
            Y = y;
            U = u;
            V = v;
            Br = br;
        }
    }
}
