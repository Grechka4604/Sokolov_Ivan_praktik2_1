using System;
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
    public partial class Form7 : Form
    {
        public Form2 form2 = new Form2();
        public Form7()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            form2.Show();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

       

        private void Form7_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
