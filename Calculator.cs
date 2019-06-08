using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Calculator : Form
    {
        double Number1 = 0;
        double Number2 = 0;
        double total;
        string theOperator = "";

        public Calculator()
        {
            InitializeComponent();
            labelNumber.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            if (theOperator == "")
            {
                
                result.Text = result.Text + "7"; // DISPLAY 7
                Number1 = Convert.ToDouble(result.Text);
            }
            else
            {
                result.Text = result.Text + "7";
                Number2 = Convert.ToDouble(result.Text);
            }
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            if (theOperator == "")
            {

                result.Text = result.Text + "9"; 
                Number1 = Convert.ToDouble(result.Text);
            }
            else
            {
                result.Text = result.Text + "9";
                Number2 = Convert.ToDouble(result.Text);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //THIS IS OUR TEXT BOOK TO DISPLAY
            
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            if (theOperator == "")
            {

                result.Text = result.Text + "8";
                Number1 = Convert.ToDouble(result.Text);
            }
            else
            {
                result.Text = result.Text + "9";
                Number2 = Convert.ToDouble(result.Text);
            }
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            if (theOperator == "")
            {

                result.Text = result.Text + "6"; 
                Number1 = Convert.ToDouble(result.Text);
            }
            else
            {
                result.Text = result.Text + "6";
                Number2 = Convert.ToDouble(result.Text);
            }
        }


        private void buttonFive_Click(object sender, EventArgs e)
        {
         if (theOperator == "")
        {

            result.Text = result.Text + "5";
            Number1 = Convert.ToDouble(result.Text);
        }
        else
        {
            result.Text = result.Text + "5";
            Number2 = Convert.ToDouble(result.Text);
        }
    }


        private void buttonFour_Click(object sender, EventArgs e)
        {
            if (theOperator == "")
            {

                result.Text = result.Text + "4";
                Number1 = Convert.ToDouble(result.Text);
            }
            else
            {
                result.Text = result.Text + "4";
                Number2 = Convert.ToDouble(result.Text);
            }
        
    }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            if (theOperator == "")
            {

                result.Text = result.Text + "3";
                Number1 = Convert.ToDouble(result.Text);
            }
            else
            {
                result.Text = result.Text + "3";
                Number2 = Convert.ToDouble(result.Text);
            }
        
    }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            if (theOperator == "")
            {

                result.Text = result.Text + "2";
                Number1 = Convert.ToDouble(result.Text);
            }
            else
            {
                result.Text = result.Text + "2";
                Number2 = Convert.ToDouble(result.Text);
            }
        }


        private void buttonOne_Click(object sender, EventArgs e)
        {
            if (theOperator == "")
            {

                result.Text = result.Text + "1";
                Number1 = Convert.ToDouble(result.Text);
            }
            else
            {
                result.Text = result.Text + "1";
                Number2 = Convert.ToDouble(result.Text);
            }
        
    }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            if (theOperator == "")
            {

                result.Text = result.Text + "0";
                Number1 = Convert.ToDouble(result.Text);
            }
            else
            {
                result.Text = result.Text + "0";
                Number2 = Convert.ToDouble(result.Text);
            }
        
    }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            switch (theOperator)
            {
                case "+":
                    total = Number1 + Number2;
                    break;
                case "-":
                    total = Number1 - Number2;
                    break;
                case "*":
                    total = Number1 * Number2;
                    break;
                case "/":
                    total = Number1 / Number2;
                    break;
            }
            result.Text = Convert.ToString(total);
        }


        private void buttonAddition_Click(object sender, EventArgs e)
        {
            theOperator = "+";
            result.Text = "";
            labelNumber.Text = Convert.ToString(Number1);
        }


        private void buttonClear_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            Number1 = 0;
            Number2 = 0;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            theOperator = "-";
            result.Text = "";
            labelNumber.Text = Convert.ToString(Number1);
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            theOperator = "*";
            result.Text = "";
            labelNumber.Text = Convert.ToString(Number1);
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            theOperator = "/";
            result.Text = "";
            labelNumber.Text = Convert.ToString(Number1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
