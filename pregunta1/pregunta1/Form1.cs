using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pregunta1
{
    
    public partial class Form1 : Form
    {
        int num1, num2, num3;
        string mem1, mem2;
        
        public Form1()
        {
            InitializeComponent();
            num3 = 0;
            num2 = 0;
            num1 = 0;
            mem1 = mem2 = "";
        }
        private void button_numbers(object sender, EventArgs e)
        {
            
            num1 = num1 * 10 + (Int32.Parse(((Button)sender).Text));

            textBox1.Text = ""+(num1);
            
        }

        private void buttonborrar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
            label2.Text = "";
            num1 = 0;
            num2 = 0;
            mem2 = mem1 = "";
        }

        private void buttoneliminardig_Click(object sender, EventArgs e)
        {
            if(num1.ToString().Length == 1)
            {
                textBox1.Text = "";
                num1 = 0;
            } 
            else
            {
                num1 = Convert.ToInt32(num1.ToString().Substring(0, num1.ToString().Length - 1));
                textBox1.Text = "" + num1;
            }
            
            

        }

        private void buttonmulti_Click(object sender, EventArgs e)
        {
            string op = "*";
            if (label2.Text.Length != 0)
            {
                op = label2.Text.Substring(label2.Text.Length - 2, 1);
            }
            else
            {
                if (textBox1.Text == "") op = "";
            }

            switch (op)
            {
                case "+":
                    num2 = num2 + num1;
                    mem2 = "" + num2;
                    label2.Text += num1 + " * ";
                    num1 = 0;
                    textBox1.Text = "";
                    label1.Text = mem2;
                    break;


                case "*":
                    mem1 = "" + num1;
                    if (mem2 == "")
                    {
                        num2 = num1;
                        mem2 = "" + num2;
                    }
                    else
                    {
                        num2 = num2 * num1;
                        mem2 = "" + num2;
                    }
                    label2.Text += num1 + " * ";
                    num1 = 0;
                    textBox1.Text = "";
                    label1.Text = mem2;
                    break;

                case "-":
                    num2 = num2 - num1;
                    mem2 = "" + num2;
                    label2.Text += num1 + " * ";
                    num1 = 0;
                    textBox1.Text = "";
                    label1.Text = mem2;
                    break;

                case "/":
                    if (num1 == 0)
                    {
                        label1.Text = "NO EXISTE DIVISION ENTRE 0";
                        textBox1.Text = "";
                        label2.Text = "";
                        num1 = 0;
                        num2 = 0;

                    }
                    else
                    {
                        num2 = num2 / num1;
                        mem2 = "" + num2;
                        label2.Text += num1 + " * ";
                        num1 = 0;
                        textBox1.Text = "";
                        label1.Text = mem2;
                    }
                    break;

                default:
                    label1.Text = "";
                    break;
            }
        }

        private void buttondiv_Click(object sender, EventArgs e)
        {
            string op = "/";
            if (label2.Text.Length != 0)
            {
                op = label2.Text.Substring(label2.Text.Length - 2, 1);
            }
            else
            {
                if (textBox1.Text == "") op = "";
            }

            switch (op)
            {
                case "+":
                    num2 = num2 + num1;
                    mem2 = "" + num2;
                    label2.Text += num1 + " / ";
                    num1 = 0;
                    textBox1.Text = "";
                    label1.Text = mem2;
                    break;


                case "/":
                    mem1 = "" + num1;
                    if (mem2 == "")
                    {
                        num2 = num1;
                        mem2 = "" + num2;
                        label2.Text += num1 + " / ";
                        num1 = 0;
                        textBox1.Text = "";
                        label1.Text = mem2;
                    }
                    else
                    {
                        if(num1 == 0)
                        {
                            label1.Text = "NO EXISTE DIVISION ENTRE 0";
                            textBox1.Text = "";
                            label2.Text = "";
                            num1 = 0;
                            num2 = 0;

                        }
                        else
                        {
                            num2 = num2 / num1;
                            mem2 = "" + num2;
                            label2.Text += num1 + " / ";
                            num1 = 0;
                            textBox1.Text = "";
                            label1.Text = mem2;
                        }
                        
                    }
                    
                    break;

                case "-":
                    num2 = num2 - num1;
                    mem2 = "" + num2;
                    label2.Text += num1 + " / ";
                    num1 = 0;
                    textBox1.Text = "";
                    label1.Text = mem2;
                    break;

                case "*":
                    num2 = num2 * num1;
                    mem2 = "" + num2;
                    label2.Text += num1 + " / ";
                    num1 = 0;
                    textBox1.Text = "";
                    label1.Text = mem2;
                    break;

                default:
                    label1.Text = "";
                    break;
            }
        }

        private void buttonigual_Click(object sender, EventArgs e)
        {
            if (label2.Text.Length == 0)
            {
                label1.Text = "";
            }else
            {
                if (textBox1.Text.Length != 0)
                {
                    
                    string op = label2.Text.Substring(label2.Text.Length - 2, 1);
                    if(op == "+")
                    {
                        num2 = num2 + num1;
                        label2.Text += num1 + " = ";
                        num1 = 0;
                        textBox1.Text = "";
                        label1.Text = "" + num2;
                    }
                    if (op == "-")
                    {
                        num2 = num2 - num1;
                        label2.Text += num1 + " = ";
                        num1 = 0;
                        textBox1.Text = "";
                        label1.Text = "" + num2;
                    }
                    if (op == "*")
                    {
                        num2 = num2 * num1;
                        label2.Text += num1 + " = ";
                        num1 = 0;
                        textBox1.Text = "";
                        label1.Text = "" + num2;
                    }
                    if (op == "/")
                    {
                        
                        if (num1 == 0)
                           {
                            label1.Text = "NO EXISTE DIVISION ENTRE 0";
                            textBox1.Text = "";
                            label2.Text = "";
                            num1 = 0;
                            num2 = 0;
                        }
                        else
                        {
                            num2 = num2 / num1;
                            mem2 = "" + num2;
                            label2.Text += num1 + " / ";
                            num1 = 0;
                            textBox1.Text = "";
                            label1.Text = mem2;
                        }
                        
                    }

                }
                else
                {
                    label2.Text = label2.Text.Substring(0, label2.Text.Length - 2) + "=";
                    textBox1.Text = "";
                    num1 = 0;
                    num2 = 0;
                }
            }
        }

        private void buttonResta(object sender, EventArgs e)
        {
            
            string op="-";
            if (label2.Text.Length != 0)
            {
                op = label2.Text.Substring(label2.Text.Length - 2, 1);
            }
            else
            {
                if (textBox1.Text == "") op = "";
            }

            switch (op)
            {
                case "+":
                    num2 = num2 + num1;
                    mem2 = "" + num2;
                    label2.Text += num1 + " - ";
                    num1 = 0;
                    textBox1.Text = "";
                    label1.Text = mem2;
                    break;


                case "-":
                    mem1 = "" + num1;
                    if (mem2 == "")
                    {
                        num2 = num1;
                        mem2 = "" + num2;
                    }
                    else
                    {
                        num2 = num2 - num1;
                        mem2 = "" + num2;
                    }
                    label2.Text += num1 + " - ";
                    num1 = 0;
                    textBox1.Text = "";
                    label1.Text = mem2;
                    break;

                case "*":
                    num2 = num2 * num1;
                    mem2 = "" + num2;
                    label2.Text += num1 + " - ";
                    num1 = 0;
                    textBox1.Text = "";
                    label1.Text = mem2;
                    break;

                case "/":
                    if (num1 == 0)
                    {
                        label1.Text = "NO EXISTE DIVISION ENTRE 0";
                        textBox1.Text = "";
                        label2.Text = "";
                        num1 = 0;
                        num2 = 0;

                    }
                    else
                    {
                        num2 = num2 / num1;
                        mem2 = "" + num2;
                        label2.Text += num1 + " - ";
                        num1 = 0;
                        textBox1.Text = "";
                        label1.Text = mem2;
                    }
                    break;

                default:
                    label1.Text = "";
                    break;
            }
        }
            

        private void buttonSuma(object sender, EventArgs e)
        {
            string op = "+";
            if (label2.Text.Length != 0)
            {
                op = label2.Text.Substring(label2.Text.Length - 2, 1);
            }
            else
            {
                if (textBox1.Text == "") op = "";
            }

            switch (op)
            {
                case "-":
                    num2 = num2 - num1;
                    mem2 = "" + num2;
                    label2.Text += num1 + " + ";
                    num1 = 0;
                    textBox1.Text = "";
                    label1.Text = mem2;
                    break;


                case "+":
                    mem1 = "" + num1;
                    if (mem2 == "")
                    {
                        num2 = num1;
                        mem2 = "" + num2;
                    }
                    else
                    {
                        num2 = num2 + num1;
                        mem2 = "" + num2;
                    }
                    label2.Text += num1 + " + ";
                    num1 = 0;
                    textBox1.Text = "";
                    label1.Text = mem2;
                    break;

                case "*":
                    num2 = num2 * num1;
                    mem2 = "" + num2;
                    label2.Text += num1 + " + ";
                    num1 = 0;
                    textBox1.Text = "";
                    label1.Text = mem2;
                    break;

                case "/":
                    if (num1 == 0)
                    {
                        label1.Text = "NO EXISTE DIVISION ENTRE 0";
                        textBox1.Text = "";
                        label2.Text = "";
                        num1 = 0;
                        num2 = 0;

                    }
                    else
                    {
                        num2 = num2 / num1;
                        mem2 = "" + num2;
                        label2.Text += num1 + " + ";
                        num1 = 0;
                        textBox1.Text = "";
                        label1.Text = mem2;
                    }
                    break;

                default:
                    label1.Text = "";
                    break;
            }

        }

    }
}
