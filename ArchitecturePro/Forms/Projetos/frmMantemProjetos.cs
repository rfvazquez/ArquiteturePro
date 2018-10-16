using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ArchitecturePro.ControlView;
using ArchitecturePro.DataBase;
using ArchitecturePro.Forms.FluxoCaixa;
using ArchitecturePro.Forms.FormUtil;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using ArchitecturePro.Util;

namespace ArchitecturePro.Forms.Projetos
{
    public partial class frmMantemProjetos : Form
    {
        private DataBaseControler baseControl = new DataBaseControler();
        public int IdProjeto = 0;
        private int IdCliente = 0;
        private int IdOrcamentoSelecionado = 0;
        private int IdItemPedidoSelecionado = 0;
        private int IdDataPagamentoSelecionada = 0;
        private int IdDespesaSelecionado = 0;
        private int IdFaseProjeto = 0;
        private string NomeArquivo = "";
        private string TipoArquivo = "";
        private string linkPagSeguro = "";
        public frmProjetos principal = null;
        private TrocaSelecaoDados clienteSelecionado = new TrocaSelecaoDados();
        private TrocaSelecaoDados faseSelecionada = new TrocaSelecaoDados();


        public void CriaFasesProjeto()
        {
            var fases = baseControl.BuscaFasesAtivas();
            foreach (var fase in fases)
            {
                var faseProjeto = new tb_fasesProjeto()
                {
                    fap_PrjId = IdProjeto,
                    fap_Finalizada = false,
                    fap_FasId = fase.fas_Id,
                    fap_DataPrevista = dtInicio.Value.AddDays(fase.fas_Dias),
                    fap_DataReal = dtInicio.Value,
                };
                baseControl.MantemFaseProjeto(faseProjeto);
            }
            var projeto = baseControl.BuscaProjetoId(IdProjeto);
            projeto.prj_DataFimPrevista = baseControl.BuscaFasesProjeto(IdProjeto).Max(x => x.fap_DataPrevista);
            baseControl.MantemProjeto(projeto);
            CarregaFaseProjeto();
        }



        public void CarregaFaseProjeto()
        {
            var listFasesProjetoData = baseControl.BuscaFasesProjeto(IdProjeto);
            var listFasesProjetoView = new List<ViewFasesProjeto>();
            foreach (var faseProjetoData in listFasesProjetoData)
            {
                var faseProjeto = new ViewFasesProjeto()
                {
                    Id = (int)faseProjetoData.fap_Id,
                    DataReal = faseProjetoData.fap_DataReal,
                    DataPrevista = faseProjetoData.fap_DataPrevista,
                    FaseFinalizada = faseProjetoData.fap_Finalizada,
                    Fase = faseProjetoData.tb_fases.fas_Descricao
                };

                listFasesProjetoView.Add(faseProjeto);
            }
            grdFasesProjeto.DataSource = null;
            grdFasesProjeto.DataSource = listFasesProjetoView;

            gridView5.OptionsView.ColumnAutoWidth = false;
            gridView5.BestFitColumns();
            gridView5.VertScrollVisibility = ScrollVisibility.Auto;
            gridView5.HorzScrollVisibility = ScrollVisibility.Auto;
        }



        public void CarregaDespesas()
        {
            var listDespesasData = baseControl.BuscaFluxoProjeto(IdProjeto, true);
            var listDespesasView = new List<ViewDespesas>();
            foreach (var despesasData in listDespesasData)
            {
                var despesas = new ViewDespesas()
                {
                    Id = (int)despesasData.pfc_Id,
                    Descricao = despesasData.tb_fluxoCaixa.flc_Descricao,
                    Valor = despesasData.tb_fluxoCaixa.flc_Valor,
                    Data = despesasData.tb_fluxoCaixa.flc_DataCaixa
                };

                listDespesasView.Add(despesas);
            }
            gridDespesas.DataSource = null;
            gridDespesas.DataSource = listDespesasView;

            gridView4.OptionsView.ColumnAutoWidth = false;
            gridView4.BestFitColumns();
            gridView4.VertScrollVisibility = ScrollVisibility.Auto;
            gridView4.HorzScrollVisibility = ScrollVisibility.Auto;

            // aqui vamos calcular o total Gastoo até o momento
            var totalDespesa = baseControl.CalculaInformacoesTotalProjeto(IdProjeto, true);
            lblTotalDespesas.Text = String.Format("Total Gasto: R${0}", Math.Round(Convert.ToDecimal(totalDespesa), 2));
        }

        public frmMantemProjetos()
        {
            InitializeComponent();
        }

