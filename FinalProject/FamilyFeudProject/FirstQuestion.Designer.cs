namespace FamilyFeudProject
{
    partial class FirstQuestion
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
            label1 = new Label();
            splitter = new TableLayoutPanel();
            txtAnswer5 = new Label();
            txtAnswer2 = new Label();
            txtAnswer4 = new Label();
            txtAnswer3 = new Label();
            txtAnswer6 = new Label();
            txtAnswer1 = new Label();
            txtPlayerTurn = new Label();
            txtUserAnswer = new TextBox();
            btnSubmit = new Button();
            splitter.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 9);
            label1.Name = "label1";
            label1.Size = new Size(667, 37);
            label1.TabIndex = 0;
            label1.Text = "Give me the most popular languages in programming. ";
            // 
            // splitter
            // 
            splitter.BackColor = SystemColors.ActiveBorder;
            splitter.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            splitter.ColumnCount = 2;
            splitter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            splitter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            splitter.Controls.Add(txtAnswer5, 1, 1);
            splitter.Controls.Add(txtAnswer2, 0, 1);
            splitter.Controls.Add(txtAnswer4, 1, 0);
            splitter.Controls.Add(txtAnswer3, 0, 2);
            splitter.Controls.Add(txtAnswer6, 0, 2);
            splitter.Controls.Add(txtAnswer1, 0, 0);
            splitter.Location = new Point(12, 49);
            splitter.Margin = new Padding(10);
            splitter.Name = "splitter";
            splitter.RowCount = 3;
            splitter.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            splitter.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            splitter.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            splitter.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            splitter.Size = new Size(669, 292);
            splitter.TabIndex = 0;
            // 
            // txtAnswer5
            // 
            txtAnswer5.Anchor = AnchorStyles.Left;
            txtAnswer5.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            txtAnswer5.Location = new Point(338, 98);
            txtAnswer5.Name = "txtAnswer5";
            txtAnswer5.Size = new Size(325, 94);
            txtAnswer5.TabIndex = 8;
            txtAnswer5.Text = "5";
            txtAnswer5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtAnswer2
            // 
            txtAnswer2.Anchor = AnchorStyles.Left;
            txtAnswer2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            txtAnswer2.Location = new Point(5, 98);
            txtAnswer2.Name = "txtAnswer2";
            txtAnswer2.Size = new Size(325, 94);
            txtAnswer2.TabIndex = 7;
            txtAnswer2.Text = "2";
            txtAnswer2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtAnswer4
            // 
            txtAnswer4.Anchor = AnchorStyles.Left;
            txtAnswer4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            txtAnswer4.Location = new Point(338, 2);
            txtAnswer4.Name = "txtAnswer4";
            txtAnswer4.Size = new Size(325, 94);
            txtAnswer4.TabIndex = 6;
            txtAnswer4.Text = "4";
            txtAnswer4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtAnswer3
            // 
            txtAnswer3.Anchor = AnchorStyles.Left;
            txtAnswer3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            txtAnswer3.Location = new Point(5, 195);
            txtAnswer3.Name = "txtAnswer3";
            txtAnswer3.Size = new Size(325, 94);
            txtAnswer3.TabIndex = 6;
            txtAnswer3.Text = "3";
            txtAnswer3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtAnswer6
            // 
            txtAnswer6.Anchor = AnchorStyles.Left;
            txtAnswer6.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            txtAnswer6.Location = new Point(338, 195);
            txtAnswer6.Name = "txtAnswer6";
            txtAnswer6.Size = new Size(325, 94);
            txtAnswer6.TabIndex = 1;
            txtAnswer6.Text = "6";
            txtAnswer6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtAnswer1
            // 
            txtAnswer1.Anchor = AnchorStyles.Left;
            txtAnswer1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            txtAnswer1.Location = new Point(5, 2);
            txtAnswer1.Name = "txtAnswer1";
            txtAnswer1.Size = new Size(325, 94);
            txtAnswer1.TabIndex = 0;
            txtAnswer1.Text = "1";
            txtAnswer1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPlayerTurn
            // 
            txtPlayerTurn.Font = new Font("Tahoma", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPlayerTurn.Location = new Point(17, 375);
            txtPlayerTurn.Name = "txtPlayerTurn";
            txtPlayerTurn.Size = new Size(325, 45);
            txtPlayerTurn.TabIndex = 1;
            txtPlayerTurn.Text = "Player 1's TURN";
            txtPlayerTurn.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUserAnswer
            // 
            txtUserAnswer.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserAnswer.Location = new Point(348, 375);
            txtUserAnswer.Name = "txtUserAnswer";
            txtUserAnswer.Size = new Size(190, 39);
            txtUserAnswer.TabIndex = 2;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubmit.Location = new Point(568, 375);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(107, 39);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // FirstQuestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 450);
            Controls.Add(btnSubmit);
            Controls.Add(txtUserAnswer);
            Controls.Add(txtPlayerTurn);
            Controls.Add(splitter);
            Controls.Add(label1);
            Name = "FirstQuestion";
            Text = "First Question";
            Load += FirstQuestion_Load;
            splitter.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TableLayoutPanel splitter;
        private Label txtAnswer5;
        private Label txtAnswer2;
        private Label txtAnswer4;
        private Label txtAnswer3;
        private Label txtAnswer6;
        private Label txtAnswer1;
        private Label txtPlayerTurn;
        private TextBox txtUserAnswer;
        private Button btnSubmit;
    }
}