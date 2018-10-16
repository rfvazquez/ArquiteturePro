namespace ArchitecturePro.Forms.Projetos
{
    partial class frmAddDataPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddDataPagamento));
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.Location = new System.Drawing.Point(187, 0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 77);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Controls.Add(this.btnSair);
            this.pnlBotoes.Controls.Add(this.btnSalvar);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotoes.Location = new System.Drawing.Point(0, 61);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(262, 77);
            this.pnlBotoes.TabIndex = 41;
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(112, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 77);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "&Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(150, 25);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 48;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(147, 9);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 47;
            this.lblValor.Text = "Valor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Data";
            // 
            // dtData
            // 
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtData.Location = new System.Drawing.Point(12, 25);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(115, 20);
            this.dtData.TabIndex = 49;
            // 
            // frmAddDataPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 138);
            this.ControlBox = false;
            this.Controls.Add(this.dtData);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddDataPagamento";
            this.Text = "Data de Pagamento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddDataPagamento_FormClosed);
            this.Load += new System.EventHandler(this.frmAddDataPagamento_Load);
            this.pnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.Button btnSair;
    }
}