        private void CalculaValorPedido()
        {

            var valorDesconto = (Convert.ToDecimal(String.IsNullOrEmpty(txtPerGanho.Text)
                                       ? 0
                                       : Convert.ToDecimal(txtPerGanho.Text)) / Convert.ToDecimal(100.0)) * -1;
            var valorArredondamento = Convert.ToDecimal(String.IsNullOrEmpty(txtArredondamento.Text)
                                       ? 0
                                       : Convert.ToDecimal(txtArredondamento.Text));

            try
            {


                var totalOrcado = baseControl.CalculaValorPrevistoProjeto(IdProjeto);
                lblValorOrcado.Text = String.Format("R$ {0}", totalOrcado);
                var valorGanho = Convert.ToDecimal(0);
                if (valorDesconto > 0)
                {
                    valorGanho = (Decimal)(totalOrcado * valorDesconto + valorArredondamento);
                }
                else
                {
                    valorGanho = (Decimal)(totalOrcado + valorArredondamento);
                }

                
                var valorProjeto = totalOrcado + valorGanho;

                var percentualGanho = (100 - (valorGanho * 100 / totalOrcado)) * -1;

                lblValorPedido.Text = String.Format("R${0}", Math.Round(Convert.ToDecimal(valorProjeto), 2));
                lblValorGanho.Text = String.Format("R${0}", Math.Round(Convert.ToDecimal(valorGanho), 2));
                lblPercentualGanho.Text = String.Format("{0}%", Math.Round(Convert.ToDecimal(percentualGanho), 2));

                var totalItem = baseControl.CalculaValorTotalItensProjeto(IdProjeto);
                var faltaItem = valorProjeto - totalItem;


                if (faltaItem == 0)
                {
                    lblFaltaItem.Text = "Pedido Completo";
                }
                else
                {
                    if (faltaItem > 0)
                    {
                        lblFaltaItem.Text = String.Format("Falta Distribuir:  R${0}",
                            Math.Round(Convert.ToDecimal(faltaItem), 2));
                    }
                    else
                    {
                        lblFaltaItem.Text = String.Format("Está distribuido a mais: R${0}",
                            Math.Round(Convert.ToDecimal(faltaItem), 2));
                    }
                }


                var totalLancado = baseControl.CalculaInformacoesTotalProjeto(IdProjeto, false);
                var faltaLancar = valorProjeto - totalLancado;

                if (faltaLancar == 0)
                {
                    lblFaltaForma.Text = "Forma de Pagamento Completo";
                }
                else
                {
                    if (faltaLancar > 0)
                    {
                        lblFaltaForma.Text = String.Format("Falta Receber:  R${0}",
                            Math.Round(Convert.ToDecimal(faltaLancar), 2));
                    }
                    else
                    {
                        lblFaltaForma.Text = String.Format("Está Recebendo a mais: R${0}",
                            Math.Round(Convert.ToDecimal(faltaLancar), 2));
                    }
                }
            }
            catch (Exception)
            {

            }
        }


        private void grdFaseProjeto_ClickRow(object sender, RowClickEventArgs e)
        {
            IdFaseProjeto = int.Parse(((GridView)sender).GetRowCellValue(e.RowHandle, "Id").ToString());
            if (Boolean.Parse(((GridView)sender).GetRowCellValue(e.RowHandle, "FaseFinalizada").ToString()))
            {
                btnConcluiFaseProjeto.Enabled = false;
            }
            else
            {
                btnConcluiFaseProjeto.Enabled = true;
            }
        }

        private void grdDespesas_ClickRow(object sender, RowClickEventArgs e)
        {
            IdDespesaSelecionado = int.Parse(((GridView)sender).GetRowCellValue(e.RowHandle, "Id").ToString());
        }

        private void grdOrcamento_ClickRow(object sender, RowClickEventArgs e)
        {
            IdOrcamentoSelecionado = int.Parse(((GridView)sender).GetRowCellValue(e.RowHandle, "Id").ToString());
        }

