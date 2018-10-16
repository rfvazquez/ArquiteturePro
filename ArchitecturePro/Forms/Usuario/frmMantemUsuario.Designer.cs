namespace ArchitecturePro.Forms.Usuario
{
    partial class frmMantemUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantemUsuario));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ckbAtivo = new System.Windows.Forms.CheckBox();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cblAcessos = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Usuário:";
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Location = new System.Drawing.Point(16, 30);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(297, 20);
            this.txtNomeUsuario.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(16, 70);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(297, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "E-Mail:";
            // 
            // ckbAtivo
            // 
            this.ckbAtivo.AutoSize = true;
            this.ckbAtivo.Location = new System.Drawing.Point(16, 96);
            this.ckbAtivo.Name = "ckbAtivo";
            this.ckbAtivo.Size = new System.Drawing.Size(50, 17);
            this.ckbAtivo.TabIndex = 4;
            this.ckbAtivo.Text = "Ativo";
            this.ckbAtivo.UseVisualStyleBackColor = true;
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Controls.Add(this.btnSair);
            this.pnlBotoes.Controls.Add(this.btnSalvar);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotoes.Location = new System.Drawing.Point(0, 235);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(325, 77);
            this.pnlBotoes.TabIndex = 5;
            this.pnlBotoes.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBotoes_Paint);
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(175, 0);
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
            this.btnSalvar.Location = new System.Drawing.Point(250, 0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 77);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cblAcessos
            // 
            this.cblAcessos.FormattingEnabled = true;
            this.cblAcessos.Location = new System.Drawing.Point(12, 135);
            this.cblAcessos.Name = "cblAcessos";
            this.cblAcessos.Size = new System.Drawing.Size(301, 94);
            this.cblAcessos.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Acessos:";
            // 
            // frmMantemUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(325, 312);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cblAcessos);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.ckbAtivo);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeUsuario);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMantemUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantem Usuário";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMantemUsuario_FormClosed);
            this.Load += new System.EventHandler(this.frmMantemUsuario_Load);
            this.pnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckbAtivo;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.CheckedListBox cblAcessos;
        private System.Windows.Forms.Label label3;
    }
}