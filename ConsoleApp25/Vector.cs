using Microsoft.Win32;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    internal class Vector
    {
        public double x { get; }
        public double y { get; }
        public Vector (double x, double y)
        {
            this.x = x; 
            this.y = y;
        }
        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector(a.x + b.x, a.y + b.y);
        }
        public static Vector operator -(Vector a, Vector b)
        {
            return new Vector(a.x-b.x, a.y-b.y);
        }
        public static Vector operator +(Vector v)
        {
            return v;
        }
        public static Vector operator -(Vector v)
        {
            return new Vector(-v.x, -v.y);
        }
        public string ToString()
        {
            return "" + x + ";" + y;
        }
        public static double operator *(Vector a, Vector b)
        {
            double scalare = Math.Sqrt(Math.Pow(a.x - b.x, 2) + Math.Pow(a.y - b.y, 2));
            return scalare;
        }
        public static Vector operator *(Vector a, double z)
        {
            return new Vector(a.x * z, a.y * z);
        }
        public static Vector operator *(double z, Vector b)
        {
            return new Vector(z * b.x, z * b.y);
        }
        public static Vector operator /(Vector a, double z)
        {
            return new Vector(a.x/z, a.y/z);
        }
    }
}
