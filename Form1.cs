using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_1110
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        /// <summary>
        /// O TryParse método é como a Parse método, exceto o TryParse método gerará uma exceção se a conversão falhar. 
        /// Ele elimina a necessidade de usar a identificação de exceções para testar um FormatException caso esse s seja 
        /// inválido e não possa ser analisado com êxito. MSDN
        /// </summary>

        public void ConversaoParse() { 
            try {
                //Conversão Parse
                int parse = Int32.Parse(txtNumero.Text);
                lblParse.Text = ("Parse: " + parse.ToString());
            } catch (FormatException e) { MessageBox.Show(e.Message + "\nDigite o primeiro número novamente!");
                txtNumero.Focus();
            }
        }

        public void ConversaoTryParse() {
            //Conversão TryParse
            int numero;
            bool result = Int32.TryParse(txtNumero2.Text, out numero);
            if (result) {
                lblTryParse.Text = ("TryParse: " + numero.ToString());
            }
            else {
                MessageBox.Show("Entrada Inválida!" + "\nDigite novamente");
            }            
        }

        private void btnConverter_Click(object sender, EventArgs e) {
            this.ConversaoParse();
            this.ConversaoTryParse();
        }

        private void txtLimpar_Click(object sender, EventArgs e) {
            txtNumero.Text = string.Empty;
            txtNumero2.Text = string.Empty;
            lblParse.Text = string.Empty;
            lblTryParse.Text = string.Empty;
            txtNumero.Focus();
        }

        private void txtNumero_keydown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                this.txtNumero2.Focus();
        }

        private void txtNumero2_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                this.ConversaoParse();
                this.ConversaoTryParse();
        }
    }
}
