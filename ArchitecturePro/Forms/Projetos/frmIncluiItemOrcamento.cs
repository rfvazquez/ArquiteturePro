using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ArchitecturePro.ControlView;
using ArchitecturePro.DataBase;
using ArchitecturePro.Forms.FormUtil;
using ArchitecturePro.Util;

namespace ArchitecturePro.Forms.Projetos
{
    public partial class frmIncluiItemOrcamento : Form
    {
        private DataBaseControler baseControl = new DataBaseControler();
        public int IdOrcamento = 0;
        public int IdProjeto = 0;
        public frmMantemProjetos principal = null;
        public frmPrincipal telaMenu = null;
        public TrocaSelecaoDados servicoSelecionado = new TrocaSelecaoDados();
        public frmIncluiItemOrcamento()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmIncluiItemOrcamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            telaMenu.JanelasAbertas();
        }

        private void frmIncluiItemOrcamento_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            if (IdOrcamento != 0)
            {
                var orcamento = baseControl.BuscaOrcamento(IdOrcamento);
                txtServico.Text = orcamento.tb_servicos.ser_Descricao;
                txtQtdePlanejada.Text = Convert.ToInt32(orcamento.orc_Qtde).ToString();
                servicoSelecionado.Id = (int)orcamento.orc_SerId;
            }
        }

        private void btnBuscaServico_Click(object sender, EventArgs e)
        {
            var buscarCliente = new frmBuscaItem();
            var listServicosData = baseControl.BuscaServicosAtivos();
            var listServicosView = new List<ViewServicos>();
            foreach (var servicosData in listServicosData)
            {
                var servicos = new ViewServicos()
                {
                    Id = (int)servicosData.ser_Id,
                    Descricao = servicosData.ser_Descricao,
                    Data = servicosData.ser_Data,
                    Ativo = servicosData.ser_Ativo,
                    Unidade = servicosData.tb_unidade.uni_Descricao,
                    Valor = servicosData.ser_Valor
                };
                listServicosView.Add(servicos);
            }
            servicoSelecionado = new TrocaSelecaoDados();
            buscarCliente.Text = "Orçamento - Buscar Serviços";
            buscarCliente.trocaObjeto = servicoSelecionado;
            buscarCliente.CarregaTabela(listServicosView);
            buscarCliente.Show();
            buscarCliente.FormClosed += carregaInformacaoServico;
        }

        private void carregaInformacaoServico(object sender, FormClosedEventArgs e)
        {
            var servico = baseControl.BuscaServicosId(servicoSelecionado.Id);
            txtServico.Text = servico.ser_Descricao;
        }

        private bool ValidaCampos()
        {
            var ret = true;
            if (String.IsNullOrEmpty(txtServico.Text))
            {
                Mensagem.MensagemShow("Serviço é um campo obrigatório!", "Camila Moraes Arquitetura",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                ret = false;
            }
            if (String.IsNullOrEmpty(txtQtdePlanejada.Text))
            {
                Mensagem.MensagemShow("Quantidade Planejada é um campo obrigatório!", "Camila Moraes Arquitetura",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                ret = false;
            }
            return ret;
        }

        private void limpaCampos()
        {
            txtQtdePlanejada.Text = "";
            txtServico.Text = "";
            IdOrcamento = 0;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                if (IdOrcamento == 0)
                {
                    var orcamento = new tb_orcamento()
                    {
                        orc_PrjId = IdProjeto,
                        orc_Qtde = Convert.ToInt32(String.IsNullOrEmpty(txtQtdePlanejada.Text) ? "0" : txtQtdePlanejada.Text),
                        orc_SerId = servicoSelecionado.Id,
                    };
                    if (baseControl.MantemOrcamento(orcamento))
                    {
                        limpaCampos();
                    }
                }
                else
                {
                    var orcamento = baseControl.BuscaOrcamento(IdOrcamento);
                    orcamento.orc_PrjId = IdProjeto;
                    orcamento.orc_Qtde =
                        Convert.ToInt32(String.IsNullOrEmpty(txtQtdePlanejada.Text) ? "0" : txtQtdePlanejada.Text);
                    orcamento.orc_SerId = servicoSelecionado.Id;
                    if (baseControl.MantemOrcamento(orcamento))
                    {
                        limpaCampos();
                    }
                }
            }
            principal.CarregaTabelaOrcamento();

        }

        private void txtQtdePlanejada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }

        }
    }
}
