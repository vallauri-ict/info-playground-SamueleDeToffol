﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es09ProvaDictionary
{
    public partial class Form1 : Form
    {
        public struct Libro
        {
            public string titolo;
            public string autore;
        }
        public int i = 0;
        Dictionary<int, Libro> dictionaryLibri = new Dictionary<int, Libro>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCarica_Click(object sender, EventArgs e)
        {
            Libro l;
            l.titolo = txtTitolo.Text;
            l.autore = txtAutore.Text;
            if (!(String.IsNullOrWhiteSpace(l.titolo)||String.IsNullOrWhiteSpace(l.autore)))
            {
                dictionaryLibri.Add(i++, l);
                MessageBox.Show("Libro aggiunto");
                foreach (var textbox in this.Controls.OfType<TextBox>())
                {
                    textbox.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Inserire correttamente i dati");
            }
            
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            Libro ausiliare;
            foreach (int key in dictionaryLibri.Keys)
            {
                ausiliare = dictionaryLibri[key];
                MessageBox.Show("Titolo: "+ausiliare.titolo+"\nAutore: "+ausiliare.autore,key.ToString());
            }
        }
    }
}
