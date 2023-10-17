namespace DistanceCalculator
{
    partial class DistanceCalculatorFrame
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
            lblTime = new Label();
            txtTime = new TextBox();
            label1 = new Label();
            txtSpeed = new TextBox();
            lblResult = new Label();
            txtResult = new TextBox();
            btnCalculate = new Button();
            SuspendLayout();
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTime.Location = new Point(25, 45);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(236, 21);
            lblTime.TabIndex = 0;
            lblTime.Text = "Enter your time (in seconds) : ";
            // 
            // txtTime
            // 
            txtTime.Location = new Point(267, 47);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(100, 23);
            txtTime.TabIndex = 1;
            txtTime.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(25, 83);
            label1.Name = "label1";
            label1.Size = new Size(214, 21);
            label1.TabIndex = 2;
            label1.Text = "Enter your speed (in m/s) : ";
            // 
            // txtSpeed
            // 
            txtSpeed.Location = new Point(267, 85);
            txtSpeed.Name = "txtSpeed";
            txtSpeed.Size = new Size(100, 23);
            txtSpeed.TabIndex = 3;
            txtSpeed.TextAlign = HorizontalAlignment.Center;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblResult.Location = new Point(166, 178);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(57, 21);
            lblResult.TabIndex = 4;
            lblResult.Text = "Result";
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtResult.Location = new Point(128, 202);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(133, 39);
            txtResult.TabIndex = 5;
            txtResult.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalculate.Location = new Point(128, 117);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(133, 43);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // DistanceCalculatorFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 272);
            Controls.Add(btnCalculate);
            Controls.Add(txtResult);
            Controls.Add(lblResult);
            Controls.Add(txtSpeed);
            Controls.Add(label1);
            Controls.Add(txtTime);
            Controls.Add(lblTime);
            Name = "DistanceCalculatorFrame";
            Text = "Distance Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTime;
        private TextBox txtTime;
        private Label label1;
        private TextBox txtSpeed;
        private Label lblResult;
        private TextBox txtResult;
        private Button btnCalculate;
    }
}