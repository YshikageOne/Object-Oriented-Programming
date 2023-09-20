namespace SchoolStuff2.Week7.test
{
    partial class SimpleCalculatorFrame
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
            lblNumber1 = new Label();
            lblNumber2 = new Label();
            txtNumber1 = new TextBox();
            txtNumber2 = new TextBox();
            btnAdd = new Button();
            btnSubtract = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            lblResult = new Label();
            txtResult = new TextBox();
            SuspendLayout();
            // 
            // lblNumber1
            // 
            lblNumber1.AutoSize = true;
            lblNumber1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumber1.Location = new Point(77, 64);
            lblNumber1.Name = "lblNumber1";
            lblNumber1.Size = new Size(328, 39);
            lblNumber1.TabIndex = 0;
            lblNumber1.Text = "Enter the first number :";
            // 
            // lblNumber2
            // 
            lblNumber2.AutoSize = true;
            lblNumber2.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumber2.Location = new Point(77, 149);
            lblNumber2.Name = "lblNumber2";
            lblNumber2.Size = new Size(368, 39);
            lblNumber2.TabIndex = 1;
            lblNumber2.Text = "Enter the second number :";
            // 
            // txtNumber1
            // 
            txtNumber1.Location = new Point(411, 74);
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new Size(128, 27);
            txtNumber1.TabIndex = 2;
            // 
            // txtNumber2
            // 
            txtNumber2.Location = new Point(451, 161);
            txtNumber2.Name = "txtNumber2";
            txtNumber2.Size = new Size(128, 27);
            txtNumber2.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(77, 210);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(151, 84);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubtract.Location = new Point(234, 210);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(151, 84);
            btnSubtract.TabIndex = 8;
            btnSubtract.Text = "Subtract";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnMultiply.Location = new Point(391, 210);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(151, 84);
            btnMultiply.TabIndex = 9;
            btnMultiply.Text = "Multiply";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnDivide.Location = new Point(548, 210);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(151, 84);
            btnDivide.TabIndex = 10;
            btnDivide.Text = "Divide";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lblResult.Location = new Point(342, 297);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(103, 39);
            lblResult.TabIndex = 1;
            lblResult.Text = "Result";
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtResult.Location = new Point(304, 353);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(167, 47);
            txtResult.TabIndex = 11;
            txtResult.TextAlign = HorizontalAlignment.Center;
            // 
            // SimpleCalculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResult);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btnSubtract);
            Controls.Add(btnAdd);
            Controls.Add(txtNumber2);
            Controls.Add(txtNumber1);
            Controls.Add(lblResult);
            Controls.Add(lblNumber2);
            Controls.Add(lblNumber1);
            Name = "SimpleCalculator";
            Text = "SimpleCalculator";
            Load += SimpleCalculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumber1;
        private Label lblNumber2;
        private TextBox txtNumber1;
        private TextBox txtNumber2;
        private Button btnAdd;
        private Button btnSubtract;
        private Button btnMultiply;
        private Button btnDivide;
        private Label lblResult;
        private TextBox txtResult;
    }
}