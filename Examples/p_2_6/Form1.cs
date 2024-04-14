using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p_2_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double num1, num2, sum;

                num1 = double.Parse(textBox1.Text);
                num2 = Convert.ToDouble(textBox2.Text);
                sum = num1 + num2;

                label1.Text = sum.ToString();
            }
            catch (Exception ex) {
                label1.Text = ex.Message;
            }
        }
    }
}
