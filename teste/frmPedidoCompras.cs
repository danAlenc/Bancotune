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
    public partial class frmPedidoCompras : Form
    {
        public frmPedidoCompras()
        {
            InitializeComponent();
        }

        private void btnSairPedidoCompras_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtbEmpresaPedidoCompra_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAlterarCoiPedidoCompras_Click(object sender, EventArgs e)
        {
            if (VerificaDados())
            {
                Processos p = new Processos();
                p.setEmpresaPedidoCompra(txtbEmpresaPedidoCompra.Text);
                p.setCoiPedidoCompra(txtbCoiPedidoCompra.Text);
                p.setPedidoCompra(txtbPedidoCompra.Text);

                p.Pedido_Operacao();
            }
            else
            {
                MessageBox.Show("Há campos em branco, Verifique!");
            }
        }

        public bool VerificaDados()
        {
            if (!string.IsNullOrEmpty(txtbEmpresaPedidoCompra.Text) && !string.IsNullOrEmpty(txtbPedidoCompra.Text) && !string.IsNullOrEmpty(txtbCoiPedidoCompra.Text))
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
        public bool VerificaDados1()
        {
            if (!string.IsNullOrEmpty(txtbEmpresaPedidoCompra.Text) && !string.IsNullOrEmpty(txtbPedidoCompra.Text) && !string.IsNullOrEmpty(txtbCoiPedidoCompra.Text) && !string.IsNullOrEmpty(dtPedidoCompra.Text))
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

        private void btnAlterarDataPedidoCompras_Click(object sender, EventArgs e)
        {
            if (VerificaDados1())
            {
                Processos p = new Processos();
                p.setEmpresaPedidoCompra(txtbEmpresaPedidoCompra.Text);
                p.setCoiPedidoCompra(txtbCoiPedidoCompra.Text);
                p.setPedidoCompra(txtbPedidoCompra.Text);
                p.setdtPedidoCompra(dtPedidoCompra.Text);

                p.Pedido_DataValidade();
            }
            else
            {
                MessageBox.Show("Há campos em branco, Verifique!");
            }
        }
    }
}
