using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GreatestCommonFactor
{
    public partial class GCDFrame : Form
    {
        public GCDFrame()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtFirstNum.Text, out int num1) && int.TryParse(txtSecondNum.Text, out int num2))
            {
                int gcd = CalculateGCD(num1, num2);
                lblResult.Text = $"The GCD between {num1} and {num2} is {gcd}";

            }
            else
            {
                MessageBox.Show("Please enter valid integers in both fields.");
            }
        }

        private int CalculateGCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}
