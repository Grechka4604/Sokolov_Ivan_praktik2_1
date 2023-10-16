using System;
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
    public partial class Form12 : Form
    {
        internal Form2 form2 = new Form2();
        internal Queue queue = new Queue();
        public Form12()
        {
            InitializeComponent();
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            form2.Show();
        }

        private void Form12_Load_1(object sender, EventArgs e)
        {
            this.textBox1.Text = queue.First().ToString();
            this.textBox2.Text = queue.Last().ToString();
            this.textBox1.ReadOnly = true;
            this.textBox2.ReadOnly = true;
        }

        private void Form12_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
