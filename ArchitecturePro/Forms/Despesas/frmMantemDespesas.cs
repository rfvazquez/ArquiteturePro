using System;
using System.Windows.Forms;
using ArchitecturePro.DataBase;
using ArchitecturePro.Util;

namespace ArchitecturePro.Forms.Despesas
{
    public partial class frmMantemDespesas : Form
    {
        private DataBaseControler baseControl = new DataBaseControler();
        public int IdDespesa = 0;
        public frmDespesas principal = null;
        public frmMantemDespesas()
        {
            InitializeComponent();
        }

        private void carregaCombos()
        {
            var grupoFinanceiro = baseControl.BuscaGruposFinanceirosAtivo();

            cbxGrupoFinanceiro.Items.Clear();
            cbxGrupoFinanceiro.DataSource = grupoFinanceiro;
            cbxGrupoFinanceiro.DisplayMember = "grf_Descricao";
            cbxGrupoFinanceiro.ValueMember = "grf_Id";

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMantemDespesas_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            carregaCombos();
            if (IdDespesa != 0)
            {
                var despesa = baseControl.BuscaDespesasId(IdDespesa);
                txtDescricao.Text = despesa.des_Descricao;
                cbxGrupoFinanceiro.Text = despesa.tb_grupoFinanceiro.grf_Descricao;
            }
            
        }

        private void frmMantemDespesas_FormClosed(object sender, FormClosedEventArgs e)
        {
            var incial = (frmPrincipal)principal.MdiParent;
            incial.JanelasAbertas();
        }

        private void BloqueiaCampos(bool status)
        {
            txtDescricao.Enabled = status;
            cbxGrupoFinanceiro.Enabled = status;
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
                if (IdDespesa == 0)
                {
                    var despesa = new tb_despesas()
                    {
                        des_Descricao = txtDescricao.Text,
                        des_GrfId = Convert.ToInt32(cbxGrupoFinanceiro.SelectedValue)
                    };
                    if (baseControl.MantemDespesas(despesa))
                        {
                        Mensagem.MensagemShow("Despesa Criada com sucesso!", "Camila Moraes Arquitetura", MessageBoxButtons.OK,
                            MessageBoxIcon.Asterisk);
                        BloqueiaCampos(false);
                    }
                }
                else
                {
                    var despesa = baseControl.BuscaDespesasId(IdDespesa);
                    despesa.des_Descricao = txtDescricao.Text;
                    despesa.des_GrfId = Convert.ToInt32(cbxGrupoFinanceiro.SelectedValue);
                    if (baseControl.MantemDespesas(despesa))
                    {
      
                        Mensagem.MensagemShow("Despesa alterada com sucesso!", "Camila Moraes Arquitetura", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                        BloqueiaCampos(false);
                    }
                }
            }
            principal.CarregaTabela();
        }
    }
}
