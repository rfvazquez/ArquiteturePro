using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ArchitecturePro.ControlView;
using ArchitecturePro.DataBase;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using ArchitecturePro.Util;

namespace ArchitecturePro.Forms.Despesas
{
    public partial class frmDespesas : Form
    {
        public DataBaseControler baseControl = new DataBaseControler();
        public int linhaSelecionada = 0;
        public frmDespesas()
        {
            InitializeComponent();
        }

        public void CarregaTabela()
        {
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
            grdDespesas.DataSource = null;
            grdDespesas.DataSource = listDespesasView;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDespesas_FormClosed(object sender, FormClosedEventArgs e)
        {
            var principal = (frmPrincipal)this.MdiParent;
            principal.JanelasAbertas();
        }

        private void frmDespesas_Load(object sender, EventArgs e)
        {
            gridView1.RowClick += despesas_ClickRow;
            CarregaTabela();
            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.BestFitColumns();
            gridView1.VertScrollVisibility = ScrollVisibility.Auto;
            gridView1.HorzScrollVisibility = ScrollVisibility.Auto;
        }

        private void despesas_ClickRow(object sender, RowClickEventArgs e)
        {
            linhaSelecionada = int.Parse(((GridView)sender).GetRowCellValue(e.RowHandle, "Id").ToString());
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

            var principal = (frmPrincipal)this.MdiParent;
            principal.IniciaAguarde();


            var mantemDespesas = new frmMantemDespesas();
            mantemDespesas.principal = this;
            mantemDespesas.MdiParent = this.MdiParent;
            mantemDespesas.Show();
            mantemDespesas.WindowState = FormWindowState.Normal;
            mantemDespesas.Focus();
            principal.JanelasAbertas();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var principal = (frmPrincipal)this.MdiParent;
            principal.IniciaAguarde();

            var mantemDespesas = new frmMantemDespesas();
            if (linhaSelecionada == 0)
            {
                Mensagem.MensagemShow("Selecione uma linha para Editar!", "Camila Moraes Arquitetura", MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
            }
            else
            {
                mantemDespesas.IdDespesa = linhaSelecionada;
                mantemDespesas.principal = this;
                mantemDespesas.MdiParent = this.MdiParent;
                mantemDespesas.Show();
                mantemDespesas.WindowState = FormWindowState.Normal;
                mantemDespesas.Focus();
                principal.JanelasAbertas();
            }
            principal.InterrompeAguarde();
        }
    }
}
