namespace ArchitecturePro.Forms.Projetos
{
    partial class frmAddItemPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddItemPedido));
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscaServico = new System.Windows.Forms.Button();
            this.txtServico = new System.Windows.Forms.TextBox();
            this.lblServico = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.Location = new System.Drawing.Point(264, 0);
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
            this.pnlBotoes.Location = new System.Drawing.Point(0, 109);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(339, 77);
            this.pnlBotoes.TabIndex = 33;
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(189, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 77);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "&Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(16, 72);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(100, 20);
            this.txtQtde.TabIndex = 38;
            this.txtQtde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtde_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Quantidade";
            // 
            // btnBuscaServico
            // 
            this.btnBuscaServico.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaServico.Image")));
            this.btnBuscaServico.Location = new System.Drawing.Point(303, 20);
            this.btnBuscaServico.Name = "btnBuscaServico";
            this.btnBuscaServico.Size = new System.Drawing.Size(24, 23);
            this.btnBuscaServico.TabIndex = 36;
            this.btnBuscaServico.UseVisualStyleBackColor = true;
            this.btnBuscaServico.Click += new System.EventHandler(this.btnBuscaServico_Click);
            // 
            // txtServico
            // 
            this.txtServico.Enabled = false;
            this.txtServico.Location = new System.Drawing.Point(16, 22);
            this.txtServico.Name = "txtServico";
            this.txtServico.Size = new System.Drawing.Size(281, 20);
            this.txtServico.TabIndex = 35;
            // 
            // lblServico
            // 
            this.lblServico.AutoSize = true;
            this.lblServico.Location = new System.Drawing.Point(13, 6);
            this.lblServico.Name = "lblServico";
            this.lblServico.Size = new System.Drawing.Size(43, 13);
            this.lblServico.TabIndex = 34;
            this.lblServico.Text = "Serviço";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(134, 56);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 39;
            this.lblValor.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(137, 72);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 40;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // frmAddItemPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 186);
            this.ControlBox = false;
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.txtQtde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscaServico);
            this.Controls.Add(this.txtServico);
            this.Controls.Add(this.lblServico);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddItemPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adiciona Item Pedido";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddItemPedido_FormClosed);
            this.Load += new System.EventHandler(this.frmAddItemPedido_Load);
            this.pnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscaServico;
        private System.Windows.Forms.TextBox txtServico;
        private System.Windows.Forms.Label lblServico;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
    }
}