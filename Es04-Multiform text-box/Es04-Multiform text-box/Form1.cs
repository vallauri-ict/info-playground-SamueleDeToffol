using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es04_Multiform_text_box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Form f1 = new Form1();
            //f1.Text = "Form iniziale";
            //f1.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormExit();
            f.Text = "Uscire?";
            if (f.ShowDialog() == DialogResult.Yes)
            {
                Close();
            }
        }

        private void newSecondariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSecondaria fsec = new FormSecondaria();
            //fsec.Show();
            if (fsec.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("Operazione annullata");
            }
            else
            {
                txtNomePrinc.Text = fsec.nome;
                txtEtàPrinc.Text = fsec.età;
            }
            
        }

        private void newFigliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFiglia ffig = new FormFiglia();

        }
    }
}
