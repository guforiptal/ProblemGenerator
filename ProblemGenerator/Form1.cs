using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProblemGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sq_generate_button_Click(object sender, EventArgs e)
        {
            int A_from = int.Parse(sq_A_from.Text);
            int B_from = int.Parse(sq_B_from.Text);
            int C_from = int.Parse(sq_C_from.Text);
            int A_to = int.Parse(sq_A_to.Text);
            int B_to = int.Parse(sq_B_to.Text);
            int C_to = int.Parse(sq_C_to.Text);

            bool zero = sq_generate_0_root.Checked;
            bool one = sq_generate_1_root.Checked;
            bool two = sq_generate_2_root.Checked;
            bool only_integer = sq_only_integer.Checked;

            int num = int.Parse(sq_num2gen.Text);

            sq_eq[] equs = new sq_eq[num];
            SquareGenerator.Generate(A_from, A_to, B_from, B_to, C_from, C_to, ref equs, num, zero, one, two, only_integer);
            SquareGenerator.Output(equs, ref main_output);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about_form = new About();
            about_form.Show();
        }

        private void mod_generate_button_Click(object sender, EventArgs e)
        {
            ModuleSolver.Solve(module_Eq_string.Text);
            int x = 1;
        }
    }
}
