using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolStuff2.Week7.DreamyBull
{
    public partial class Ambatu : Form
    {
        public Ambatu()
        {
            InitializeComponent();
        }

        private void btnBlow_Click(object sender, EventArgs e)
        {
            // Create a custom form for the message box
            Form imgMessageBox = new Form();
            imgMessageBox.Size = new Size(300, 200);
            imgMessageBox.FormBorderStyle = FormBorderStyle.FixedDialog;
            imgMessageBox.MaximizeBox = false;
            imgMessageBox.MinimizeBox = false;
            imgMessageBox.StartPosition = FormStartPosition.CenterScreen;
            imgMessageBox.Text = "Hi :D";

            // Add an image to the form
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Image.FromFile("C:\\Users\\gayur\\Downloads\\ambatublow.jpg"); // Replace with the path to your image
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Dock = DockStyle.Fill;
            imgMessageBox.Controls.Add(pictureBox);

            // Add a button to close the form
            Button closeButton = new Button();
            closeButton.Text = "Ambatubloww!!!!!!!!!!!!";
            closeButton.Dock = DockStyle.Bottom;
            closeButton.Click += (s, args) => imgMessageBox.Close();
            imgMessageBox.Controls.Add(closeButton);

            // Show the custom message box
            imgMessageBox.ShowDialog();
        }
    }
}
