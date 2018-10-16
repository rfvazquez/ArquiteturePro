using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ArchitecturePro.ControlView;
using ArchitecturePro.DataBase;
using ArchitecturePro.Forms.Projetos;
using DevExpress.XtraGrid.Views.Base;

namespace ArchitecturePro.Forms.FluxoCaixa
{
    public partial class frmDetalheFluxoCaixa : Form
    {
        public DataBaseControler baseControl = new DataBaseControler();
        public DateTime dataControle;
        public frmFluxoCaixa principal;
        public void CarregaDetalheFluxoCaixa(DateTime data)
        {
            var listDiaFluxoCaixaData = baseControl.BuscaFluxoCaixaDia(data);
            var listDiaFluxoCaixaView = new List<ViewDetalheFluxoCaixa>();
            foreach (var diaFluxoCaixa in listDiaFluxoCaixaData)
            {
                var proj = "";
                try
                {
                    proj = String.Format("ID:{0} | {1}", diaFluxoCaixa.tb_projetoFluxoCaixa.FirstOrDefault().pfc_PrjId, diaFluxoCaixa.tb_projetoFluxoCaixa.FirstOrDefault().tb_projeto.tb_cliente.cli_Fantasia);
                }
                catch (Exception){ }

                var detalheFluxoCaixa = new ViewDetalheFluxoCaixa()
                {
                    Valor = diaFluxoCaixa.flc_Valor.ToString(),
                    Descricao = diaFluxoCaixa.flc_Descricao,
                    Data = diaFluxoCaixa.flc_DataCaixa,
                    Entrada = diaFluxoCaixa.flc_Entrada,
                    Projeto = proj

                };
                listDiaFluxoCaixaView.Add(detalheFluxoCaixa);
            }
            grdDetalheFluxo.DataSource = null;
            grdDetalheFluxo.DataSource = listDiaFluxoCaixaView;
            lblMes.Text = String.Format("Detalhado {0}/{1}/{2}", data.Day ,data.Month, data.Year);
        }
        public frmDetalheFluxoCaixa()
        {
            InitializeComponent();
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            dataControle = dataControle.AddDays(1);
            CarregaDetalheFluxoCaixa(dataControle);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            dataControle = dataControle.AddDays(-1);
            CarregaDetalheFluxoCaixa(dataControle);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDetalheFluxoCaixa_FormClosed(object sender, FormClosedEventArgs e)
        {
            var menu = (frmPrincipal) principal.MdiParent;
            menu.JanelasAbertas();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregaDetalheFluxoCaixa(dataControle);
        }

        private void frmDetalheFluxoCaixa_Load(object sender, EventArgs e)
        {
            CarregaDetalheFluxoCaixa(dataControle);
            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.BestFitColumns();
            gridView1.VertScrollVisibility = ScrollVisibility.Auto;
            gridView1.HorzScrollVisibility = ScrollVisibility.Auto;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mantemProjeto = new frmMantemProjetos();
            mantemProjeto.MdiParent = this.MdiParent;

            var mantemFluxoCaixa = new frmMantemFluxoCaixa();
            mantemFluxoCaixa.dataLancamento = dataControle;
            mantemFluxoCaixa.principal = mantemProjeto;
            mantemFluxoCaixa.Show();
            mantemFluxoCaixa.WindowState = FormWindowState.Normal;
            mantemFluxoCaixa.Focus();
            var principal = (frmPrincipal)this.MdiParent;
            principal.JanelasAbertas();

        }
    }
}
