namespace teste
{
    partial class frmMensagem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMensagem));
            this.lblMensagem = new System.Windows.Forms.Label();
            this.btnAutorizacao = new System.Windows.Forms.Button();
            this.btnPedidoCompras = new System.Windows.Forms.Button();
            this.btnDtMovCob = new System.Windows.Forms.Button();
            this.btnPrecoVendaProduto = new System.Windows.Forms.Button();
            this.btnExcluirPdv = new System.Windows.Forms.Button();
            this.btnFcp = new System.Windows.Forms.Button();
            this.btnTrocarItemOrcamento = new System.Windows.Forms.Button();
            this.btnAltrarDataValidade = new System.Windows.Forms.Button();
            this.btnErroPaf = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(44, 39);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 44);
            this.lblMensagem.TabIndex = 0;
            // 
            // btnAutorizacao
            // 
            this.btnAutorizacao.Location = new System.Drawing.Point(12, 10);
            this.btnAutorizacao.Name = "btnAutorizacao";
            this.btnAutorizacao.Size = new System.Drawing.Size(474, 26);
            this.btnAutorizacao.TabIndex = 1;
            this.btnAutorizacao.Text = "Autorização, Arredondamentos, Valor item";
            this.btnAutorizacao.UseVisualStyleBackColor = true;
            this.btnAutorizacao.Click += new System.EventHandler(this.btnMensagem_Click);
            this.btnAutorizacao.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnMensagem_MouseClick);
            // 
            // btnPedidoCompras
            // 
            this.btnPedidoCompras.Location = new System.Drawing.Point(12, 42);
            this.btnPedidoCompras.Name = "btnPedidoCompras";
            this.btnPedidoCompras.Size = new System.Drawing.Size(474, 23);
            this.btnPedidoCompras.TabIndex = 2;
            this.btnPedidoCompras.Text = "Pedido Compras, operação, Validade Pedido";
            this.btnPedidoCompras.UseVisualStyleBackColor = true;
            this.btnPedidoCompras.Click += new System.EventHandler(this.btnPedidoCompras_Click);
            // 
            // btnDtMovCob
            // 
            this.btnDtMovCob.Location = new System.Drawing.Point(12, 71);
            this.btnDtMovCob.Name = "btnDtMovCob";
            this.btnDtMovCob.Size = new System.Drawing.Size(474, 23);
            this.btnDtMovCob.TabIndex = 3;
            this.btnDtMovCob.Text = "Data Mov.COB";
            this.btnDtMovCob.UseVisualStyleBackColor = true;
            this.btnDtMovCob.Click += new System.EventHandler(this.btnDtMovCob_Click);
            // 
            // btnPrecoVendaProduto
            // 
            this.btnPrecoVendaProduto.Location = new System.Drawing.Point(12, 100);
            this.btnPrecoVendaProduto.Name = "btnPrecoVendaProduto";
            this.btnPrecoVendaProduto.Size = new System.Drawing.Size(474, 23);
            this.btnPrecoVendaProduto.TabIndex = 4;
            this.btnPrecoVendaProduto.Text = "Preço venda produto";
            this.btnPrecoVendaProduto.UseVisualStyleBackColor = true;
            this.btnPrecoVendaProduto.Click += new System.EventHandler(this.btnPrecoVendaProduto_Click);
            // 
            // btnExcluirPdv
            // 
            this.btnExcluirPdv.Location = new System.Drawing.Point(12, 129);
            this.btnExcluirPdv.Name = "btnExcluirPdv";
            this.btnExcluirPdv.Size = new System.Drawing.Size(474, 23);
            this.btnExcluirPdv.TabIndex = 5;
            this.btnExcluirPdv.Text = "Liberar, Excluir Numero PDV";
            this.btnExcluirPdv.UseVisualStyleBackColor = true;
            this.btnExcluirPdv.Click += new System.EventHandler(this.btnExcluirPdv_Click);
            // 
            // btnFcp
            // 
            this.btnFcp.Location = new System.Drawing.Point(12, 306);
            this.btnFcp.Name = "btnFcp";
            this.btnFcp.Size = new System.Drawing.Size(474, 23);
            this.btnFcp.TabIndex = 6;
            this.btnFcp.Text = "Ajuste FCP";
            this.btnFcp.UseVisualStyleBackColor = true;
            this.btnFcp.Click += new System.EventHandler(this.btnFcp_Click);
            // 
            // btnTrocarItemOrcamento
            // 
            this.btnTrocarItemOrcamento.Location = new System.Drawing.Point(12, 333);
            this.btnTrocarItemOrcamento.Name = "btnTrocarItemOrcamento";
            this.btnTrocarItemOrcamento.Size = new System.Drawing.Size(474, 23);
            this.btnTrocarItemOrcamento.TabIndex = 7;
            this.btnTrocarItemOrcamento.Text = "Trocar item Orçamento";
            this.btnTrocarItemOrcamento.UseVisualStyleBackColor = true;
            this.btnTrocarItemOrcamento.Click += new System.EventHandler(this.btnTrocarItemOrcamento_Click);
            // 
            // btnAltrarDataValidade
            // 
            this.btnAltrarDataValidade.Location = new System.Drawing.Point(12, 361);
            this.btnAltrarDataValidade.Name = "btnAltrarDataValidade";
            this.btnAltrarDataValidade.Size = new System.Drawing.Size(474, 23);
            this.btnAltrarDataValidade.TabIndex = 8;
            this.btnAltrarDataValidade.Text = "Alterar Data Validade - Autorização";
            this.btnAltrarDataValidade.UseVisualStyleBackColor = true;
            this.btnAltrarDataValidade.Click += new System.EventHandler(this.btnAltrarDataValidade_Click);
            // 
            // btnErroPaf
            // 
            this.btnErroPaf.Location = new System.Drawing.Point(12, 388);
            this.btnErroPaf.Name = "btnErroPaf";
            this.btnErroPaf.Size = new System.Drawing.Size(474, 23);
            this.btnErroPaf.TabIndex = 9;
            this.btnErroPaf.Text = "Ajuste erro PAF";
            this.btnErroPaf.UseVisualStyleBackColor = true;
            this.btnErroPaf.Click += new System.EventHandler(this.btnErroPaf_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(205, 441);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(474, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Ajuste Coletor / Coleta Dados Externo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMensagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(498, 466);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnErroPaf);
            this.Controls.Add(this.btnAltrarDataValidade);
            this.Controls.Add(this.btnTrocarItemOrcamento);
            this.Controls.Add(this.btnFcp);
            this.Controls.Add(this.btnExcluirPdv);
            this.Controls.Add(this.btnPrecoVendaProduto);
            this.Controls.Add(this.btnDtMovCob);
            this.Controls.Add(this.btnPedidoCompras);
            this.Controls.Add(this.btnAutorizacao);
            this.Controls.Add(this.lblMensagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMensagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BancoTune CISS MBS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Button btnAutorizacao;
        private System.Windows.Forms.Button btnPedidoCompras;
        private System.Windows.Forms.Button btnDtMovCob;
        private System.Windows.Forms.Button btnPrecoVendaProduto;
        private System.Windows.Forms.Button btnExcluirPdv;
        private System.Windows.Forms.Button btnFcp;
        private System.Windows.Forms.Button btnTrocarItemOrcamento;
        private System.Windows.Forms.Button btnAltrarDataValidade;
        private System.Windows.Forms.Button btnErroPaf;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button button1;
    }
}

