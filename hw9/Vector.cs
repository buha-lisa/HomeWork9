namespace hw9
{
    struct Vector
    {
        public int X { get; }
        public int Y { get; }
        public int Z { get; }

        public Vector(int x, int y, int z)
        {
            X = x; Y = y; Z = z;
        }

        public Vector Addition(Vector vec)
        {
            int x = X + vec.X;
            int y = Y + vec.Y;
            int z = Z + vec.Z;
            return new Vector(x, y, z);
        }
        public Vector Subtraction(Vector vec)
        {
            int x = X - vec.X;
            int y = Y - vec.Y;
            int z = Z - vec.Z;
            return new Vector(x, y, z);
        }
        public Vector MultiplicationOnNumber(int num)
        {
            int x = X * num;
            int y = Y * num;
            int z = Z * num;
            return new Vector(x, y, z);
        }

        public override string ToString() => $"{X}, {Y}, {Z}";
    }
}
