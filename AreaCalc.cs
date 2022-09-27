using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalcLib
{
    public class AreaCalc
    {
        public double CircleArea(double radius) => Math.PI * Math.Pow(radius, 2);

        public double TriangleArea(int a, int b, int c)
        {
            var p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}

