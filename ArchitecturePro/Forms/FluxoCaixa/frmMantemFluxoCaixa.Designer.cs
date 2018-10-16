namespace ArchitecturePro.Forms.FluxoCaixa
{
    partial class frmMantemFluxoCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantemFluxoCaixa));
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProjeto = new System.Windows.Forms.TextBox();
            this.btnBuscaProjeto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnBuscaDespesa = new System.Windows.Forms.Button();
            this.lblData = new System.Windows.Forms.Label();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Controls.Add(this.btnSair);
            this.pnlBotoes.Controls.Add(this.btnSalvar);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotoes.Location = new System.Drawing.Point(0, 145);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(329, 77);
            this.pnlBotoes.TabIndex = 16;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Projeto";
            // 
            // txtProjeto
            // 
            this.txtProjeto.Enabled = false;
            this.txtProjeto.Location = new System.Drawing.Point(16, 29);
            this.txtProjeto.Name = "txtProjeto";
            this.txtProjeto.Size = new System.Drawing.Size(267, 20);
            this.txtProjeto.TabIndex = 18;
            // 
            // btnBuscaProjeto
            // 
            this.btnBuscaProjeto.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaProjeto.Image")));
            this.btnBuscaProjeto.Location = new System.Drawing.Point(289, 27);
            this.btnBuscaProjeto.Name = "btnBuscaProjeto";
            this.btnBuscaProjeto.Size = new System.Drawing.Size(24, 23);
            this.btnBuscaProjeto.TabIndex = 19;
            this.btnBuscaProjeto.UseVisualStyleBackColor = true;
            this.btnBuscaProjeto.Click += new System.EventHandler(this.btnBuscaProjeto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Location = new System.Drawing.Point(16, 68);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(267, 20);
            this.txtDescricao.TabIndex = 21;
            this.txtDescricao.TextChanged += new System.EventHandler(this.txtDescricao_TextChanged);
            // 
            // btnBuscaDespesa
            // 
            this.btnBuscaDespesa.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaDespesa.Image")));
            this.btnBuscaDespesa.Location = new System.Drawing.Point(289, 65);
            this.btnBuscaDespesa.Name = "btnBuscaDespesa";
            this.btnBuscaDespesa.Size = new System.Drawing.Size(24, 23);
            this.btnBuscaDespesa.TabIndex = 22;
            this.btnBuscaDespesa.UseVisualStyleBackColor = true;
            this.btnBuscaDespesa.Click += new System.EventHandler(this.btnBuscaDespesa_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(13, 91);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 23;
            this.lblData.Text = "Data";
            // 
            // dtData
            // 
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtData.Location = new System.Drawing.Point(16, 107);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(117, 20);
            this.dtData.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(164, 107);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(119, 20);
            this.txtValor.TabIndex = 26;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // frmMantemFluxoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 222);
            this.ControlBox = false;
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.btnBuscaDespesa);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscaProjeto);
            this.Controls.Add(this.txtProjeto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlBotoes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMantemFluxoCaixa";
            this.Text = "Mantem Fluxo Caixa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMantemFluxoCaixa_FormClosed);
            this.Load += new System.EventHandler(this.frmMantemFluxoCaixa_Load);
            this.pnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProjeto;
        private System.Windows.Forms.Button btnBuscaProjeto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnBuscaDespesa;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValor;
    }
}