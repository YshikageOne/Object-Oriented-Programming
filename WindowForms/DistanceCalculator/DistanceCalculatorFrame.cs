using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistanceCalculator
{
    public partial class DistanceCalculatorFrame : Form
    {
        public DistanceCalculatorFrame()
        {
            InitializeComponent();
        }

        private void DistanceCalculator_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double speed = Convert.ToDouble(txtSpeed.Text);
            double time = Convert.ToDouble(txtTime.Text);

            double distance = speed * time;
            String result = distance + " m";

            txtResult.Text = result;

        }
    }
}
