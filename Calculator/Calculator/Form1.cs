using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Calculator calc = new Calculator();

        private void additionButton_Click(object sender, EventArgs e)
        {
            double val1 = Convert.ToDouble(value1TextBox.Text);
            double val2 = Convert.ToDouble(value2TextBox.Text);

            calc.Addition(val1, val2);

            solutionLabel.Text = calc.sum.ToString();
            value1TextBox.Text = "";
            value2TextBox.Text = "";
        }

        private void subtractionButton_Click(object sender, EventArgs e)
        {
            double val1 = Convert.ToDouble(value1TextBox.Text);
            double val2 = Convert.ToDouble(value2TextBox.Text);

            calc.Subtraction(val1, val2);

            solutionLabel.Text = calc.difference.ToString();
            value1TextBox.Text = "";
            value2TextBox.Text = "";
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            double val1 = Convert.ToDouble(value1TextBox.Text);
            double val2 = Convert.ToDouble(value2TextBox.Text);

            calc.Multiplication(val1, val2);

            solutionLabel.Text = calc.product.ToString();
            value1TextBox.Text = "";
            value2TextBox.Text = "";
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            double val1 = Convert.ToDouble(value1TextBox.Text);
            double val2 = Convert.ToDouble(value2TextBox.Text);

            calc.Division(val1, val2);

            solutionLabel.Text = calc.quotient.ToString();
            value1TextBox.Text = "";
            value2TextBox.Text = "";
        }
    }
}

