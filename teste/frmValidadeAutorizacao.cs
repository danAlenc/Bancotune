using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste
{
    public partial class frmValidadeAutorizacao : Form
    {
        public frmValidadeAutorizacao()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSairValidade_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtbAutorizacaoValidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAlterarValidade_Click(object sender, EventArgs e)
        {
            if (VerificaDados())
            {
                Processos p = new Processos();
                p.setAutorizacaoValidade(txtbAutorizacaoValidade.Text);
                p.setCodProdutoAutoValidade(txtbCodProdutoAutoValidade.Text);
                p.setdtaValidadeAuto(dtaValidadeAuto.Text);

                p.Alterar_Data_Validade();
            }
            else
            {
                MessageBox.Show("Há campos em branco, Verifique!");
            }
        }

        public bool VerificaDados()
        {
            if (!string.IsNullOrEmpty(txtbAutorizacaoValidade.Text) && !string.IsNullOrEmpty(txtbCodProdutoAutoValidade.Text) && !string.IsNullOrEmpty(dtaValidadeAuto.Text))
            {
                // MessageBox.Show("Campos de notas ok!!");
                return true;
            }
            else
            {
                // MessageBox.Show("Há algum campo de nota vazio");
                return false;
            }
        }
    }
}
