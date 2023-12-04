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
    public partial class frmAjusteFCP : Form
    {
        public frmAjusteFCP()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtbEmpresaFcp_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAjustarFcp_Click(object sender, EventArgs e)
        {
            if (VerificaDados()) 
            {
                Processos p = new Processos();
                p.setPlanilhaFcp(txtbPlanilhaFcp.Text);
                p.setEmpresafcp(txtbEmpresaFcp.Text);

                p.Ajuste_Fcp();

            }
            else
            {
                MessageBox.Show("Há campos em Branco, Verifique!");
            }
        }
        public bool VerificaDados()
        {
            if (!string.IsNullOrEmpty(txtbPlanilhaFcp.Text) && !string.IsNullOrEmpty(txtbEmpresaFcp.Text))
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