using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es10_Dictionary_negozio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct dizionario
        {
            //public int Key;
            public string nomeArt;
        }
        Dictionary<int, dizionario> diz = new Dictionary<int, dizionario>();
        int i = 0;
        private void btnInserisci_Click(object sender, EventArgs e)
        {
            dizionario d;
            d.nomeArt = textBox2.Text;
            diz.Add(Convert.ToInt32(textBox1.Text), d);
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            lblNum.Text = "Numero di elementi=" + diz.Count;
            /*foreach(dizionario d in diz.Values)
            {
                MessageBox.Show("Chiave: " + d.Key + " Nome articolo: " + d.nomeArt); ;
            }*/
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            lblArt.Text = "Articolo cercato: " + diz[Convert.ToInt32(textBox1.Text)];
        }
    }
}
