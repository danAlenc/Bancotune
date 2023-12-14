using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;



namespace teste
{
    internal class Processos
    {
        private String EmpresaValorArredondamento;
        private String NfValorArredondamento;
        private String PedidoArredondamento;
        private String SerieValorArredondamento;
        private String AutoValorArredondamento;
        private String CodProdValor;
        private String ValorBruto;
        private String ValorLiquido;
        private String AutorizacaoValidade;
        private String CodProdutoAutoValidade;
        private String dtaValidadeAuto;
        private String ProdutoNovoOrcamento;
        private String ProdutoAtualOrcamento;
        private String Orcamento;
        private String EmpresaOrcamento;
        private String PrecoVenda;
        private String CodigoProdutoPrecoVenda;
        private String EmpresaPrecoVenda;
        private String CoiPedidoCompra;
        private String EmpresaPedidoCompra;
        private String PedidoCompra;
        private String dtPedidoCompra;
        private String SeriePdv;
        private String EmpresaPdv;
        private String PlanilhaPaf;
        private String EmpresaPaf;
        private String PlanilhaDtMov;
        private String EmpresaDtMov;
        private String dtDataMov;
        private String PlanilhaFcp;
        private String EmpresaFcp;
        private String IdColeta;
        private String TipoColeta;

        public String getEmpresaValorArredondamento()
        {
            return EmpresaValorArredondamento;
        }
        public void setEmpresaValorArredondamento(String EmpresaValorArredondamento)
        {
            this.EmpresaValorArredondamento = EmpresaValorArredondamento;
        }
        public String getNfValorArredondamento()
        {
            return NfValorArredondamento;
        }
        public void setNfValorArredondamento(String NfValorArredondamento)
        {
            this.NfValorArredondamento = NfValorArredondamento;
        }
        public String getPedidoArredondamento()
        {
            return PedidoArredondamento;
        }
        public void setPedidoArredondamento(String PedidoArredondamento)
        {
            this.PedidoArredondamento = PedidoArredondamento;
        }
        public String getSerieValorArredondamento()
        {
            return SerieValorArredondamento;
        }
        public void setSerieValorArredondamento(String SerieValorArredondamento)
        {
            this.SerieValorArredondamento = SerieValorArredondamento;
        }
        public String getAutoValorArredondamento()
        {
            return AutoValorArredondamento;
        }
        public void setAutoValorArredondamento(String AutoValorArredondamento)
        {
            this.AutoValorArredondamento = AutoValorArredondamento;
        }
        public String getCodProdValor()
        {
            return CodProdValor;
        }
        public void setCodProdValor(String CodProdValor)
        {
            this.CodProdValor = CodProdValor;
        }
        public String getValorBruto()
        {
            return ValorBruto;
        }
        public void setValorBruto(String ValorBruto)
        {
            this.ValorBruto = ValorBruto;
        }
        public String getValorLiquido()
        {
            return getValorLiquido();
        }
        public void setValorLiquido(String ValorLiquido)
        {
            this.ValorLiquido = ValorLiquido;
        }
        public String getAutorizacaoValidade()
        {
            return AutorizacaoValidade;
        }
        public void setAutorizacaoValidade(String AutorizacaoValidade)
        {
            this.AutorizacaoValidade = AutorizacaoValidade;
        }
        public String getCodProdutoAutoValidade()
        {
            return CodProdutoAutoValidade;
        }
        public void setCodProdutoAutoValidade(String CodProdutoAutoValidade)
        {
            this.CodProdutoAutoValidade = CodProdutoAutoValidade;
        }
        public String getProdutoNovoOrcamento()
        {
            return ProdutoNovoOrcamento;
        }
        public void setProdutoNovoOrcamento(String ProdutoNovoOrcamento)
        {
            this.ProdutoNovoOrcamento = ProdutoNovoOrcamento;
        }
        public String getProdutoAtualOrcamento()
        {
            return ProdutoAtualOrcamento;
        }
        public void setProdutoAtualOrcamento(String ProdutoAtualOrcamento)
        {
            this.ProdutoAtualOrcamento = ProdutoAtualOrcamento;
        }
        public String getOrcamento()
        {
            return Orcamento;
        }
        public void setOrcamento(String Orcamento)
        {
            this.Orcamento = Orcamento;
        }
        public String getEmpresaOrcamento()
        {
            return EmpresaOrcamento;
        }
        public void setEmpresaOrcamento(String EmpresaOrcamento)
        {
            this.EmpresaOrcamento = EmpresaOrcamento;
        }
        public String getPrecoVenda()
        {
            return PrecoVenda;
        }
        public void setPrecoVenda(String PrecoVenda)
        {
            this.PrecoVenda = PrecoVenda;
        }
        public String getCodigoProdutoPrecoVenda()
        {
            return CodigoProdutoPrecoVenda;
        }
        public void setCodigoProdutoPrecoVenda(String CodigoProdutoPrecoVenda)
        {
            this.CodigoProdutoPrecoVenda = CodigoProdutoPrecoVenda;
        }
        public String getEmpresaPrecoVenda()
        {
            return EmpresaPrecoVenda;
        }
        public void setEmpresaPrecoVenda(String EmpresaPrecoVenda)
        {
            this.EmpresaPrecoVenda = EmpresaPrecoVenda;
        }
        public String getCoiPedidoCompra()
        {
            return CoiPedidoCompra;
        }
        public void setCoiPedidoCompra(String CoiPedidoCompra)
        {
            this.CoiPedidoCompra = CoiPedidoCompra;
        }
        public String getEmpresaPedidoCompra()
        {
            return EmpresaPedidoCompra;
        }
        public void setEmpresaPedidoCompra(String EmpresaPedidoCompra)
        {
            this.EmpresaPedidoCompra = EmpresaPedidoCompra;
        }
        public String getPedidoCompra()
        {
            return PedidoCompra;
        }
        public void setPedidoCompra(String PedidoCompra)
        {
            this.PedidoCompra = PedidoCompra;
        }
        public String getSeriePdv()
        {
            return SeriePdv;
        }
        public void setSeriePdv(String SeriePdv)
        {
            this.SeriePdv = SeriePdv;
        }
        public String getEmpresaPdv()
        {
            return EmpresaPdv;
        }
        public void setEmpresaPdv(String EmpresaPdv)
        {
            this.EmpresaPdv = EmpresaPdv;
        }
        public String getPlanilhaPaf()
        {
            return PlanilhaPaf;
        }
        public void setPlanilhaPaf(String PlanilhaPaf)
        {
            this.PlanilhaPaf = PlanilhaPaf;
        }
        public String getEmpresaPaf()
        {
            return EmpresaPaf;
        }
        public void setEmpresaPaf(String EmpresaPaf)
        {
            this.EmpresaPaf = EmpresaPaf;
        }
        public String getPlanilhaDtMov()
        {
            return PlanilhaDtMov;
        }
        public void setPlanilhaDtMov(String PlanilhaDtMov)
        {
            this.PlanilhaDtMov = PlanilhaDtMov;
        }
        public String getEmpresaDtMov()
        {
            return EmpresaDtMov;
        }
        public void setEmpresaDtMov(String EmpresaDtMov)
        {
            this.EmpresaDtMov = EmpresaDtMov;
        }
        public String getPlanilhaFcp()
        {
            return PlanilhaFcp;
        }
        public void setPlanilhaFcp(String PlanilhaFcp)
        {
            this.PlanilhaFcp = PlanilhaFcp;
        }
        public String getEmpresaFcp()
        {
            return EmpresaFcp;
        }
        public void setEmpresafcp(String EmpresaFcp)
        {
            this.EmpresaFcp = EmpresaFcp;
        }
        public String getdtaValidadeAuto()
        {
            return dtaValidadeAuto;
        }
        public void setdtaValidadeAuto(String dtaValidadeAuto)
        {
            this.dtaValidadeAuto = dtaValidadeAuto;
        }
        public String getdtPedidoCompra()
        {
            return dtPedidoCompra;
        }
        public void setdtPedidoCompra(String dtPedidoCompra)
        {
            this.dtPedidoCompra = dtPedidoCompra;
        }
        public String getdtDataMov()
        {
            return dtDataMov;
        }
        public void setdtDatamov(String dtDataMov)
        {
            this.dtDataMov = dtDataMov;
        }
        public String getIdColeta()
        {
            return IdColeta;
        }

