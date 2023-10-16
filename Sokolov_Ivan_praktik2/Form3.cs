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
    public partial class Form3 : Form
    {
        public int a;
        internal Queue queue = new Queue();
        public Form2 form2 = new Form2();
        public Form3()
        {
            InitializeComponent();
        }

      

        private void button1_Click_1(object sender, EventArgs e)
        {
            int result = int.Parse(textBox1.Text);
            if (queue.IsFull)
            {
                this.Hide();
                Form4 form4 = new Form4();
                form4.form2 = this.form2;
                form4.ShowDialog();
            }
            else
            {
                queue.Enqueue(result);
                this.Hide();
                Form7 form7 = new Form7();
                form7.form2 = this.form2;
                form7.ShowDialog();

            }
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

