using System;
using System.Windows.Forms;
using ArchitecturePro.DataBase;
using ArchitecturePro.Util;

namespace ArchitecturePro.Forms.Projetos
{
    public partial class frmAddDataPagamento : Form
    {
        private DataBaseControler baseControl = new DataBaseControler();
        public int IdProjetoFluxoCaixa = 0;
        public int IdProjeto = 0;
        public frmMantemProjetos principal = null;
        public frmPrincipal telaMenu = null;

        public frmAddDataPagamento()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddDataPagamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            telaMenu.JanelasAbertas();
        }

        private void frmAddDataPagamento_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            if (IdProjetoFluxoCaixa != 0)
            {
                var projetoFluxoCaixa = baseControl.BuscaProjetoFluxoCaixa(IdProjetoFluxoCaixa);
                txtValor.Text = Convert.ToDecimal(projetoFluxoCaixa.tb_fluxoCaixa.flc_Valor).ToString();
                dtData.Value = projetoFluxoCaixa.tb_fluxoCaixa.flc_DataCaixa;
            }
        }

        private bool ValidaCampos()
        {
            var ret = true;
            if (String.IsNullOrEmpty(txtValor.Text))
            {
                Mensagem.MensagemShow("Valor é um campo obrigatório!", "Camila Moraes Arquitetura",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                ret = false;
            }
            return ret;
        }
        private void limpaCampos()
        {
            txtValor.Text = "";
            dtData.Value = DateTime.Now;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                if (IdProjetoFluxoCaixa == 0)
                {
                    var fluxoCaixa = new tb_fluxoCaixa()
                    {
                        flc_DataCadastro = DateTime.Now,
                        flc_UsrId = telaMenu.usuarioLogado.usr_Id,
                        flc_DataCaixa = dtData.Value,
                        flc_Descricao = String.Format("Parcela Projeto {0}", dtData.Value),
                        flc_Entrada = true,
                        flc_Valor = Convert.ToDecimal(String.IsNullOrEmpty(txtValor.Text) ? "0" : txtValor.Text),
                        flc_GrfId = baseControl.BuscaGrupoFinanceiroEntrada(), 

                        flc_PagamentoConfirmado = 0,
                        flc_PagSeguro = 0,
                        flc_URLPagamento = "",
                        

                    };
                    if (baseControl.MatemProjetoFluxoCaixa(fluxoCaixa, IdProjeto))
                    {
                        limpaCampos();
                    }
                }
                else
                {
                    var IdFluxoCaixa = baseControl.BuscaIdFluxoCaixaPeloProjetoFluxoCaixaId(IdProjetoFluxoCaixa);
                    var fluxoCaixa = baseControl.BuscaFluxoCaixaId(IdFluxoCaixa);
                    fluxoCaixa.flc_Valor = Convert.ToDecimal(String.IsNullOrEmpty(txtValor.Text) ? "0" : txtValor.Text);
                    fluxoCaixa.flc_DataCaixa = dtData.Value;
                    fluxoCaixa.flc_Descricao = String.Format("Parcela Projeto {0}", dtData.Value);
                    if (baseControl.MatemFluxoCaixa(fluxoCaixa))
                    {
                        limpaCampos();
                    }
                }
            }
            principal.CarregaTelaPedido();
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == ',' || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' && txtValor.Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPagSeguro_Click(object sender, EventArgs e)
        {

        }
    }
}
