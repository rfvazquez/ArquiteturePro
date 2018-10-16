using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ArchitecturePro.ControlView;
using ArchitecturePro.DataBase;
using ArchitecturePro.Forms.FormUtil;
using ArchitecturePro.Util;

namespace ArchitecturePro.Forms.Projetos
{
    public partial class frmAddItemPedido : Form
    {
        private DataBaseControler baseControl = new DataBaseControler();
        public int IdItemPedido = 0;
        public int IdProjeto = 0;
        public frmMantemProjetos principal = null;
        public frmPrincipal telaMenu = null;
        public TrocaSelecaoDados servicoSelecionado = new TrocaSelecaoDados();
        public frmAddItemPedido()
        {
            InitializeComponent();
        }

        private void frmAddItemPedido_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            if (IdItemPedido != 0)
            {
                var orcamento = baseControl.BuscaItemPedido(IdItemPedido);
                txtServico.Text = orcamento.tb_servicos.ser_Descricao;
                txtQtde.Text = Convert.ToInt32(orcamento.ipo_Qtde).ToString();
                txtValor.Text = Convert.ToDecimal(orcamento.ipo_Valor).ToString();
                servicoSelecionado.Id = (int) orcamento.tb_servicos.ser_Id;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddItemPedido_FormClosed(object sender, FormClosedEventArgs e)
        {
            telaMenu.JanelasAbertas();
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
            if (String.IsNullOrEmpty(txtQtde.Text))
            {
                Mensagem.MensagemShow("Quantidade Planejada é um campo obrigatório!", "Camila Moraes Arquitetura",
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

        private void limpaCampos()
        {
            txtQtde.Text = "";
            txtServico.Text = "";
            IdItemPedido = 0;
            txtValor.Text = "";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                if (IdItemPedido == 0)
                {
                    var itemPedido = new tb_ItemPedido()
                    {
                         ipo_PrjId = IdProjeto,
                         ipo_Qtde = Convert.ToInt32(String.IsNullOrEmpty(txtQtde.Text) ? "0" : txtQtde.Text),
                         ipo_SerId = servicoSelecionado.Id,
                         ipo_Valor = Convert.ToDecimal(String.IsNullOrEmpty(txtValor.Text) ? "0" : txtValor.Text),
                    };
                    if (baseControl.MantemItemPedido(itemPedido))
                    {
                        limpaCampos();
                    }
                }
                else
                {
                    var itemPedido = baseControl.BuscaItemPedido(IdItemPedido);
                    itemPedido.ipo_PrjId = IdProjeto;
                    itemPedido.ipo_Qtde =
                        Convert.ToInt32(String.IsNullOrEmpty(txtQtde.Text) ? "0" : txtQtde.Text);
                    itemPedido.ipo_SerId = servicoSelecionado.Id;
                    itemPedido.ipo_Valor = Convert.ToDecimal(String.IsNullOrEmpty(txtValor.Text) ? "0" : txtValor.Text);
                    if (baseControl.MantemItemPedido(itemPedido))
                    {
                        limpaCampos();
                    }
                }
            }
            principal.CarregaTelaPedido();
        }

        private void txtQtde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
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
    }
}
