using ArchitecturePro.DataBase;
using ArchitecturePro.Util;
using System;
using System.Windows.Forms;

namespace ArchitecturePro.Forms.Configuracoes
{
    public partial class frmConfiguracoesEmpresa : Form
    {
        private DataBaseControler baseControl = new DataBaseControler();
        private int id = 0;
        public bool configuracaoInicial = false;
        public frmLogin frmLogin { set; get; }
        public frmConfiguracoesEmpresa()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConfiguracoesEmpresa_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                var incial = (frmPrincipal)this.MdiParent;
                incial.JanelasAbertas();
            }
            catch (Exception ex)
            {

            }
        }

        private void frmConfiguracoesEmpresa_Load(object sender, EventArgs e)
        {
            txtTelCelular.Mask = "(99) 00000-0000";
            txtCEP.Mask = "00000-000";
            txtDocumento.Mask = "00.000.000/0000-AA";

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            var empresa = baseControl.BuscaDadosEmpresa();
            if (empresa != null)
            {
                txtRazaoSocial.Text = empresa.emp_RazaoSocial;
                txtNomeFantasia.Text = empresa.emp_Nome;
                txtDocumento.Text = empresa.emp_CNPJ;
                txtTelCelular.Text = empresa.emp_Telefone;
                txtCEP.Text = empresa.emp_CEP;
                txtLogradouro.Text = empresa.emp_Logradouro;
                txtCidade.Text = empresa.emp_Cidade;
                txtNumero.Text = empresa.emp_Numero;
                txtComplemento.Text = empresa.emp_Complemento;
                cbxEstado.Text = empresa.emp_Estado;
                txtBairro.Text = empresa.emp_Bairro;

                txtEmail.Text = empresa.emp_Email;
                txtEmailPagSeguro.Text = empresa.emp_LoginPagSeguro;
                txtTokenPagSeguro.Text = empresa.emp_TokenPagSeguro;
                ckbTestePagSeguro.Checked = empresa.emp_TestePagSeguro == "1";

                txtSenhaEmail.Text = empresa.emp_SenhaEmail;

                id = (int)empresa.emp_Id;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var empresa = new tb_empresa();
            if (id == 0)
            {
                empresa.emp_Nome = txtNomeFantasia.Text;
                empresa.emp_RazaoSocial = txtRazaoSocial.Text;
                empresa.emp_CNPJ = txtDocumento.Text;
                empresa.emp_Bairro = txtBairro.Text;
                empresa.emp_CEP = txtCEP.Text;
                empresa.emp_Cidade = txtCidade.Text;
                empresa.emp_Complemento = txtComplemento.Text;
                empresa.emp_Estado = cbxEstado.Text;
                empresa.emp_Logradouro = txtLogradouro.Text;
                empresa.emp_Numero = txtNumero.Text;
                empresa.emp_Telefone = txtTelCelular.Text;
                empresa.emp_Email = txtEmail.Text;
                empresa.emp_SenhaEmail = txtSenhaEmail.Text;
                empresa.emp_LoginPagSeguro = txtEmailPagSeguro.Text;
                empresa.emp_TokenPagSeguro = txtTokenPagSeguro.Text;
                empresa.emp_TestePagSeguro = ckbTestePagSeguro.Checked == true ? "1" : "0";

            }
            else
            {
                empresa.emp_Nome = txtNomeFantasia.Text;
                empresa.emp_RazaoSocial = txtRazaoSocial.Text;
                empresa.emp_CNPJ = txtDocumento.Text;
                empresa.emp_Bairro = txtBairro.Text;
                empresa.emp_CEP = txtCEP.Text;
                empresa.emp_Cidade = txtCidade.Text;
                empresa.emp_Complemento = txtComplemento.Text;
                empresa.emp_Estado = cbxEstado.Text;
                empresa.emp_Logradouro = txtLogradouro.Text;
                empresa.emp_Numero = txtNumero.Text;
                empresa.emp_Telefone = txtTelCelular.Text;
                empresa.emp_Id = id;

                empresa.emp_Email = txtEmail.Text;
                empresa.emp_SenhaEmail = txtSenhaEmail.Text;
                empresa.emp_LoginPagSeguro = txtEmailPagSeguro.Text;
                empresa.emp_TokenPagSeguro = txtTokenPagSeguro.Text;
                empresa.emp_TestePagSeguro = ckbTestePagSeguro.Checked == true ? "1" : "0";


            }
            if (baseControl.SalvaDadosEmpresa(empresa))
            {
                Mensagem.MensagemShow("Cliente Salvo com sucesso!", txtNomeFantasia.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                if (configuracaoInicial)
                {
                    frmLogin.LoginSistema();
                    frmLogin.nomeSistema = txtNomeFantasia.Text;
                    this.Close();
                }
            }
        }

        private void btnBuscaEndereco_Click(object sender, EventArgs e)
        {
            if (configuracaoInicial)
            {
                var endereco = new BuscaEndereco().BuscaDadosEndereco(txtCEP.Text);
                if (endereco != null)
                {
                    txtLogradouro.Text = endereco.logradouro;
                    txtCidade.Text = endereco.localidade;
                    txtComplemento.Text = endereco.complemento;
                    txtBairro.Text = endereco.bairro;
                    cbxEstado.Text = new BuscaEndereco().ConvertUf(endereco.uf);
                }
            }
            else
            {
                var incial = (frmPrincipal)this.MdiParent;
                incial.IniciaAguarde();
                var endereco = new BuscaEndereco().BuscaDadosEndereco(txtCEP.Text);
                if (endereco != null)
                {
                    txtLogradouro.Text = endereco.logradouro;
                    txtCidade.Text = endereco.localidade;
                    txtComplemento.Text = endereco.complemento;
                    txtBairro.Text = endereco.bairro;
                    cbxEstado.Text = new BuscaEndereco().ConvertUf(endereco.uf);
                }
                incial.InterrompeAguarde();
            }
        }
    }
}
