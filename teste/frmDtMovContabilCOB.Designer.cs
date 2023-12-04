namespace teste
{
    partial class frmDtMovContabilCOB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDtMovContabilCOB));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbEmpresaDtMov = new System.Windows.Forms.TextBox();
            this.txtbPlanilhaDtMov = new System.Windows.Forms.TextBox();
            this.dtDataMov = new System.Windows.Forms.DateTimePicker();
            this.btnAlterarDtMov = new System.Windows.Forms.Button();
            this.btnSairDtMov = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Planilha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nova Data";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtbEmpresaDtMov
            // 
            this.txtbEmpresaDtMov.Location = new System.Drawing.Point(75, 22);
            this.txtbEmpresaDtMov.Name = "txtbEmpresaDtMov";
            this.txtbEmpresaDtMov.Size = new System.Drawing.Size(200, 20);
            this.txtbEmpresaDtMov.TabIndex = 3;
            this.txtbEmpresaDtMov.TextChanged += new System.EventHandler(this.txtbEmpresaDtMov_TextChanged);
            // 
            // txtbPlanilhaDtMov
            // 
            this.txtbPlanilhaDtMov.Location = new System.Drawing.Point(75, 47);
            this.txtbPlanilhaDtMov.Name = "txtbPlanilhaDtMov";
            this.txtbPlanilhaDtMov.Size = new System.Drawing.Size(200, 20);
            this.txtbPlanilhaDtMov.TabIndex = 4;
            // 
            // dtDataMov
            // 
            this.dtDataMov.CustomFormat = "yyyy/MM/dd";
            this.dtDataMov.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDataMov.Location = new System.Drawing.Point(75, 73);
            this.dtDataMov.Name = "dtDataMov";
            this.dtDataMov.Size = new System.Drawing.Size(97, 20);
            this.dtDataMov.TabIndex = 5;
            // 
            // btnAlterarDtMov
            // 
            this.btnAlterarDtMov.Location = new System.Drawing.Point(15, 99);
            this.btnAlterarDtMov.Name = "btnAlterarDtMov";
            this.btnAlterarDtMov.Size = new System.Drawing.Size(260, 23);
            this.btnAlterarDtMov.TabIndex = 6;
            this.btnAlterarDtMov.Text = "Alterar";
            this.btnAlterarDtMov.UseVisualStyleBackColor = true;
            this.btnAlterarDtMov.Click += new System.EventHandler(this.btnAlterarDtMov_Click);
            // 
            // btnSairDtMov
            // 
            this.btnSairDtMov.Location = new System.Drawing.Point(15, 128);
            this.btnSairDtMov.Name = "btnSairDtMov";
            this.btnSairDtMov.Size = new System.Drawing.Size(260, 23);
            this.btnSairDtMov.TabIndex = 7;
            this.btnSairDtMov.Text = "Sair";
            this.btnSairDtMov.UseVisualStyleBackColor = true;
            this.btnSairDtMov.Click += new System.EventHandler(this.btnSairDtMov_Click);
            // 
            // frmDtMovContabilCOB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 160);
            this.Controls.Add(this.btnSairDtMov);
            this.Controls.Add(this.btnAlterarDtMov);
            this.Controls.Add(this.dtDataMov);
            this.Controls.Add(this.txtbPlanilhaDtMov);
            this.Controls.Add(this.txtbEmpresaDtMov);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDtMovContabilCOB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Data Movimento Contabil - COB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbEmpresaDtMov;
        private System.Windows.Forms.TextBox txtbPlanilhaDtMov;
        private System.Windows.Forms.DateTimePicker dtDataMov;
        private System.Windows.Forms.Button btnAlterarDtMov;
        private System.Windows.Forms.Button btnSairDtMov;
    }
}