using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ArchitecturePro.ControlView;
using ArchitecturePro.DataBase;
using ArchitecturePro.Forms.Clientes;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using ArchitecturePro.Util;

namespace ArchitecturePro.Forms.GrupoFinanceiro
{
    public partial class frmGrupoFinanceiro : Form
    {
        public DataBaseControler baseControl = new DataBaseControler();
        public int linhaSelecionada = 0;
        public frmGrupoFinanceiro()
        {
            InitializeComponent();
        }

        public void CarregaTabela()
        {
            var listGrupoFinanceiroData = baseControl.BuscaTodosGruposFinanceiros();
            var listGrupoFinanceiroView = new List<ViewGrupoFinanceiro>();
            foreach (var grupoFinanceiroData in listGrupoFinanceiroData)
            {
                var grupoFinanciero = new ViewGrupoFinanceiro()
                {
                    Id = (int)grupoFinanceiroData.grf_Id,
                    Descricao = grupoFinanceiroData.grf_Descricao,
                    Data = grupoFinanceiroData.grf_Data,
                    Ativo = grupoFinanceiroData.grf_Ativo
                };
                listGrupoFinanceiroView.Add(grupoFinanciero);
            }
            grdGrupoFinanceiro.DataSource = null;
            grdGrupoFinanceiro.DataSource = listGrupoFinanceiroView;
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmControleFinanceiro_FormClosed(object sender, FormClosedEventArgs e)
        {
            var principal = (frmPrincipal)this.MdiParent;
            principal.JanelasAbertas();
        }

        private void frmGrupoFinanceiro_Load(object sender, EventArgs e)
        {
            gridView1.RowClick += grdGrupoFinanceiro_ClickRow;
            CarregaTabela();
            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.BestFitColumns();
            gridView1.VertScrollVisibility = ScrollVisibility.Auto;
            gridView1.HorzScrollVisibility = ScrollVisibility.Auto;
        }

        private void grdGrupoFinanceiro_ClickRow(object sender, RowClickEventArgs e)
        {
            linhaSelecionada = int.Parse(((GridView)sender).GetRowCellValue(e.RowHandle, "Id").ToString());
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var principal = (frmPrincipal)this.MdiParent;
            principal.IniciaAguarde();

            var mantemGrupoFinanceiro = new frmMatemGrupoFinanceiro();
            if (linhaSelecionada == 0)
            {
                Mensagem.MensagemShow("Selecione uma linha para Editar!", "Camila Moraes Arquitetura", MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
            }
            else
            {
                mantemGrupoFinanceiro.IdGrupoFinanceiro = linhaSelecionada;
                mantemGrupoFinanceiro.principal = this;
                mantemGrupoFinanceiro.MdiParent = this.MdiParent;
                mantemGrupoFinanceiro.Show();
                mantemGrupoFinanceiro.WindowState = FormWindowState.Normal;
                mantemGrupoFinanceiro.Focus();
                principal.JanelasAbertas();
            }
            principal.InterrompeAguarde();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            var principal = (frmPrincipal)this.MdiParent;
            principal.IniciaAguarde();

            var mantemGrupoFinanceiro = new frmMatemGrupoFinanceiro();
            mantemGrupoFinanceiro.principal = this;
            mantemGrupoFinanceiro.MdiParent = this.MdiParent;
            mantemGrupoFinanceiro.Show();
            mantemGrupoFinanceiro.WindowState = FormWindowState.Normal;
            mantemGrupoFinanceiro.Focus();
            principal.JanelasAbertas();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
