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
    public partial class frmDtMovContabilCOB : Form
    {
        public frmDtMovContabilCOB()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSairDtMov_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtbEmpresaDtMov_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAlterarDtMov_Click(object sender, EventArgs e)
        {
            if (VerificaDados())
            {
                Processos p = new Processos();
                p.setEmpresaDtMov(txtbEmpresaDtMov.Text);
                p.setPlanilhaDtMov(txtbPlanilhaDtMov.Text);
                p.setdtDatamov(dtDataMov.Text);

                p.Data_Cobranca();
            }
            else
            {
                MessageBox.Show("Há campos em branco, Verifique!");
            }
        }

        public bool VerificaDados()
        {
            if (!string.IsNullOrEmpty(txtbEmpresaDtMov.Text) && !string.IsNullOrEmpty(txtbPlanilhaDtMov.Text) && !string.IsNullOrEmpty(dtDataMov.Text))
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
