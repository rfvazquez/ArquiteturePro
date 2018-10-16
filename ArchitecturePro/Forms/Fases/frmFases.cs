using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ArchitecturePro.ControlView;
using ArchitecturePro.DataBase;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using ArchitecturePro.Util;

namespace ArchitecturePro.Forms.Fases
{
    public partial class frmFases : Form
    {
        public DataBaseControler baseControl = new DataBaseControler();
        public int linhaSelecionada = 0;
        public frmFases()
        {
            InitializeComponent();
        }

        public void CarregaTabela()
        {
            var listFasesData = baseControl.BuscaFases();
            var listFasesView = new List<ViewFases>();
            foreach (var faseData in listFasesData)
            {
                var fase = new ViewFases()
                {
                    Id = (int)faseData.fas_Id,
                    Descricao = faseData.fas_Descricao,
                    DiasEntrega = (int)faseData.fas_Dias,
                    Ativo = faseData.fas_Ativo
                };
                listFasesView.Add(fase);
            }
            grdFasesProjeto.DataSource = null;
            grdFasesProjeto.DataSource = listFasesView;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFasesProjeto_FormClosed(object sender, FormClosedEventArgs e)
        {
            var principal = (frmPrincipal)this.MdiParent;
            principal.JanelasAbertas();
        }

        private void frmFasesProjeto_Load(object sender, EventArgs e)
        {
            gridView1.RowClick += grdFase_ClickRow;
            CarregaTabela();
            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.BestFitColumns();
            gridView1.VertScrollVisibility = ScrollVisibility.Auto;
            gridView1.HorzScrollVisibility = ScrollVisibility.Auto;
        }

        private void grdFase_ClickRow(object sender, RowClickEventArgs e)
        {
            linhaSelecionada = int.Parse(((GridView)sender).GetRowCellValue(e.RowHandle, "Id").ToString());
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            var principal = (frmPrincipal)this.MdiParent;
            principal.IniciaAguarde();

            var mantemFase = new frmMatemFase();
            mantemFase.principal = this;
            mantemFase.MdiParent = this.MdiParent;
            mantemFase.Show();
            mantemFase.WindowState = FormWindowState.Normal;
            mantemFase.Focus();
            principal.JanelasAbertas();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var principal = (frmPrincipal)this.MdiParent;
            principal.IniciaAguarde();

            var mantemFase = new frmMatemFase();
            if (linhaSelecionada == 0)
            {
                Mensagem.MensagemShow("Selecione uma linha para Editar!", "Camila Moraes Arquitetura", MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
            }
            else
            {
                mantemFase.IdFase = linhaSelecionada;
                mantemFase.principal = this;
                mantemFase.MdiParent = this.MdiParent;
                mantemFase.Show();
                mantemFase.WindowState = FormWindowState.Normal;
                mantemFase.Focus();
                principal.JanelasAbertas();
            }

            principal.InterrompeAguarde();
        }
    }   
}
