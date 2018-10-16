namespace ArchitecturePro.Forms.Servicos
{
    partial class frmMantemServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantemServico));
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.ckbAtivo = new System.Windows.Forms.CheckBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxUnidade = new System.Windows.Forms.ComboBox();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Controls.Add(this.btnSair);
            this.pnlBotoes.Controls.Add(this.btnSalvar);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotoes.Location = new System.Drawing.Point(0, 129);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(329, 77);
            this.pnlBotoes.TabIndex = 15;
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(179, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 77);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "&Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.Location = new System.Drawing.Point(254, 0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 77);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // ckbAtivo
            // 
            this.ckbAtivo.AutoSize = true;
            this.ckbAtivo.Location = new System.Drawing.Point(254, 64);
            this.ckbAtivo.Name = "ckbAtivo";
            this.ckbAtivo.Size = new System.Drawing.Size(50, 17);
            this.ckbAtivo.TabIndex = 14;
            this.ckbAtivo.Text = "Ativo";
            this.ckbAtivo.UseVisualStyleBackColor = true;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(12, 22);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(297, 20);
            this.txtDescricao.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Descrição";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(12, 61);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(236, 20);
            this.txtValor.TabIndex = 17;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Valor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Unidade";
            // 
            // cbxUnidade
            // 
            this.cbxUnidade.FormattingEnabled = true;
            this.cbxUnidade.Location = new System.Drawing.Point(12, 100);
            this.cbxUnidade.Name = "cbxUnidade";
            this.cbxUnidade.Size = new System.Drawing.Size(297, 21);
            this.cbxUnidade.TabIndex = 22;
            // 
            // frmMantemServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 206);
            this.ControlBox = false;
            this.Controls.Add(this.cbxUnidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.ckbAtivo);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMantemServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantem Serviço";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMantemServico_FormClosed);
            this.Load += new System.EventHandler(this.frmMantemServico_Load);
            this.pnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.CheckBox ckbAtivo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxUnidade;
    }
}