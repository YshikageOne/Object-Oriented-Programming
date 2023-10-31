namespace FamilyFeudProject
{
    partial class StartWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            titleImage = new Label();
            txtTitle = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            txtCredits = new Label();
            btnExit = new Button();
            btnPlay = new Button();
            SuspendLayout();
            // 
            // titleImage
            // 
            titleImage.Image = Properties.Resources.logo2;
            titleImage.Location = new Point(12, 9);
            titleImage.Name = "titleImage";
            titleImage.Size = new Size(342, 164);
            titleImage.TabIndex = 0;
            // 
            // txtTitle
            // 
            txtTitle.AutoSize = true;
            txtTitle.Font = new Font("Tw Cen MT Condensed Extra Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitle.Location = new Point(88, 173);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(189, 44);
            txtTitle.TabIndex = 1;
            txtTitle.Text = "Family Feud\r\n";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // txtCredits
            // 
            txtCredits.Font = new Font("Lucida Bright", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtCredits.Location = new Point(12, 237);
            txtCredits.Name = "txtCredits";
            txtCredits.Size = new Size(342, 97);
            txtCredits.TabIndex = 2;
            txtCredits.Text = "A Project by : \r\n\r\nClyde Allen T. Yu\r\nJhonna Mae M. Elman\r\nHosea James R. Zacarias\r\n";
            txtCredits.TextAlign = ContentAlignment.MiddleCenter;
            txtCredits.Click += txtCredits_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.Location = new Point(229, 328);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(125, 55);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnPlay
            // 
            btnPlay.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPlay.Location = new Point(12, 328);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(125, 55);
            btnPlay.TabIndex = 5;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // StartWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 395);
            Controls.Add(btnPlay);
            Controls.Add(btnExit);
            Controls.Add(txtCredits);
            Controls.Add(txtTitle);
            Controls.Add(titleImage);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "StartWindow";
            Text = "Welcome to Family Feud!!!";
            Load += StartWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleImage;
        private Label txtTitle;
        private System.Windows.Forms.Timer timer1;
        private Label txtCredits;
        private Button btnExit;
        private Button btnPlay;
    }
}