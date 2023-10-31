using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyFeudProject
{
    public partial class StartWindow : Form
    {
        private String titleText;
        private int len = 0;

        public StartWindow()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (len < titleText.Length)
            {
                txtTitle.Text = txtTitle.Text + titleText.ElementAt(len);
                len++;
            }
            else
            {
                len = 0;
                txtTitle.Text = "";
            }
        }

        private void StartWindow_Load(object sender, EventArgs e)
        {
            titleText = txtTitle.Text;
            txtTitle.Text = "";
            timer1.Start();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            FirstQuestion firstQuestion = new FirstQuestion();
            firstQuestion.Show();
        }

        private void txtCredits_Click(object sender, EventArgs e)
        {
            
        }
    }
}
