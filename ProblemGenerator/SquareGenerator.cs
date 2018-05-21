using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mehroz;

namespace ProblemGenerator
{
    public struct sq_eq
    {
        public int A, B, C;
        public double[] roots;

        public sq_eq(int a, int b, int c, double[]r)
        {
            A = a;
            B = b;
            C = c;
            roots = r;
        }
    }

    public struct ABC
    {
        public int A, B, C;

        public ABC(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }
    }

    static class SquareGenerator
    {
        private static Random gen;

        static SquareGenerator()
        {
            gen = new Random();
        }

        public static void Generate(int A_from, int A_to, int B_from, int B_to, int C_from, int C_to, ref sq_eq[] eq, int num, bool zero, bool one, bool two, bool int_only)
        {
            int count = 0;
            List<int> As = new List<int>();
            List<int> Bs = new List<int>();
            List<int> Cs = new List<int>();
            List<ABC> abc = new List<ABC>();

            for (int i = 0; i < A_to - A_from; ++i) As.Add(i + A_from);
            for (int i = 0; i < B_to - B_from; ++i) Bs.Add(i + B_from);
            for (int i = 0; i < C_to - C_from; ++i) Cs.Add(i + C_from);

            do
            {
                int a;
                int b;
                int c;
                do
                {
                    a = As[gen.Next() % As.Count];
                    b = Bs[gen.Next() % Bs.Count];
                    c = Cs[gen.Next() % Cs.Count];
                }
                while (abc.Contains(new ABC(a, b, c)));

                abc.Add(new ABC(a, b, c));

                double[] roots = SquareSolver.Solve(a, b, c);

                if ((((zero) && (roots.Length == 0)) ||
                    ((one) && (roots.Length == 1)) ||
                    ((two) && (roots.Length == 2))) &&
                    ((int_only == false) || ((int_only == true) && (roots[0] % 1 == 0) && (roots[1] % 1 == 0))))
                {
                    sq_eq eq_solve = new sq_eq(a, b, c, roots);
                    eq[count] = eq_solve;
                    ++count;
                }
            }
            while (count != num);
        }

        public static void Output(sq_eq[] eqs, ref System.Windows.Forms.RichTextBox box)
        {
            box.Text = "";
            foreach (sq_eq eq in eqs)
            {
                if ((eq.A == 0) && (eq.B == 0) && (eq.C == 0)) break;
                box.Text += Environment.NewLine + eq.A + "x^2 + " + eq.B + "x + " + eq.C + " = 0";
                if (eq.roots.Length == 1)
                    box.Text += Environment.NewLine + "  " + "x1 = " + string.Format("{0:N2}", eq.roots[0]);
                else
                {
                    box.Text += Environment.NewLine + "  ";
                    
                    if(eq.roots.Length == 2)
                    {
                        box.Text += "x1 = " + string.Format("{0:N2}", eq.roots[0]);
                        box.Text += " x2 = " + string.Format("{0:N2}", eq.roots[1]);
                    }
               
                }

            }
        }
    }
}
