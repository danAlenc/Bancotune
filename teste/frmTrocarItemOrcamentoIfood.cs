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
    public partial class frmTrocarItemOrcamentoIfood : Form
    {
        public frmTrocarItemOrcamentoIfood()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSairOrcamento_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtbEmpresaOrcamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAlterarProdOrcamento_Click(object sender, EventArgs e)
        {
            if (VerificaDados()) 
            {
                Processos p = new Processos();
                p.setEmpresaOrcamento(txtbEmpresaOrcamento.Text);
                p.setOrcamento(txtbOrcamento.Text);
                p.setProdutoAtualOrcamento(txtbProdutoAtualOrcamento.Text);
                p.setProdutoNovoOrcamento(txtbProdutoNovoOrcamento.Text);

                p.Alterar_Item_Orcamento();
            }
            else
            {
                MessageBox.Show("Há campos em branco, Verifique!");
            }
        }

        public bool VerificaDados()
        {
            if (!string.IsNullOrEmpty(txtbEmpresaOrcamento.Text) && !string.IsNullOrEmpty(txtbOrcamento.Text) && !string.IsNullOrEmpty(txtbProdutoAtualOrcamento.Text) && !string.IsNullOrEmpty(txtbProdutoNovoOrcamento.Text))
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
