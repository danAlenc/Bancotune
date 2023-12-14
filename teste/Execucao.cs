using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.Security.Cryptography;

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
                String sql = "update dba.confere_pedido set valtotbruto='" + obj.getValorBruto() + "'"
                    + ", valtotliquido= '" + obj.getValorLiquido() + "'"
                    + ", valunitbruto = valtotbruto/qtdproduto "
                    + " where idpedido ='" + obj.getPedidoArredondamento() + "'"
                    + " and idempresa ='" + obj.getEmpresaValorArredondamento() + "'"
                    + " and idsubproduto='" + obj.getCodProdValor() + "'";

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

        public void CorrigirValor_Confere_Nfe(Processos obj)
        {
            ConexaoDb2 conexao = new ConexaoDb2();
            SqlCommand cmd;

            try
            {
                conexao.Conectar();
                String sql = "update dba.confere_nfe set valtotbruto='" + obj.getValorBruto() + "'"
                    + " where idautorizacao='" + obj.getAutoValorArredondamento() + "'"
                    + " and idempresa ='" + obj.getEmpresaValorArredondamento() + "'"
                    + " and idsubproduto='" + obj.getCodProdValor() + "'";

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
                String sql = "update dba.confere_autoriza set dadosxml=null"
                    + " where idautorizacao ='" + obj.getAutoValorArredondamento() + "'"
                    + " and idempresa ='" + obj.getEmpresaValorArredondamento() + "'";

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
                String sql = "update dba.confere_pedido set valunitbruto=valtotliquido/qtdproduto "
                    + " where idpedido ='" + obj.getPedidoArredondamento() + "'"
                    + " and idempresa ='" + obj.getEmpresaValorArredondamento() + "'";

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
                String sql = "update dba.contabil_movimento  set dtmovimento='" + obj.getdtDataMov() + "'"
                    + " where idplanilha ='" + obj.getPlanilhaDtMov() + "'"
                    + " and idempresa ='" + obj.getEmpresaDtMov() + "'"
                    + " and origemmovimento = 'COB' or idplanilha ='" + obj.getPlanilhaDtMov() + "'"
                    + " and idempresa ='" + obj.getEmpresaDtMov() + "'"
                    + " and origemmovimento = 'SIT'";

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
                String sql = "update dba.pedido_compra  set idoperacao='" + obj.getCoiPedidoCompra() + "'"
                    + " where idempresa ='" + obj.getEmpresaPedidoCompra() + "'"
                    + " and idpedido ='" + obj.getPedidoCompra() + "'";

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
                String sql = "update dba.pedido_compra  set dtvalidadepedido='" + obj.getdtPedidoCompra() + "'"
                    + " where idempresa ='" + obj.getEmpresaPedidoCompra() + "'"
                    + " and idpedido ='" + obj.getPedidoCompra() + "'";

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
                String sql = "update dba.politica_preco_produto  set valprecovarejo='" + obj.getPrecoVenda() + "'"
                    + " where idempresa ='" + obj.getEmpresaPrecoVenda() + "'"
                    + " and idsubproduto ='" + obj.getCodigoProdutoPrecoVenda() + "'";

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
                String sql = "update dba.cadastro_caixa_venda set idcaixa= 999 where idempresa='" + obj.getEmpresaPdv() + "'"
                    + " and idcaixa ='" + obj.getSeriePdv() + "'";

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
                String sql = "update dba.estoque_analitico_st  set valfcepstretido = valbasefcepstretido * perfcepstretido /100"
                    + " where idempresa ='" + obj.getEmpresaFcp() + "'"
                    + " and idplanilha ='" + obj.getPlanilhaFcp() + "'";

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
                String sql = "update dba.estoque_analitico  set flagevidencia = 'F' "
                    + " where idempresa ='" + obj.getEmpresaPaf() + "'"
                    + " and flagevidencia= 'T' "
                    + " and idplanilha ='" + obj.getPlanilhaPaf() + "'";

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
                String sql = "update dba.orcamento_prod set idproduto = (select idproduto from dba.produto_grade where idsubproduto = '" + obj.getProdutoNovoOrcamento() + "') , idsubproduto = '" + obj.getProdutoNovoOrcamento() + "'"
                + " where idempresa ='" + obj.getEmpresaOrcamento() + "'"
                + " and idorcamento ='" + obj.getOrcamento() + "'"
                + " and idsubproduto ='" + obj.getProdutoAtualOrcamento() + "'";

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
                String sql = "update dba.confere_mercadoria_validade  set  dtvalidade= '" + obj.getdtaValidadeAuto() + "'"
                    + " where "
                    + " idautorizacao = '" + obj.getAutorizacaoValidade() + "'"
                    + " and idsubproduto ='" + obj.getCodProdutoAutoValidade() + "'";

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

        public void AjusteColetor(Processos obj)
        {
            ConexaoDb2 conexao = new ConexaoDb2();
            SqlCommand cmd;

            try
            {
                conexao.Conectar();
                String sql = "update dba.coleta_dados_externo set tipocoleta = '" + obj.getTipoColeta() + "'"
                    + " where idcoleta ='" + obj.getIdColeta() + "'";

                cmd = new SqlCommand(sql, conexao.GetCon());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Coleta alterada com Sucesso, Validar!");

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

