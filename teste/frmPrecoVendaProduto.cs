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
    public partial class frmPrecoVendaProduto : Form
    {
        public frmPrecoVendaProduto()
        {
            InitializeComponent();
        }

        private void btnSairPrecoVenda_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtbEmpresaPrecoVenda_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAlterarPrecoVenda_Click(object sender, EventArgs e)
        {
            if (VerificaDados())
            {
                Processos p = new Processos();
                p.setEmpresaPrecoVenda(txtbEmpresaPrecoVenda.Text);
                p.setCodigoProdutoPrecoVenda(txtbCodigoProdutoPrecoVenda.Text);
                p.setPrecoVenda(txtbPrecoVenda.Text);

                p.Produto_Mudar_Preco();
            }
            else
            {
                MessageBox.Show("Há campos em branco, Verifique!");
            }

        }

        public bool VerificaDados()
        {
            if (!string.IsNullOrEmpty(txtbEmpresaPrecoVenda.Text) && !string.IsNullOrEmpty(txtbCodigoProdutoPrecoVenda.Text) && !string.IsNullOrEmpty(txtbPrecoVenda.Text))
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
