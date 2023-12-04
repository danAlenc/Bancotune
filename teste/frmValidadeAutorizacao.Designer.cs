namespace teste
{
    partial class frmValidadeAutorizacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmValidadeAutorizacao));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbAutorizacaoValidade = new System.Windows.Forms.TextBox();
            this.txtbCodProdutoAutoValidade = new System.Windows.Forms.TextBox();
            this.dtaValidadeAuto = new System.Windows.Forms.DateTimePicker();
            this.btnAlterarValidade = new System.Windows.Forms.Button();
            this.btnSairValidade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Autorização";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nova data";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtbAutorizacaoValidade
            // 
            this.txtbAutorizacaoValidade.Location = new System.Drawing.Point(127, 16);
            this.txtbAutorizacaoValidade.Name = "txtbAutorizacaoValidade";
            this.txtbAutorizacaoValidade.Size = new System.Drawing.Size(145, 20);
            this.txtbAutorizacaoValidade.TabIndex = 3;
            this.txtbAutorizacaoValidade.TextChanged += new System.EventHandler(this.txtbAutorizacaoValidade_TextChanged);
            // 
            // txtbCodProdutoAutoValidade
            // 
            this.txtbCodProdutoAutoValidade.Location = new System.Drawing.Point(127, 43);
            this.txtbCodProdutoAutoValidade.Name = "txtbCodProdutoAutoValidade";
            this.txtbCodProdutoAutoValidade.Size = new System.Drawing.Size(145, 20);
            this.txtbCodProdutoAutoValidade.TabIndex = 4;
            // 
            // dtaValidadeAuto
            // 
            this.dtaValidadeAuto.CustomFormat = "yyyy/MM/dd";
            this.dtaValidadeAuto.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtaValidadeAuto.Location = new System.Drawing.Point(127, 82);
            this.dtaValidadeAuto.Name = "dtaValidadeAuto";
            this.dtaValidadeAuto.Size = new System.Drawing.Size(100, 20);
            this.dtaValidadeAuto.TabIndex = 6;
            // 
            // btnAlterarValidade
            // 
            this.btnAlterarValidade.Location = new System.Drawing.Point(12, 118);
            this.btnAlterarValidade.Name = "btnAlterarValidade";
            this.btnAlterarValidade.Size = new System.Drawing.Size(330, 23);
            this.btnAlterarValidade.TabIndex = 7;
            this.btnAlterarValidade.Text = "Alterar";
            this.btnAlterarValidade.UseVisualStyleBackColor = true;
            this.btnAlterarValidade.Click += new System.EventHandler(this.btnAlterarValidade_Click);
            // 
            // btnSairValidade
            // 
            this.btnSairValidade.Location = new System.Drawing.Point(12, 147);
            this.btnSairValidade.Name = "btnSairValidade";
            this.btnSairValidade.Size = new System.Drawing.Size(330, 23);
            this.btnSairValidade.TabIndex = 8;
            this.btnSairValidade.Text = "Sair";
            this.btnSairValidade.UseVisualStyleBackColor = true;
            this.btnSairValidade.Click += new System.EventHandler(this.btnSairValidade_Click);
            // 
            // frmValidadeAutorizacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 176);
            this.Controls.Add(this.btnSairValidade);
            this.Controls.Add(this.btnAlterarValidade);
            this.Controls.Add(this.dtaValidadeAuto);
            this.Controls.Add(this.txtbCodProdutoAutoValidade);
            this.Controls.Add(this.txtbAutorizacaoValidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmValidadeAutorizacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autorização - Alterar data Validade do Produto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbAutorizacaoValidade;
        private System.Windows.Forms.TextBox txtbCodProdutoAutoValidade;
        private System.Windows.Forms.DateTimePicker dtaValidadeAuto;
        private System.Windows.Forms.Button btnAlterarValidade;
        private System.Windows.Forms.Button btnSairValidade;
    }
}