        private void grdItemPedido_ClickRow(object sender, RowClickEventArgs e)
        {
            IdItemPedidoSelecionado = int.Parse(((GridView)sender).GetRowCellValue(e.RowHandle, "Id").ToString());
        }
        private void grdDataPagamento_ClickRow(object sender, RowClickEventArgs e)
        {
            IdDataPagamentoSelecionada = int.Parse(((GridView)sender).GetRowCellValue(e.RowHandle, "Id").ToString());
            linkPagSeguro = ((GridView)sender).GetRowCellValue(e.RowHandle, "UrlPagamento").ToString();
        }
        public void CarregaTelaPedido()
        {
            #region Item do pedido
            var listItemPedidoData = baseControl.BuscaItemPedidoProjeto(IdProjeto);
            var listItemPedidoView = new List<ViewItemPedido>();
            foreach (var itemPedidoData in listItemPedidoData)
            {
                var itemPedido = new ViewItemPedido()
                {
                    Id = (int)itemPedidoData.ipo_Id,
                    Valor = itemPedidoData.ipo_Valor,
                    Item = itemPedidoData.tb_servicos.ser_Descricao,
                    Qtde = Convert.ToInt32(itemPedidoData.ipo_Qtde)
                };

                listItemPedidoView.Add(itemPedido);
            }
            grdItensPedido.DataSource = null;
            grdItensPedido.DataSource = listItemPedidoView;

            gridView2.OptionsView.ColumnAutoWidth = false;
            gridView2.BestFitColumns();
            gridView2.VertScrollVisibility = ScrollVisibility.Auto;
            gridView2.HorzScrollVisibility = ScrollVisibility.Auto;
            #endregion

            #region Dados do Pagamento
            var listProjetoFluxoCaixaData = baseControl.BuscaFluxoProjeto(IdProjeto, false);
            var listFormaPagamentoView = new List<ViewFormaPagamento>();
            foreach (var projetoFluxoCaixaData in listProjetoFluxoCaixaData)
            {
                var formaPagamento = new ViewFormaPagamento()
                {
                    Id = (int)projetoFluxoCaixaData.pfc_Id,
                    Valor = projetoFluxoCaixaData.tb_fluxoCaixa.flc_Valor,
                    Data = projetoFluxoCaixaData.tb_fluxoCaixa.flc_DataCaixa,
                    UrlPagamento = projetoFluxoCaixaData.tb_fluxoCaixa.flc_URLPagamento,
                    PagSeguro = projetoFluxoCaixaData.tb_fluxoCaixa.flc_PagSeguro == 1 ? true : false,
                    PagamentoConfirmado = projetoFluxoCaixaData.tb_fluxoCaixa.flc_PagamentoConfirmado == 1 ? true : false
                };

                listFormaPagamentoView.Add(formaPagamento);
            }
            grdFormaPagamento.DataSource = null;
            grdFormaPagamento.DataSource = listFormaPagamentoView;

            gridView3.OptionsView.ColumnAutoWidth = false;
            gridView3.BestFitColumns();
            gridView3.VertScrollVisibility = ScrollVisibility.Auto;
            gridView3.HorzScrollVisibility = ScrollVisibility.Auto;
            #endregion

            // aqui vamos fazer a grid de forma de pagamento

            CalculaValorPedido();
        }

        public void CarregaTabelaOrcamento()
        {
            var listOrcamentoData = baseControl.BuscaOrcamentosProjeto(IdProjeto);
            var listOrcamentoView = new List<ViewOrcamento>();
            foreach (var orcamentoData in listOrcamentoData)
            {
                var orcamento = new ViewOrcamento()
                {
                    Id = (int)orcamentoData.orc_Id,
                    Valor = (Convert.ToDouble(orcamentoData.tb_servicos.ser_Valor) * Convert.ToDouble(orcamentoData.orc_Qtde)),
                    Servico = orcamentoData.tb_servicos.ser_Descricao,
                    Qtde = Convert.ToInt32(orcamentoData.orc_Qtde)
                };

                listOrcamentoView.Add(orcamento);
            }
            grdOrcamento.DataSource = null;
            grdOrcamento.DataSource = listOrcamentoView;

            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.BestFitColumns();
            gridView1.VertScrollVisibility = ScrollVisibility.Auto;
            gridView1.HorzScrollVisibility = ScrollVisibility.Auto;

            lblValorPlanejado.Text = String.Format("Valor Total Orçado: R$ {0}",
                baseControl.CalculaValorPrevistoProjeto(IdProjeto).ToString());
            CalculaValorPedido();
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMantemProjetos_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            if (IdProjeto != 0)
            {
                var projeto = baseControl.BuscaProjetoId(IdProjeto);
                txtCliente.Text = projeto.tb_cliente.cli_Fantasia;
                txtObservacao.Text = projeto.prj_Obs;
                dtInicio.Value = projeto.prj_DataInicio;
                clienteSelecionado.Id = Convert.ToInt32(projeto.tb_cliente.cli_Id);
                txtArredondamento.Text = Convert.ToString(projeto.prj_Arredondamento);
                txtPerGanho.Text = Convert.ToString(projeto.prj_PerGanho);
                CarregaTabelaOrcamento();
                CarregaTelaPedido();
                CarregaDespesas();
                CarregaFaseProjeto();
            }

            gridView1.RowClick += grdOrcamento_ClickRow;
            gridView2.RowClick += grdItemPedido_ClickRow;
            gridView3.RowClick += grdDataPagamento_ClickRow;
            gridView4.RowClick += grdDespesas_ClickRow;
            gridView5.RowClick += grdFaseProjeto_ClickRow;
            gridView6.RowClick += grdArquivos_ClickRow;
            CarregaArquivosGoogleDrive();
        }


