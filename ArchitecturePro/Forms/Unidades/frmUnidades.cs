using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ArchitecturePro.ControlView;
using ArchitecturePro.DataBase;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using ArchitecturePro.Util;

namespace ArchitecturePro.Forms.Unidades
{
    public partial class frmUnidades : Form
    {

        public DataBaseControler baseControl = new DataBaseControler();
        public int linhaSelecionada = 0;

        public void CarregaTabela()
        {
            var listUnidadesData = baseControl.BuscaTodasUnidades();
            var listUnidadeView = new List<ViewUnidade>();
            foreach (var unidadeData in listUnidadesData)
            {
                var unidade = new ViewUnidade()
                {
                    Id = (int)unidadeData.uni_Id,
                    Descricao = unidadeData.uni_Descricao
                };
                listUnidadeView.Add(unidade);
            }
            grdUnidades.DataSource = null;
            grdUnidades.DataSource = listUnidadeView;
        }
        public frmUnidades()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUnidades_FormClosed(object sender, FormClosedEventArgs e)
        {
            var principal = (frmPrincipal)this.MdiParent;
            principal.JanelasAbertas();

        }

        private void frmUnidades_Load(object sender, EventArgs e)
        {
            gridView1.RowClick += grdUnidades_ClickRow;
            CarregaTabela();

            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.BestFitColumns();
            gridView1.VertScrollVisibility = ScrollVisibility.Auto;
            gridView1.HorzScrollVisibility = ScrollVisibility.Auto;
        }

        private void grdUnidades_ClickRow(object sender, RowClickEventArgs e)
        {
            linhaSelecionada = int.Parse(((GridView)sender).GetRowCellValue(e.RowHandle, "Id").ToString());
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var principal = (frmPrincipal)this.MdiParent;
            principal.IniciaAguarde();

            var mantemUnidades = new frmMantemUnidades();
            if (linhaSelecionada == 0)
            {
                Mensagem.MensagemShow("Selecione uma linha para Editar!", "Camila Moraes Arquitetura", MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
            }
            else
            {
                mantemUnidades.idUnidade = linhaSelecionada;
                mantemUnidades.principal = this;
                mantemUnidades.MdiParent = this.MdiParent;
                mantemUnidades.Show();
                mantemUnidades.WindowState = FormWindowState.Normal;
                mantemUnidades.Focus();
                principal.JanelasAbertas();
            }

            principal.InterrompeAguarde();

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            var mantemUnidade = new frmMantemUnidades();
            mantemUnidade.principal = this;
            mantemUnidade.MdiParent = this.MdiParent;
            mantemUnidade.Show();
            mantemUnidade.WindowState = FormWindowState.Normal;
            mantemUnidade.Focus();
            var principal = (frmPrincipal)this.MdiParent;
            principal.JanelasAbertas();

        }
    }
}
