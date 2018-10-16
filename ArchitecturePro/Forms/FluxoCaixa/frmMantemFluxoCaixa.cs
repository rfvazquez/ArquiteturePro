using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ArchitecturePro.ControlView;
using ArchitecturePro.DataBase;
using ArchitecturePro.Forms.FormUtil;
using ArchitecturePro.Forms.Projetos;
using ArchitecturePro.Util;

namespace ArchitecturePro.Forms.FluxoCaixa
{
    public partial class frmMantemFluxoCaixa : Form
    {
        private DataBaseControler baseControl = new DataBaseControler();
        public int IdFluxoCaixa = 0;
        public int IdProjeto = 0;
        public frmMantemProjetos principal = null;
        public TrocaSelecaoDados despesaSelecionada = new TrocaSelecaoDados();
        public TrocaSelecaoDados projetoSelecionado = new TrocaSelecaoDados();
        public DateTime dataLancamento;
        public frmMantemFluxoCaixa()
        {
            InitializeComponent();
        }

        private void frmMantemFluxoCaixa_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            if (IdFluxoCaixa != 0)
            {
                var fluxoProjeto = baseControl.BuscaProjetoFluxoCaixa(IdFluxoCaixa);

                var fluxoCaixa = fluxoProjeto.tb_fluxoCaixa;
                var prj = fluxoProjeto.tb_projeto;
                txtProjeto.Text = String.Format("Projeto Número: {0}", prj.prj_Id);
                txtDescricao.Text = fluxoCaixa.flc_Descricao;
                dtData.Value = fluxoCaixa.flc_DataCaixa;
                txtValor.Text = fluxoCaixa.flc_Valor.ToString();

                despesaSelecionada.Id = (int)baseControl.BuscaDespesasDescricao(txtDescricao.Text).des_Id;
                projetoSelecionado.Id = (int)prj.prj_Id;
            }
            else
            {
                if (IdProjeto != 0)
                {
                    var prj = baseControl.BuscaProjetoId(IdProjeto);
                    projetoSelecionado.Id = (int)prj.prj_Id;
                    txtProjeto.Text = String.Format("Projeto Número: {0}", prj.prj_Id);
                }
            }

