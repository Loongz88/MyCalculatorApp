using System;
using System.Windows.Forms;

namespace MyCalculatorApp
{
    public partial class Form1 : Form
    {
        Double resultsValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        private readonly List<string> history = [];

        public Form1()
        {
            InitializeComponent();
            listBoxHistory.Visible = false;
        }


        private void Button_click(object sender, EventArgs e)
        {
            if ((textBox_Results.Text == "0") || (isOperationPerformed))
            {
                textBox_Results.Clear();
            }
            isOperationPerformed = false;

            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox_Results.Text.Contains("."))
                    textBox_Results.Text = textBox_Results.Text + button.Text;
            }
            else
                textBox_Results.Text = textBox_Results.Text + button.Text;
        }


        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultsValue != 0)
            {
                button16.PerformClick();
                operationPerformed = button.Text;
                CurrentOperation.Text = resultsValue + " " + operationPerformed;
                isOperationPerformed = true;

            }
            else

            operationPerformed = button.Text;
            resultsValue = Double.Parse(textBox_Results.Text);
            CurrentOperation.Text = resultsValue + " " + operationPerformed;
            isOperationPerformed = true;
            //textBox_Results.Clear();
        }


        private void btnEquals_Click(object sender, EventArgs e)
        {
            string secondNumber = textBox_Results.Text;
            string firstNumber = textBox_Results.Text;
            string historyEntry = resultsValue.ToString() + " " + operationPerformed    + " " + secondNumber
             + " = " + textBox_Results.Text;

            listBoxHistory.Items.Add(historyEntry);

            if (operationPerformed == "")
            {
                CurrentOperation.Text = secondNumber + " =";
            }
            else
            {
                CurrentOperation.Text = resultsValue.ToString()
                                        + " " + operationPerformed + " "
                                        + secondNumber + " =";
            }

            switch (operationPerformed)
            {
                case "+":
                    textBox_Results.Text =
                        (resultsValue + Double.Parse(textBox_Results.Text)).ToString();
                    break;

                case "-":
                    textBox_Results.Text =
                        (resultsValue - Double.Parse(textBox_Results.Text)).ToString();
                    break;

                case "*":
                    textBox_Results.Text =
                        (resultsValue * Double.Parse(textBox_Results.Text)).ToString();
                    break;

                case "/":
                    if (Double.Parse(textBox_Results.Text) == 0)
                    {
                        MessageBox.Show("Cannot divide by zero", "Calculator",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        textBox_Results.Text = "0";
                    }
                    else
                    {
                        textBox_Results.Text =
                            (resultsValue / Double.Parse(textBox_Results.Text)).ToString();
                    }
                    break;

                default:
                    break;
            }

            resultsValue = Double.Parse(textBox_Results.Text);
            operationPerformed = "";
            isOperationPerformed = true;


         
            listBoxHistory.Items.Add(historyEntry);
    
        
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox_Results.Text = "0";
            operationPerformed = "";
            resultsValue = 0;
            isOperationPerformed = true;


        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            if (textBox_Results.Text.Length > 1)
            {
                textBox_Results.Text =
                    textBox_Results.Text.Substring(0, textBox_Results.Text.Length - 1);
            }
            else
            {
                // Reset when last digit is removed
                textBox_Results.Text = "0";

                if (CurrentOperation.Text.Contains("="))
                {
                    resultsValue = 0;
                    operationPerformed = "";
                    CurrentOperation.Text = "";
                    history.Clear();
                    listBoxHistory.Items.Clear();
                }
            }
        }

        private void ButtonHistory_Click(object sender, EventArgs e)
        {
            listBoxHistory.Visible = !listBoxHistory.Visible;
        }
    }

}

