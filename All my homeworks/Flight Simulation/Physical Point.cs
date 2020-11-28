using System;
using System.Collections.Generic;
using System.Text;
using VectorStructure;

namespace FlightSimulation
{
    struct PhysicalPoint
    {
        public Vector coords;
        public double weight;
        public Vector speed;
        public PhysicalPoint(double Weight, Vector Speed)
        {
            coords = new Vector(0, 0, 0);
            weight = Weight;
            speed = Speed;
        }
        public double Distance() => Math.Sqrt(coords.x * coords.x + coords.z * coords.z);

    }
}
