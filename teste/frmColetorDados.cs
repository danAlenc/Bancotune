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
    public partial class frmColetorDados : Form
    {
        public frmColetorDados()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void rdbAvulso_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAvulso.Checked)
            {
                Processos p = new Processos();

                rdbBalanco.Checked = false;
                rdbVendas.Checked = false;
                p.setTipoColeta("A");
            }
        }

        private void rdbBalanco_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBalanco.Checked)
            {
                Processos p = new Processos();

                rdbAvulso.Checked = false;
                rdbVendas.Checked = false;
                p.setTipoColeta("B");
            }
        }

        private void rdbVendas_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbVendas.Checked)
            {
                Processos p = new Processos();

                rdbAvulso.Checked = false;
                rdbBalanco.Checked = false;
                p.setTipoColeta("V");
            }
        }

        private void btnAjusteColeta_Click(object sender, EventArgs e)
        {

            if (VerificaDados())
            {
                Processos p = new Processos();

                try
                {
                    // Chame o método AjusteColetor da classe Processos
                    p.AjusteColetor();

                    MessageBox.Show("Ajuste do Coletor concluído com sucesso!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro!");
                    MessageBox.Show("Erro ao ajustar o Coletor: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Há campos em branco, Verifique!");
            }
        }
        public bool VerificaDados()
        {
            if (!string.IsNullOrEmpty(txtbIdColeta.Text))
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
