using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_some_original_name_
{
    public partial class Form1 : Form
    {
        Double result = 0;
        String operation = "";
        bool enterValue = false;
        string numOne;
        string numTwo;
        double memory = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

/*        private void сhangeSign()
        {
            if (txtDisplay.Text != "0")
            {
                double currentValue = Double.Parse(txtDisplay.Text);
                double newValue = -currentValue;
                txtDisplay.Text = newValue.ToString();
            }
        }
*/
        private void buttonEquils_Click(object sender, EventArgs e)
        {
            lblShowOp.Text = "";
            numTwo = txtDisplay.Text;
            switch (operation)
            {
                case "+":
                    txtDisplay.Text = (result + Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (result - Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (result * Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (result / Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "^":
                    txtDisplay.Text = Math.Pow(result, Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "√":
                    txtDisplay.Text = Math.Sqrt(Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "%":
                    txtDisplay.Text = (result % Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "1/x":
                    txtDisplay.Text = (1 / Double.Parse(txtDisplay.Text)).ToString();
                    break;
/*                case "MC":
                    memory = 0;
                    break;
                case "MR":
                    txtDisplay.Text = memory.ToString();
                    break;
                case "MS":
                    memory = Double.Parse(txtDisplay.Text);
                    break;
                case "M+":
                    memory += Double.Parse(txtDisplay.Text);
                    break;
                case "M-":
                    memory -= Double.Parse(txtDisplay.Text);
                    break;*/
                default:
                    break;
            }
            result = Double.Parse(txtDisplay.Text);
            operation = "";

            buttonClearHistory.Visible = true;
            rtbHistory .AppendText (numOne + "  " + numTwo + "  =  " + "\n");
            rtbHistory.AppendText("\t" + txtDisplay.Text + "\n");
            lblHIstoryDisplay.Text = "";
        }

        private void numbersOn(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if((txtDisplay.Text == "0") || (enterValue))
                txtDisplay.Text = "";
            enterValue = false;

            if(b.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                {
                    txtDisplay.Text = txtDisplay.Text + b.Text;
                }
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + b.Text;
            }
        }

        private void operatorsClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (result != 0)
            {
                buttonEquils.PerformClick();
                enterValue = true;
                operation = b.Text;
                lblShowOp.Text = result + " " + operation;
            }
            else
            {
                operation = b.Text;
                result = Double.Parse(txtDisplay.Text);
                txtDisplay.Text = "";
                lblShowOp.Text = result + " " + operation;
            }

            numOne = lblShowOp.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            result = 0;
        }

        private void lblHIstoryDisplay_Click(object sender, EventArgs e)
        {

        }

        private void buttonClearHistory_Click(object sender, EventArgs e)
        {
            rtbHistory.Clear();
            if(lblHIstoryDisplay.Text == "")
            {
                lblHIstoryDisplay.Text = "No history yet";
            }
            buttonClearHistory.Visible = false;
            rtbHistory.ScrollBars = 0;
        }

        private void changeSign(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "0")
            {
                double currentValue = Double.Parse(txtDisplay.Text);
                double newValue = -currentValue;
                txtDisplay.Text = newValue.ToString();
            }
        }

        private void cancelInput(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
            }
        }
        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }
        //прибавление числа на экране к числу, записанному в памяти
        private void operatorsClickMPlus(object sender, EventArgs e)
        {
            memory += Double.Parse(txtDisplay.Text);
        /*      Пример: в памяти записано число 15, производим сложение 39 + 12 = 51,
                нажимаем M+, калькулятор складывает 51 и 15 и записывает в память 66   */
        }
        // вычитание числа на экране из числа, записанного в памяти
        private void operatorsClickMMinus(object sender, EventArgs e)
        {
            memory -= Double.Parse(txtDisplay.Text);
        }
        //записывает в память число, которое на экране
        private void operatorsClickMS(object sender, EventArgs e)
        {
            memory = Double.Parse(txtDisplay.Text);
        }
        //выводит число из памяти на экран
        private void operatorsClickMR(object sender, EventArgs e)
        {
            txtDisplay.Text = memory.ToString();
        }
        //удаляет число из памяти
        private void operatorsClickMC(object sender, EventArgs e)
        {
            memory = 0;
        }

        /*        private void cancelInput(object sender, EventArgs e)
                {
                    if (txtDisplay.Text.Length > 0)
                    {
                        txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                    }
                }*/
    }
}
