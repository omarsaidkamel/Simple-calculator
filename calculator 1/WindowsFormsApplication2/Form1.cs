using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        int num1, num2, Result;
        char op;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name.Text += "1";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
                    }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click_1(object sender, EventArgs e)
        {

        }

        private void button16_Click_1(object sender, EventArgs e)
        {

        }

        private void button18_Click_1(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
        num1 =Convert.ToInt32(name.Text);
        op = '/';
        name.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            name.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            name.Text += "4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            name.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
        num1 = Convert.ToInt32(name.Text);
        op = '-';
        name.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            name.Text += "2";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            name.Text += "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            name.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            name.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            name.Text += "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            name.Text += "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            name.Text += "0";
        }

        private void button13_Click(object sender, EventArgs e)
        { 
        num1 = Convert.ToInt32(name.Text);
        op = '+';
            name.Clear();
        }

        private void button16_Click_2(object sender, EventArgs e)
        {
        num1 = Convert.ToInt32(name.Text);
        op = '*';
        name.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            name.Text += ",";
        }

        private void button17_Click_2(object sender, EventArgs e)
        {
            num2 = Convert.ToInt32(name.Text);
            switch (op) 
            { case '+':
                    Result = num1 + num2;
                    break;
              case '/':
                    Result = num1 / num2;
                    break;
              case '*':
                    Result = num1 * num2;
                    break;
              case '-':
                    Result = num1 - num2;
                    break;
            }  
            name.Text = Convert.ToString(Result);
        }
    }
}
