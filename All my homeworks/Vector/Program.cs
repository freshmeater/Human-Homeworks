using System;

namespace Vector
{
    struct Vector
    {
        double x;
        double y;
        double z;
        double length;
        public Vector(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            length = Length(x, y, z);
        }

        public override string ToString() => "(" + x + "," + y + "," + z + ")";

        static double Length(double x, double y, double z) => Math.Sqrt(x * x + y * y + z * z);
        
        void Normalize()
        {
            x /= length;
            y /= length ;
            z /= length;
        }

        Vector GetNormalized() => new Vector(x / length, y / length, z / length);

        public static Vector operator +(Vector a, Vector b) => new Vector(a.x + b.x, a.y + b.y, a.z + b.z);
        
        public static Vector operator -(Vector a, Vector b) => new Vector(a.x - b.x, a.y - b.y, a.z - b.z);

        public static Vector operator *(Vector a, int b) => new Vector(a.x * b, a.y * b, a.z * b);

        public static Vector operator *(Vector a, double b) => new Vector(a.x * b, a.y * b, a.z * b);

        public static Vector operator *(Vector a, Vector b) => new Vector(a.x * b.x, a.y * b.y, a.z * b.z);

        public static Vector operator /(Vector a, int b) => new Vector(a.x / b, a.y / b, a.z / b);

        public static Vector operator /(Vector a, double b) => new Vector(a.x / b, a.y / b, a.z / b);
    }
}
