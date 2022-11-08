using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorForms
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        bool startNumberIsTrue = true;

        double num1 = 0;
        double num2 = 0;
        string sign = "";
        double temp;
        double temp1;
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void BtnZero_Click_1(object sender, EventArgs e)
        {
            NumberBt_Click("0");
        }

        private void BtnOne_Click(object sender, EventArgs e)
        {
            NumberBt_Click("1");
        }

        private void BtnTwo_Click(object sender, EventArgs e)
        {
            NumberBt_Click("2");
        }

        private void BtnThree_Click(object sender, EventArgs e)
        {
            NumberBt_Click("3");
        }

        private void BtnFour_Click(object sender, EventArgs e)
        {
            NumberBt_Click("4");
        }

        private void BtnFive_Click(object sender, EventArgs e)
        {
            NumberBt_Click("5");
        }

        private void BtnSix_Click(object sender, EventArgs e)
        {

            NumberBt_Click("6");
        }

        private void BtnSeven_Click(object sender, EventArgs e)
        {
            NumberBt_Click("7");
        }

        private void BtnEight_Click(object sender, EventArgs e)
        {
            NumberBt_Click("8");
        }

        private void BtnNine_Click(object sender, EventArgs e)
        {
            NumberBt_Click("9");
        }

        private void BtnAddDot_Click(object sender, EventArgs e)
        {
            NumberBt_Click(",");
        }



        private void NumberBt_Click(string number)
        {
            if (startNumberIsTrue == false)
            {
                
                LbEquals.Text += number;
            }
            else
            {
                
                LbEquals.Text = number;
                startNumberIsTrue = false;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Operation("+");
        }
        private void BtnSub_Click(object sender, EventArgs e)
        {
            Operation("-");
        }
        private void BtnDiv_Click(object sender, EventArgs e)
        {
            Operation("/");
        }
        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            Operation("*");
        }
        private void BtnMinus_Click(object sender, EventArgs e)
        {
            if(LbEquals.Text==String.Empty)
            NumberBt_Click("-");
        }

                            
        private void BtnEquals_Click(object sender, EventArgs e)
        {
                 
            if (LbEquals.Text != String.Empty)
            {
                num2 = Convert.ToDouble(LbEquals.Text);
              
                switch (sign)
                {
                    case "+":
                        {
                            LbEquals.Text = Convert.ToString(num1 + num2);
                        }
                        break;
                    case "-":
                        {                                                
                              LbEquals.Text = Convert.ToString(num1- num2);
                        }
                        break;
                    case "/":
                        {
                            if (num2 != 0)
                                LbEquals.Text = Convert.ToString(num1 / num2);
                            else
                                MessageBox.Show("Cannot divide by zero!");
                        }
                        break;
                    case "*":
                        {
                            LbEquals.Text = Convert.ToString(num1 * num2);
                        }
                        break;                  
                  
                }            
                startNumberIsTrue = true;
            }
                
               
           
        }

        private void BtnBackSpace_Click(object sender, EventArgs e)
        {
            if(LbEquals.Text!=String.Empty)
            LbEquals.Text = LbEquals.Text.Remove(LbEquals.Text.Length - 1);
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (LbEquals.Text != String.Empty || LbOperation.Text != String.Empty)
            {
                LbOperation.Text= LbOperation.Text = "";
                LbEquals.Text = LbEquals.Text= "";
            }
        }
        private void Operation(string sign)
        {
            if (LbEquals.Text != String.Empty)
            {

                num1= Convert.ToDouble(LbEquals.Text);
                LbOperation.Text = LbEquals.Text;
                
                LbOperation.Text += sign;
                this.sign = sign;
                startNumberIsTrue = true;
            }
            
        }

        private void BtnCE_Click(object sender, EventArgs e)
        {
            if (LbEquals.Text != "")
                LbEquals.Text=LbEquals.Text="";
        }

        
    }
}
