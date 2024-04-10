using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double resultValue = 0;
        double value = 0;
        string operation = "";
        bool isOperPerformed = false;

        public Form1()
        {
           InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "0") || (isOperPerformed)) 
                txtDisplay.Clear();
            isOperPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                    txtDisplay.Text += button.Text;
            }
            else
                txtDisplay.Text += button.Text;
        }

        private void btnOperator(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                equal.PerformClick();
                operation = button.Text;
                resultValue = double.Parse(txtDisplay.Text);
                currentOp.Text = resultValue + " " + operation;
                isOperPerformed = true;

            }
            else
            {
                operation = button.Text;
                resultValue = double.Parse(txtDisplay.Text);
                currentOp.Text = resultValue + " " + operation;
                isOperPerformed = true;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            resultValue = 0;
        }

        private void buttonEqual(object sender, EventArgs e)
        {
            value = double.Parse(txtDisplay.Text);
            switch (operation)
            {
                case "+":
                    txtDisplay.Text = (resultValue + value).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (resultValue - value).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (resultValue * value).ToString();
                    break;
                case "/":
                    if (value != 0)
                    {
                        txtDisplay.Text = (resultValue / value).ToString();
                    }
                    else
                    {
                        txtDisplay.Text = "infinity";
                    }
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    
}
