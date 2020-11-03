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
    public partial class FormFiglia : Form
    {
        public string txtValue;
        private TextBox txtPadre;

        public string TxtValue
        {
            get => txtValue;
            set
            {
                txtValue = value;
                txtModificaFiglia.Text = txtValue;
            }
        }

        public FormFiglia(TextBox txtPadre)
        {
            InitializeComponent();
            this.txtPadre = txtPadre;
        }

        public FormFiglia()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        private void FormFiglia_Load(object sender, EventArgs e)
        {

        }
=======
        private void txtModificaFiglia_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModificaFiglia_Click(object sender, EventArgs e)
        {
            txtPadre.Text = txtModificaFiglia.Text;
            
        }
>>>>>>> 43d0e782bcd14206a9aa8608e00c620e0d93c9fe
    }
}
