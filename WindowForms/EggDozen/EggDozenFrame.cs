using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EggDozen.EggDozen
{
    public partial class EggDozenFrame : Form
    {
        public EggDozenFrame()
        {
            InitializeComponent();
        }

        private void EggDozenFrame_Load(object sender, EventArgs e)
        {

        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtEgg1.Text);
            int num2 = Convert.ToInt32(txtEgg2.Text);
            int num3 = Convert.ToInt32(txtEgg3.Text);
            int num4 = Convert.ToInt32(txtEgg4.Text);
            int num5 = Convert.ToInt32(txtEgg5.Text);

            int sum = num1 + num2 + num3 + num4 + num5;
            int dozens = sum / 12;
            int leftover = sum % 12;

            String result = (sum + " Eggs is " + dozens + " dozens and " + leftover + " left over");

            lblResult.Text = result;

        }
    }
}
