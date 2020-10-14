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
    public partial class FormSecondaria : Form
    {
        public string nome;
        public string età;
        public FormSecondaria()
        {
            InitializeComponent();
        }

        private void FormSecondaria_Load(object sender, EventArgs e)
        {
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            nome = txtNome.Text;
            età = txtEtà.Text;
            MessageBox.Show(nome+" - "+età);
        }
    }
}
