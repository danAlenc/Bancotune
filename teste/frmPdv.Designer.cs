namespace teste
{
    partial class frmPdv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPdv));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbEmpresaPdv = new System.Windows.Forms.TextBox();
            this.txtbSeriePdv = new System.Windows.Forms.TextBox();
            this.btnExcluirPdv = new System.Windows.Forms.Button();
            this.btnSairPdv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número do caixa (Série)";
            // 
            // txtbEmpresaPdv
            // 
            this.txtbEmpresaPdv.Location = new System.Drawing.Point(124, 20);
            this.txtbEmpresaPdv.Name = "txtbEmpresaPdv";
            this.txtbEmpresaPdv.Size = new System.Drawing.Size(136, 20);
            this.txtbEmpresaPdv.TabIndex = 2;
            this.txtbEmpresaPdv.TextChanged += new System.EventHandler(this.txtbEmpresaPdv_TextChanged);
            // 
            // txtbSeriePdv
            // 
            this.txtbSeriePdv.Location = new System.Drawing.Point(124, 46);
            this.txtbSeriePdv.Name = "txtbSeriePdv";
            this.txtbSeriePdv.Size = new System.Drawing.Size(136, 20);
            this.txtbSeriePdv.TabIndex = 3;
            // 
            // btnExcluirPdv
            // 
            this.btnExcluirPdv.Location = new System.Drawing.Point(8, 72);
            this.btnExcluirPdv.Name = "btnExcluirPdv";
            this.btnExcluirPdv.Size = new System.Drawing.Size(252, 23);
            this.btnExcluirPdv.TabIndex = 4;
            this.btnExcluirPdv.Text = "Excluir";
            this.btnExcluirPdv.UseVisualStyleBackColor = true;
            this.btnExcluirPdv.Click += new System.EventHandler(this.btnExcluirPdv_Click);
            // 
            // btnSairPdv
            // 
            this.btnSairPdv.Location = new System.Drawing.Point(8, 101);
            this.btnSairPdv.Name = "btnSairPdv";
            this.btnSairPdv.Size = new System.Drawing.Size(252, 23);
            this.btnSairPdv.TabIndex = 5;
            this.btnSairPdv.Text = "Sair";
            this.btnSairPdv.UseVisualStyleBackColor = true;
            this.btnSairPdv.Click += new System.EventHandler(this.btnSairPdv_Click);
            // 
            // frmPdv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 130);
            this.Controls.Add(this.btnSairPdv);
            this.Controls.Add(this.btnExcluirPdv);
            this.Controls.Add(this.txtbSeriePdv);
            this.Controls.Add(this.txtbEmpresaPdv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPdv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liberar número caixa de PDV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbEmpresaPdv;
        private System.Windows.Forms.TextBox txtbSeriePdv;
        private System.Windows.Forms.Button btnExcluirPdv;
        private System.Windows.Forms.Button btnSairPdv;
    }
}