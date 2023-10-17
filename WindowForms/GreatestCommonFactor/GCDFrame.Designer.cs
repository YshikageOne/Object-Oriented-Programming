namespace GreatestCommonFactor
{
    partial class GCDFrame
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
            lblFirstNum = new Label();
            txtFirstNum = new TextBox();
            label1 = new Label();
            txtSecondNum = new TextBox();
            lblResult = new Label();
            btnCalculate = new Button();
            SuspendLayout();
            // 
            // lblFirstNum
            // 
            lblFirstNum.AutoSize = true;
            lblFirstNum.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblFirstNum.Location = new Point(12, 37);
            lblFirstNum.Name = "lblFirstNum";
            lblFirstNum.Size = new Size(199, 37);
            lblFirstNum.TabIndex = 0;
            lblFirstNum.Text = "First Number :";
            // 
            // txtFirstNum
            // 
            txtFirstNum.Font = new Font("Unispace", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            txtFirstNum.Location = new Point(254, 37);
            txtFirstNum.Name = "txtFirstNum";
            txtFirstNum.Size = new Size(127, 40);
            txtFirstNum.TabIndex = 1;
            txtFirstNum.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 114);
            label1.Name = "label1";
            label1.Size = new Size(236, 37);
            label1.TabIndex = 2;
            label1.Text = "Second Number :";
            // 
            // txtSecondNum
            // 
            txtSecondNum.Font = new Font("Unispace", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            txtSecondNum.Location = new Point(254, 111);
            txtSecondNum.Name = "txtSecondNum";
            txtSecondNum.Size = new Size(127, 40);
            txtSecondNum.TabIndex = 3;
            txtSecondNum.TextAlign = HorizontalAlignment.Center;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Palatino Linotype", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblResult.Location = new Point(12, 187);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(14, 32);
            lblResult.TabIndex = 4;
            lblResult.Text = "\r\n";
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalculate.Location = new Point(396, 64);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 61);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "Get GCD";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // GCDFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 227);
            Controls.Add(btnCalculate);
            Controls.Add(lblResult);
            Controls.Add(txtSecondNum);
            Controls.Add(label1);
            Controls.Add(txtFirstNum);
            Controls.Add(lblFirstNum);
            Name = "GCDFrame";
            Text = "Greatest Common Denominator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstNum;
        private TextBox txtFirstNum;
        private Label label1;
        private TextBox txtSecondNum;
        private Label lblResult;
        private Button btnCalculate;
    }
}