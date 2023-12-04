namespace teste
{
    partial class frmTrocarItemOrcamentoIfood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrocarItemOrcamentoIfood));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbEmpresaOrcamento = new System.Windows.Forms.TextBox();
            this.txtbOrcamento = new System.Windows.Forms.TextBox();
            this.txtbProdutoAtualOrcamento = new System.Windows.Forms.TextBox();
            this.txtbProdutoNovoOrcamento = new System.Windows.Forms.TextBox();
            this.btnAlterarProdOrcamento = new System.Windows.Forms.Button();
            this.btnSairOrcamento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empresa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nro Orçamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cod. Produto Atual";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cod. Produto Novo";
            // 
            // txtbEmpresaOrcamento
            // 
            this.txtbEmpresaOrcamento.Location = new System.Drawing.Point(115, 12);
            this.txtbEmpresaOrcamento.Name = "txtbEmpresaOrcamento";
            this.txtbEmpresaOrcamento.Size = new System.Drawing.Size(156, 20);
            this.txtbEmpresaOrcamento.TabIndex = 4;
            this.txtbEmpresaOrcamento.TextChanged += new System.EventHandler(this.txtbEmpresaOrcamento_TextChanged);
            // 
            // txtbOrcamento
            // 
            this.txtbOrcamento.Location = new System.Drawing.Point(115, 38);
            this.txtbOrcamento.Name = "txtbOrcamento";
            this.txtbOrcamento.Size = new System.Drawing.Size(156, 20);
            this.txtbOrcamento.TabIndex = 5;
            // 
            // txtbProdutoAtualOrcamento
            // 
            this.txtbProdutoAtualOrcamento.Location = new System.Drawing.Point(115, 64);
            this.txtbProdutoAtualOrcamento.Name = "txtbProdutoAtualOrcamento";
            this.txtbProdutoAtualOrcamento.Size = new System.Drawing.Size(156, 20);
            this.txtbProdutoAtualOrcamento.TabIndex = 6;
            // 
            // txtbProdutoNovoOrcamento
            // 
            this.txtbProdutoNovoOrcamento.Location = new System.Drawing.Point(115, 90);
            this.txtbProdutoNovoOrcamento.Name = "txtbProdutoNovoOrcamento";
            this.txtbProdutoNovoOrcamento.Size = new System.Drawing.Size(156, 20);
            this.txtbProdutoNovoOrcamento.TabIndex = 7;
            // 
            // btnAlterarProdOrcamento
            // 
            this.btnAlterarProdOrcamento.Location = new System.Drawing.Point(15, 116);
            this.btnAlterarProdOrcamento.Name = "btnAlterarProdOrcamento";
            this.btnAlterarProdOrcamento.Size = new System.Drawing.Size(256, 23);
            this.btnAlterarProdOrcamento.TabIndex = 8;
            this.btnAlterarProdOrcamento.Text = "Alterar";
            this.btnAlterarProdOrcamento.UseVisualStyleBackColor = true;
            this.btnAlterarProdOrcamento.Click += new System.EventHandler(this.btnAlterarProdOrcamento_Click);
            // 
            // btnSairOrcamento
            // 
            this.btnSairOrcamento.Location = new System.Drawing.Point(15, 145);
            this.btnSairOrcamento.Name = "btnSairOrcamento";
            this.btnSairOrcamento.Size = new System.Drawing.Size(256, 23);
            this.btnSairOrcamento.TabIndex = 9;
            this.btnSairOrcamento.Text = "Sair";
            this.btnSairOrcamento.UseVisualStyleBackColor = true;
            this.btnSairOrcamento.Click += new System.EventHandler(this.btnSairOrcamento_Click);
            // 
            // frmTrocarItemOrcamentoIfood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 174);
            this.Controls.Add(this.btnSairOrcamento);
            this.Controls.Add(this.btnAlterarProdOrcamento);
            this.Controls.Add(this.txtbProdutoNovoOrcamento);
            this.Controls.Add(this.txtbProdutoAtualOrcamento);
            this.Controls.Add(this.txtbOrcamento);
            this.Controls.Add(this.txtbEmpresaOrcamento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmTrocarItemOrcamentoIfood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar item Orçamento Ifood";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbEmpresaOrcamento;
        private System.Windows.Forms.TextBox txtbOrcamento;
        private System.Windows.Forms.TextBox txtbProdutoAtualOrcamento;
        private System.Windows.Forms.TextBox txtbProdutoNovoOrcamento;
        private System.Windows.Forms.Button btnAlterarProdOrcamento;
        private System.Windows.Forms.Button btnSairOrcamento;
    }
}