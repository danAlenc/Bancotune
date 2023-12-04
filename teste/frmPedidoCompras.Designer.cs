namespace teste
{
    partial class frmPedidoCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedidoCompras));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbEmpresaPedidoCompra = new System.Windows.Forms.TextBox();
            this.txtbPedidoCompra = new System.Windows.Forms.TextBox();
            this.txtbCoiPedidoCompra = new System.Windows.Forms.TextBox();
            this.dtPedidoCompra = new System.Windows.Forms.DateTimePicker();
            this.btnAlterarCoiPedidoCompras = new System.Windows.Forms.Button();
            this.btnAlterarDataPedidoCompras = new System.Windows.Forms.Button();
            this.btnSairPedidoCompras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pedido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID Operação (COI)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data Validade";
            // 
            // txtbEmpresaPedidoCompra
            // 
            this.txtbEmpresaPedidoCompra.Location = new System.Drawing.Point(114, 21);
            this.txtbEmpresaPedidoCompra.Name = "txtbEmpresaPedidoCompra";
            this.txtbEmpresaPedidoCompra.Size = new System.Drawing.Size(200, 20);
            this.txtbEmpresaPedidoCompra.TabIndex = 4;
            this.txtbEmpresaPedidoCompra.TextChanged += new System.EventHandler(this.txtbEmpresaPedidoCompra_TextChanged);
            // 
            // txtbPedidoCompra
            // 
            this.txtbPedidoCompra.Location = new System.Drawing.Point(114, 61);
            this.txtbPedidoCompra.Name = "txtbPedidoCompra";
            this.txtbPedidoCompra.Size = new System.Drawing.Size(200, 20);
            this.txtbPedidoCompra.TabIndex = 5;
            // 
            // txtbCoiPedidoCompra
            // 
            this.txtbCoiPedidoCompra.Location = new System.Drawing.Point(114, 101);
            this.txtbCoiPedidoCompra.Name = "txtbCoiPedidoCompra";
            this.txtbCoiPedidoCompra.Size = new System.Drawing.Size(200, 20);
            this.txtbCoiPedidoCompra.TabIndex = 6;
            // 
            // dtPedidoCompra
            // 
            this.dtPedidoCompra.CustomFormat = "yyyy/MM/dd";
            this.dtPedidoCompra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPedidoCompra.Location = new System.Drawing.Point(114, 168);
            this.dtPedidoCompra.Name = "dtPedidoCompra";
            this.dtPedidoCompra.Size = new System.Drawing.Size(97, 20);
            this.dtPedidoCompra.TabIndex = 7;
            // 
            // btnAlterarCoiPedidoCompras
            // 
            this.btnAlterarCoiPedidoCompras.Location = new System.Drawing.Point(11, 132);
            this.btnAlterarCoiPedidoCompras.Name = "btnAlterarCoiPedidoCompras";
            this.btnAlterarCoiPedidoCompras.Size = new System.Drawing.Size(303, 23);
            this.btnAlterarCoiPedidoCompras.TabIndex = 8;
            this.btnAlterarCoiPedidoCompras.Text = "Alterar COI";
            this.btnAlterarCoiPedidoCompras.UseVisualStyleBackColor = true;
            this.btnAlterarCoiPedidoCompras.Click += new System.EventHandler(this.btnAlterarCoiPedidoCompras_Click);
            // 
            // btnAlterarDataPedidoCompras
            // 
            this.btnAlterarDataPedidoCompras.Location = new System.Drawing.Point(9, 201);
            this.btnAlterarDataPedidoCompras.Name = "btnAlterarDataPedidoCompras";
            this.btnAlterarDataPedidoCompras.Size = new System.Drawing.Size(303, 23);
            this.btnAlterarDataPedidoCompras.TabIndex = 9;
            this.btnAlterarDataPedidoCompras.Text = "Alterar Data";
            this.btnAlterarDataPedidoCompras.UseVisualStyleBackColor = true;
            this.btnAlterarDataPedidoCompras.Click += new System.EventHandler(this.btnAlterarDataPedidoCompras_Click);
            // 
            // btnSairPedidoCompras
            // 
            this.btnSairPedidoCompras.Location = new System.Drawing.Point(9, 230);
            this.btnSairPedidoCompras.Name = "btnSairPedidoCompras";
            this.btnSairPedidoCompras.Size = new System.Drawing.Size(303, 23);
            this.btnSairPedidoCompras.TabIndex = 10;
            this.btnSairPedidoCompras.Text = "Sair";
            this.btnSairPedidoCompras.UseVisualStyleBackColor = true;
            this.btnSairPedidoCompras.Click += new System.EventHandler(this.btnSairPedidoCompras_Click);
            // 
            // frmPedidoCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 259);
            this.Controls.Add(this.btnSairPedidoCompras);
            this.Controls.Add(this.btnAlterarDataPedidoCompras);
            this.Controls.Add(this.btnAlterarCoiPedidoCompras);
            this.Controls.Add(this.dtPedidoCompra);
            this.Controls.Add(this.txtbCoiPedidoCompra);
            this.Controls.Add(this.txtbPedidoCompra);
            this.Controls.Add(this.txtbEmpresaPedidoCompra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPedidoCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Pedido compras: COI e Validade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbEmpresaPedidoCompra;
        private System.Windows.Forms.TextBox txtbPedidoCompra;
        private System.Windows.Forms.TextBox txtbCoiPedidoCompra;
        private System.Windows.Forms.DateTimePicker dtPedidoCompra;
        private System.Windows.Forms.Button btnAlterarCoiPedidoCompras;
        private System.Windows.Forms.Button btnAlterarDataPedidoCompras;
        private System.Windows.Forms.Button btnSairPedidoCompras;
    }
}