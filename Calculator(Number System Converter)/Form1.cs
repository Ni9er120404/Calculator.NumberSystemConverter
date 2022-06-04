using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Calculator_Number_System_Converter_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Calculator Calculator = new Calculator();
        private string N;
        private void Button12_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("9");
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("8");
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("7");
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("6");
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("5");
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("4");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("3");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("2");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("1");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = N;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("0");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            radioButton5.Checked = radioButton5.Checked;
            N = Calculator.Dec16(textBox1.Text);
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            radioButton4.Checked = radioButton4.Checked;
            N = Calculator.Dec9(textBox1.Text);
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioButton3.Checked = radioButton3.Checked;
            N = Calculator.Dec8(textBox1.Text);
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Checked = radioButton2.Checked;
            N = Calculator.Dec3(textBox1.Text);
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = radioButton1.Checked;
            N = Calculator.Dec2(textBox1.Text);
        }
    }
    class Calculator
    {
        private string Num { get; set; }
        public string Dec2(string num_1)
        {
            Num = num_1;
            int num = Convert.ToInt32(Num);
            string num_2 = Convert.ToString(num, 2);
            return num_2;
        }
        public string Dec8(string num_1)
        {
            Num = num_1;
            int num = Convert.ToInt32(Num);
            string num_2 = Convert.ToString(num, 8);
            return num_2;
        }
        public string Dec16(string num_1)
        {
            Num = num_1;
            int num = Convert.ToInt32(Num);
            string num_2 = Convert.ToString(num, 16);
            return num_2;
        }
        public string Dec3(string num_1)
        {
            Num = num_1;
            int num = Convert.ToInt32(Num);
            string num_2 = "";
            List<int> list = new List<int>();
            for (int i = 0; ; i++)
            {
                if (num > 0)
                {
                    int a = num % 3;
                    int b = num / 3;
                    num = b;
                    list.Add(a);
                }
                else
                {
                    break;
                }
            }
            list.Reverse();
            for (int i = 0; i < list.Count; i++)
            {
                num_2 += list[i].ToString();
            }
            return num_2;
        }
        public string Dec9(string num_1)
        {
            Num = num_1;
            int num = Convert.ToInt32(Num);
            string num_2 = "";
            List<int> list = new List<int>();
            for (int i = 0; ; i++)
            {
                if (num > 0)
                {
                    int a = num % 9;
                    int b = num / 9;
                    num = b;
                    list.Add(a);
                }
                else
                {
                    break;
                }
            }
            list.Reverse();
            for (int i = 0; i < list.Count; i++)
            {
                num_2 += list[i].ToString();
            }
            return num_2;
        }
    }
}