﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sokolov_Ivan_praktik2
{
    public partial class Form11 : Form
    {
        internal Form2 form2 = new Form2();
        internal Queue queue = new Queue();
        public Form11()
        {
            InitializeComponent();
        }

       
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            form2.Show();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form11_Load_1(object sender, EventArgs e)
        {
            this.Hide();
            form2.Show();
        }

        private void Form11_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
