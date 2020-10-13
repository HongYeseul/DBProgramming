using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            InitVariables();
        }

        public void InitVariables()
        {
            comboBoxComboCalc_Operator.Items.Clear();

            comboBoxComboCalc_Operator.Items.Add("+");
            comboBoxComboCalc_Operator.Items.Add("-");
            comboBoxComboCalc_Operator.Items.Add("*");
            comboBoxComboCalc_Operator.Items.Add("/");
            comboBoxComboCalc_Operator.Items.Add("^");

            comboBoxComboCalc_Operator.SelectedIndex = 0;

        }

        private void buttonComboBoxCalculator_Click(object sender, EventArgs e)
        {
            String oper1 = textBoxComboCalc_Oper1.Text;
            String oper2 = textBoxComboCalc_Oper2.Text;

            String oper = "";
            float result = 0;
            switch (comboBoxComboCalc_Operator.SelectedIndex)
            {
                case 0:
                    result = float.Parse(oper1) + float.Parse(oper2);
                    oper = "+";
                    break;
                case 1:
                    result = float.Parse(oper1) - float.Parse(oper2);
                    oper = "-";
                    break;
                case 2:
                    result = float.Parse(oper1) * float.Parse(oper2);
                    oper = "*";
                    break;
                case 3:
                    result = float.Parse(oper1) / float.Parse(oper2);
                    oper = "/";
                    break;
                case 4:
                    result = (float)Math.Pow(Convert.ToInt32(oper1), Convert.ToInt32(oper2));
                    oper = "^";
                    break;
            }
            textBoxComboCalc_Result.Text = oper1 + oper + oper2 + '=' + result;
        }

        private void buttonRadioBoxCalculator_Click(object sender, EventArgs e)
        {
            String oper1 = textBoxRadioCalc_Oper1.Text;
            String oper2 = textBoxRadioCalc_Oper2.Text;

            String oper = "";
            float result = 0;
            if (radioButtonOperator_plus.Checked)
            {
                result = float.Parse(oper1) + float.Parse(oper2); ;
                oper = "+";
            }
            else if(radioButtonOperator_minus.Checked)
            {
                result = float.Parse(oper1) - float.Parse(oper2); ;
                oper = "-";
            } else if (radioButtonOperator_pow.Checked)
            {
                result = (float)Math.Pow(Convert.ToInt32(oper1), Convert.ToInt32(oper2));
                oper = "^";
            }
            textBoxRadioCalc_Result.Text = oper1 + oper + oper2 + '=' + result;
        }
    }
}
