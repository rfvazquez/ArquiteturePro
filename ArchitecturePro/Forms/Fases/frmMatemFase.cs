using System;
using System.Windows.Forms;
using ArchitecturePro.DataBase;
using ArchitecturePro.Util;

namespace ArchitecturePro.Forms.Fases
{
    public partial class frmMatemFase : Form
    {

        private DataBaseControler baseControl = new DataBaseControler();
        public int IdFase = 0;
        public frmFases principal = null;

        public frmMatemFase()
        {
            InitializeComponent();
        }

        private void txtDias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        private void frmMatemFase_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            if (IdFase != 0)
            {
                var fase = baseControl.BuscaFasesId(IdFase);
                txtDescricao.Text = fase.fas_Descricao;
                ckbAtivo.Checked = fase.fas_Ativo;
                txtDias.Text = fase.fas_Dias.ToString();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMatemFase_FormClosed(object sender, FormClosedEventArgs e)
        {
            var incial = (frmPrincipal)principal.MdiParent;
            incial.JanelasAbertas();
        }

        private void BloqueiaCampos(bool status)
        {
            txtDescricao.Enabled = status;
            ckbAtivo.Enabled = status;
            txtDias.Enabled = status;
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

            if (String.IsNullOrEmpty(txtDias.Text))
            {
                Mensagem.MensagemShow("Dias é um campo obrigatório!", "Camila Moraes Arquitetura",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                ret = false;
            }
            return ret;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                if (IdFase == 0)
                {
                    var fase = new tb_fases()
                    {
                        fas_Dias = Convert.ToInt32(txtDias.Text),
                        fas_Descricao = txtDescricao.Text,
                        fas_Ativo = ckbAtivo.Checked,

                    };
                    if (baseControl.MantemFase(fase))
                    {
                        Mensagem.MensagemShow("Fase criada com sucesso!", "Camila Moraes Arquitetura", MessageBoxButtons.OK,
                            MessageBoxIcon.Asterisk);
                        BloqueiaCampos(false);
                    }
                }
                else
                {
                    var fase = baseControl.BuscaFasesId(IdFase);
                    fase.fas_Dias = Convert.ToInt32(txtDias.Text);
                    fase.fas_Descricao = txtDescricao.Text;
                    fase.fas_Ativo = ckbAtivo.Checked;
                    if (baseControl.MantemFase(fase))
                    {
                        Mensagem.MensagemShow("Fase alterada com sucesso!", "Camila Moraes Arquitetura", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                        BloqueiaCampos(false);
                    }
                }
            }
            principal.CarregaTabela();
        }
    }
}
