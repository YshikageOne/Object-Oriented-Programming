using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolStuff2.Week7.test
{
    public partial class SimpleCalculatorFrame : Form
    {
        public SimpleCalculatorFrame()
        {
            InitializeComponent();
        }

        private void SimpleCalculator_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtNumber1.Text);
            int num2 = Convert.ToInt32(txtNumber2.Text);

            int sum = num1 + num2;

            txtResult.Text = sum.ToString();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtNumber1.Text);
            int num2 = Convert.ToInt32(txtNumber2.Text);

            int difference = num1 - num2;

            txtResult.Text = difference.ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtNumber1.Text);
            int num2 = Convert.ToInt32(txtNumber2.Text);

            int product = num1 * num2;

            txtResult.Text = product.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtNumber1.Text);
            int num2 = Convert.ToInt32(txtNumber2.Text);

            int quotient = num1 / num2;

            txtResult.Text = quotient.ToString();
        }
    }
}
