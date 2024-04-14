using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p_2_5
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
                sbyte num1;
                byte num2;
                int sum;

                // num1 = Convert.ToSByte(textBox1.Text);
                num1 = sbyte.Parse(textBox1.Text);
                num2 = 255;
                sum = num1 + num2;

                label1.Text = sum.ToString();
            }
            catch(Exception ex)
            {
                label1.Text = ex.Message;
            }
        }
    }
}
