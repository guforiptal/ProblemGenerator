using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ProblemGenerator
{
    static class SquareSolver
    {
        public static double[] Solve(int A, int B, int C)
        {
            double D = B * B - 4 * A * C;

            if (A == 0)
            {
                if (B != 0)
                    return new double[]{ -1.0 * C / B };
                else 
                    return new double[3];
            }
            else
            {
                if (D > 0)
                    return new double[] { (-B + Math.Sqrt(D)) / (2 * A), (-B - Math.Sqrt(D)) / (2 * A) };
                else if (D == 0)
                    return new double[] { -1.0 * B / (2 * A) };
                else if (D < 0)
                    return new double[0];
            }

            return new double[0];
        }
    }
}