        private void btnBuscaCliente_Click(object sender, EventArgs e)
        {
            var buscarCliente = new frmBuscaItem();
            var listClienteData = baseControl.BuscaTodosClientes();
            var listClientesView = new List<ViewClientes>();
            foreach (var clienteData in listClienteData)
            {
                var cliente = new ViewClientes()
                {
                    Id = (int)clienteData.cli_Id,
                    Descricao = clienteData.cli_Descricao,
                    Fantasia = clienteData.cli_Fantasia,
                    Cpf = clienteData.cli_CpfCnpj,
                    Logradouro = clienteData.cli_Logradouro,
                    Numero = clienteData.cli_Numero,
                    Cidade = clienteData.cli_Cidade,
                    Estado = clienteData.cli_Estado,
                    CEP = clienteData.cli_CEP,
                    Complemento = clienteData.cli_Complemento,
                    Contato = clienteData.cli_Contato,
                    Telefone = clienteData.cli_Telefone,
                    Celular = clienteData.cli_Celular,
                    EMail = clienteData.cli_Email,
                    Data = clienteData.cli_Data,
                    Ativo = clienteData.cli_Ativo,
                };
                listClientesView.Add(cliente);
            }
            IdCliente = clienteSelecionado.Id;
            clienteSelecionado = new TrocaSelecaoDados();
            buscarCliente.Text = "Projetos - Buscar Cliente";
            buscarCliente.trocaObjeto = clienteSelecionado;
            buscarCliente.CarregaTabela(listClientesView);
            buscarCliente.Show();
            buscarCliente.FormClosed += carregaInformacaoCliente;

        }
        private void carregaInformacaoCliente(object sender, FormClosedEventArgs e)
        {
            if (clienteSelecionado.Id != 0)
            {
                var cliente = baseControl.BuscaClenteId(clienteSelecionado.Id);
                txtCliente.Text = cliente.cli_Fantasia;
            }
            else
            {
                clienteSelecionado.Id = IdCliente;
            }
        }


        private void CarregaFasesProjeto(object sender, FormClosedEventArgs e)
        {
            if (faseSelecionada.Id != 0)
            {
                var fase = baseControl.BuscaFasesId(faseSelecionada.Id);
                var faseProjeto = new tb_fasesProjeto()
                {
                    fap_PrjId = IdProjeto,
                    fap_Finalizada = false,
                    fap_FasId = fase.fas_Id,
                    fap_DataPrevista = dtInicio.Value.AddDays(fase.fas_Dias),
                    fap_DataReal = dtInicio.Value,
                };
                baseControl.MantemFaseProjeto(faseProjeto);
                CarregaFaseProjeto();
            }
        }

