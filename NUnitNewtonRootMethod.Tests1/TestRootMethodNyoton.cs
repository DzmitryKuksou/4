using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using SearchRoots;

namespace NUnitNewtonRootMethod.Tests1
{
    [TestFixture]
    public class TestRootMethodNyoton
    {
        [TestCase(3, 0.00001, 2, 5, ExpectedResult = 1.73205)]
        [TestCase(3, 0.001, 2, 3, ExpectedResult = 1.732)]
        [TestCase(3, 0.000001, 2, 6, ExpectedResult = 1.732051)]
        [TestCase(3, 0.0000001, 2, 7, ExpectedResult = 1.7320508)]
        public double Test_SearchRootNewton(double number, double eps, int rPower, int round)
        {

            return Math.Round(SearchRoot.SearchRootNewton(number, eps, rPower), round);
        }
        [TestCase(3, 0.00001, -5)]
        [TestCase(3, 1, -5)]
        [TestCase(-3, 0.00001, 5)]
        [TestCase(3, -0.00001, -5)]
        public void Test_SearchRootNewton_ArgumentException(double number, double eps, int rPower)
        {
            Assert.Throws<ArgumentException>(() => SearchRoot.SearchRootNewton(number, eps, rPower));
        }
    }
}
