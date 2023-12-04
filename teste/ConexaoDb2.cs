using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste
{
    internal class ConexaoDb2
    {
            private SqlConnection con = null;  // Variável para conexão

            private string servidor = "";  // Localização do servidor
            private string nomeDoBanco = "";  // Nome do banco de dados
            private string usuario = "";  // Nome do usuário
            private string senha = "";  // Senha do usuário

            public ConexaoDb2() { }

            public ConexaoDb2(string pServidor, string pNomeDoBanco, string pUsuario, string pSenha)
            {
                this.servidor = pServidor;
                this.nomeDoBanco = pNomeDoBanco;
                this.usuario = pUsuario;
                this.senha = pSenha;
            }

            /// <summary>
            /// Abre uma conexão com o banco
            /// </summary>
            /// <returns>SqlConnection</returns>
            public SqlConnection Conectar()
            {
                try
                {
                    // Driver do DB2
                    Type type = Type.GetType("");

                    // Local do banco, nome do banco, usuário e senha
                    string connectionString = $"";
                    con = new SqlConnection(connectionString);

                    con.Open();
                    //MessageBox.Show("Sucesso na conexão");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Erro na conexão");
                    MessageBox.Show(e.ToString());
                }

                return con;
            }

            /// <summary>
            /// Encerra a conexão corrente
            /// </summary>
            /// <returns>bool</returns>
            public bool FecharConexao()
            {
                try
                {
                    con.Close();
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                return false;
            }

            /// <summary>
            /// Obtém a conexão
            /// </summary>
            public SqlConnection GetCon()
            {
                return con;
            }

            /// <summary>
            /// Define a conexão
            /// </summary>
            public void SetCon(SqlConnection con)
            {
                this.con = con;
            }
    }
}


