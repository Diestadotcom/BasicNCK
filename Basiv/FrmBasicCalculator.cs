using System;
using System.Windows.Forms;
using CalculatorPrivateAssembly;

namespace BasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();

            cmbOperator.Items.Clear();
            cmbOperator.Items.Add("+");
            cmbOperator.Items.Add("-");
            cmbOperator.Items.Add("*");
            cmbOperator.Items.Add("/");

            cmbOperator.SelectedIndex = 0;

            btnCompute.Click += btnCompute_Click;
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            float num1;
            float num2;
            float answer = 0;

            if (!float.TryParse(txtNum1.Text, out num1))
            {
                MessageBox.Show("Please enter the first number.");
                return;
            }

            if (!float.TryParse(txtNum2.Text, out num2))
            {
                MessageBox.Show("Please enter the second number.");
                return;
            }

            if (cmbOperator.SelectedItem == null)
            {
                MessageBox.Show("Please select an operator.");
                return;
            }

            switch (cmbOperator.SelectedItem.ToString())
            {
                case "+":
                    answer = BasicComputation.Addition(num1, num2);
                    break;

                case "-":
                    answer = BasicComputation.Subtraction(num1, num2);
                    break;

                case "*":
                    answer = BasicComputation.Multiplication(num1, num2);
                    break;

                case "/":
                    if (num2 == 0)
                    {
                        MessageBox.Show("Cannot divide by zero.");
                        return;
                    }

                    answer = BasicComputation.Division(num1, num2);
                    break;
            }

            lblTotal.Text = "Total: " + answer.ToString();
        }
    }
}
