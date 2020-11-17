using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsRegistrazioneRegex
{
    public partial class Form1 : Form
    {
        const string fileName = "utenti.txt";
        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnRegistra_Click(object sender, EventArgs e)
        {
            bool valido = true;

            
            Regex regCognome = new Regex(@"^[A-Z]{1}[a-z]+$");
            controllaTxt(txtCognome, regCognome,ref valido);
        
            Regex regNome = regCognome;
            controllaTxt(txtNome, regNome, ref valido);
      
            Regex regIndirizzo = new Regex(@"^[A-Z]{1}[A-Za-z]+\s+[A-Za-z]+\s+[\d,A-Z,a-z]+$");
            controllaTxt(txtIndirizzo, regIndirizzo, ref valido);
     
            Regex regCitta = new Regex(@"^[A-Z]{1}[a-z]+$");
            controllaTxt(txtCitta, regCitta, ref valido);
       
            Regex regCap = new Regex(@"^\d{5}$");
            controllaTxt(txtCap, regCap, ref valido);
          
            Regex regMail = new Regex(@"^[A-Za-z,\-,_,.,\d]+@{1}[A-Za-z,\d]+\.+[A-Za-z]{2,4}$");
            controllaTxt(txtMail, regMail, ref valido);

            Regex regUser = new Regex(@"^[A-Za-z,\d,\-,_,.]+$");
            controllaTxt(txtUsername, regUser, ref valido);

            Regex regPassword = new Regex(@"^(?=.*\d)(?=.*[A-Z])(?=.*[a-z]).{8,20}$");
            controllaTxt(txtPassword, regPassword, ref valido);
            
            if (valido)
            {
                try
                {
                    Utente user = Utente.creaUtente(txtCognome.Text, txtNome.Text, txtIndirizzo.Text, txtCitta.Text, txtCap.Text, txtMail.Text, txtUsername.Text, txtPassword.Text);
                    InsiemeUtenti.AggiungiUtente(user, fileName);
                    MessageBox.Show("Utente creato correttamente");
                    foreach (var item in this.Controls.OfType<TextBox>())
                    {
                        item.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    txtUsername.BackColor = Color.Red;
                }
            }


   
        }

        private void controllaTxt(TextBox txt, Regex reg, ref bool valido)
        {
            if (String.IsNullOrWhiteSpace(txt.Text))
            {
                MessageBox.Show("Dato mancante in "+txt.Name);
                valido = false;
                txt.BackColor = (Color.Red);
            }
            else if (!reg.IsMatch(txt.Text))
            {
                MessageBox.Show("Dato inserito non valido in " + txt.Name);
                valido = false;
                txt.BackColor = (Color.Red);
            }
            else
            {
                txt.BackColor = Color.White;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
