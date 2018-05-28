using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemGenerator
{
    static class ModuleSolver
    {
        /*private static double left_C = 0.0d;
        private static double left_X = 0.0d;
        private static double right_C = 0.0d;
        private static double right_X = 0.0d;*/
        private static List<float> roots;
        private static String last_eq;

        public static void Solve(String eq)
        {
            last_eq = eq;
            roots = new List<float>();
            eq = eq.Replace(" ", "").Replace("∣", "|").Replace("−", "-").ToLower();
            SolveRecursive(eq);
        }
        public static void SolveRecursive(String eq)
        {
            StringBuilder[] parts = new StringBuilder[2];
            String[] buf = eq.Split('=');
            parts[0] = new StringBuilder(buf[0]);
            parts[1] = new StringBuilder(buf[1]);
            List<int>[] modules = new List<int>[2];
            for (int i = 0; i < 2; ++i)
            {
                modules[i] = findAllModules(ref parts[i]);
                if (modules[i].Any())
                {
                    // only if |x|()|| not |x| + |x|
                    //parts[i].remove(modules[i][modules[i].count / 2], 1);
                    //parts[i].remove(modules[i][modules[i].count / 2 - 1], 1);
                    //solve(string.concat(parts[0], "=", parts[1]));
                    // no - before ||
                    parts[i].Remove(modules[i][1], 1);
                    parts[i].Remove(modules[i][0], 1);
                    SolveRecursive(String.Concat(parts[0], "=", parts[1]));
                    invertSigns(ref parts[i], modules[i][0], modules[i][1]);
                    SolveRecursive(String.Concat(parts[0], "=", parts[1]));
                }
            }
            if (!(modules[0].Any() && modules[1].Any())) countEq(ref parts);
        }
        private static List<int> findAllModules(ref StringBuilder str)
        {
            var foundIndexes = new List<int>();
            int count = 0;
            for (int i = 0; (i < str.Length) && (count < 2); ++i)
            {
                if (str[i] == '|')
                {
                    foundIndexes.Add(i);
                    ++count;
                }
            }
            return foundIndexes;
        }
        private static void invertSigns(ref StringBuilder str, int from, int to)
        {
            if (from > 1)
            {
                if (str[from - 1] == '-') { str[from-1] = '+'; return; }
                if (str[from - 1] == '+') { str.Remove(from - 1, 1);--from;--to; }
            }
            if ((str[from] != '-')) { str.Insert(from, '+'); ++to; }
            for (int i = from; i < to - 1; ++i)
            {
                if (str[i] == '+') { str[i] = '-'; continue; };
                if (str[i] == '-') { str[i] = '+'; continue; };
            }
        }   
        private static void countEq(ref StringBuilder[] str)
        {
            float leftX = 0.0f;
            float leftC = 0.0f;
            float rightX = 0.0f;
            float rightC = 0.0f;
            countPartEq(ref str[0], ref leftX, ref leftC);
            countPartEq(ref str[1], ref rightX, ref rightC);
            leftX -= rightX;
            rightC -= leftC;
            if (Math.Abs(leftX) < 0.00000001f) return;
            float root = rightC / leftX;
            if (!roots.Contains(root)) roots.Add(root);
        }
        private static void countPartEq(ref StringBuilder str, ref float X, ref float C)
        {
            if (str[0] != '-') str.Insert(0, '+');
            for (int i = 0; i < str.Length;)
            {
                if (str[i] == '-') // -
                {
                    if (str[i + 1] == 'x') { X -= 1.0f; i += 2; }  // -x
                    else
                    {
                        if ((i + 2 < str.Length) && (str[i + 2] == 'x')) { X -= (float)(str[i + 1] - '0'); i += 3; } // -Nx
                        else { C -= (float)(str[i + 1] - '0'); i += 2; } // -N
                    }
                }
                else
                {
                    if (str[i + 1] == 'x') { X += 1.0f; i += 2; }  // +x
                    else
                    {
                        if ((i + 2 < str.Length) && (str[i + 2] == 'x')) { X += (float)(str[i + 1] - '0'); i += 3; } // +Nx
                        else { C += (float)(str[i + 1] - '0'); i += 2; } // +N
                    }
                }
            }
        }
        private static bool testRoot(float)
        {

        }
        public static void Output(ref System.Windows.Forms.RichTextBox box)
        {
            box.Text = "";
            int num = 0;
            foreach (float root in roots)
            {
                box.Text += "x" + num + "=" + string.Format("{0:N2}", root);
                box.Text += Environment.NewLine;
                ++num;
            }
            box.Text += Environment.NewLine;
        }
    }
}
