namespace teste
{
    partial class frmPrecoVendaProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrecoVendaProduto));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbEmpresaPrecoVenda = new System.Windows.Forms.TextBox();
            this.txtbCodigoProdutoPrecoVenda = new System.Windows.Forms.TextBox();
            this.txtbPrecoVenda = new System.Windows.Forms.TextBox();
            this.btnAlterarPrecoVenda = new System.Windows.Forms.Button();
            this.btnSairPrecoVenda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Preço Venda";
            // 
            // txtbEmpresaPrecoVenda
            // 
            this.txtbEmpresaPrecoVenda.Location = new System.Drawing.Point(91, 6);
            this.txtbEmpresaPrecoVenda.Name = "txtbEmpresaPrecoVenda";
            this.txtbEmpresaPrecoVenda.Size = new System.Drawing.Size(113, 20);
            this.txtbEmpresaPrecoVenda.TabIndex = 3;
            this.txtbEmpresaPrecoVenda.TextChanged += new System.EventHandler(this.txtbEmpresaPrecoVenda_TextChanged);
            // 
            // txtbCodigoProdutoPrecoVenda
            // 
            this.txtbCodigoProdutoPrecoVenda.Location = new System.Drawing.Point(91, 38);
            this.txtbCodigoProdutoPrecoVenda.Name = "txtbCodigoProdutoPrecoVenda";
            this.txtbCodigoProdutoPrecoVenda.Size = new System.Drawing.Size(113, 20);
            this.txtbCodigoProdutoPrecoVenda.TabIndex = 4;
            // 
            // txtbPrecoVenda
            // 
            this.txtbPrecoVenda.Location = new System.Drawing.Point(91, 73);
            this.txtbPrecoVenda.Name = "txtbPrecoVenda";
            this.txtbPrecoVenda.Size = new System.Drawing.Size(113, 20);
            this.txtbPrecoVenda.TabIndex = 5;
            // 
            // btnAlterarPrecoVenda
            // 
            this.btnAlterarPrecoVenda.Location = new System.Drawing.Point(5, 99);
            this.btnAlterarPrecoVenda.Name = "btnAlterarPrecoVenda";
            this.btnAlterarPrecoVenda.Size = new System.Drawing.Size(199, 23);
            this.btnAlterarPrecoVenda.TabIndex = 7;
            this.btnAlterarPrecoVenda.Text = "Alterar";
            this.btnAlterarPrecoVenda.UseVisualStyleBackColor = true;
            this.btnAlterarPrecoVenda.Click += new System.EventHandler(this.btnAlterarPrecoVenda_Click);
            // 
            // btnSairPrecoVenda
            // 
            this.btnSairPrecoVenda.Location = new System.Drawing.Point(6, 128);
            this.btnSairPrecoVenda.Name = "btnSairPrecoVenda";
            this.btnSairPrecoVenda.Size = new System.Drawing.Size(199, 23);
            this.btnSairPrecoVenda.TabIndex = 8;
            this.btnSairPrecoVenda.Text = "Sair";
            this.btnSairPrecoVenda.UseVisualStyleBackColor = true;
            this.btnSairPrecoVenda.Click += new System.EventHandler(this.btnSairPrecoVenda_Click);
            // 
            // frmPrecoVendaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 159);
            this.Controls.Add(this.btnSairPrecoVenda);
            this.Controls.Add(this.btnAlterarPrecoVenda);
            this.Controls.Add(this.txtbPrecoVenda);
            this.Controls.Add(this.txtbCodigoProdutoPrecoVenda);
            this.Controls.Add(this.txtbEmpresaPrecoVenda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrecoVendaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preço Venda Produto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbEmpresaPrecoVenda;
        private System.Windows.Forms.TextBox txtbCodigoProdutoPrecoVenda;
        private System.Windows.Forms.TextBox txtbPrecoVenda;
        private System.Windows.Forms.Button btnAlterarPrecoVenda;
        private System.Windows.Forms.Button btnSairPrecoVenda;
    }
}