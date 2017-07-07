using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchRoots
{
    public static class SearchRoot
    {
        /// <summary>
        /// Checking of parameters
        /// </summary>
        /// <param name="number">number</param>
        /// <param name="eps">epsilon</param>
        /// <param name="rPower">Power of root</param>
        private static void Checking(double number, double eps, int rPower)
        {
            if (number <= 0 || eps <= 0 || rPower <= 0) throw new ArgumentException("Numbers should be positive!");
            if (eps > 1) throw new ArgumentException("Epsilon > 1");
        }
        /// <summary>
        /// find root of number
        /// </summary>
        /// <param name="number">number</param>
        /// <param name="eps">epsilon</param>
        /// <param name="rPower">Power of root</param>
        /// <returns>result</returns>
        public static double SearchRootNewton(double number, double eps,  int rPower)
        {
            Checking(number, eps, rPower);
            Math.Pow(3, 2);
            double x1 = number / rPower;
            double x2 = 1.0 / rPower * ((rPower - 1) * x1 + number / Math.Pow(x1, rPower - 1));
            while (Math.Abs(x1 - x2) > eps) 
            {
                x1 = x2;
                x2 = 1.0 / rPower * ((rPower - 1) * x1 + number / Math.Pow(x1, rPower - 1));
            }
            return x2;
        }
    }
}
