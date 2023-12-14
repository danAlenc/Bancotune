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
    public partial class frmMensagem : Form
    {
        public frmMensagem()
        {
            InitializeComponent();
        }

        private void btnMensagem_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void btnMensagem_Click(object sender, EventArgs e)
        {
            frmValorArredondamentoValorItem av = new frmValorArredondamentoValorItem();
            av.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnFcp_Click(object sender, EventArgs e)
        {
            frmAjusteFCP fcp = new frmAjusteFCP();
            fcp.ShowDialog();
        }

        private void btnErroPaf_Click(object sender, EventArgs e)
        {
            frmPaf paf = new frmPaf();
            paf.ShowDialog();
        }

        private void btnAltrarDataValidade_Click(object sender, EventArgs e)
        {
            frmValidadeAutorizacao autoValidade = new frmValidadeAutorizacao();
            autoValidade.ShowDialog();
        }

        private void btnTrocarItemOrcamento_Click(object sender, EventArgs e)
        {
            frmTrocarItemOrcamentoIfood ifood = new frmTrocarItemOrcamentoIfood();
            ifood.ShowDialog();
        }

        private void btnExcluirPdv_Click(object sender, EventArgs e)
        {
            frmPdv pdv = new frmPdv();
            pdv.ShowDialog();
        }

        private void btnPrecoVendaProduto_Click(object sender, EventArgs e)
        {
            frmPrecoVendaProduto pvp = new frmPrecoVendaProduto();
            pvp.ShowDialog();
        }

        private void btnDtMovCob_Click(object sender, EventArgs e)
        {
            frmDtMovContabilCOB dtmov = new frmDtMovContabilCOB();
            dtmov.ShowDialog();
        }

        private void btnPedidoCompras_Click(object sender, EventArgs e)
        {
            frmPedidoCompras pdc = new frmPedidoCompras();
            pdc.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmColetorDados cd = new frmColetorDados();
            cd.ShowDialog();
        }
    }
}