        public void setIdColeta(String IdColeta)
        {
            this.IdColeta = IdColeta;
        }

        public String getTipoColeta()
        {
            return TipoColeta;
        }
        public void setTipoColeta(String TipoColeta)
        {
            this.TipoColeta = TipoColeta;
        }

        public void CorrigirValor()
        {
            Execucao ex = new Execucao();
            ex.CorrigirValor(this);
        }

        public void CorrigirValor_Confere_Nfe()
        {
            Execucao ex = new Execucao();
            ex.CorrigirValor_Confere_Nfe(this);
        }

        public void RemoverXml()
        {
            Execucao ex = new Execucao();
            ex.RemoverXml(this);
        }
        public void Arredondamento()
        {
            Execucao ex = new Execucao();
            ex.Arredondamento(this);
        }
        public void Data_Cobranca()
        {
            Execucao ex = new Execucao();
            ex.Data_Cobranca(this);
        }
        public void Pedido_Operacao()
        {
            Execucao ex = new Execucao();
            ex.Pedido_Operacao(this);
        }
        public void Pedido_DataValidade()
        {
            Execucao ex = new Execucao();
            ex.Pedido_DataValidade(this);
        }
        public void Produto_Mudar_Preco()
        {
            Execucao ex = new Execucao();
            ex.Produto_Mudar_Preco(this);
        }
        public void Excluir_Caixa()
        {
            Execucao ex = new Execucao();
            ex.Excluir_Serie_Caixa(this);
        }
        public void Ajuste_Fcp()
        {
            Execucao ex = new Execucao();
            ex.Ajuste_Fcp(this);
        }
        public void Ajuste_Paf()
        {
            Execucao ex = new Execucao();
            ex.Ajuste_Paf(this);
        }
        public void Alterar_Item_Orcamento()
        {
            Execucao ex = new Execucao();
            ex.Alterar_Item_Orcamento(this);
        }
        public void Alterar_Data_Validade()
        {
            Execucao ex = new Execucao();
            ex.alterar_data_Validade(this);
        }
        public void AjusteColetor()
        {
            Execucao ex = new Execucao();
            ex.AjusteColetor(this);
        }

    }
}
