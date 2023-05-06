using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{


    public partial class Calculator : Form
    {

        public string currentOperand;
        public string previoseOperand;
        public string operation;
        public string result_s;

        public Calculator()
        {
            InitializeComponent();
        }
        public void onNumberBtnClick(object sender, EventArgs e)
        {
            if (result.Text.Length <= 9)
            {
                ButtonClicked.buttonClicked = (sender as Button).Text;
                if (result_s == result.Text)
                {
                    result.Text = null;
                    result_s = null;
                    previoseOperand = null;
                    currentOperand = null;
                }
                switch (ButtonClicked.buttonClicked)
                {
                    //Adds number to text
                    case "1":
                        result.Text += "1";
                        break;
                    case "2":
                        result.Text += "2";
                        break;
                    case "3":
                        result.Text += "3";
                        break;
                    case "4":
                        result.Text += "4";
                        break;
                    case "5":
                        result.Text += "5";
                        break;
                    case "6":
                        result.Text += "6";
                        break;
                    case "7":
                        result.Text += "7";
                        break;
                    case "8":
                        result.Text += "8";
                        break;
                    case "9":
                        result.Text += "9";
                        break;
                    case "0":
                        result.Text += "0";
                        break;
                }
                currentOperand += ButtonClicked.buttonClicked;
            }
            result.Focus();
        }
        public void onOperationBtnClick(object sender, EventArgs e)
        {
            if (result.Text != "")
            {
                ButtonClicked.buttonClicked = (sender as Button).Text;
                switch (ButtonClicked.buttonClicked)
                {

                    //Changes text on depending operation
                    case "+":
                        operation = "+";
                        previoseOperand = currentOperand;
                        currentOperand = null;
                        previouse_result.Text = result.Text + " +";
                        result.Text = null;
                        break;
                    case "-":
                        operation = "-";
                        previoseOperand = currentOperand;
                        currentOperand = null;
                        previouse_result.Text = result.Text + " -";
                        result.Text = null;
                        break;
                    case "*":
                        operation = "*";
                        previoseOperand = currentOperand;
                        currentOperand = null;
                        previouse_result.Text = result.Text + " *";
                        result.Text = null;
                        break;
                    case "/":
                        operation = "/";
                        previoseOperand = currentOperand;
                        currentOperand = null;
                        previouse_result.Text = result.Text + " /";
                        result.Text = null;
                        break;
                }
            }
            result.Focus();

        }
        public void onResultBtnClick(object sender, EventArgs e)
        {
            if(result.Text != "" && previouse_result.Text != "")
            {
                //Parse stringsd to ints
                float current = float.Parse(result.Text.Replace(".", ","));
                float previouse = float.Parse(previoseOperand.Replace(".", ","));
                float result_num;

                //Calculate result depending on operation
                switch (operation)
                {
                    case "+":
                        result_num = previouse + current;
                        previouse_result.Text = null;
                        result.Text = result_num.ToString().Replace(",", ".");
                        operation = null;
                        currentOperand = result.Text.Replace(",", ".");
                        result_s = result_num.ToString().Replace(",", ".");
                        result_num = 0;
                        break;
                    case "-":
                        result_num = previouse - current;
                        previouse_result.Text = null;
                        result.Text = result_num.ToString().Replace(",", ".");
                        operation = null;
                        currentOperand = result.Text;
                        result_s = result_num.ToString().Replace(",", ".");
                        result_num = 0;
                        break;
                    case "*":
                        result_num = previouse * current;
                        previouse_result.Text = null;
                        result.Text = result_num.ToString().Replace(",", ".");
                        operation = null;
                        currentOperand = result.Text;
                        result_s = result_num.ToString().Replace(",", ".");
                        result_num = 0;
                        break;
                    case "/":
                        result_num = previouse / current;
                        previouse_result.Text = null;
                        result.Text = result_num.ToString().Replace(",", ".");
                        operation = null;
                        currentOperand = result.Text;
                        result_s = result_num.ToString().Replace(",", ".");
                        result_num = 0;
                        break;
                }
            }
            result.Focus();

        }
        public void onACBtnClick(object sender, EventArgs e)
        {
            previouse_result.Text = null;
            result.Text = null;
            currentOperand = null;
            previoseOperand = null;
            result_s = null;
            operation = null;
            result.Focus();

        }
        public void onDELBtnClick(object sender, EventArgs e)
        {
            if(result.Text != "")
            {
                result.Text = result.Text.Substring(0, result.Text.Length - 1);
                currentOperand = result.Text;
            }else if(result.Text == "" && previouse_result.Text != "")
            {
                result.Text = previouse_result.Text.Replace(" " + operation, "");
                currentOperand = previoseOperand;
                previoseOperand = null;
                previouse_result.Text = null;
                operation = null;
                result.Text = result.Text.Substring(0, result.Text.Length - 1);
                currentOperand = result.Text;
            }
            result.Focus();

        }

        private void button17_Click(object sender, EventArgs e)
        {
            About form = new About();
            form.Show();
            result.Focus();

        }

        private void onDecimalPointBtnClick(object sender, EventArgs e)
        {
            if (!result.Text.Contains("."))
            {
                result.Text += ".";
                currentOperand = result.Text;
                result.Focus();

            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Application.Exit();
            result.Focus();
        }



        public void onKeyPressed(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                //Numbersv
                case Keys.NumPad0:
                    chechResult();
                    result.Text += "0";
                    currentOperand += "0";
                    break;
                case Keys.NumPad1:
                    chechResult();
                    result.Text += "1";
                    currentOperand += "1";
                    break;
                case Keys.NumPad2:
                    chechResult();
                    result.Text += "2";
                    currentOperand += "2";
                    break;
                case Keys.NumPad3:
                    chechResult();
                    result.Text += "3";
                    currentOperand += "3";
                    break;
                case Keys.NumPad4:
                    chechResult();
                    result.Text += "4";
                    currentOperand += "4";
                    break;
                case Keys.NumPad5:
                    chechResult();
                    result.Text += "5";
                    currentOperand += "5";
                    break;
                case Keys.NumPad6:
                    chechResult();
                    result.Text += "6";
                    currentOperand += "6";
                    break;
                case Keys.NumPad7:
                    chechResult();
                    result.Text += "7";
                    currentOperand += "7";
                    break;
                case Keys.NumPad8:
                    chechResult();
                    result.Text += "8";
                    currentOperand += "8";
                    break;
                case Keys.NumPad9:
                    chechResult();
                    result.Text += "9";
                    currentOperand += "9";
                    break;
                case Keys.D0:
                    chechResult();
                    result.Text += "0";
                    currentOperand += "0";
                    break;
                case Keys.D1:
                    chechResult();
                    result.Text += "1";
                    currentOperand += "1";
                    break;
                case Keys.D2:
                    chechResult();
                    result.Text += "2";
                    currentOperand += "2";
                    break;
                case Keys.D3:
                    chechResult();
                    result.Text += "3"; 
                    currentOperand += "3";
                    break;
                case Keys.D4:
                    chechResult();
                    result.Text += "4";
                    currentOperand += "4";
                    break;
                case Keys.D5:
                    chechResult();
                    result.Text += "5";
                    currentOperand += "5";
                    break;
                case Keys.D6:
                    chechResult();
                    result.Text += "6";
                    currentOperand += "6";
                    break;
                case Keys.D7:
                    chechResult();
                    result.Text += "7";
                    currentOperand += "7";
                    break;
                case Keys.D8:
                    chechResult();
                    result.Text += "8";
                    currentOperand += "8";
                    break;
                case Keys.D9:
                    chechResult();
                    result.Text += "9";
                    currentOperand += "9";
                    break;
            }



            //Operations
            if (result.Text != "")
            {
                switch (e.KeyCode)
                {

                    //Changes text on depending operation
                    case Keys.Add:
                        operation = "+";
                        previoseOperand = currentOperand;
                        currentOperand = null;
                        previouse_result.Text = result.Text + " +";
                        result.Text = null;
                        break;
                    case Keys.Subtract:
                        operation = "-";
                        previoseOperand = currentOperand;
                        currentOperand = null;
                        previouse_result.Text = result.Text + " -";
                        result.Text = null;
                        break;
                    case Keys.Multiply:
                        operation = "*";
                        previoseOperand = currentOperand;
                        currentOperand = null;
                        previouse_result.Text = result.Text + " *";
                        result.Text = null;
                        break;
                    case Keys.Divide:
                        operation = "/";
                        previoseOperand = currentOperand;
                        currentOperand = null;
                        previouse_result.Text = result.Text + " /";
                        result.Text = null;
                        break;
                }
            }


            //Other buttons
            switch (e.KeyCode)
            {

                //Changes text on depending operation
                case Keys.Enter:
                    if (result.Text != "" && previouse_result.Text != "")
                    {
                        //Parse stringsd to ints
                        float current = float.Parse(currentOperand.Replace(".", ","));
                        float previouse = float.Parse(previoseOperand.Replace(".", ","));
                        float result_num;

                        //Calculate result depending on operation
                        switch (operation)
                        {
                            case "+":
                                result_num = previouse + current;
                                previouse_result.Text = null;
                                result.Text = result_num.ToString().Replace(",", ".");
                                operation = null;
                                currentOperand = result.Text.Replace(",", ".");
                                result_s = result_num.ToString().Replace(",", ".");
                                result_num = 0;
                                break;
                            case "-":
                                result_num = previouse - current;
                                previouse_result.Text = null;
                                result.Text = result_num.ToString().Replace(",", ".");
                                operation = null;
                                currentOperand = result.Text;
                                result_s = result_num.ToString().Replace(",", ".");
                                result_num = 0;
                                break;
                            case "*":
                                result_num = previouse * current;
                                previouse_result.Text = null;
                                result.Text = result_num.ToString().Replace(",", ".");
                                operation = null;
                                currentOperand = result.Text;
                                result_s = result_num.ToString().Replace(",", ".");
                                result_num = 0;
                                break;
                            case "/":
                                result_num = previouse / current;
                                previouse_result.Text = null;
                                result.Text = result_num.ToString().Replace(",", ".");
                                operation = null;
                                currentOperand = result.Text;
                                result_s = result_num.ToString().Replace(",", ".");
                                result_num = 0;
                                break;
                        }
                    }
                    break;


                case Keys.Back:
                    if (result.Text != "" && result.Text != "NaN")
                    {
                        result.Text = result.Text.Substring(0, result.Text.Length - 1);
                        currentOperand = result.Text;
                    }
                    else if (result.Text == "NaN")
                    {
                        result.Text = "";
                        currentOperand = result.Text;
                    }
                    else if (result.Text == "" && previouse_result.Text != "")
                    {
                        result.Text = previouse_result.Text.Replace(" " + operation, "");
                        currentOperand = previoseOperand;
                        previoseOperand = null;
                        previouse_result.Text = null;
                        operation = null;
                        result.Text = result.Text.Substring(0, result.Text.Length - 1);
                        currentOperand = result.Text;
                    }
                    break;
                case Keys.OemPeriod:
                    if (!result.Text.Contains("."))
                    {
                        result.Text += ".";
                        currentOperand = result.Text;
                        result.Focus();

                    }
                    break;
                case Keys.Oemcomma:
                    if (!result.Text.Contains("."))
                    {
                        result.Text += ".";
                        currentOperand = result.Text;
                        result.Focus();

                    }
                    break;
            }
        }
        public void chechResult()
        {
            if (result_s == result.Text)
            {
                result.Text = null;
                result_s = null;
                previoseOperand = null;
                currentOperand = null;
            }
        }
    }
    public static class ButtonClicked
    {
        public static string buttonClicked;
    }
}
