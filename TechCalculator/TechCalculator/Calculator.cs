using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Math libraries
using AlgebraicLib;
using ArithmeticLib;
using TrigonometricLib;

/*
 * Nicholas Jordan 
 * P459018
 * Tech Calculator
 * Portfolio 1.6
 * Version created 5/04/2019
 */
namespace TechCalculator
{
    public partial class Calculator : Form
    {
        enum Operation // all the operations this program supports
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
        Operation prevOp = Operation.NULL; // no prev operator is being stored


        public Calculator()
        {
            InitializeComponent();

            this.KeyPreview = true; // allow keyboard inputs to be detected
        }

        // Helper method for entering values into input field
        public void EnterChar(object sender, EventArgs e, char i)
        {
            ValueInput.Text += i.ToString();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            Button0.Click += delegate (object s, EventArgs ee)
            {
                // Prevents a double 00 at the start
                if (ValueInput.Text.Length == 0 || // allow first character to be 0
                            ValueInput.Text.Contains('.') || // allow 0 in decimal place
                            (!ValueInput.Text.Contains('.') && !(ValueInput.Text.ElementAt(0) == '0' && ValueInput.Text.Length == 1))) // allow 0 before decimal if it isn't a double 0 (00)
                    EnterChar(sender, e, '0');
            };

            // Button number inputs
            // Sets simple click events for all form buttons
            Button1.Click += delegate (object s, EventArgs ee)
            { EnterChar(sender, e, '1'); };

            Button2.Click += delegate (object s, EventArgs ee)
            { EnterChar(sender, e, '2'); };

            Button3.Click += delegate (object s, EventArgs ee)
            { EnterChar(sender, e, '3'); };

            Button4.Click += delegate (object s, EventArgs ee)
            { EnterChar(sender, e, '4'); };

            Button5.Click += delegate (object s, EventArgs ee)
            { EnterChar(sender, e, '5'); };

            Button6.Click += delegate (object s, EventArgs ee)
            { EnterChar(sender, e, '6'); };

            Button7.Click += delegate (object s, EventArgs ee)
            { EnterChar(sender, e, '7'); };

            Button8.Click += delegate (object s, EventArgs ee)
            { EnterChar(sender, e, '8'); };

            Button9.Click += delegate (object s, EventArgs ee)
            { EnterChar(sender, e, '9'); };

            ButtonDecimal.Click += delegate (object s, EventArgs ee)
            { if (!ValueInput.Text.Contains('.')) EnterChar(sender, e, '.'); }; // only allow one decimal
        }

        // Equals button
        private void ButtonEquals_Click(object sender, EventArgs e)
        {
            if (ValidateInput(ValueInput.Text)) // always validate before calculation
                Calc(); // only calc if input is entered
        }

