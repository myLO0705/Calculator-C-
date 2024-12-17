using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private double firstNumber = 0;
        private double secondNumber = 0;
        private string operation = "";
        private bool isOperationClicked = false;

        public Form1()
        {
            InitializeComponent();
        }

        // Кнопки цифр
        private void button1_Click(object sender, EventArgs e) { textBox.Text += "1"; }
        private void button2_Click(object sender, EventArgs e) { textBox.Text += "2"; }
        private void button3_Click(object sender, EventArgs e) { textBox.Text += "3"; }
        private void button4_Click(object sender, EventArgs e) { textBox.Text += "4"; }
        private void button5_Click(object sender, EventArgs e) { textBox.Text += "5"; }
        private void button6_Click(object sender, EventArgs e) { textBox.Text += "6"; }
        private void button7_Click(object sender, EventArgs e) { textBox.Text += "7"; }
        private void button8_Click(object sender, EventArgs e) { textBox.Text += "8"; }
        private void button9_Click(object sender, EventArgs e) { textBox.Text += "9"; }
        private void button0_Click(object sender, EventArgs e) { textBox.Text += "0"; }

        // Операции
        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(textBox.Text);
            operation = "+";
            textBox.Clear();
        }
        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(textBox.Text);
            operation = "-";
            textBox.Clear();
        }
        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(textBox.Text);
            operation = "*";
            textBox.Clear();
        }
        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(textBox.Text);
            operation = "/";
            textBox.Clear();
        }

        // Кнопка равно
        private void ButtonEqual_Click(object sender, EventArgs e)
        {
            secondNumber = double.Parse(textBox.Text);

            switch (operation)
            {
                case "+":
                    textBox.Text = (firstNumber + secondNumber).ToString();
                    break;
                case "-":
                    textBox.Text = (firstNumber - secondNumber).ToString();
                    break;
                case "*":
                    textBox.Text = (firstNumber * secondNumber).ToString();
                    break;
                case "/":
                    if (secondNumber != 0)
                        textBox.Text = (firstNumber / secondNumber).ToString();
                    else
                        textBox.Text = "Error";
                    break;
            }
            operation = "";
        }

        // Кнопка очистки
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            textBox.Clear();
            firstNumber = 0;
            secondNumber = 0;
            operation = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
