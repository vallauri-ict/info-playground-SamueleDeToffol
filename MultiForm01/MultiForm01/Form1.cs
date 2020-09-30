using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiForm01
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

        private void btnApriForm2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Text = "Form 2 da design";
            f2.Show();

            Form2 f2b = new Form2(10);
            f2b.Text = "Form 2 da design con parametro";
            f2b.Show();
        }


        private void btnApriForm2B_Click(object sender, EventArgs e)
        {
            Form f2b = new Form();
            f2b.Text = "Aperta form dinamica";
            f2b.Show();
        }

        private void btnPassaTxt_Click(object sender, EventArgs e)
        {

            Form2 f2b = new Form2(txtPassata);
            f2b.Text = "Form 2 passaggio di TextBox";
            f2b.Show();
        }
    }
}
