using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alertas
{
    public partial class Alertas : Form
    {
        public Alertas()
        {
            InitializeComponent();
        }

        private void btnAlertaSimples_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Essa é uma mensagem simples", "Com um titulo");
        }

        private void Alertas_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnAlertaRobusto_Click(object sender, EventArgs e)
        {
            DialogResult Resposta = MessageBox.Show("Vamos progromar um sistema?",
                                                     "Titulo aqui",  
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);
            if (Resposta == DialogResult.Yes)
            {


            }
            else if (Resposta == DialogResult.No)
            {

                MessageBox.Show("Respondeu que não");
            }
        }
    }
}
