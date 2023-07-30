namespace MarksCalculator
{
    partial class Form1
    {
        // Other private variables, methods, and event handlers...

        // Declare controls
        private Label lblSubject1;
        private Label lblSubject2;
        private Label lblSubject3;
        private Label lblSubject4;
        private Label lblSubject5;
        private TextBox txtSubject1;
        private TextBox txtSubject2;
        private TextBox txtSubject3;
        private TextBox txtSubject4;
        private TextBox txtSubject5;
        private Button btnCalculate;
        private Label lblTotalScore;
        private Label lblPercentage;

        private void InitializeComponent()
        {
            lblSubject1 = new Label();
            txtSubject1 = new TextBox();
            lblSubject2 = new Label();
            txtSubject2 = new TextBox();
            lblSubject3 = new Label();
            txtSubject3 = new TextBox();
            lblSubject4 = new Label();
            txtSubject4 = new TextBox();
            lblSubject5 = new Label();
            txtSubject5 = new TextBox();
            btnCalculate = new Button();
            lblTotalScore = new Label();
            lblPercentage = new Label();
            SuspendLayout();
            // 
            // lblSubject1
            // 
            lblSubject1.AutoSize = true;
            lblSubject1.Location = new Point(40, 38);
            lblSubject1.Name = "lblSubject1";
            lblSubject1.Size = new Size(70, 20);
            lblSubject1.TabIndex = 9;
            lblSubject1.Text = "Subject 1";
            lblSubject1.Click += label1_Click;
            // 
            // txtSubject1
            // 
            txtSubject1.Location = new Point(152, 31);
            txtSubject1.Name = "txtSubject1";
            txtSubject1.Size = new Size(100, 27);
            txtSubject1.TabIndex = 0;
            txtSubject1.TextChanged += txtSubject1_TextChanged;
            // 
            // lblSubject2
            // 
            lblSubject2.AutoSize = true;
            lblSubject2.Location = new Point(40, 95);
            lblSubject2.Name = "lblSubject2";
            lblSubject2.Size = new Size(70, 20);
            lblSubject2.TabIndex = 10;
            lblSubject2.Text = "Subject 2";
            // 
            // txtSubject2
            // 
            txtSubject2.Location = new Point(152, 88);
            txtSubject2.Name = "txtSubject2";
            txtSubject2.Size = new Size(100, 27);
            txtSubject2.TabIndex = 1;
            txtSubject2.TextChanged += txtSubject2_TextChanged;
            // 
            // lblSubject3
            // 
            lblSubject3.AutoSize = true;
            lblSubject3.Location = new Point(40, 157);
            lblSubject3.Name = "lblSubject3";
            lblSubject3.Size = new Size(70, 20);
            lblSubject3.TabIndex = 11;
            lblSubject3.Text = "Subject 3";
            // 
            // txtSubject3
            // 
            txtSubject3.Location = new Point(152, 150);
            txtSubject3.Name = "txtSubject3";
            txtSubject3.Size = new Size(100, 27);
            txtSubject3.TabIndex = 2;
            txtSubject3.TextChanged += txtSubject3_TextChanged;
            // 
            // lblSubject4
            // 
            lblSubject4.AutoSize = true;
            lblSubject4.Location = new Point(40, 210);
            lblSubject4.Name = "lblSubject4";
            lblSubject4.Size = new Size(70, 20);
            lblSubject4.TabIndex = 12;
            lblSubject4.Text = "Subject 4";
            // 
            // txtSubject4
            // 
            txtSubject4.Location = new Point(152, 203);
            txtSubject4.Name = "txtSubject4";
            txtSubject4.Size = new Size(100, 27);
            txtSubject4.TabIndex = 3;
            txtSubject4.TextChanged += txtSubject4_TextChanged;
            // 
            // lblSubject5
            // 
            lblSubject5.AutoSize = true;
            lblSubject5.Location = new Point(40, 275);
            lblSubject5.Name = "lblSubject5";
            lblSubject5.Size = new Size(70, 20);
            lblSubject5.TabIndex = 13;
            lblSubject5.Text = "Subject 5";
            // 
            // txtSubject5
            // 
            txtSubject5.Location = new Point(152, 268);
            txtSubject5.Name = "txtSubject5";
            txtSubject5.Size = new Size(100, 27);
            txtSubject5.TabIndex = 4;
            txtSubject5.TextChanged += txtSubject5_TextChanged;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(83, 320);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(100, 30);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "Calculate";
            btnCalculate.Click += BtnCalculate_Click;
            // 
            // lblTotalScore
            // 
            lblTotalScore.Location = new Point(20, 367);
            lblTotalScore.Name = "lblTotalScore";
            lblTotalScore.Size = new Size(250, 30);
            lblTotalScore.TabIndex = 6;
            lblTotalScore.Text = "Total Score: 0 out of 500";
            // 
            // lblPercentage
            // 
            lblPercentage.Location = new Point(20, 425);
            lblPercentage.Name = "lblPercentage";
            lblPercentage.Size = new Size(250, 34);
            lblPercentage.TabIndex = 7;
            lblPercentage.Text = "Percentage: 0%";
            // 
            // Form1
            // 
            ClientSize = new Size(300, 480);
            Controls.Add(lblPercentage);
            Controls.Add(lblTotalScore);
            Controls.Add(btnCalculate);
            Controls.Add(lblSubject5);
            Controls.Add(lblSubject4);
            Controls.Add(lblSubject3);
            Controls.Add(lblSubject2);
            Controls.Add(lblSubject1);
            Controls.Add(txtSubject1);
            Controls.Add(txtSubject2);
            Controls.Add(txtSubject3);
            Controls.Add(txtSubject4);
            Controls.Add(txtSubject5);
            Name = "Form1";
            Text = "Marks Calculator";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
