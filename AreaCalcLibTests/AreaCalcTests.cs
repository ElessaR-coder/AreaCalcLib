using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaCalcLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalcLib.Tests
{
    [TestClass()]
    public class AreaCalcTests
    {
        [TestMethod()]
        public void CircleArea_r0to100()
        {
            AreaCalc areaCalc = new AreaCalc();
            for (int i = 0; i <= 100; i++)
            {
                var expected = Math.PI * Math.Pow(i,2);
                var actual = areaCalc.CircleArea(i);
                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod()]
        public void TriangleArea_random()
        {
            AreaCalc areaCalc = new AreaCalc();
            Random rnd = new Random(50);


            for (int i = 0; i <= 100; i++)
            {
                var a = rnd.Next();
                var b = rnd.Next();
                var c = rnd.Next();
                var p = (a + b + c) / 2;
                var actual = areaCalc.TriangleArea(a, b, c);

                var expected = Math.Sqrt(p * (p - a) * (p - b) * (p - c)); 
                Assert.AreEqual(expected, actual);
            }
        }
    }
}