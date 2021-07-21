using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            r.Text = "The Result Is:" + Convert.ToString(Convert.ToDouble(num1.Text) * Convert.ToDouble(num2.Text));
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            r.Text = "The Result Is:" + Convert.ToString(Convert.ToDouble(num1.Text) + Convert.ToDouble(num2.Text));
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            r.Text = "The Result Is:" + Convert.ToString(Convert.ToDouble(num1.Text) - Convert.ToDouble(num2.Text));
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            r.Text ="The Result Is:"+ Convert.ToString(Convert.ToDouble(num1.Text) / Convert.ToDouble(num2.Text));
        }
    }
}
