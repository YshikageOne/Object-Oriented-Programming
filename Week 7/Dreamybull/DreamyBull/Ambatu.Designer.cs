namespace SchoolStuff2.Week7.DreamyBull
{
    partial class Ambatu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ambatu));
            btnBlow = new Button();
            SuspendLayout();
            // 
            // btnBlow
            // 
            btnBlow.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnBlow.Location = new Point(12, 12);
            btnBlow.Name = "btnBlow";
            btnBlow.Size = new Size(416, 183);
            btnBlow.TabIndex = 0;
            btnBlow.Text = "Click ME!!!";
            btnBlow.UseVisualStyleBackColor = true;
            btnBlow.Click += btnBlow_Click;
            // 
            // Ambatu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 207);
            Controls.Add(btnBlow);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Ambatu";
            Text = "Ambatublow";
            ResumeLayout(false);
        }

        #endregion

        private Button btnBlow;
    }
}