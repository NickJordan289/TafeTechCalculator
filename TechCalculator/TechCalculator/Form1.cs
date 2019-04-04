using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AlgebraicLib;
using ArithmeticLib;
using TrigonometricLib;

namespace TechCalculator
{
	public partial class Form1 : Form
	{
        enum Operation
        {
            NULL,
            PLUS,
            MINUS,
            TIMES,
            DIVIDE,

            SINE,
            COSINE,
            TANGENT,

            SQRT,
            CRT,
            INVERSE
        }

        double val1; // first value that the operator is going to apply to
        Operation op = Operation.NULL; // no operator is being applied

		public Form1()
		{
			InitializeComponent();
		}

		public void EnterChar(object sender, EventArgs e, char i)
		{
            textBox1.Text += i.ToString();
        }

		private void Form1_Load(object sender, EventArgs e)
		{
            button0.Click += delegate (object s, EventArgs ee)
            {
                // Prevents a double 00 at the start
                if (textBox1.Text.Length == 0 || // allow first character to be 0
                            textBox1.Text.Contains('.') || // allow 0 in decimal place
                            (!textBox1.Text.Contains('.') && !(textBox1.Text.ElementAt(0) == '0' && textBox1.Text.Length==1))) // allow 0 before decimal if it isn't a double 0 (00)
                    EnterChar(sender, e, '0');
            };

            button1.Click += delegate (object s, EventArgs ee)
			{ EnterChar(sender, e, '1'); };

			button2.Click += delegate (object s, EventArgs ee)
			{ EnterChar(sender, e, '2'); };

			button3.Click += delegate (object s, EventArgs ee)
			{ EnterChar(sender, e, '3'); };

			button4.Click += delegate (object s, EventArgs ee)
			{ EnterChar(sender, e, '4'); };

			button5.Click += delegate (object s, EventArgs ee)
			{ EnterChar(sender, e, '5'); };

			button6.Click += delegate (object s, EventArgs ee)
			{ EnterChar(sender, e, '6'); };

			button7.Click += delegate (object s, EventArgs ee)
			{ EnterChar(sender, e, '7'); };

			button8.Click += delegate (object s, EventArgs ee)
			{ EnterChar(sender, e, '8'); };

			button9.Click += delegate (object s, EventArgs ee)
			{ EnterChar(sender, e, '9'); };

			buttonDecimal.Click += delegate (object s, EventArgs ee)
            { if (!textBox1.Text.Contains('.')) EnterChar(sender, e, '.'); }; // only allow one decimal
		}

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            Calc();
        }

        private void Calc()
        {
            // Perform operation
            if (op == Operation.NULL)
            {
                textBox1.Text = double.Parse(textBox1.Text).ToString(); // may as well perform a format
                return;
            }

            double val2 = double.Parse(textBox1.Text);
            double result = val1;

            switch (op)
            {
                //Arithmetic
                case Operation.PLUS:
                    result = Arithmetic.Add(val1, val2);
                    break;
                case Operation.MINUS:
                    result = Arithmetic.Subtraction(val1, val2);
                    break;
                case Operation.TIMES:
                    result = Arithmetic.Multiplication(val1, val2);
                    break;
                case Operation.DIVIDE:
                    result = Arithmetic.Division(val1, val2);
                    break;
                // Trigonometric
                case Operation.SINE:
                    result = Trigonometric.Sine(val1, false);
                    break;
                case Operation.COSINE:
                    result = Trigonometric.Cosine(val1, false);
                    break;
                case Operation.TANGENT:
                    currentCalculation.Text = "Invalid input";
                    if(val1 != 90)
                    {
                        result = 0;
                    }
                    else
                    {
                        result = Trigonometric.Tan(val1, false);
                    }
                    break;
                // Algebraic
                case Operation.SQRT:
                    result = Algebraic.SquareRoot(val2);
                    break;
                case Operation.CRT:
                    result = Algebraic.CubeRoot(val2);
                    break;
                case Operation.INVERSE:
                    result = Algebraic.Inverse(val2);
                    break;

            }

            op = Operation.NULL;

            textBox1.Text = result.ToString();
            currentCalculation.Text = "";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            val1 = double.Parse(textBox1.Text);
            currentCalculation.Text = val1 + " +";
            op = Operation.PLUS;
            textBox1.Clear();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            val1 = double.Parse(textBox1.Text);
            op = Operation.MINUS;
            textBox1.Clear();
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            val1 = double.Parse(textBox1.Text);
            op = Operation.TIMES;
            textBox1.Clear();
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            val1 = double.Parse(textBox1.Text);
            op = Operation.DIVIDE;
            textBox1.Clear();
        }

        private void buttonTan_Click(object sender, EventArgs e)
        {
            val1 = double.Parse(textBox1.Text);
            op = Operation.TANGENT;
            textBox1.Clear();
        }

        private void buttonCos_Click(object sender, EventArgs e)
        {
            val1 = double.Parse(textBox1.Text);
            op = Operation.COSINE;
            textBox1.Clear();
        }

        private void buttonSin_Click(object sender, EventArgs e)
        {
            val1 = double.Parse(textBox1.Text);
            op = Operation.SINE;
            textBox1.Clear();
        }

        private void buttonInv_Click(object sender, EventArgs e)
        {
            op = Operation.INVERSE;
            Calc();
        }

        private void buttonRoot_Click(object sender, EventArgs e)
        {
            op = Operation.SQRT;
            Calc();
        }

        private void buttonRoot3_Click(object sender, EventArgs e)
        {
            op = Operation.CRT;
            Calc();
        }
    }
}
