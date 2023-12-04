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
    public partial class frmValorArredondamentoValorItem : Form
    {
        public frmValorArredondamentoValorItem()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnSairProdArrendondamento_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtbEmpresaValorArredondamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAjustarValorProd_Click(object sender, EventArgs e)
        {
            if (VerificaDados1())
            {
                Processos p = new Processos();
                p.setEmpresaValorArredondamento(txtbEmpresaValorArredondamento.Text);
                p.setNfValorArredondamento(txtbNfValorArredondamento.Text);
                p.setPedidoArredondamento(txtbPedidoArredondamento.Text);
                p.setSerieValorArredondamento(txtSerieValorArredondamento.Text);
                p.setAutoValorArredondamento(txtbAutoValorArredondamento.Text);
                p.setCodProdValor(txtbCodProdValor.Text);
                p.setValorBruto(txtbValorBruto.Text);
                p.setValorLiquido(txtbValorLiquido.Text);

                p.CorrigirValor();
            }
            else
            {
                MessageBox.Show("Há campos em Branco, Verifique!");
            }
        }

        public bool VerificaDados1()
        {
            if (!string.IsNullOrEmpty(txtbEmpresaValorArredondamento.Text) && !string.IsNullOrEmpty(txtbNfValorArredondamento.Text) && !string.IsNullOrEmpty(txtbPedidoArredondamento.Text) && !string.IsNullOrEmpty(txtSerieValorArredondamento.Text) && !string.IsNullOrEmpty(txtbAutoValorArredondamento.Text) && !string.IsNullOrEmpty(txtbCodProdValor.Text) && !string.IsNullOrEmpty(txtbValorBruto.Text) && !string.IsNullOrEmpty(txtbValorLiquido.Text))
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (VerificaDados())
            {
                Processos p = new Processos();
                p.setEmpresaValorArredondamento(txtbEmpresaValorArredondamento.Text);
                p.setNfValorArredondamento(txtbNfValorArredondamento.Text);
                p.setPedidoArredondamento(txtbPedidoArredondamento.Text);
                p.setSerieValorArredondamento(txtSerieValorArredondamento.Text);
                p.setAutoValorArredondamento(txtbAutoValorArredondamento.Text);

                p.Arredondamento();
            }
            else
            {
                MessageBox.Show("Há campos em Branco, Verifique!");
            }
        }

        public bool VerificaDados()
        {
            if (!string.IsNullOrEmpty(txtbEmpresaValorArredondamento.Text) && !string.IsNullOrEmpty(txtbNfValorArredondamento.Text) && !string.IsNullOrEmpty(txtbPedidoArredondamento.Text) && !string.IsNullOrEmpty(txtSerieValorArredondamento.Text) && !string.IsNullOrEmpty(txtbAutoValorArredondamento.Text))
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

        private void btnRemoverXmlValorArredondamento_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente limpar os dados do XML na CONFERE_AUTORIZA?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (VerificaDados1())
                {
                    Processos p = new Processos();
                    p.setEmpresaValorArredondamento(txtbEmpresaValorArredondamento.Text);
                    p.setNfValorArredondamento(txtbNfValorArredondamento.Text);
                    p.setPedidoArredondamento(txtbPedidoArredondamento.Text);
                    p.setSerieValorArredondamento(txtSerieValorArredondamento.Text);
                    p.setAutoValorArredondamento(txtbAutoValorArredondamento.Text);
                    p.setCodProdValor(txtbCodProdValor.Text);
                    p.setValorBruto(txtbValorBruto.Text);
                    p.setValorLiquido(txtbValorLiquido.Text);

                    p.RemoverXml();
                }
                else
                {
                    MessageBox.Show("Os campos Empresa, NF, SERIE, PEDIDO e Autorização, todos devem ser preenchidos!!");
                }
            }

        }

        private void btnLimparvalorArredondamento_Click(object sender, EventArgs e)
        {
            txtbAutoValorArredondamento.Text = "";
            txtbCodProdValor.Text = "";
            txtbEmpresaValorArredondamento.Text = "";
            txtbNfValorArredondamento.Text = "";
            txtbPedidoArredondamento.Text = "";
            txtbValorBruto.Text = "";
            txtbValorLiquido.Text = "";
            txtSerieValorArredondamento.Text = "";

        }
    }
}
