using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualProgramingProject
{
    public partial class Calculator_Form : Form
    {
        public Calculator_Form()
        {
            InitializeComponent();
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Calculator_Form_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtCal;
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            this.ForeColor = Color.Brown;
            this.groupBox1.BackColor = Color.Black;
        }

        private void btnWhite_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            this.groupBox1.BackColor = Color.White;
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txtCal.Text += "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txtCal.Text += "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txtCal.Text += "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txtCal.Text += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txtCal.Text += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txtCal.Text += "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txtCal.Text += "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txtCal.Text += "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txtCal.Text += "9";

        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            txtCal.Text += "0";
        }

        private void btn_dote_Click(object sender, EventArgs e)
        {
            txtCal.Text += ".";
        }

        private void btn_Mult_Click(object sender, EventArgs e)
        {
            txtCal.Text += "*";
        }

        private void btn_subst_Click(object sender, EventArgs e)
        {
            txtCal.Text += "/";
        }

        private void btn_sum_Click(object sender, EventArgs e)
        {
            txtCal.Text += "+";
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            txtCal.Text += "-";
        }


        private void btn_Eque_Click(object sender, EventArgs e)
        {
            bool checkDot1 = false;
            bool checkDot2 = false;
            string Cal = txtCal.Text;
            double num1 = 0.0;
            double num2 = 0.0;
            double num1Dot = 0.0;
            double num2Dot = 0.0;
            char op = ' ';
            int counterNumOfOperation = 0;
            bool check = false;
            for (int i = 0; i < Cal.Length; i++)
            {
                if (counterNumOfOperation > 1)
                {
                    switch (op)
                    {
                        case '+':
                            txtCal.Text = (num1 + num2).ToString();
                            break;
                        case '-':
                            txtCal.Text = (num1 - num2).ToString();
                            break;
                        case '*':
                            txtCal.Text = (num1 * num2).ToString();
                            break;
                        case '/':
                            txtCal.Text = (num1 / num2).ToString();
                            break;
                    }
                    num1 = double.Parse(txtCal.Text);
                    num2 = 0;
                }
                if (Cal[i] == '+' || Cal[i] == '-' || Cal[i] == '*' || Cal[i] == '/')
                {
                    counterNumOfOperation++;
                    check = true;
                    op = Cal[i];
                }
                else
                {
                    if (!check)
                    {
                        if (Cal[i] == '.')
                        {
                            checkDot1 = true;
                        }
                        else
                        {
                            if (checkDot1)
                            {
                                num1Dot++;
                            }
                            num1 = num1 * 10 + (Cal[i] - '0');
                        }
                    }
                    else
                    {
                        if (Cal[i] == '.')
                        {
                            checkDot2 = true;
                        }
                        else
                        {
                            if (checkDot2)
                            {
                                num2Dot++;
                            }
                            num2 = num2 * 10 + (Cal[i] - '0');
                        }
                    }
                }
            }
            if (num1Dot != 0)
            {
                num1 /= (Math.Pow(10, num1Dot));
            }
            if (num2Dot != 0)
            {
                num2 /= (Math.Pow(10, num2Dot));
            }
            switch (op)
            {
                case '+':
                    txtCal.Text = (num1 + num2).ToString();
                    break;
                case '-':
                    txtCal.Text = (num1 - num2).ToString();
                    break;
                case '*':
                    txtCal.Text = (num1 * num2).ToString();
                    break;
                case '/':
                    txtCal.Text = (num1 / num2).ToString();
                    break;
            }
        }
        private void btn_CE_Click(object sender, EventArgs e)
        {
            string text = txtCal.Text;
            text = text.Substring(0, text.Length - 1);
            txtCal.Text = text;
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            txtCal.Text = "";
        }

        private void txtCal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
