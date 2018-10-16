using System;
using System.Windows.Forms;
using ArchitecturePro.DataBase;
using ArchitecturePro.Util;

namespace ArchitecturePro.Forms.Clientes
{
    public partial class frmMantemClientes : Form
    {
        private DataBaseControler baseControl = new DataBaseControler();
        public int IdCliente = 0;
        public frmClientes principal = null;

        public frmMantemClientes()
        {
            InitializeComponent();
        }

        private void frmMantemClientes_Load(object sender, EventArgs e)
        {
            MudaPessoa();
            txtTelCelular.Mask = "(99) 00000-0000";
            txtTelComercial.Mask = "(99) 0000-0000";
            txtCEP.Mask = "00000-000";
            txtCepObra.Mask = "00000-000";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            if (IdCliente > 0)
            {
                var cliente = baseControl.BuscaClenteId(IdCliente);
                if (cliente != null)
                {
                    txtEmail.Text = cliente.cli_Email;
                    txtBairro.Text = cliente.cli_Bairro;
                    txtCEP.Text = cliente.cli_CEP;
                    txtCidade.Text = cliente.cli_Cidade;
                    txtComplemento.Text = cliente.cli_Complemento;
                    txtDescricao.Text = cliente.cli_Descricao;
                    if (cliente.cli_CpfCnpj.Length > 14)
                    {
                        rbtPessoaJuridica.Checked = true;
                    }
                    else
                    {
                        rbtPessoaFisica.Checked = true;
                    }
                    txtDocumento.Text = cliente.cli_CpfCnpj;
                    txtTelComercial.Text = cliente.cli_Telefone;
                    txtTelCelular.Text = cliente.cli_Celular;
                    txtLogradouro.Text = cliente.cli_Logradouro;
                    txtNumero.Text = cliente.cli_Numero;
                    txtNomeContato.Text = cliente.cli_Contato;
                    txtNomeFantasia.Text = cliente.cli_Fantasia;
                    cbxEstado.Text = cliente.cli_Estado;

                    txtBairroObra.Text = cliente.cli_BairroObra;
                    txtCepObra.Text = cliente.cli_CEPObra;
                    txtCidadeObra.Text = cliente.cli_CidadeObra;
                    txtComplementoObra.Text = cliente.cli_ComplementoObra;
                    txtLogradouroObra.Text = cliente.cli_LogradouroObra;
                    txtNumeroObra.Text = cliente.cli_NumeroObra;
                    cbxEstadoObra.Text = cliente.cli_EstadoObra;
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MudaPessoa()
        {
            if (rbtPessoaFisica.Checked)
            {
                lblCPF.Text = "CPF";
                txtDocumento.Mask = "000.000.000-00";
            }
            else
            {
                lblCPF.Text = "CNPJ";
                txtDocumento.Mask = "00.000.000/0000-AA";
            }
        }


        private void rbtPessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            MudaPessoa();
        }

        private void rbtPessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            MudaPessoa();
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (IdCliente > 0)
            {
                var cliente = baseControl.BuscaClenteId(IdCliente);
                cliente.cli_Ativo = true;
                cliente.cli_CpfCnpj = txtDocumento.Text;
                cliente.cli_Logradouro = txtLogradouro.Text;
                cliente.cli_Contato = txtNomeContato.Text;
                cliente.cli_Cidade = txtCidade.Text;
                cliente.cli_Estado = cbxEstado.Text;
                cliente.cli_Complemento = txtComplemento.Text;
                cliente.cli_Celular = txtTelCelular.Text;
                cliente.cli_CEP = txtCEP.Text;
                cliente.cli_Descricao = txtDescricao.Text;
                cliente.cli_Fantasia = txtNomeFantasia.Text;
                cliente.cli_Bairro = txtBairro.Text;
                cliente.cli_Data = DateTime.Now;
                cliente.cli_Email = txtEmail.Text;
                cliente.cli_Numero = txtNumero.Text;
                cliente.cli_Telefone = txtTelComercial.Text;

                cliente.cli_CEPObra = txtCepObra.Text;
                cliente.cli_LogradouroObra = txtLogradouroObra.Text;
                cliente.cli_NumeroObra = txtNumeroObra.Text;
                cliente.cli_BairroObra = txtBairroObra.Text;
                cliente.cli_CidadeObra = txtCidadeObra.Text;
                cliente.cli_EstadoObra = cbxEstadoObra.Text;
                cliente.cli_ComplementoObra = txtComplementoObra.Text;

                if (baseControl.MantemCliente(cliente))
                {
                    Mensagem.MensagemShow("Cliente Salvo com sucesso!", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    BloqueiaCampos(false);
                }
            }
            else
            {
                var cliente = new tb_cliente()
                {
                    cli_Ativo = true,
                    cli_CpfCnpj = txtDocumento.Text,
                    cli_Logradouro = txtLogradouro.Text,
                    cli_Contato = txtNomeContato.Text,
                    cli_Cidade = txtCidade.Text,
                    cli_Estado = cbxEstado.Text,
                    cli_Complemento = txtComplemento.Text,
                    cli_Celular = txtTelCelular.Text,
                    cli_CEP = txtCEP.Text,
                    cli_Descricao = txtDescricao.Text,
                    cli_Fantasia = txtNomeFantasia.Text,
                    cli_Bairro = txtBairro.Text,
                    cli_Data = DateTime.Now,
                    cli_Email = txtEmail.Text,
                    cli_Numero = txtNumero.Text,
                    cli_Telefone = txtTelComercial.Text,

                    cli_CEPObra = txtCepObra.Text,
                    cli_LogradouroObra = txtLogradouroObra.Text,
                    cli_NumeroObra = txtNumeroObra.Text,
                    cli_BairroObra = txtBairroObra.Text,
                    cli_CidadeObra = txtCidadeObra.Text,
                    cli_EstadoObra = cbxEstadoObra.Text,
                    cli_ComplementoObra = txtComplementoObra.Text,
                };
                if (baseControl.MantemCliente(cliente))
                {
                    Mensagem.MensagemShow("Cliente Salvo com sucesso!", "Camila Moraes Arquitetura", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                    BloqueiaCampos(false);
                }
            }
            principal.CarregaTabela();
        }

        private void BloqueiaCampos(bool status)
        {
            txtDocumento.Enabled = status;
            txtLogradouro.Enabled = status;
            txtNomeContato.Enabled = status;
            txtCidade.Enabled = status;
            cbxEstado.Enabled = status;
            txtComplemento.Enabled = status;
            txtTelCelular.Enabled = status;
            txtCEP.Enabled = status;
            txtDescricao.Enabled = status;
            txtNomeFantasia.Enabled = status;
            txtBairro.Enabled = status;
            txtEmail.Enabled = status;
            txtNumero.Enabled = status;
            txtTelComercial.Enabled = status;
            btnSalvar.Enabled = status;
            txtLogradouroObra.Enabled = status;
            txtNumeroObra.Enabled = status;
            txtCidadeObra.Enabled = status;
            cbxEstadoObra.Enabled = status;
            txtComplementoObra.Enabled = status;
            txtCepObra.Enabled = status;
            txtBairroObra.Enabled = status;
        }

        private void txtCEP_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnBuscaEndereco_Click(object sender, EventArgs e)
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

        private void frmMantemClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            var incial = (frmPrincipal)principal.MdiParent;
            incial.JanelasAbertas();
        }

        private void btnBuscaCepObra_Click(object sender, EventArgs e)
        {
            var incial = (frmPrincipal)this.MdiParent;
            incial.IniciaAguarde();
            var endereco = new BuscaEndereco().BuscaDadosEndereco(txtCepObra.Text);
            if (endereco != null)
            {
                txtLogradouroObra.Text = endereco.logradouro;
                txtCidadeObra.Text = endereco.localidade;
                txtComplementoObra.Text = endereco.complemento;
                txtBairroObra.Text = endereco.bairro;
                cbxEstadoObra.Text = new BuscaEndereco().ConvertUf(endereco.uf);
            }
            incial.InterrompeAguarde();
        }
    }
}