        private void frmMantemProjetos_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                var incial = (frmPrincipal)principal.MdiParent;
                incial.JanelasAbertas();
            }
            catch (Exception ex)
            {

            }
        }

        private bool ValidaCampos()
        {
            var ret = true;
            if (String.IsNullOrEmpty(txtCliente.Text))
            {
                Mensagem.MensagemShow("Cliente é um Campo obrigatório",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                ret = false;
            }
            return ret;
        }

        private void BloqueiaCampos(bool status)
        {
            txtCliente.Enabled = status;
            dtInicio.Enabled = status;
            txtObservacao.Enabled = status;
            btnBuscaCliente.Enabled = status;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                if (IdProjeto == 0)
                {
                    var incial = (frmPrincipal)principal.MdiParent;
                    var projeto = new tb_projeto()
                    {
                        prj_DataFimPrevista = dtInicio.Value,
                        prj_DataFimReal = dtInicio.Value,
                        prj_CliId = clienteSelecionado.Id,
                        prj_DataInicio = dtInicio.Value,
                        prj_Obs = txtObservacao.Text,
                        prj_UsrId = incial.usuarioLogado.usr_Id,
                        prj_Arredondamento = Convert.ToDecimal(String.IsNullOrEmpty(txtArredondamento.Text) ? 0 : Convert.ToDecimal(txtArredondamento.Text)),
                        prj_PerGanho = Convert.ToInt32(String.IsNullOrEmpty(txtPerGanho.Text) ? 0 : Convert.ToInt32(txtPerGanho.Text))
                    };
                    var idTemp = baseControl.MantemProjeto(projeto);
                    if (idTemp != 0)
                    {

                        //Aqui cria a pasta no google drive
                        GoogleDrive.CriaDiretorio(idTemp.ToString());

                        IdProjeto = idTemp;
                        CarregaTabelaOrcamento();
                        CriaFasesProjeto();
                        CarregaDespesas();
                        CarregaFaseProjeto();
                        Mensagem.MensagemShow("Projeto Criado com sucesso!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Asterisk);
                        BloqueiaCampos(false);
                    }
                }
                else
                {
                    var projeto = baseControl.BuscaProjetoId(IdProjeto);
                    projeto.prj_CliId = clienteSelecionado.Id;
                    projeto.prj_DataInicio = dtInicio.Value;
                    projeto.prj_Obs = txtObservacao.Text;
                    projeto.prj_Arredondamento =
                        Convert.ToDecimal(String.IsNullOrEmpty(txtArredondamento.Text)
                            ? 0
                            : Convert.ToDecimal(txtArredondamento.Text));
                    projeto.prj_PerGanho =
                        Convert.ToInt32(String.IsNullOrEmpty(txtPerGanho.Text) ? 0 : Convert.ToInt32(txtPerGanho.Text));
                    var idTemp = baseControl.MantemProjeto(projeto);
                    if (idTemp != 0)
                    {
                        Mensagem.MensagemShow("Projeto alterado com sucesso!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Asterisk);
                        BloqueiaCampos(false);
                    }
                }
                principal.CarregaTabela();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IdProjeto == 0)
            {
                if (tabControl1.SelectedIndex != 0)
                {
                    tabControl1.SelectedIndex = 0;
                    Mensagem.MensagemShow("Necessário um projeto salvo para completar o estudo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void btnIncluirOrcamento_Click(object sender, EventArgs e)
        {
            var incluiItemOrcamento = new frmIncluiItemOrcamento();
            incluiItemOrcamento.IdProjeto = IdProjeto;
            incluiItemOrcamento.principal = this;
            incluiItemOrcamento.telaMenu = (frmPrincipal)this.MdiParent;
            incluiItemOrcamento.Show();
            incluiItemOrcamento.WindowState = FormWindowState.Normal;
            incluiItemOrcamento.Focus();
            var principal = (frmPrincipal)this.MdiParent;
            principal.JanelasAbertas();
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditarOrcamento_Click(object sender, EventArgs e)
        {
            if (IdOrcamentoSelecionado == 0)
            {
                Mensagem.MensagemShow("Selecione uma linha para Editar!", MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
            }
            else
            {
                var incluiItemOrcamento = new frmIncluiItemOrcamento();
                incluiItemOrcamento.IdOrcamento = IdOrcamentoSelecionado;
                incluiItemOrcamento.IdProjeto = IdProjeto;
                incluiItemOrcamento.principal = this;
                incluiItemOrcamento.telaMenu = (frmPrincipal)this.MdiParent;
                incluiItemOrcamento.Show();
                incluiItemOrcamento.WindowState = FormWindowState.Normal;
                incluiItemOrcamento.Focus();
                var principal = (frmPrincipal)this.MdiParent;
                principal.JanelasAbertas();
            }
        }

        private void btnDeletaOrcamento_Click(object sender, EventArgs e)
        {
            if (IdOrcamentoSelecionado == 0)
            {
                Mensagem.MensagemShow("Selecione uma linha para Deletar!", MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
            }
            else
            {
                baseControl.DeletaOrcamento(IdOrcamentoSelecionado);
                IdOrcamentoSelecionado = 0;
                CarregaTabelaOrcamento();
            }
        }

        private void txtPerGanho_TextChanged(object sender, EventArgs e)
        {
            CalculaValorPedido();
        }

        private void txtArredondamento_TextChanged(object sender, EventArgs e)
        {
            CalculaValorPedido();
        }

        private void txtPerGanho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }

        }

        private void txtArredondamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == ',' || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' && txtArredondamento.Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            var addItemPedido = new frmAddItemPedido();
            addItemPedido.IdProjeto = IdProjeto;
            addItemPedido.principal = this;
            addItemPedido.telaMenu = (frmPrincipal)this.MdiParent;
            addItemPedido.Show();
            addItemPedido.WindowState = FormWindowState.Normal;
            addItemPedido.Focus();
            var principal = (frmPrincipal)this.MdiParent;
            principal.JanelasAbertas();
        }

        private void btnEditarItem_Click(object sender, EventArgs e)
        {
            if (IdItemPedidoSelecionado == 0)
            {
                Mensagem.MensagemShow("Selecione uma linha para Editar!", MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
            }
            else
            {
                var addItemPedido = new frmAddItemPedido();
                addItemPedido.IdProjeto = IdProjeto;
                addItemPedido.IdItemPedido = IdItemPedidoSelecionado;
                addItemPedido.principal = this;
                addItemPedido.telaMenu = (frmPrincipal)this.MdiParent;
                addItemPedido.Show();
                addItemPedido.WindowState = FormWindowState.Normal;
                addItemPedido.Focus();
                var principal = (frmPrincipal)this.MdiParent;
                principal.JanelasAbertas();
            }
        }

        private void btnRemoverItem_Click(object sender, EventArgs e)
        {
            if (IdItemPedidoSelecionado == 0)
            {
                Mensagem.MensagemShow("Selecione uma linha para Deletar!", MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
            }
            else
            {
                baseControl.DeletaItemPedido(IdItemPedidoSelecionado);
                IdOrcamentoSelecionado = 0;
                CarregaTelaPedido();
            }
        }

        private void btnAddFormaPagamento_Click(object sender, EventArgs e)
        {
            var addDataPatamento = new frmAddDataPagamento();
            addDataPatamento.IdProjeto = IdProjeto;
            addDataPatamento.principal = this;
            addDataPatamento.telaMenu = (frmPrincipal)this.MdiParent;
            addDataPatamento.Show();
            addDataPatamento.WindowState = FormWindowState.Normal;
            addDataPatamento.Focus();
            var principal = (frmPrincipal)this.MdiParent;
            principal.JanelasAbertas();
        }

        private void btnEditFormaPagamento_Click(object sender, EventArgs e)
        {
            if (IdDataPagamentoSelecionada == 0)
            {
                Mensagem.MensagemShow("Selecione uma linha para Editar!", MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
            }
            else
            {

                if (!String.IsNullOrEmpty(linkPagSeguro))
                {
                    var projeto = baseControl.BuscaProjetoId(IdProjeto);
                    var pgtoPagSeguro = new frmPgtoPagSeguro();
                    pgtoPagSeguro.projeto = projeto;
                    pgtoPagSeguro.linkPagSeguro = linkPagSeguro;
                    pgtoPagSeguro.MdiParent = this.MdiParent;
                    pgtoPagSeguro.Show();
                }
                else
                {
                    var addDataPatamento = new frmAddDataPagamento();
                    addDataPatamento.IdProjeto = IdProjeto;
                    addDataPatamento.IdProjetoFluxoCaixa = IdDataPagamentoSelecionada;
                    addDataPatamento.principal = this;
                    addDataPatamento.telaMenu = (frmPrincipal)this.MdiParent;
                    addDataPatamento.Show();
                    addDataPatamento.WindowState = FormWindowState.Normal;
                    addDataPatamento.Focus();
                }


                var principal = (frmPrincipal)this.MdiParent;
                principal.JanelasAbertas();
            }
        }

        private void btnApagaFormaPagamento_Click(object sender, EventArgs e)
        {
            if (IdDataPagamentoSelecionada == 0)
            {
                Mensagem.MensagemShow("Selecione uma linha para Deletar!", MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
            }
            else
            {
                baseControl.DeletaProjetoFluxoCaixa(IdDataPagamentoSelecionada);
                IdOrcamentoSelecionado = 0;
                CarregaTelaPedido();
            }
        }

        private void lblValorGanho_Click(object sender, EventArgs e)
        {

        }

        private void btnPrintPedido_Click(object sender, EventArgs e)
        {
            var printPedido = new frmPedido();
            printPedido.Text = String.Format("Pedido Nº {0}", IdProjeto);
            printPedido.IdPedido = IdProjeto;
            printPedido.IdCliente = clienteSelecionado.Id;
            printPedido.Observacao = txtObservacao.Text;
            printPedido.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var mantemFluxoCaixa = new frmMantemFluxoCaixa();
            mantemFluxoCaixa.IdProjeto = IdProjeto;
            mantemFluxoCaixa.principal = this;
            mantemFluxoCaixa.BloquiaBuscaProjeto();
            //mantemFluxoCaixa.telaMenu = (frmPrincipal)this.MdiParent;
            mantemFluxoCaixa.Show();
            mantemFluxoCaixa.WindowState = FormWindowState.Normal;
            mantemFluxoCaixa.Focus();
            var principal = (frmPrincipal)this.MdiParent;
            principal.JanelasAbertas();
        }

        private void btnEditarDespesa_Click(object sender, EventArgs e)
        {
            if (IdDespesaSelecionado == 0)
            {
                Mensagem.MensagemShow("Selecione uma linha para Editar!", MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
            }
            else
            {
                var mantemFluxoCaixa = new frmMantemFluxoCaixa();
                mantemFluxoCaixa.IdProjeto = IdProjeto;
                mantemFluxoCaixa.principal = this;
                mantemFluxoCaixa.BloquiaBuscaProjeto();
                mantemFluxoCaixa.IdFluxoCaixa = IdDespesaSelecionado;
                //mantemFluxoCaixa.telaMenu = (frmPrincipal)this.MdiParent;
                mantemFluxoCaixa.Show();
                mantemFluxoCaixa.WindowState = FormWindowState.Normal;
                mantemFluxoCaixa.Focus();
                var principal = (frmPrincipal)this.MdiParent;
                principal.JanelasAbertas();
            }

        }

        private void btnDeletarDespesa_Click(object sender, EventArgs e)
        {
            if (IdDespesaSelecionado == 0)
            {
                Mensagem.MensagemShow("Selecione uma linha para Deletar!", MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
            }
            else
            {
                baseControl.DeletaProjetoFluxoCaixa(IdDespesaSelecionado);
                IdOrcamentoSelecionado = 0;
                CarregaTelaPedido();
            }
        }

        private void btnDeletaFaseProjeto_Click(object sender, EventArgs e)
        {
            if (baseControl.DeletaFaseProjeto(IdFaseProjeto))
            {
                Mensagem.MensagemShow("Fase do Projeto Excluida com sucesso!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);
            }
        }

        private void btnConcluiFaseProjeto_Click(object sender, EventArgs e)
        {
            var faseProjeto = baseControl.BuscaFasesProjetoId(IdFaseProjeto);
            if (faseProjeto != null)
            {
                faseProjeto.fap_DataReal = DateTime.Now;
                faseProjeto.fap_Finalizada = true;
                if (baseControl.MantemFaseProjeto(faseProjeto))
                {
                    CarregaFaseProjeto();
                    var projeto = baseControl.BuscaProjetoId(IdProjeto);
                    projeto.prj_DataFimReal = baseControl.BuscaFasesProjeto(IdProjeto).Max(x => x.fap_DataReal);
                    baseControl.MantemProjeto(projeto);
                    principal.CarregaTabela();
                }
            }
        }

        private void btnCriaFasesProjeto_Click(object sender, EventArgs e)
        {
            var alterarData = new frmAlteraDataFases();
            alterarData.MdiParent = this.MdiParent;
            alterarData.IdProjeto = IdProjeto;
            alterarData.principal = this;
            alterarData.Show();
        }

        private void btnExcluirFase_Click(object sender, EventArgs e)
        {
            try
            {
                var faseProjeto = baseControl.BuscaFasesProjetoId(IdFaseProjeto);
                if (baseControl.DeletaFaseProjeto(IdFaseProjeto))
                {
                    CarregaFaseProjeto();
                    Mensagem.MensagemShow("Fase do Projeto Excluida com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow("Erro ao excluir a fase do projeto: " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIncluirFaseProjeto_Click(object sender, EventArgs e)
        {
            var buscaFaseProjeto = new frmBuscaItem();
            var listFaseProjetoData = baseControl.BuscaFases();
            var listFasesView = new List<ViewFases>();
            foreach (var FaseData in listFaseProjetoData)
            {
                var fases = new ViewFases()
                {
                    Id = (int)FaseData.fas_Id,
                    Ativo = FaseData.fas_Ativo,
                    Descricao = FaseData.fas_Descricao,
                    DiasEntrega = (int)FaseData.fas_Dias
                };
                listFasesView.Add(fases);
            }
            clienteSelecionado = new TrocaSelecaoDados();
            buscaFaseProjeto.Text = "Projetos - Buscar Fase";
            buscaFaseProjeto.trocaObjeto = faseSelecionada;
            buscaFaseProjeto.CarregaTabela(listFasesView);
            buscaFaseProjeto.Show();
            buscaFaseProjeto.FormClosed += CarregaFasesProjeto;
        }

        public void CarregaArquivosGoogleDrive()
        {
            GoogleDrive.CriaDiretorio(IdProjeto.ToString());

            grdArquivos.DataSource = null;
            grdArquivos.DataSource = GoogleDrive.ListarArquivos(IdProjeto.ToString());

            gridView6.OptionsView.ColumnAutoWidth = false;
            gridView6.BestFitColumns();
            gridView6.VertScrollVisibility = ScrollVisibility.Auto;
            gridView6.HorzScrollVisibility = ScrollVisibility.Auto;
        }


        private void btnUpload_Click(object sender, EventArgs e)
        {

            if (buscarArquivo.ShowDialog() == DialogResult.OK)
            {

                var principal = (frmPrincipal)this.MdiParent;
                principal.IniciaAguarde();

                buscarArquivo.Filter = $"Qualquer Arquivo (*.*)|*.*";
                if (GoogleDrive.Upload(buscarArquivo.FileName, IdProjeto.ToString()))
                {
                    CarregaArquivosGoogleDrive();
                    principal.InterrompeAguarde();
                    Mensagem.MensagemShow("Upload do arquivo efetuado com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                principal.InterrompeAguarde();
            }
        }

        private void grdArquivos_ClickRow(object sender, RowClickEventArgs e)
        {
            NomeArquivo = ((GridView)sender).GetRowCellValue(e.RowHandle, "Nome").ToString();
            TipoArquivo = ((GridView)sender).GetRowCellValue(e.RowHandle, "Tipo").ToString();
        }


        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(NomeArquivo))
            {
                salvarArquivo.FileName = NomeArquivo;
                salvarArquivo.DefaultExt = $"*.{TipoArquivo}";
                salvarArquivo.Filter = $"Tipo de Arquivo (*.{TipoArquivo})|*.{TipoArquivo}";
                if (salvarArquivo.ShowDialog() == DialogResult.OK)
                {
                    var principal = (frmPrincipal)this.MdiParent;
                    principal.IniciaAguarde();

                    if (GoogleDrive.Download(NomeArquivo, salvarArquivo.FileName))
                    {
                        Mensagem.MensagemShow("Download Efetuado com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    principal.InterrompeAguarde();
                }
            }
            else
            {
                Mensagem.MensagemShow("Selecione o Arquivo que deseja fazer o Download!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(NomeArquivo))
            {
                if (Mensagem.MensagemShow($"Deseja mesmo apagar o arquivo {NomeArquivo}", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {

                    var principal = (frmPrincipal)this.MdiParent;
                    principal.IniciaAguarde();

                    if (GoogleDrive.DeleteArquivo(NomeArquivo))
                    {
                        CarregaArquivosGoogleDrive();
                        principal.InterrompeAguarde();
                        Mensagem.MensagemShow("Arquivo Deletado com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    principal.InterrompeAguarde();
                }
            }
            else
            {
                Mensagem.MensagemShow("Selecione o arquivo a ser deletado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGerarPagamentoPagSeguro_Click(object sender, EventArgs e)
        {
            var projeto = baseControl.BuscaProjetoId(IdProjeto);
            if (projeto != null)
            {
                var link = IntegracaoPagSeguro.GeraPagamento(projeto);
                if (link.ToUpper() != "ERRO")
                {
                    var formPrincipal = (frmPrincipal)this.MdiParent;
                    var fluxoCaixa = new tb_fluxoCaixa()
                    {
                        flc_DataCadastro = DateTime.Now,
                        flc_UsrId = formPrincipal.usuarioLogado.usr_Id,
                        flc_DataCaixa = DateTime.Now,
                        flc_Descricao = "Pagamento do Projeto via PagSeguro",
                        flc_Entrada = true,
                        flc_Valor = Convert.ToDecimal(lblValorPedido.Text.Replace("R$", "")),
                        flc_GrfId = baseControl.BuscaGrupoFinanceiroEntrada(),

                        flc_PagamentoConfirmado = 0,
                        flc_PagSeguro = 1,
                        flc_URLPagamento = link,


                    };
                    if (!baseControl.MatemProjetoFluxoCaixa(fluxoCaixa, IdProjeto))
                    {
                        return;
                    }

                    var pgtoPagSeguro = new frmPgtoPagSeguro();
                    pgtoPagSeguro.projeto = projeto;
                    pgtoPagSeguro.linkPagSeguro = link;
                    pgtoPagSeguro.MdiParent = this.MdiParent;
                    pgtoPagSeguro.Show();

                    var principal = (frmPrincipal)this.MdiParent;
                    principal.JanelasAbertas();
                }


            }
        }
    }
}
