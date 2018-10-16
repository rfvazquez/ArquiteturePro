using System;
using System.Windows.Forms;
using ArchitecturePro.DataBase;
using ArchitecturePro.Util;

namespace ArchitecturePro.Forms.Unidades
{
    public partial class frmMantemUnidades : Form
    {
        private DataBaseControler baseControl = new DataBaseControler();
        public int idUnidade = 0;
        public frmUnidades principal = null;


        public frmMantemUnidades()
        {
            InitializeComponent();
        }

        private void frmMantemUnidades_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            if (idUnidade != 0)
            {
                var unidade = baseControl.BuscaUnidadeId(idUnidade);
                txtDescricao.Text = unidade.uni_Descricao;
            }
        }

        private void frmMantemUnidades_FormClosed(object sender, FormClosedEventArgs e)
        {
            var incial = (frmPrincipal)principal.MdiParent;
            incial.JanelasAbertas();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BloqueiaCampos(bool status)
        {
            txtDescricao.Enabled = status;
            btnSalvar.Enabled = status;
        }

        private bool ValidaCampos()
        {
            var ret = true;
            if (String.IsNullOrEmpty(txtDescricao.Text))
            {
                Mensagem.MensagemShow("Descrição é um campo obrigatório!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                ret = false;
            }
            return ret;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                if (idUnidade == 0)
                {
                    var unidade = new tb_unidade()
                    {
                        uni_Descricao = txtDescricao.Text
                    };
                    if (baseControl.MatemUnidade(unidade))
                    {
                        Mensagem.MensagemShow("Unidade criada com sucesso!", MessageBoxButtons.OK,
                            MessageBoxIcon.Asterisk);
                        BloqueiaCampos(false);
                    }
                }
                else
                {
                    var unidade = baseControl.BuscaUnidadeId(idUnidade);
                    unidade.uni_Descricao = txtDescricao.Text;
                    if (baseControl.MatemUnidade(unidade))
                    {

                        Mensagem.MensagemShow("Unidade alterada com sucesso!", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                        BloqueiaCampos(false);
                    }
                }
            }
            principal.CarregaTabela();
        }

    }
}

