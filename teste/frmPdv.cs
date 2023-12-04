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
    public partial class frmPdv : Form
    {
        public frmPdv()
        {
            InitializeComponent();
        }

        private void btnSairPdv_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtbEmpresaPdv_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExcluirPdv_Click(object sender, EventArgs e)
        {
            if (VerificaDados())
            {
                Processos p = new Processos();
                p.setSeriePdv(txtbSeriePdv.Text);
                p.setEmpresaPdv(txtbEmpresaPdv.Text);

                p.Excluir_Caixa();
            }
            else
            {
                MessageBox.Show("Há campos em branco, Verifique!");
            }
        }
        public bool VerificaDados()
        {
            if (!string.IsNullOrEmpty(txtbEmpresaPdv.Text) && !string.IsNullOrEmpty(txtbSeriePdv.Text))
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
