﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_3_different_uppercase_and_lowercase_characters
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number1, Number2, sum;

            number1 = int.Parse(textBox1.Text);
            Number2 = int.Parse(textBox2.Text);
            sum = number1 + Number2;

            label1.Text = sum.ToString();
        }
    }
}
