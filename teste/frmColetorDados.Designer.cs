namespace teste
{
    partial class frmColetorDados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmColetorDados));
            this.txtbIdColeta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbAvulso = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbVendas = new System.Windows.Forms.RadioButton();
            this.rdbBalanco = new System.Windows.Forms.RadioButton();
            this.btnAjusteColeta = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbIdColeta
            // 
            this.txtbIdColeta.Location = new System.Drawing.Point(69, 6);
            this.txtbIdColeta.Name = "txtbIdColeta";
            this.txtbIdColeta.Size = new System.Drawing.Size(100, 20);
            this.txtbIdColeta.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Coleta";
            // 
            // rdbAvulso
            // 
            this.rdbAvulso.AutoSize = true;
            this.rdbAvulso.Location = new System.Drawing.Point(15, 64);
            this.rdbAvulso.Name = "rdbAvulso";
            this.rdbAvulso.Size = new System.Drawing.Size(73, 17);
            this.rdbAvulso.TabIndex = 2;
            this.rdbAvulso.TabStop = true;
            this.rdbAvulso.Text = "Avulsa - A";
            this.rdbAvulso.UseVisualStyleBackColor = true;
            this.rdbAvulso.CheckedChanged += new System.EventHandler(this.rdbAvulso_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo Coleta";
            // 
            // rdbVendas
            // 
            this.rdbVendas.AutoSize = true;
            this.rdbVendas.Location = new System.Drawing.Point(96, 64);
            this.rdbVendas.Name = "rdbVendas";
            this.rdbVendas.Size = new System.Drawing.Size(97, 17);
            this.rdbVendas.TabIndex = 4;
            this.rdbVendas.TabStop = true;
            this.rdbVendas.Text = "Televendas - V";
            this.rdbVendas.UseVisualStyleBackColor = true;
            // 
            // rdbBalanco
            // 
            this.rdbBalanco.AutoSize = true;
            this.rdbBalanco.Location = new System.Drawing.Point(199, 64);
            this.rdbBalanco.Name = "rdbBalanco";
            this.rdbBalanco.Size = new System.Drawing.Size(80, 17);
            this.rdbBalanco.TabIndex = 5;
            this.rdbBalanco.TabStop = true;
            this.rdbBalanco.Text = "Balanço - B";
            this.rdbBalanco.UseVisualStyleBackColor = true;
            // 
            // btnAjusteColeta
            // 
            this.btnAjusteColeta.Location = new System.Drawing.Point(15, 87);
            this.btnAjusteColeta.Name = "btnAjusteColeta";
            this.btnAjusteColeta.Size = new System.Drawing.Size(264, 23);
            this.btnAjusteColeta.TabIndex = 6;
            this.btnAjusteColeta.Text = "Ajustar";
            this.btnAjusteColeta.UseVisualStyleBackColor = true;
            this.btnAjusteColeta.Click += new System.EventHandler(this.btnAjusteColeta_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(15, 116);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(264, 23);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmColetorDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 146);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAjusteColeta);
            this.Controls.Add(this.rdbBalanco);
            this.Controls.Add(this.rdbVendas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdbAvulso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbIdColeta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmColetorDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmColetorDados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbIdColeta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbAvulso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbVendas;
        private System.Windows.Forms.RadioButton rdbBalanco;
        private System.Windows.Forms.Button btnAjusteColeta;
        private System.Windows.Forms.Button btnSair;
    }
}