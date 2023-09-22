using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            //this.PreviewKeyDown += new PreviewKeyDownEventHandler(Form1_PreviewKeyDown);
            
            this.KeyPreview = true;
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string buttonText = clickedButton.Text;
            string currentText = Calculate.Text;
            if (currentText.Length == 1 && currentText[0] == '0')
            {
                Calculate.Text = buttonText;
            }
            else
            {
                Calculate.Text = currentText + buttonText;
            }
            label1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string buttonText = clickedButton.Text;
            string currentText = Calculate.Text;
            if(currentText.Length==1 && currentText[0]=='0')
            {
                Calculate.Text = buttonText;
            }
            else
            {
                Calculate.Text = currentText + buttonText;
            }
            label1.Focus();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string buttonText = clickedButton.Text;
            string currentText = Calculate.Text;
            if (currentText.Length == 1 && currentText[0] == '0')
            {
                Calculate.Text = buttonText;
            }
            else
            {
                Calculate.Text = currentText + buttonText;
            }
            label1.Focus();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int index = 0;
            Button clickedButton = (Button)sender;
            string buttonText = clickedButton.Text;
            string currentText = Calculate.Text;
            for (; index < currentText.Length - 1;)
            {
                index++;
            }

            if ('0' <= currentText[index] && currentText[index] <= '9')
            {
                Calculate.Text = currentText + buttonText;
            }
            label1.Focus();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string buttonText = clickedButton.Text;
            string currentText = Calculate.Text;
            if (currentText.Length == 1 && currentText[0] == '0')
            {
                Calculate.Text = buttonText;
            }
            else
            {
                Calculate.Text = currentText + buttonText;
            }
            label1.Focus();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string buttonText = clickedButton.Text;
            string currentText = Calculate.Text;
            if (currentText.Length == 1 && currentText[0] == '0')
            {
                Calculate.Text = buttonText;
            }
            else
            {
                Calculate.Text = currentText + buttonText;
            }
            label1.Focus();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string buttonText = clickedButton.Text;
            string currentText = Calculate.Text;
            if (currentText.Length == 1 && currentText[0] == '0')
            {
                Calculate.Text = buttonText;
            }
            else
            {
                Calculate.Text = currentText + buttonText;
            }
            label1.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string buttonText = clickedButton.Text;
            string currentText = Calculate.Text;
            if (currentText.Length == 1 && currentText[0] == '0')
            {
                Calculate.Text = buttonText;
            }
            else
            {
                Calculate.Text = currentText + buttonText;
            }
            label1.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string buttonText = clickedButton.Text;
            string currentText = Calculate.Text;
            if (currentText.Length == 1 && currentText[0] == '0')
            {
                Calculate.Text = buttonText;
            }
            else
            {
                Calculate.Text = currentText + buttonText;
            }
            label1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string buttonText = clickedButton.Text;
            string currentText = Calculate.Text;
            if (currentText.Length == 1 && currentText[0] == '0')
            {
                Calculate.Text = buttonText;
            }
            else
            {
                Calculate.Text = currentText + buttonText;
            }
            label1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string buttonText = clickedButton.Text;
            string currentText = Calculate.Text;
            if (currentText.Length == 1 && currentText[0] == '0')
            {
                Calculate.Text = buttonText;
            }
            else
            {
                Calculate.Text = currentText + buttonText;
            }
            label1.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string currentText = Calculate.Text;
            if (currentText.Length > 0)
            {
                currentText = currentText.Substring(0, currentText.Length - 1);
            }

            Calculate.Text = currentText;
            label1.Focus();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int index = 0;
            Button clickedButton = (Button)sender;
            string buttonText = clickedButton.Text;
            string currentText = Calculate.Text;
            for (; index < currentText.Length - 1;)
            {
                index++;
            }

            if ('0' <= currentText[index] && currentText[index] <= '9')
            {
                Calculate.Text = currentText + buttonText;
            }
            label1.Focus();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int index = 0;
            Button clickedButton = (Button)sender;
            string buttonText = clickedButton.Text;
            string currentText = Calculate.Text;
            for (; index < currentText.Length - 1;)
            {
                index++;
            }

            if ('0' <= currentText[index] && currentText[index] <= '9')
            {
                Calculate.Text = currentText + buttonText;
            }
            label1.Focus();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int index = 0;
            Button clickedButton = (Button)sender;
            string buttonText = clickedButton.Text;
            string currentText = Calculate.Text;
            for (; index < currentText.Length - 1;)
            {
                index++;
            }

            if ('0' <= currentText[index] && currentText[index] <= '9')
            {
                Calculate.Text = currentText + buttonText;
            }
            label1.Focus();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string currentText = Calculate.Text;
            Calculate.Text = calc(currentText);
            label1.Focus();
        }
        private string calc(string input)
        {
            int index = 0, p1 = 0, p2 = 0;
            float o1 = 0, o2 = 0;
            char op;
            for (int i = 0; i < input.Length; i++)
            {
                if ('0' <= input[i] && input[i] <= '9')
                {
                    continue;
                }
                if (input[i] == '+' || input[i] == '-' || input[i] == '*' || input[i] == '/')
                {
                    index = i;
                }
                if (input[i] == '.' && index == 0)
                {
                    p1 = i;
                }
                if (input[i] == '.' && index != 0)
                {
                    p2 = i;
                }

            }
            if (index == 0)
            {

                return input;
            }
            op = input[index];
            if (p1 == 0)
            {
                for (int i = 0; i < index; i++)
                {
                    o1 += ((float)(input[index - 1 - i] - '0')) * (float)Math.Pow(10, i);
                }
            }
            else
            {
                for (int i = 0; i < p1; i++)
                {
                    o1 += ((float)(input[p1 - 1 - i] - '0')) * (float)Math.Pow(10, i);
                }
                for (int i = p1 + 1; i < index; i++)
                {
                    o1 += (input[i] - '0') * (float)Math.Pow(10, p1 - i);
                }
            }
            if (p2 == 0)
            {
                for (int i = 0; index < input.Length - 1 - i; i++)
                {
                    o2 += (input[input.Length - 1 - i] - '0') * (float)Math.Pow(10, i);
                }
            }
            else
            {
                for (int i = 0; index < p2 - 1 - i; i++)
                {
                    o2 += (input[p2 - 1 - i] - '0') * (float)Math.Pow(10, i);
                }
                for (int i = p2 + 1; i < input.Length; i++)
                {
                    o2 += (input[i] - '0') * (float)Math.Pow(10, p2 - i);
                }
            }

            return (operate(o1, o2, op)).ToString();
        }
        private float operate(float o1, float o2, char op)
        {
            switch (op)
            {
                case '+':
                    return o1 + o2;
                case '-':
                    return o1 - o2;
                case '*':
                    return o1 * o2;
                default:
                    if (o2 == 0)
                    {
                        throw new DivideByZeroException("Division by zero is not allowed.");
                    }
                    else
                    {
                        return o1 / o2;
                    }

            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Calculate.Text = "";
            label1.Focus();
        }

        
        

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyPressed = e.KeyChar;

            switch (keyPressed)
            {
                case '0':
                    button1.PerformClick();
                    e.Handled = true;
                    break;
                case '1':
                    button2.PerformClick();
                    e.Handled = true;
                    break;
                case '2':
                    button3.PerformClick();
                    e.Handled = true;
                    break;
                case '3':
                    button4.PerformClick();
                    e.Handled = true;
                    break;
                case '4':
                    button5.PerformClick();
                    e.Handled = true;
                    break;
                case '5':
                    button6.PerformClick();
                    e.Handled = true;
                    break;
                case '6':
                    button7.PerformClick();
                    e.Handled = true;
                    break;
                case '7':
                    button8.PerformClick();
                    e.Handled = true;
                    break;
                case '8':
                    button9.PerformClick();
                    e.Handled = true;
                    break;
                case '9':
                    button10.PerformClick();
                    e.Handled = true;
                    break;
                case '-':
                    button11.PerformClick();
                    e.Handled = true;
                    break;
                case '+':
                    button12.PerformClick();
                    e.Handled = true;
                    break;
                case '*':
                    button13.PerformClick();
                    e.Handled = true;
                    break;
                case '/':
                    button14.PerformClick();
                    e.Handled = true;
                    break;
                case (char)Keys.Enter:
                    button15.PerformClick();
                    e.Handled = true;
                    break;
                case '.':
                    button17.PerformClick();
                    e.Handled = true;
                    break;
                case '\b':
                    delete.PerformClick();
                    e.Handled = true;
                    break;

                
            }
        }
        


        private void button17_Click(object sender, EventArgs e)
        {
            int index = 0,token=0,token2=0,token3=0;
            Button clickedButton = (Button)sender;
            string buttonText = clickedButton.Text;
            string currentText = Calculate.Text;
            for (; index < currentText.Length - 1;)
            {
                if (currentText[index] == '.')
                {
                    token=1;
                    
                }
                if (currentText[index] == '+' || currentText[index] == '-' || currentText[index] == '*' || currentText[index] == '/')
                {
                    token2 = 1;
                }
                if(currentText[index] == '.' && token2==1)
                {
                    token3 = 1;
                }
                index++;
            }
            if(token == 0 && token2==0)
            {
                if ('0' <= currentText[index] && currentText[index] <= '9')
                {
                    Calculate.Text = currentText + buttonText;
                }
            }
            else if( token2==1 && token3==0) 
            {
                if ('0' <= currentText[index] && currentText[index] <= '9')
                {
                    Calculate.Text = currentText + buttonText;
                }
            }
            label1.Focus();

        }

        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /*
            switch (e.KeyCode)
            {
                case Keys.D0:
                    button1.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.D1:
                    button2.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.D2:
                    button3.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.D3:
                    button4.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.D4:
                    button5.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.D5:
                    button6.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.D6:
                    button7.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.D7:
                    button8.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.D8:
                    button9.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.D9:
                    button10.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.OemMinus: // For the '-' key
                    button11.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.Oemplus: // For the '+' key
                    button12.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.Multiply:
                    button13.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.Divide:
                    button14.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.Enter:
                    button15.PerformClick(); // Perform the action associated with the Equals button
                    e.Handled = true;
                    break;
                case Keys.Decimal: // For the '.' key
                    button17.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.Back:
                    delete.PerformClick();
                    e.Handled = true;
                    break;
            }
            */
        }
    }


    }
