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
    public partial class Form8 : Form
    {
        internal Queue queue = new Queue();
        public Form2 form2 = new Form2();

        public int[] data;
        public Form8()
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

        private void Form8_Load_1(object sender, EventArgs e)
        {
            data = queue.Full_write();
            for (int i = 0; i < queue.Count; i++)
            {
                this.textBox1.Text += Convert.ToString(data[i]) + ' ';
            }
            this.textBox1.Multiline = true;
            this.textBox1.MinimumSize = new Size(400, 200);
            this.textBox1.MaximumSize = new Size(400, 200);
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = ScrollBars.Vertical;
        }

        private void Form8_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
