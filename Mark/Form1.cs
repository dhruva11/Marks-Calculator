using System;
using System.Windows.Forms;

namespace MarksCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Event handler for btnCalculate.Click
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // Assuming there are five subjects, you can add more textboxes if needed
            int[] subjectMarks = new int[5];

            // Read marks from textboxes and validate input
            if (!int.TryParse(txtSubject1.Text, out subjectMarks[0]) ||
                !int.TryParse(txtSubject2.Text, out subjectMarks[1]) ||
                !int.TryParse(txtSubject3.Text, out subjectMarks[2]) ||
                !int.TryParse(txtSubject4.Text, out subjectMarks[3]) ||
                !int.TryParse(txtSubject5.Text, out subjectMarks[4]))
            {
                MessageBox.Show("Please enter valid marks for all subjects.");
                return;
            }

            // Calculate total score out of 500
            int totalScore = 0;
            foreach (int marks in subjectMarks)
            {
                totalScore += marks;
            }

            // Display total score
            lblTotalScore.Text = $"Total Score: {totalScore} out of 500";

            // Calculate percentage
            double percentage = (double)totalScore / 500 * 100;
            lblPercentage.Text = $"Percentage: {percentage:F2}%";
        }

        // Event handlers for textboxes
        private void txtSubject1_TextChanged(object sender, EventArgs e)
        {
            // You can add any validation or event handling specific to txtSubject1 here
        }

        private void txtSubject2_TextChanged(object sender, EventArgs e)
        {
            // You can add any validation or event handling specific to txtSubject2 here
        }

        private void txtSubject3_TextChanged(object sender, EventArgs e)
        {
            // You can add any validation or event handling specific to txtSubject3 here
        }

        private void txtSubject4_TextChanged(object sender, EventArgs e)
        {
            // You can add any validation or event handling specific to txtSubject4 here
        }

        private void txtSubject5_TextChanged(object sender, EventArgs e)
        {
            // You can add any validation or event handling specific to txtSubject5 here
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
