using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace teste
{
    internal class Execucao
    {

        public void CorrigirValor(Processos obj) 
        {
            ConexaoDb2 conexao = new ConexaoDb2();
            SqlCommand cmd;

            try
            {
                conexao.Conectar();
                String sql = "";

                cmd = new SqlCommand(sql, conexao.GetCon());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Correção Confere_Pedido do item com Sucesso!");

            }
            catch (SqlException sqle)
            {
                Console.WriteLine("Erro!");
                MessageBox.Show("SQL ERRO, Verifique: " + sqle);
            }
            finally
            {
                conexao.FecharConexao();
            }
            
        }

        public void CorrigirValor_Confere_Nfe(Processos obbj)
        {
            ConexaoDb2 conexao = new ConexaoDb2();
            SqlCommand cmd;

            try
            {
                conexao.Conectar();
                String sql = "";

                cmd = new SqlCommand(sql, conexao.GetCon());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Correção de Valor do item Confere_Nfe, com Sucesso!");

            }
            catch (SqlException sqle)
            {
                Console.WriteLine("Erro!");
                MessageBox.Show("SQL ERRO, Verifique: " + sqle);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        public void RemoverXml(Processos obj)
        {
            ConexaoDb2 conexao = new ConexaoDb2();
            SqlCommand cmd;

            try
            {
                conexao.Conectar();
                String sql = "";

                cmd = new SqlCommand(sql, conexao.GetCon());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Removido DadosXml do Confere_Autoriza!");

            }
            catch (SqlException sqle)
            {
                Console.WriteLine("Erro!");
                MessageBox.Show("SQL ERRO, Verifique: " + sqle);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        public void Arredondamento(Processos obj)
        {
            ConexaoDb2 conexao = new ConexaoDb2();
            SqlCommand cmd;

            try
            {
                conexao.Conectar();
                String sql = "";

                cmd = new SqlCommand(sql, conexao.GetCon());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Recalculado Valor unitario Confere_pedido, (Arredondamento)!");

            }
            catch (SqlException sqle)
            {
                Console.WriteLine("Erro!");
                MessageBox.Show("SQL ERRO, Verifique: " + sqle);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        public void Data_Cobranca(Processos obj)
        {
            ConexaoDb2 conexao = new ConexaoDb2();
            SqlCommand cmd;

            try
            {
                conexao.Conectar();
                String sql = "";

                cmd = new SqlCommand(sql, conexao.GetCon());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Movimento Alterada, Validar!");

            }
            catch (SqlException sqle)
            {
                Console.WriteLine("Erro!");
                MessageBox.Show("SQL ERRO, Verifique: " + sqle);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        public void Pedido_Operacao(Processos obj) 
        {
            ConexaoDb2 conexao = new ConexaoDb2();
            SqlCommand cmd;

            try
            {
                conexao.Conectar();
                String sql = "";

                cmd = new SqlCommand(sql, conexao.GetCon());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Operação do pedido Alterada, Validar!");

            }
            catch (SqlException sqle)
            {
                Console.WriteLine("Erro!");
                MessageBox.Show("SQL ERRO, Verifique: " + sqle);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        public void Pedido_DataValidade(Processos obj)
        {
            ConexaoDb2 conexao = new ConexaoDb2();
            SqlCommand cmd;

            try
            {
                conexao.Conectar();
                String sql = "";

                cmd = new SqlCommand(sql, conexao.GetCon());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data validade Alterada, Validar!");

            }
            catch (SqlException sqle)
            {
                Console.WriteLine("Erro!");
                MessageBox.Show("SQL ERRO, Verifique: " + sqle);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        public void Produto_Mudar_Preco(Processos obj)
        {
            ConexaoDb2 conexao = new ConexaoDb2();
            SqlCommand cmd;

            try
            {
                conexao.Conectar();
                String sql = "";

                cmd = new SqlCommand(sql, conexao.GetCon());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Preço do produto Alterado, Validar!");

            }
            catch (SqlException sqle)
            {
                Console.WriteLine("Erro!");
                MessageBox.Show("SQL ERRO, Verifique: " + sqle);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        public void Excluir_Serie_Caixa(Processos obj)
        {
            ConexaoDb2 conexao = new ConexaoDb2();
            SqlCommand cmd;

            try
            {
                conexao.Conectar();
                String sql = "";

                cmd = new SqlCommand(sql, conexao.GetCon());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Caixa excluido com Sucesso, Validar!");

            }
            catch (SqlException sqle)
            {
                Console.WriteLine("Erro!");
                MessageBox.Show("SQL ERRO, Verifique: " + sqle);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        public void Ajuste_Fcp(Processos obj)
        {
            ConexaoDb2 conexao = new ConexaoDb2();
            SqlCommand cmd;

            try
            {
                conexao.Conectar();
                String sql = "";

                cmd = new SqlCommand(sql, conexao.GetCon());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ajuste de Arredondamento OK, Validar!");

            }
            catch (SqlException sqle)
            {
                Console.WriteLine("Erro!");
                MessageBox.Show("SQL ERRO, Verifique: " + sqle);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        public void Ajuste_Paf(Processos obj)
        {
            ConexaoDb2 conexao = new ConexaoDb2();
            SqlCommand cmd;

            try
            {
                conexao.Conectar();
                String sql = "";

                cmd = new SqlCommand(sql, conexao.GetCon());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ajuste PAF OK, Validar!");

            }
            catch (SqlException sqle)
            {
                Console.WriteLine("Erro!");
                MessageBox.Show("SQL ERRO, Verifique: " + sqle);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        public void Alterar_Item_Orcamento(Processos obj)
        {
            ConexaoDb2 conexao = new ConexaoDb2();
            SqlCommand cmd;

            try
            {
                conexao.Conectar();
                String sql = "";

                cmd = new SqlCommand(sql, conexao.GetCon());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item alterado com sucesso, Validar!");

            }
            catch (SqlException sqle)
            {
                Console.WriteLine("Erro!");
                MessageBox.Show("SQL ERRO, Verifique: " + sqle);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        public void alterar_data_Validade(Processos obj)
        {
            ConexaoDb2 conexao = new ConexaoDb2();
            SqlCommand cmd;

            try
            {
                conexao.Conectar();
                String sql = "";

                cmd = new SqlCommand(sql, conexao.GetCon());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data alterada com Sucesso, Validar!");

            }
            catch (SqlException sqle)
            {
                Console.WriteLine("Erro!");
                MessageBox.Show("SQL ERRO, Verifique: " + sqle);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

    }
}
