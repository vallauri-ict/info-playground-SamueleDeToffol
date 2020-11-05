using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es06_Classe_Indexata
{
 
    public partial class Form1 : Form
    {
        MiaIndexClasse indexVect;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrea_Click(object sender, EventArgs e)
        {
            indexVect = new MiaIndexClasse(Convert.ToInt32(txtElementi.Text));
            for (int i = 0; i < Convert.ToInt32(txtElementi.Text)-1; i++)
            {
                indexVect[i] = i.ToString();
            }
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            string s = "";
            for (int i = 0; i <indexVect.length(); i++)
            {
                s += indexVect[i] + " - ";
            }
            MessageBox.Show(s);
        }
    }
}
