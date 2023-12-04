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
    public partial class frmPaf : Form
    {
        public frmPaf()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtbEmpresaPaf_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (VerificaDados()) 
            {
                Processos p = new Processos();
                p.setPlanilhaPaf(txtbPlanilhaPaf.Text);
                p.setEmpresaPaf(txtbEmpresaPaf.Text);

                p.Ajuste_Paf();
            }
            else
            {
                MessageBox.Show("Há campos em branco, Verifique!");
            }

        }

        private void btnSairPaf_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        public bool VerificaDados()
        {
            if (!string.IsNullOrEmpty(txtbPlanilhaPaf.Text) && !string.IsNullOrEmpty(txtbEmpresaPaf.Text))
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
