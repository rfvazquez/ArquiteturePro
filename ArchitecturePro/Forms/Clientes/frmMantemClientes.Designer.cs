namespace ArchitecturePro.Forms.Clientes
{
    partial class frmMantemClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantemClientes));
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tabDadosCliente = new System.Windows.Forms.TabControl();
            this.dadosCliente = new System.Windows.Forms.TabPage();
            this.txtDocumento = new System.Windows.Forms.MaskedTextBox();
            this.rbtPessoaJuridica = new System.Windows.Forms.RadioButton();
            this.rbtPessoaFisica = new System.Windows.Forms.RadioButton();
            this.txtTelCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtTelComercial = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeContato = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.EnderecoCliente = new System.Windows.Forms.TabPage();
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
            this.tabEndObra = new System.Windows.Forms.TabPage();
            this.btnBuscaCepObra = new System.Windows.Forms.Button();
            this.txtBairroObra = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtComplementoObra = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCidadeObra = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbxEstadoObra = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtNumeroObra = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtLogradouroObra = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtCepObra = new System.Windows.Forms.MaskedTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.pnlBotoes.SuspendLayout();
            this.tabDadosCliente.SuspendLayout();
            this.dadosCliente.SuspendLayout();
            this.EnderecoCliente.SuspendLayout();
            this.tabEndObra.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Controls.Add(this.btnSair);
            this.pnlBotoes.Controls.Add(this.btnSalvar);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotoes.Location = new System.Drawing.Point(0, 286);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(498, 77);
            this.pnlBotoes.TabIndex = 6;
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(348, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 77);
            this.btnSair.TabIndex = 9;
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
            this.btnSalvar.Location = new System.Drawing.Point(423, 0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 77);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // tabDadosCliente
            // 
            this.tabDadosCliente.Controls.Add(this.dadosCliente);
            this.tabDadosCliente.Controls.Add(this.EnderecoCliente);
            this.tabDadosCliente.Controls.Add(this.tabEndObra);
            this.tabDadosCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDadosCliente.Location = new System.Drawing.Point(0, 0);
            this.tabDadosCliente.Name = "tabDadosCliente";
            this.tabDadosCliente.SelectedIndex = 0;
            this.tabDadosCliente.Size = new System.Drawing.Size(498, 286);
            this.tabDadosCliente.TabIndex = 7;
            // 
            // dadosCliente
            // 
            this.dadosCliente.BackColor = System.Drawing.SystemColors.Control;
            this.dadosCliente.Controls.Add(this.txtDocumento);
            this.dadosCliente.Controls.Add(this.rbtPessoaJuridica);
            this.dadosCliente.Controls.Add(this.rbtPessoaFisica);
            this.dadosCliente.Controls.Add(this.txtTelCelular);
            this.dadosCliente.Controls.Add(this.txtTelComercial);
            this.dadosCliente.Controls.Add(this.txtEmail);
            this.dadosCliente.Controls.Add(this.label6);
            this.dadosCliente.Controls.Add(this.label5);
            this.dadosCliente.Controls.Add(this.label4);
            this.dadosCliente.Controls.Add(this.txtNomeContato);
            this.dadosCliente.Controls.Add(this.label3);
            this.dadosCliente.Controls.Add(this.lblCPF);
            this.dadosCliente.Controls.Add(this.txtNomeFantasia);
            this.dadosCliente.Controls.Add(this.label1);
            this.dadosCliente.Controls.Add(this.txtDescricao);
            this.dadosCliente.Controls.Add(this.lblId);
            this.dadosCliente.Location = new System.Drawing.Point(4, 22);
            this.dadosCliente.Name = "dadosCliente";
            this.dadosCliente.Padding = new System.Windows.Forms.Padding(3);
            this.dadosCliente.Size = new System.Drawing.Size(490, 260);
            this.dadosCliente.TabIndex = 0;
            this.dadosCliente.Text = "Dados Cliente";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(182, 110);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(211, 20);
            this.txtDocumento.TabIndex = 4;
            // 
            // rbtPessoaJuridica
            // 
            this.rbtPessoaJuridica.AutoSize = true;
            this.rbtPessoaJuridica.Location = new System.Drawing.Point(23, 113);
            this.rbtPessoaJuridica.Name = "rbtPessoaJuridica";
            this.rbtPessoaJuridica.Size = new System.Drawing.Size(99, 17);
            this.rbtPessoaJuridica.TabIndex = 3;
            this.rbtPessoaJuridica.Text = "Pessoa Juridica";
            this.rbtPessoaJuridica.UseVisualStyleBackColor = true;
            this.rbtPessoaJuridica.CheckedChanged += new System.EventHandler(this.rbtPessoaJuridica_CheckedChanged);
            // 
            // rbtPessoaFisica
            // 
            this.rbtPessoaFisica.AutoSize = true;
            this.rbtPessoaFisica.Checked = true;
            this.rbtPessoaFisica.Location = new System.Drawing.Point(23, 93);
            this.rbtPessoaFisica.Name = "rbtPessoaFisica";
            this.rbtPessoaFisica.Size = new System.Drawing.Size(90, 17);
            this.rbtPessoaFisica.TabIndex = 2;
            this.rbtPessoaFisica.TabStop = true;
            this.rbtPessoaFisica.Text = "Pessoa Fisica";
            this.rbtPessoaFisica.UseVisualStyleBackColor = true;
            this.rbtPessoaFisica.CheckedChanged += new System.EventHandler(this.rbtPessoaFisica_CheckedChanged);
            // 
            // txtTelCelular
            // 
            this.txtTelCelular.Location = new System.Drawing.Point(265, 188);
            this.txtTelCelular.Name = "txtTelCelular";
            this.txtTelCelular.Size = new System.Drawing.Size(211, 20);
            this.txtTelCelular.TabIndex = 7;
            // 
            // txtTelComercial
            // 
            this.txtTelComercial.Location = new System.Drawing.Point(23, 188);
            this.txtTelComercial.Name = "txtTelComercial";
            this.txtTelComercial.Size = new System.Drawing.Size(212, 20);
            this.txtTelComercial.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(23, 227);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(453, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "E-Mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Telefone Celular";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefone Comercial";
            // 
            // txtNomeContato
            // 
            this.txtNomeContato.Location = new System.Drawing.Point(23, 149);
            this.txtNomeContato.Name = "txtNomeContato";
            this.txtNomeContato.Size = new System.Drawing.Size(453, 20);
            this.txtNomeContato.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nome Contato";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(179, 95);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(65, 13);
            this.lblCPF.TabIndex = 4;
            this.lblCPF.Text = "CPF / CNPJ";
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.Location = new System.Drawing.Point(23, 71);
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(453, 20);
            this.txtNomeFantasia.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome Fantasia";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(23, 32);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(453, 20);
            this.txtDescricao.TabIndex = 0;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(20, 16);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(55, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Descrição";
            // 
            // EnderecoCliente
            // 
            this.EnderecoCliente.BackColor = System.Drawing.SystemColors.Control;
            this.EnderecoCliente.Controls.Add(this.btnBuscaEndereco);
            this.EnderecoCliente.Controls.Add(this.txtBairro);
            this.EnderecoCliente.Controls.Add(this.label12);
            this.EnderecoCliente.Controls.Add(this.txtComplemento);
            this.EnderecoCliente.Controls.Add(this.label11);
            this.EnderecoCliente.Controls.Add(this.txtCidade);
            this.EnderecoCliente.Controls.Add(this.label10);
            this.EnderecoCliente.Controls.Add(this.cbxEstado);
            this.EnderecoCliente.Controls.Add(this.label9);
            this.EnderecoCliente.Controls.Add(this.txtNumero);
            this.EnderecoCliente.Controls.Add(this.label8);
            this.EnderecoCliente.Controls.Add(this.txtLogradouro);
            this.EnderecoCliente.Controls.Add(this.label7);
            this.EnderecoCliente.Controls.Add(this.txtCEP);
            this.EnderecoCliente.Controls.Add(this.label2);
            this.EnderecoCliente.Location = new System.Drawing.Point(4, 22);
            this.EnderecoCliente.Name = "EnderecoCliente";
            this.EnderecoCliente.Padding = new System.Windows.Forms.Padding(3);
            this.EnderecoCliente.Size = new System.Drawing.Size(490, 260);
            this.EnderecoCliente.TabIndex = 1;
            this.EnderecoCliente.Text = "Endereço Cliente";
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
            this.txtCEP.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCEP_MaskInputRejected);
            this.txtCEP.TabIndexChanged += new System.EventHandler(this.txtCEP_TabIndexChanged);
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
            // tabEndObra
            // 
            this.tabEndObra.BackColor = System.Drawing.SystemColors.Control;
            this.tabEndObra.Controls.Add(this.btnBuscaCepObra);
            this.tabEndObra.Controls.Add(this.txtBairroObra);
            this.tabEndObra.Controls.Add(this.label13);
            this.tabEndObra.Controls.Add(this.txtComplementoObra);
            this.tabEndObra.Controls.Add(this.label14);
            this.tabEndObra.Controls.Add(this.txtCidadeObra);
            this.tabEndObra.Controls.Add(this.label15);
            this.tabEndObra.Controls.Add(this.cbxEstadoObra);
            this.tabEndObra.Controls.Add(this.label16);
            this.tabEndObra.Controls.Add(this.txtNumeroObra);
            this.tabEndObra.Controls.Add(this.label17);
            this.tabEndObra.Controls.Add(this.txtLogradouroObra);
            this.tabEndObra.Controls.Add(this.label18);
            this.tabEndObra.Controls.Add(this.txtCepObra);
            this.tabEndObra.Controls.Add(this.label19);
            this.tabEndObra.Location = new System.Drawing.Point(4, 22);
            this.tabEndObra.Name = "tabEndObra";
            this.tabEndObra.Padding = new System.Windows.Forms.Padding(3);
            this.tabEndObra.Size = new System.Drawing.Size(490, 260);
            this.tabEndObra.TabIndex = 2;
            this.tabEndObra.Text = "Endereco Obra";
            // 
            // btnBuscaCepObra
            // 
            this.btnBuscaCepObra.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaCepObra.Image")));
            this.btnBuscaCepObra.Location = new System.Drawing.Point(136, 30);
            this.btnBuscaCepObra.Name = "btnBuscaCepObra";
            this.btnBuscaCepObra.Size = new System.Drawing.Size(28, 23);
            this.btnBuscaCepObra.TabIndex = 33;
            this.btnBuscaCepObra.UseVisualStyleBackColor = true;
            this.btnBuscaCepObra.Click += new System.EventHandler(this.btnBuscaCepObra_Click);
            // 
            // txtBairroObra
            // 
            this.txtBairroObra.Location = new System.Drawing.Point(11, 151);
            this.txtBairroObra.Name = "txtBairroObra";
            this.txtBairroObra.Size = new System.Drawing.Size(454, 20);
            this.txtBairroObra.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 135);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "Bairro";
            // 
            // txtComplementoObra
            // 
            this.txtComplementoObra.Location = new System.Drawing.Point(11, 190);
            this.txtComplementoObra.Name = "txtComplementoObra";
            this.txtComplementoObra.Size = new System.Drawing.Size(454, 20);
            this.txtComplementoObra.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 174);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Complemento";
            // 
            // txtCidadeObra
            // 
            this.txtCidadeObra.Location = new System.Drawing.Point(166, 111);
            this.txtCidadeObra.Name = "txtCidadeObra";
            this.txtCidadeObra.Size = new System.Drawing.Size(299, 20);
            this.txtCidadeObra.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(163, 95);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Cidade";
            // 
            // cbxEstadoObra
            // 
            this.cbxEstadoObra.FormattingEnabled = true;
            this.cbxEstadoObra.ItemHeight = 13;
            this.cbxEstadoObra.Items.AddRange(new object[] {
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
            this.cbxEstadoObra.Location = new System.Drawing.Point(11, 111);
            this.cbxEstadoObra.Name = "cbxEstadoObra";
            this.cbxEstadoObra.Size = new System.Drawing.Size(140, 21);
            this.cbxEstadoObra.TabIndex = 28;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 94);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 13);
            this.label16.TabIndex = 27;
            this.label16.Text = "Estado";
            // 
            // txtNumeroObra
            // 
            this.txtNumeroObra.Location = new System.Drawing.Point(409, 71);
            this.txtNumeroObra.Name = "txtNumeroObra";
            this.txtNumeroObra.Size = new System.Drawing.Size(56, 20);
            this.txtNumeroObra.TabIndex = 21;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(406, 55);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 13);
            this.label17.TabIndex = 26;
            this.label17.Text = "Número";
            // 
            // txtLogradouroObra
            // 
            this.txtLogradouroObra.Location = new System.Drawing.Point(11, 71);
            this.txtLogradouroObra.Name = "txtLogradouroObra";
            this.txtLogradouroObra.Size = new System.Drawing.Size(382, 20);
            this.txtLogradouroObra.TabIndex = 20;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 55);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 13);
            this.label18.TabIndex = 25;
            this.label18.Text = "Logradouro";
            // 
            // txtCepObra
            // 
            this.txtCepObra.Location = new System.Drawing.Point(11, 32);
            this.txtCepObra.Name = "txtCepObra";
            this.txtCepObra.Size = new System.Drawing.Size(119, 20);
            this.txtCepObra.TabIndex = 19;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(8, 16);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(28, 13);
            this.label19.TabIndex = 22;
            this.label19.Text = "CEP";
            // 
            // frmMantemClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 363);
            this.ControlBox = false;
            this.Controls.Add(this.tabDadosCliente);
            this.Controls.Add(this.pnlBotoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMantemClientes";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantem Clientes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMantemClientes_FormClosed);
            this.Load += new System.EventHandler(this.frmMantemClientes_Load);
            this.pnlBotoes.ResumeLayout(false);
            this.tabDadosCliente.ResumeLayout(false);
            this.dadosCliente.ResumeLayout(false);
            this.dadosCliente.PerformLayout();
            this.EnderecoCliente.ResumeLayout(false);
            this.EnderecoCliente.PerformLayout();
            this.tabEndObra.ResumeLayout(false);
            this.tabEndObra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TabControl tabDadosCliente;
        private System.Windows.Forms.TabPage dadosCliente;
        private System.Windows.Forms.TabPage EnderecoCliente;
        private System.Windows.Forms.TextBox txtNomeContato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtNomeFantasia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtTelCelular;
        private System.Windows.Forms.MaskedTextBox txtTelComercial;
        private System.Windows.Forms.RadioButton rbtPessoaJuridica;
        private System.Windows.Forms.RadioButton rbtPessoaFisica;
        private System.Windows.Forms.MaskedTextBox txtDocumento;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnBuscaEndereco;
        private System.Windows.Forms.TabPage tabEndObra;
        private System.Windows.Forms.Button btnBuscaCepObra;
        private System.Windows.Forms.TextBox txtBairroObra;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtComplementoObra;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCidadeObra;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbxEstadoObra;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtNumeroObra;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtLogradouroObra;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.MaskedTextBox txtCepObra;
        private System.Windows.Forms.Label label19;
    }
}