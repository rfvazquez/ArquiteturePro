using System;
using System.Windows.Forms;
using ArchitecturePro.DataBase;
using ArchitecturePro.Util;

namespace ArchitecturePro.Forms.GrupoFinanceiro
{
    public partial class frmMatemGrupoFinanceiro : Form
    {
        private DataBaseControler baseControl = new DataBaseControler();
        public int IdGrupoFinanceiro = 0;
        public frmGrupoFinanceiro principal = null;

        public frmMatemGrupoFinanceiro()
        {
            InitializeComponent();
        }

        private void frmMatemGrupoFinanceiro_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            if (IdGrupoFinanceiro != 0)
            {
                var grupoFianceiro = baseControl.BuscaGrupoFinanceiroId(IdGrupoFinanceiro);
                txtDescricao.Text = grupoFianceiro.grf_Descricao;
                ckbAtivo.Checked = grupoFianceiro.grf_Ativo;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMatemGrupoFinanceiro_FormClosed(object sender, FormClosedEventArgs e)
        {
            var incial = (frmPrincipal)principal.MdiParent;
            incial.JanelasAbertas();
        }

        private void BloqueiaCampos(bool status)
        {
            txtDescricao.Enabled = status;
            ckbAtivo.Enabled = status;
            btnSalvar.Enabled = status;
        }


        private bool ValidaCampos()
        {
            var ret = true;
            if (String.IsNullOrEmpty(txtDescricao.Text))
            {
                Mensagem.MensagemShow("Descrição é um campo obrigatório!", "Camila Moraes Arquitetura",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                ret = false;
            }
            return ret;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                if (IdGrupoFinanceiro == 0)
                {
                    var grupoFinanceiro = new tb_grupoFinanceiro()
                    {
                        grf_Descricao = txtDescricao.Text,
                        grf_Ativo = ckbAtivo.Checked,
                        grf_Data = DateTime.Now
                    };
                    if (baseControl.MatemGrupoFinanceiro(grupoFinanceiro))
                    {
                        Mensagem.MensagemShow("Grupo Financeiro Criado com sucesso!", "Camila Moraes Arquitetura", MessageBoxButtons.OK,
                            MessageBoxIcon.Asterisk);
                        BloqueiaCampos(false);
                    }
                }
                else
                {
                    var grupoFinanceiro = baseControl.BuscaGrupoFinanceiroId(IdGrupoFinanceiro);
                    grupoFinanceiro.grf_Descricao = txtDescricao.Text;
                    grupoFinanceiro.grf_Ativo = ckbAtivo.Checked;
                    grupoFinanceiro.grf_Data = DateTime.Now;
                    if (baseControl.MatemGrupoFinanceiro(grupoFinanceiro))
                    {
                        //new Util.EnviarEmail().SendMail(txtEmail.Text, "Senha Sistema Camila Moraes Arquitetura",
                        //    String.Format("Sua senha para acesso ao sistema é: {0}", usuario.usr_Senha.ToString()));

                        Mensagem.MensagemShow("Grupo Financeiro alterado com sucesso!", "Camila Moraes Arquitetura", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                        BloqueiaCampos(false);
                    }
                }
            }
            principal.CarregaTabela();
        }
    }
}
