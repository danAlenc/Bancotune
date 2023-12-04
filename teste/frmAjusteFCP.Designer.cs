namespace teste
{
    partial class frmAjusteFCP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAjusteFCP));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbEmpresaFcp = new System.Windows.Forms.TextBox();
            this.txtbPlanilhaFcp = new System.Windows.Forms.TextBox();
            this.btnAjustarFcp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSairFpc = new System.Windows.Forms.Button();
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Planilha NF";
            // 
            // txtbEmpresaFcp
            // 
            this.txtbEmpresaFcp.Location = new System.Drawing.Point(79, 12);
            this.txtbEmpresaFcp.Name = "txtbEmpresaFcp";
            this.txtbEmpresaFcp.Size = new System.Drawing.Size(59, 20);
            this.txtbEmpresaFcp.TabIndex = 2;
            this.txtbEmpresaFcp.TextChanged += new System.EventHandler(this.txtbEmpresaFcp_TextChanged);
            // 
            // txtbPlanilhaFcp
            // 
            this.txtbPlanilhaFcp.Location = new System.Drawing.Point(79, 38);
            this.txtbPlanilhaFcp.Name = "txtbPlanilhaFcp";
            this.txtbPlanilhaFcp.Size = new System.Drawing.Size(172, 20);
            this.txtbPlanilhaFcp.TabIndex = 3;
            // 
            // btnAjustarFcp
            // 
            this.btnAjustarFcp.Location = new System.Drawing.Point(2, 77);
            this.btnAjustarFcp.Name = "btnAjustarFcp";
            this.btnAjustarFcp.Size = new System.Drawing.Size(381, 23);
            this.btnAjustarFcp.TabIndex = 4;
            this.btnAjustarFcp.Text = "Ajustar erro FCP";
            this.btnAjustarFcp.UseVisualStyleBackColor = true;
            this.btnAjustarFcp.Click += new System.EventHandler(this.btnAjustarFcp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(386, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Obs: Pegar o numero da PLANILHA no Monitor NF-e da nota que está com erro!";
            // 
            // btnSairFpc
            // 
            this.btnSairFpc.Location = new System.Drawing.Point(2, 106);
            this.btnSairFpc.Name = "btnSairFpc";
            this.btnSairFpc.Size = new System.Drawing.Size(381, 23);
            this.btnSairFpc.TabIndex = 6;
            this.btnSairFpc.Text = "Sair";
            this.btnSairFpc.UseVisualStyleBackColor = true;
            this.btnSairFpc.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmAjusteFCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 137);
            this.Controls.Add(this.btnSairFpc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAjustarFcp);
            this.Controls.Add(this.txtbPlanilhaFcp);
            this.Controls.Add(this.txtbEmpresaFcp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAjusteFCP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajuste FCP 2% Arredondamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbEmpresaFcp;
        private System.Windows.Forms.TextBox txtbPlanilhaFcp;
        private System.Windows.Forms.Button btnAjustarFcp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSairFpc;
    }
}