            if (dataLancamento.Date != Convert.ToDateTime("01/01/0001").Date)
            {
                dtData.Value = dataLancamento;
            }
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
            if (String.IsNullOrEmpty(txtValor.Text))
            {
                Mensagem.MensagemShow("Valor é um campo obrigatório!", "Camila Moraes Arquitetura",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                ret = false;

            }
            return ret;
        }


        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMantemFluxoCaixa_FormClosed(object sender, FormClosedEventArgs e)
        {
            var incial = (frmPrincipal)principal.MdiParent;
            incial.JanelasAbertas();
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

        private void btnBuscaDespesa_Click(object sender, EventArgs e)
        {
            var buscaDespesa = new frmBuscaItem();
            var listDespesasData = baseControl.BuscaTodasDespesas();
            var listDespesasView = new List<ViewGrupoDespesas>();
            foreach (var despesasData in listDespesasData)
            {
                var despesas = new ViewGrupoDespesas()
                {
                    Id = (int)despesasData.des_Id,
                    Descricao = despesasData.des_Descricao,
                    GrupoFinanceiro = despesasData.tb_grupoFinanceiro.grf_Descricao
                };
                listDespesasView.Add(despesas);
            }
            despesaSelecionada = new TrocaSelecaoDados();
            buscaDespesa.Text = "Fluxo de Caixa - Buscar Despesa";
            buscaDespesa.trocaObjeto = despesaSelecionada;
            buscaDespesa.CarregaTabela(listDespesasView);
            buscaDespesa.Show();
            buscaDespesa.FormClosed += carregaInformacaoDespesa;
        }
        private void carregaInformacaoDespesa(object sender, FormClosedEventArgs e)
        {
            var despesa = baseControl.BuscaDespesasId(despesaSelecionada.Id);
            if (despesa != null)
            {
                txtDescricao.Text = despesa.des_Descricao;
            }
        }


        private void btnBuscaProjeto_Click(object sender, EventArgs e)
        {
            var buscaDespesa = new frmBuscaItem();
            var lisProjetosData = baseControl.BuscaTodosProjetos();
            var listProjetosView = new List<ViewProjeto>();
            foreach (var projetoData in lisProjetosData)
            {
                var projeto = new ViewProjeto()
                {
                    Id = (int)projetoData.prj_Id,
                    DataInicio = projetoData.prj_DataInicio,
                    DataFimReal = projetoData.prj_DataFimReal,
                    DataFimPrevista = projetoData.prj_DataFimPrevista,
                    Cliente = projetoData.tb_cliente.cli_Fantasia,
                    UsuarioInclusao = projetoData.tb_usuario.usr_Nome
                };
                listProjetosView.Add(projeto);
            }
            projetoSelecionado = new TrocaSelecaoDados();
            buscaDespesa.Text = "Fluxo de Caixa - Buscar Projetos";
            buscaDespesa.trocaObjeto = projetoSelecionado;
            buscaDespesa.CarregaTabela(listProjetosView);
            buscaDespesa.Show();
            buscaDespesa.FormClosed += carregaInformacaoProjeto;
        }
        private void carregaInformacaoProjeto(object sender, FormClosedEventArgs e)
        {
            var projeto = baseControl.BuscaProjetoId(projetoSelecionado.Id);
            if (projeto != null)
            {
                txtProjeto.Text = String.Format("Projeto Número: {0}", projeto.prj_Id); ;
            }
        }
        private void limpaCampos()
        {
            txtDescricao.Text = "";
            txtValor.Text = "";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                if (IdFluxoCaixa == 0)
                {
                    var formMenu = (frmPrincipal)principal.MdiParent;
                    var despesa = baseControl.BuscaDespesasId(despesaSelecionada.Id);
                    var fluxoCaixa = new tb_fluxoCaixa()
                    {
                        flc_DataCadastro = DateTime.Now,
                        flc_DataCaixa = dtData.Value,
                        flc_Descricao = despesa.des_Descricao,
                        flc_Entrada = false,
                        flc_Valor = Convert.ToDecimal(txtValor.Text),
                        flc_UsrId = formMenu.usuarioLogado.usr_Id,
                        flc_GrfId = despesa.des_GrfId

                    };

                    if (projetoSelecionado == null)
                    {
                        if (baseControl.MatemFluxoCaixa(fluxoCaixa))
                        {
                            Mensagem.MensagemShow("Nova Movimentação de Caixa realizada com sucesso!", "Camila Moraes Arquitetura", MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk);
                            limpaCampos();
                        }
                    }
                    else
                    {
                        if (baseControl.MatemProjetoFluxoCaixa(fluxoCaixa, projetoSelecionado.Id))
                        {
                            Mensagem.MensagemShow("Nova Movimentação de Caixa realizada com sucesso!", "Camila Moraes Arquitetura", MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk);
                            limpaCampos();
                        }
                    }
                }
                else
                {
                    var despesa = baseControl.BuscaDespesasId(despesaSelecionada.Id);
                    var fluxoCaixa = baseControl.BuscaProjetoFluxoCaixa(IdFluxoCaixa).tb_fluxoCaixa;

                    fluxoCaixa.flc_DataCaixa = dtData.Value;
                    fluxoCaixa.flc_Descricao = despesa.des_Descricao;
                    fluxoCaixa.flc_Entrada = false;
                    fluxoCaixa.flc_Valor = Convert.ToDecimal(txtValor.Text);
                    fluxoCaixa.flc_GrfId = despesa.des_GrfId;
                    if (baseControl.MatemFluxoCaixa(fluxoCaixa))
                    {
                        Mensagem.MensagemShow("Nova Movimentação de Caixa realizada com sucesso!", "Camila Moraes Arquitetura", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                        limpaCampos();
                    }
                }
            }
            principal.CarregaDespesas();
        }

        public void BloquiaBuscaProjeto()
        {
            btnBuscaProjeto.Enabled = false;
        }
    }
}
