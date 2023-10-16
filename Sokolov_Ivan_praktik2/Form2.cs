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
    public partial class Form2 : Form
    {
        public string text;
        public int a;
        Queue queue = new Queue();
        public Form2()
        {
            InitializeComponent();
        }

     

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.a = a;
            form3.queue = queue;
            form3.form2 = this;
            form3.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            if (queue.IsEmpty)
            {
                Form5 form5 = new Form5();
                form5.form2 = this;
                form5.ShowDialog();
            }
            else
            {
                queue.Dequeue();
                Form6 form6 = new Form6();
                form6.form2 = this;
                form6.ShowDialog();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            queue.Clear();
            form9.form2 = this;
            this.Hide();
            form9.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (queue.IsEmpty)
            {
                Form10 form10 = new Form10();
                form10.form2 = this;
                this.Hide();
                form10.ShowDialog();
            }
            else if (queue.Count == 1)
            {
                Form11 form11 = new Form11();
                form11.form2 = this;
                form11.queue = queue;
                this.Hide();
                form11.ShowDialog();

            }
            else
            {
                Form12 form12 = new Form12();
                form12.form2 = this;
                form12.queue = queue;
                this.Hide();
                form12.ShowDialog();
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.queue = queue;
            form8.form2 = this;
            this.Hide();
            form8.ShowDialog();
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            if ((a == 2) || (a == 1))
            {
                int result = Int32.Parse(text);
                queue.capacity = result;
                if (a == 2)
                {
                    queue.Creat_Random_Queue(result);
                }
                a = 0;
            }
        }

        private void Form2_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
