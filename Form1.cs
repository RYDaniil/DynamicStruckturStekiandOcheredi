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
        }
        private bool Flag = false;

        private void button1_Click(object sender, EventArgs e)
        {
            var chisla = new Stack<double>();
            string str;
            str = textBox1.Text;
            var list = str.Split(' ');
            for (int i = 0; i < list.Length; i++)
            {
                if ((list[i] == "+") || (list[i] == "-") || (list[i] == "*") || (list[i] == "/"))
                {
                    var num2 = chisla.Get_and_Remove();
                    var num1 = chisla.Get_and_Remove();
                    switch (list[i])
                    {
                        case "+":
                            chisla.Add(num1 + num2);
                            break;
                        case "-":
                            chisla.Add(num1 - num2);
                            break;
                        case "*":
                            chisla.Add(num1 * num2);
                            break;
                        case "/":
                            chisla.Add(1.0 * (num1 / num2));
                            break;
                    }

                }
                else
                {
                    chisla.Add(double.Parse(list[i]));
                }
            }
            textBox1.Text = Convert.ToString(chisla.Get());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

