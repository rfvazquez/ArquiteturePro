namespace ArchitecturePro.Forms.Configuracoes
{
    partial class frmConfiguracoesEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracoesEmpresa));
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tabDadosCliente = new System.Windows.Forms.TabControl();
            this.dadosEmpresa = new System.Windows.Forms.TabPage();
            this.txtSenhaEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.MaskedTextBox();
            this.txtTelCelular = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.EnderecoEmpresa = new System.Windows.Forms.TabPage();
            this.btnBuscaEndereco = new System.Windows.Forms.Button();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pagSeguro = new System.Windows.Forms.TabPage();
            this.ckbTestePagSeguro = new System.Windows.Forms.CheckBox();
            this.txtTokenPagSeguro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmailPagSeguro = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pnlBotoes.SuspendLayout();
            this.tabDadosCliente.SuspendLayout();
            this.dadosEmpresa.SuspendLayout();
            this.EnderecoEmpresa.SuspendLayout();
            this.pagSeguro.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Controls.Add(this.btnSair);
            this.pnlBotoes.Controls.Add(this.btnSalvar);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotoes.Location = new System.Drawing.Point(0, 248);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(499, 77);
            this.pnlBotoes.TabIndex = 27;
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(349, 0);
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
            this.btnSalvar.Location = new System.Drawing.Point(424, 0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 77);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // tabDadosCliente
            // 
            this.tabDadosCliente.Controls.Add(this.dadosEmpresa);
            this.tabDadosCliente.Controls.Add(this.EnderecoEmpresa);
            this.tabDadosCliente.Controls.Add(this.pagSeguro);
            this.tabDadosCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDadosCliente.Location = new System.Drawing.Point(0, 0);
            this.tabDadosCliente.Name = "tabDadosCliente";
            this.tabDadosCliente.SelectedIndex = 0;
            this.tabDadosCliente.Size = new System.Drawing.Size(499, 248);
            this.tabDadosCliente.TabIndex = 28;
            // 
            // dadosEmpresa
            // 
            this.dadosEmpresa.BackColor = System.Drawing.SystemColors.Control;
            this.dadosEmpresa.Controls.Add(this.txtSenhaEmail);
            this.dadosEmpresa.Controls.Add(this.label4);
            this.dadosEmpresa.Controls.Add(this.txtEmail);
            this.dadosEmpresa.Controls.Add(this.label3);
            this.dadosEmpresa.Controls.Add(this.txtDocumento);
            this.dadosEmpresa.Controls.Add(this.txtTelCelular);
            this.dadosEmpresa.Controls.Add(this.label5);
            this.dadosEmpresa.Controls.Add(this.lblCPF);
            this.dadosEmpresa.Controls.Add(this.txtNomeFantasia);
            this.dadosEmpresa.Controls.Add(this.label1);
            this.dadosEmpresa.Controls.Add(this.txtRazaoSocial);
            this.dadosEmpresa.Controls.Add(this.lblId);
            this.dadosEmpresa.Location = new System.Drawing.Point(4, 22);
            this.dadosEmpresa.Name = "dadosEmpresa";
            this.dadosEmpresa.Padding = new System.Windows.Forms.Padding(3);
            this.dadosEmpresa.Size = new System.Drawing.Size(491, 222);
            this.dadosEmpresa.TabIndex = 0;
            this.dadosEmpresa.Text = "Dados da Empresa";
            // 
            // txtSenhaEmail
            // 
            this.txtSenhaEmail.Location = new System.Drawing.Point(11, 189);
            this.txtSenhaEmail.Name = "txtSenhaEmail";
            this.txtSenhaEmail.PasswordChar = '#';
            this.txtSenhaEmail.Size = new System.Drawing.Size(211, 20);
            this.txtSenhaEmail.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Senha E-Mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(11, 149);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(453, 20);
            this.txtEmail.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "E-Mail";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(11, 110);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(211, 20);
            this.txtDocumento.TabIndex = 4;
            // 
            // txtTelCelular
            // 
            this.txtTelCelular.Location = new System.Drawing.Point(253, 110);
            this.txtTelCelular.Name = "txtTelCelular";
            this.txtTelCelular.Size = new System.Drawing.Size(211, 20);
            this.txtTelCelular.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Telefone";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(8, 93);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(34, 13);
            this.lblCPF.TabIndex = 4;
            this.lblCPF.Text = "CNPJ";
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.Location = new System.Drawing.Point(11, 70);
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(453, 20);
            this.txtNomeFantasia.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome Fantasia";
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Location = new System.Drawing.Point(11, 31);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(453, 20);
            this.txtRazaoSocial.TabIndex = 0;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(8, 15);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(70, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Razão Social";
            // 
            // EnderecoEmpresa
            // 
            this.EnderecoEmpresa.BackColor = System.Drawing.SystemColors.Control;
            this.EnderecoEmpresa.Controls.Add(this.btnBuscaEndereco);
            this.EnderecoEmpresa.Controls.Add(this.txtBairro);
            this.EnderecoEmpresa.Controls.Add(this.label12);
            this.EnderecoEmpresa.Controls.Add(this.txtComplemento);
            this.EnderecoEmpresa.Controls.Add(this.label11);
            this.EnderecoEmpresa.Controls.Add(this.txtCidade);
            this.EnderecoEmpresa.Controls.Add(this.label10);
            this.EnderecoEmpresa.Controls.Add(this.cbxEstado);
            this.EnderecoEmpresa.Controls.Add(this.label9);
            this.EnderecoEmpresa.Controls.Add(this.txtNumero);
            this.EnderecoEmpresa.Controls.Add(this.label8);
            this.EnderecoEmpresa.Controls.Add(this.txtLogradouro);
            this.EnderecoEmpresa.Controls.Add(this.label7);
            this.EnderecoEmpresa.Controls.Add(this.txtCEP);
            this.EnderecoEmpresa.Controls.Add(this.label2);
            this.EnderecoEmpresa.Location = new System.Drawing.Point(4, 22);
            this.EnderecoEmpresa.Name = "EnderecoEmpresa";
            this.EnderecoEmpresa.Padding = new System.Windows.Forms.Padding(3);
            this.EnderecoEmpresa.Size = new System.Drawing.Size(491, 222);
            this.EnderecoEmpresa.TabIndex = 1;
            this.EnderecoEmpresa.Text = "Endereço";
            // 
            // btnBuscaEndereco
            // 
            this.btnBuscaEndereco.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaEndereco.Image")));
            this.btnBuscaEndereco.Location = new System.Drawing.Point(136, 31);
            this.btnBuscaEndereco.Name = "btnBuscaEndereco";
            this.btnBuscaEndereco.Size = new System.Drawing.Size(28, 23);
            this.btnBuscaEndereco.TabIndex = 18;
            this.btnBuscaEndereco.UseVisualStyleBackColor = true;
            this.btnBuscaEndereco.Click += new System.EventHandler(this.btnBuscaEndereco_Click);
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(11, 152);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(454, 20);
            this.txtBairro.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Bairro";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(11, 191);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(454, 20);
            this.txtComplemento.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Complemento";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(166, 112);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(299, 20);
            this.txtCidade.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(163, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Cidade";
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.ItemHeight = 13;
            this.cbxEstado.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Distrito Federal",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins"});
            this.cbxEstado.Location = new System.Drawing.Point(11, 112);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(140, 21);
            this.cbxEstado.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Estado";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(409, 72);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(56, 20);
            this.txtNumero.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(406, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Número";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(11, 72);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(382, 20);
            this.txtLogradouro.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Logradouro";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(11, 33);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(119, 20);
            this.txtCEP.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CEP";
            // 
            // pagSeguro
            // 
            this.pagSeguro.BackColor = System.Drawing.SystemColors.Control;
            this.pagSeguro.Controls.Add(this.ckbTestePagSeguro);
            this.pagSeguro.Controls.Add(this.txtTokenPagSeguro);
            this.pagSeguro.Controls.Add(this.label6);
            this.pagSeguro.Controls.Add(this.txtEmailPagSeguro);
            this.pagSeguro.Controls.Add(this.label13);
            this.pagSeguro.Location = new System.Drawing.Point(4, 22);
            this.pagSeguro.Name = "pagSeguro";
            this.pagSeguro.Size = new System.Drawing.Size(491, 222);
            this.pagSeguro.TabIndex = 2;
            this.pagSeguro.Text = "Pag Seguro";
            // 
            // ckbTestePagSeguro
            // 
            this.ckbTestePagSeguro.AutoSize = true;
            this.ckbTestePagSeguro.Location = new System.Drawing.Point(11, 96);
            this.ckbTestePagSeguro.Name = "ckbTestePagSeguro";
            this.ckbTestePagSeguro.Size = new System.Drawing.Size(162, 17);
            this.ckbTestePagSeguro.TabIndex = 20;
            this.ckbTestePagSeguro.Text = "Utilizar SandBox Pag Seguro";
            this.ckbTestePagSeguro.UseVisualStyleBackColor = true;
            // 
            // txtTokenPagSeguro
            // 
            this.txtTokenPagSeguro.Location = new System.Drawing.Point(11, 69);
            this.txtTokenPagSeguro.Name = "txtTokenPagSeguro";
            this.txtTokenPagSeguro.PasswordChar = '#';
            this.txtTokenPagSeguro.Size = new System.Drawing.Size(472, 20);
            this.txtTokenPagSeguro.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Token Acesso Pag Seguro";
            // 
            // txtEmailPagSeguro
            // 
            this.txtEmailPagSeguro.Location = new System.Drawing.Point(11, 29);
            this.txtEmailPagSeguro.Name = "txtEmailPagSeguro";
            this.txtEmailPagSeguro.Size = new System.Drawing.Size(472, 20);
            this.txtEmailPagSeguro.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "E-Mail Acesso Pag Seguro";
            // 
            // frmConfiguracoesEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 325);
            this.ControlBox = false;
            this.Controls.Add(this.tabDadosCliente);
            this.Controls.Add(this.pnlBotoes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConfiguracoesEmpresa";
            this.Text = "Configurações Empresa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmConfiguracoesEmpresa_FormClosed);
            this.Load += new System.EventHandler(this.frmConfiguracoesEmpresa_Load);
            this.pnlBotoes.ResumeLayout(false);
            this.tabDadosCliente.ResumeLayout(false);
            this.dadosEmpresa.ResumeLayout(false);
            this.dadosEmpresa.PerformLayout();
            this.EnderecoEmpresa.ResumeLayout(false);
            this.EnderecoEmpresa.PerformLayout();
            this.pagSeguro.ResumeLayout(false);
            this.pagSeguro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TabControl tabDadosCliente;
        private System.Windows.Forms.TabPage dadosEmpresa;
        private System.Windows.Forms.MaskedTextBox txtDocumento;
        private System.Windows.Forms.MaskedTextBox txtTelCelular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtNomeFantasia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TabPage EnderecoEmpresa;
        private System.Windows.Forms.Button btnBuscaEndereco;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSenhaEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage pagSeguro;
        private System.Windows.Forms.TextBox txtTokenPagSeguro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmailPagSeguro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox ckbTestePagSeguro;
    }
}