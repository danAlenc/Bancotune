namespace teste
{
    partial class frmPaf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaf));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbEmpresaPaf = new System.Windows.Forms.TextBox();
            this.txtbPlanilhaPaf = new System.Windows.Forms.TextBox();
            this.btnAjustarPaf = new System.Windows.Forms.Button();
            this.btnSairPaf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empresa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Planilha NF";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Obs: Ao lançar a nota, é apresentado um erro na gravação. ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(466, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nos detalhes deste erro é apresentado um SQL com a mensagem de PAF e o número da " +
    "Planilha";
            // 
            // txtbEmpresaPaf
            // 
            this.txtbEmpresaPaf.Location = new System.Drawing.Point(84, 16);
            this.txtbEmpresaPaf.Name = "txtbEmpresaPaf";
            this.txtbEmpresaPaf.Size = new System.Drawing.Size(65, 20);
            this.txtbEmpresaPaf.TabIndex = 4;
            this.txtbEmpresaPaf.TextChanged += new System.EventHandler(this.txtbEmpresaPaf_TextChanged);
            // 
            // txtbPlanilhaPaf
            // 
            this.txtbPlanilhaPaf.Location = new System.Drawing.Point(84, 42);
            this.txtbPlanilhaPaf.Name = "txtbPlanilhaPaf";
            this.txtbPlanilhaPaf.Size = new System.Drawing.Size(118, 20);
            this.txtbPlanilhaPaf.TabIndex = 5;
            // 
            // btnAjustarPaf
            // 
            this.btnAjustarPaf.Location = new System.Drawing.Point(7, 94);
            this.btnAjustarPaf.Name = "btnAjustarPaf";
            this.btnAjustarPaf.Size = new System.Drawing.Size(463, 23);
            this.btnAjustarPaf.TabIndex = 6;
            this.btnAjustarPaf.Text = "Ajustar erro PAF";
            this.btnAjustarPaf.UseVisualStyleBackColor = true;
            this.btnAjustarPaf.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSairPaf
            // 
            this.btnSairPaf.Location = new System.Drawing.Point(7, 123);
            this.btnSairPaf.Name = "btnSairPaf";
            this.btnSairPaf.Size = new System.Drawing.Size(463, 23);
            this.btnSairPaf.TabIndex = 7;
            this.btnSairPaf.Text = "Sair";
            this.btnSairPaf.UseVisualStyleBackColor = true;
            this.btnSairPaf.Click += new System.EventHandler(this.btnSairPaf_Click);
            // 
            // frmPaf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 153);
            this.Controls.Add(this.btnSairPaf);
            this.Controls.Add(this.btnAjustarPaf);
            this.Controls.Add(this.txtbPlanilhaPaf);
            this.Controls.Add(this.txtbEmpresaPaf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPaf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajuste erro PAF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbEmpresaPaf;
        private System.Windows.Forms.TextBox txtbPlanilhaPaf;
        private System.Windows.Forms.Button btnAjustarPaf;
        private System.Windows.Forms.Button btnSairPaf;
    }
}