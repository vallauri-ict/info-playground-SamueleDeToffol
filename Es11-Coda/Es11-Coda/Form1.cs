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
    public partial class Form1 : Form
    {
        public static Dictionary<string, Queue<Paziente>> code = new Dictionary<string, Queue<Paziente>>();
        public struct Paziente
        {
            public string nome;
            public int eta;
            public string colore;
        }
        public Queue<Paziente> Rosso = new Queue<Paziente>();
        public Queue<Paziente> Giallo = new Queue<Paziente>();
        public Queue<Paziente> Verde = new Queue<Paziente>();
        public Queue<Paziente> Bianco = new Queue<Paziente>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormMedico fm = new FormMedico();
            fm.Show();
            code.Add("rosso", Rosso);
            code.Add("giallo", Giallo);
            code.Add("verde", Verde);
            code.Add("bianco", Bianco);
        }

        private void btnInserisciPaziente_Click_1(object sender, EventArgs e)
        {
            bool errore = false;
            foreach (var item in Controls.OfType<TextBox>())
            {
                if (String.IsNullOrWhiteSpace(item.Text))
                {
                    errore = true;
                }
            }
            if (!errore)
            {
                if (cmbColore.SelectedIndex == -1)
                {
                    errore = true;
                }
                else
                {
                    Paziente p;
                    p.nome = txtCognome.Text + " " + txtNome.Text;
                    p.eta = Convert.ToInt32(numEta.Value);
                    p.colore = cmbColore.SelectedItem.ToString();
                    code[p.colore.ToLower()].Enqueue(p);
                    MessageBox.Show("Paziente inserito");
                    foreach (var item in Controls.OfType<TextBox>())
                    {
                        item.Text = "";
                    }
                    numEta.Value = 0;
                    cmbColore.SelectedIndex = -1;
                }
            }
            if (errore)
            {
                MessageBox.Show("Inserire correttamente i dati");
            }
        }
    }
}