        // Delete / Reverse button
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ValueInput.Text.Length > 0) // only delete if there is something to delete
                ValueInput.Text = ValueInput.Text.Substring(0, ValueInput.Text.Length - 1); // remove one character
        }

        // validate input text
        private bool ValidateInput(string input)
        {
            // not empty and not just - or .
            return (ValueInput.Text.Length > 0 && // len > 0
                !(ValueInput.Text.Length == 1 && // if len == 1
                    (ValueInput.Text[0] == '-' || ValueInput.Text[0] == '.'))); // make sure single char is not . or -
        }

        // Main calculation function
        // Performs all operations functionality
        private void Calc()
        {
            ErrorDisplay.Text = ""; // clear error at start of calculation

            // only proceed if operation is set and input is valid
            if (op == Operation.NULL || !ValidateInput(ValueInput.Text))
            {
                return; // exit calc
            }

            // Perform operations

            // init values we need
            string input = ValueInput.Text; // input string from input box
            double val2 = double.Parse(input); // read in input to val2
            double result = val1; // default result to current value
            bool inplace = false; // is operation performed inplace (on input rather than on entire statement)

            double output = 0; // temporarily stores output of inplace operations
            switch (op) // switch on our enum
            {
                //Arithmetic
                case Operation.PLUS:
                    result = Arithmetic.Add(val1, val2); // standard two sided add
                    break;
                case Operation.MINUS:
                    result = Arithmetic.Subtraction(val1, val2); // standard two sided sub
                    break;
                case Operation.TIMES:
                    result = Arithmetic.Multiplication(val1, val2); // standard two sided mult
                    break;
                case Operation.DIVIDE:
                    try
                    {
                        result = Arithmetic.Division(val1, val2); // standard two sided div
                    }
                    catch (Exception e)
                    {
                        ValueInput.Text = ""; // reset input for invalid values
                        ErrorDisplay.Text = "Invalid use of Division on " + val2;
                    }
                    break;
                // Trigonometric
                case Operation.SINE:
                    inplace = true; // Sine is performed inplace directly on input
                    try
                    {
                        output = Trigonometric.Sine(val1, false); // store result in temp
                        ValueInput.Text = output.ToString(); // replace input with result of sine
                    }
                    catch (Exception e) // if error with calculation is found set input to empty
                    {
                        ValueInput.Text = ""; // reset input for invalid values
                        ErrorDisplay.Text = "Invalid use of Sine on " + val1;
                    }
                    break;
                case Operation.COSINE:
                    inplace = true; // Cosine is performed inplace directly on input
                    try
                    {
                        output = Trigonometric.Cosine(val1, false); // store result in temp
                        ValueInput.Text = output.ToString(); // replace input with result of cos
                    }
                    catch (Exception e) // if error with calculation is found set input to empty
                    {
                        ValueInput.Text = ""; // reset input for invalid values
                        ErrorDisplay.Text = "Invalid use of Cosine on " + val1;
                    }
                    break;
                case Operation.TANGENT:
                    inplace = true; // Tan is performed inplace directly on input
                    try
                    {
                        output = Trigonometric.Tan(val1, false); // store result in temp
                        ValueInput.Text = output.ToString(); // replace input with result of cos
                    }
                    catch (Exception e) // if error with calculation is found set input to empty
                    {
                        ValueInput.Text = ""; // reset input for invalid values
                        ErrorDisplay.Text = "Invalid use of Tan on " + val1;
                    }
                    break;
                // Algebraic
                case Operation.SQRT:
                    inplace = true; // Square Root is performed inplace directly on input
                    try
                    {
                        output = Algebraic.SquareRoot(val2); // store result in temp
                        ValueInput.Text = output.ToString(); // replace input with result of sqrt
                    }
                    catch (Exception e) // if error with calculation is found set input to empty
                    {
                        ValueInput.Text = ""; // reset input for invalid values
                        ErrorDisplay.Text = "Invalid use of SquareRoot on " + val1;
                    }
                    break;
                case Operation.CRT:
                    inplace = true; // Cuberoot is performed inplace directly on input
                    try
                    {
                        output = Algebraic.CubeRoot(val2); // store result in temp
                        ValueInput.Text = output.ToString(); // replace input with result of cuberoot
                    }
                    catch (Exception e) // if error with calculation is found set input to empty
                    {
                        ValueInput.Text = ""; // reset input for invalid values
                        ErrorDisplay.Text = "Invalid use of Cube Root on " + val1;
                    }
                    break;
                case Operation.INVERSE:
                    inplace = true; // Inverse is performed inplace directly on input
                    try
                    {
                        output = Algebraic.Inverse(val2); // store result in temp
                        ValueInput.Text = output.ToString(); // replace input with result of inv
                    }
                    catch (Exception e) // if error with calculation is found set input to empty
                    {
                        ValueInput.Text = ""; // reset input for invalid values
                        ErrorDisplay.Text = "Invalid use of Inverse on " + val1;
                    }
                    break;
            }

            if (!inplace) // standard operations are only performed once
            {
                // reset values to defaults and submit result to input
                op = Operation.NULL;
                ValueInput.Text = result.ToString();
                CurrentCalculation.Text = "";
            }
            else // inplace operations don't delete previous calculation
            {
                // After performing inplace operation set to normal operation
                op = prevOp;
            }
        }

        // Addition button
        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            if (ValidateInput(ValueInput.Text)) // always validate before calculation
            {
                Calc(); // perform calculation on current input
                val1 = double.Parse(ValueInput.Text); // parse and set input for this operation
                CurrentCalculation.Text = val1 + " +"; // update current calc text
                op = Operation.PLUS; // set new operation
                ValueInput.Clear(); // clear for next input
            }
        }

        // Subtraction button
        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            if (ValidateInput(ValueInput.Text)) // always validate before calculation
            {
                Calc(); // perform calculation on current input
                val1 = double.Parse(ValueInput.Text); // parse and set input for this operation
                CurrentCalculation.Text = val1 + " -"; // update current calc text
                op = Operation.MINUS; // set new operation
                ValueInput.Clear(); // clear for next input
            }
            else // if empty string add - char for negative numbers
            {
                EnterChar(sender, e, '-');
            }
        }

        // Multiplication button
        private void ButtonMult_Click(object sender, EventArgs e)
        {
            if (ValidateInput(ValueInput.Text)) // always validate before calculation
            {
                Calc(); // perform calculation on current input
                val1 = double.Parse(ValueInput.Text); // parse and set input for this operation
                CurrentCalculation.Text = val1 + " *"; // update current calc text
                op = Operation.TIMES; // set new operation
                ValueInput.Clear(); // clear for next input
            }
        }

        // Division button
        private void ButtonDiv_Click(object sender, EventArgs e)
        {
            if (ValidateInput(ValueInput.Text)) // always validate before calculation
            {
                Calc(); // perform calculation on current input
                val1 = double.Parse(ValueInput.Text); // parse and set input for this operation
                CurrentCalculation.Text = val1 + " /"; // update current calc text
                op = Operation.DIVIDE; // set new operation
                ValueInput.Clear(); // clear for next input
            }
        }

        // Tangent button
        private void ButtonTan_Click(object sender, EventArgs e)
        {
            if (ValidateInput(ValueInput.Text)) // always validate before calculation
            {
                val1 = double.Parse(ValueInput.Text); // parse and set input for this operation
                prevOp = op; // keep track of previous, used for inplace functions
                op = Operation.TANGENT; // set new operation
                Calc();  // perform operation
            }
        }

        // Cosine button
        private void ButtonCos_Click(object sender, EventArgs e)
        {
            if (ValidateInput(ValueInput.Text)) // always validate before calculation
            {
                val1 = double.Parse(ValueInput.Text); // parse and set input for this operation
                prevOp = op; // keep track of previous, used for inplace functions
                op = Operation.COSINE; // set new operation
                Calc(); // perform operation
            }
        }

        // Sine button
        private void ButtonSin_Click(object sender, EventArgs e)
        {
            if (ValidateInput(ValueInput.Text)) // always validate before calculation
            {
                val1 = double.Parse(ValueInput.Text); // parse and set input for this operation
                prevOp = op; // keep track of previous, used for inplace functions
                op = Operation.SINE; // set new operation
                Calc(); // perform operation
            }
        }

        // Inverse button
        private void ButtonInv_Click(object sender, EventArgs e)
        {
            prevOp = op; // keep track of previous, used for inplace functions
            op = Operation.INVERSE; // set new operation
            Calc(); // perform operation
        }

        // Square root button
        private void ButtonRoot_Click(object sender, EventArgs e)
        {
            prevOp = op; // keep track of previous, used for inplace functions
            op = Operation.SQRT; // set new operation
            Calc(); // perform operation
        }

        // Cube root button
        private void ButtonRoot3_Click(object sender, EventArgs e)
        {
            prevOp = op; // keep track of previous, used for inplace functions
            op = Operation.CRT; // set new operation
            Calc(); // perform operation
        }

        // Clear all button
        private void ButtonC_Click(object sender, EventArgs e)
        {
            // Reset all fields to default
            CurrentCalculation.Text = "";
            val1 = 0;
            op = Operation.NULL;
            ValueInput.Clear();
        }

        // Clear entry button
        private void ButtonCE_Click(object sender, EventArgs e)
        {
            ValueInput.Clear(); // simply clear input field
        }

        // Allows user to type numbers and operations via keyboard
        private void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57) // 0 through 9
            {
                EnterChar(sender, e, e.KeyChar); // add keyboard input to input field 
            }

            // operation signs (*+/-.=) but not (,)
            else if (e.KeyChar >= 42 && e.KeyChar <= 47 && e.KeyChar != 44 || e.KeyChar == 61 || e.KeyChar == 8)
            {
                switch ((int)e.KeyChar) // switch on keycodes
                {
                    case 8: // backspace
                        DeleteButton_Click(sender, e);
                        break;
                    case 42: // *
                        ButtonMult_Click(sender, e); // same as mult button
                        break;
                    case 43: // +
                        ButtonPlus_Click(sender, e); // same as add button
                        break;
                    case 45: // -
                        ButtonMinus_Click(sender, e); // same as sub button
                        break;
                    case 47: // /
                        ButtonDiv_Click(sender, e); // same as div button
                        break;
                    case 46: // .
                        if (!ValueInput.Text.Contains('.')) EnterChar(sender, e, '.'); // only allow single .
                        break;
                    case 61: // =
                        ButtonEquals_Click(sender, e); // same as equals
                        break;
                }
            }
        }
    }
}
