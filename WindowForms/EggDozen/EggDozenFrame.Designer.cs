namespace EggDozen.EggDozen
{
    partial class EggDozenFrame
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
            lbl1 = new Label();
            txtEgg1 = new TextBox();
            btnCompute = new Button();
            lblResult = new Label();
            txtEgg2 = new TextBox();
            txtEgg3 = new TextBox();
            txtEgg4 = new TextBox();
            txtEgg5 = new TextBox();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl1.Location = new Point(12, 43);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(369, 42);
            lbl1.TabIndex = 0;
            lbl1.Text = "Enter the number of eggs produced by each chicken\r\n\r\n";
            // 
            // txtEgg1
            // 
            txtEgg1.Location = new Point(22, 73);
            txtEgg1.Name = "txtEgg1";
            txtEgg1.Size = new Size(65, 23);
            txtEgg1.TabIndex = 4;
            txtEgg1.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCompute
            // 
            btnCompute.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCompute.Location = new Point(75, 112);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(240, 69);
            btnCompute.TabIndex = 7;
            btnCompute.Text = "Click to Compute";
            btnCompute.UseVisualStyleBackColor = true;
            btnCompute.Click += btnCompute_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblResult.Location = new Point(75, 217);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 19);
            lblResult.TabIndex = 8;
            // 
            // txtEgg2
            // 
            txtEgg2.Location = new Point(93, 73);
            txtEgg2.Name = "txtEgg2";
            txtEgg2.Size = new Size(65, 23);
            txtEgg2.TabIndex = 9;
            txtEgg2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtEgg3
            // 
            txtEgg3.Location = new Point(164, 73);
            txtEgg3.Name = "txtEgg3";
            txtEgg3.Size = new Size(65, 23);
            txtEgg3.TabIndex = 10;
            txtEgg3.TextAlign = HorizontalAlignment.Center;
            // 
            // txtEgg4
            // 
            txtEgg4.Location = new Point(235, 73);
            txtEgg4.Name = "txtEgg4";
            txtEgg4.Size = new Size(65, 23);
            txtEgg4.TabIndex = 11;
            txtEgg4.TextAlign = HorizontalAlignment.Center;
            // 
            // txtEgg5
            // 
            txtEgg5.Location = new Point(306, 73);
            txtEgg5.Name = "txtEgg5";
            txtEgg5.Size = new Size(65, 23);
            txtEgg5.TabIndex = 12;
            txtEgg5.TextAlign = HorizontalAlignment.Center;
            // 
            // EggDozenFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 314);
            Controls.Add(txtEgg5);
            Controls.Add(txtEgg4);
            Controls.Add(txtEgg3);
            Controls.Add(txtEgg2);
            Controls.Add(lblResult);
            Controls.Add(btnCompute);
            Controls.Add(txtEgg1);
            Controls.Add(lbl1);
            Name = "EggDozenFrame";
            Text = "Poulty Egg INC.";
            Load += EggDozenFrame_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private TextBox txtEgg1;
        private Button btnCompute;
        private Label lblResult;
        private TextBox txtEgg2;
        private TextBox txtEgg3;
        private TextBox txtEgg4;
        private TextBox txtEgg5;
    }
}