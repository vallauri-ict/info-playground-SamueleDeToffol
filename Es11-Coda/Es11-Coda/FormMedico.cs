using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es11_Coda
{
    public partial class FormMedico : Form
    {
        public FormMedico()
        {
            InitializeComponent();
        }

        private void btnProssimoPaziente_Click(object sender, EventArgs e)
        {
            Form1.Paziente aus = new Form1.Paziente();
            foreach (var item in Form1.code.Values)
            {
                if (item.Count() != 0)
                {
                    aus = item.Dequeue();
                    break;
                }
            }
            if (aus.nome == null)//non trovo pazienti
            {
                MessageBox.Show("Non sono presenti pazienti");
            }
            else
            {
                MessageBox.Show(aus.nome + ": " + aus.eta + "\n" + aus.colore.ToUpper(), aus.nome);
            }
        }
    }
}
