using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArchitecturePro.ControlView;
using ArchitecturePro.DataBase;
using ArchitecturePro.Forms.GrupoFinanceiro;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using ArchitecturePro.Forms.FormUtil;
using System.Threading;
using ArchitecturePro.Util;

namespace ArchitecturePro.Forms.Projetos
{
    public partial class frmProjetos : Form
    {
        public DataBaseControler baseControl = new DataBaseControler();
        public int linhaSelecionada = 0;




        public void CarregaTabela()
        {
            var listProjetosData = baseControl.BuscaTodosProjetos();
            var listProjetosView = new List<ViewProjeto>();
            foreach (var projetoData in listProjetosData)
            {
                var projeto = new ViewProjeto()
                {
                    Id = (int)projetoData.prj_Id,
                    Cliente = projetoData.tb_cliente.cli_Fantasia,
                    DataInicio = projetoData.prj_DataInicio,
                    DataFimPrevista = projetoData.prj_DataFimPrevista,
                    DataFimReal = projetoData.prj_DataFimReal,
                    UsuarioInclusao = projetoData.tb_usuario.usr_Nome
                };
                listProjetosView.Add(projeto);
            }
            grdProjeto.DataSource = null;
            grdProjeto.DataSource = listProjetosView;
        }

        public frmProjetos()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void frmProjetos_FormClosed(object sender, FormClosedEventArgs e)
        {
            var principal = (frmPrincipal)this.MdiParent;
            principal.JanelasAbertas();

        }

        private void frmProjetos_Load(object sender, EventArgs e)
        {
            //Thread.Sleep(500);

            gridView1.RowClick += grdProjetos_ClickRow;
            CarregaTabela();

            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.BestFitColumns();
            gridView1.VertScrollVisibility = ScrollVisibility.Auto;
            gridView1.HorzScrollVisibility = ScrollVisibility.Auto;

        }
        private void grdProjetos_ClickRow(object sender, RowClickEventArgs e)
        {
            linhaSelecionada = int.Parse(((GridView)sender).GetRowCellValue(e.RowHandle, "Id").ToString());
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            var principal = (frmPrincipal)this.MdiParent;
            principal.IniciaAguarde();

            var mantemProjetos = new frmMantemProjetos();
            mantemProjetos.principal = this;
            mantemProjetos.MdiParent = this.MdiParent;
            mantemProjetos.Show();
            mantemProjetos.WindowState = FormWindowState.Normal;
            mantemProjetos.Focus();

            principal.JanelasAbertas();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            var principal = (frmPrincipal)this.MdiParent;
            principal.IniciaAguarde();

            var mantemProjetos = new frmMantemProjetos();
            if (linhaSelecionada == 0)
            {
                Mensagem.MensagemShow("Selecione uma linha para Editar!", "Camila Moraes Arquitetura", MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
            }
            else
            {


                mantemProjetos.IdProjeto = linhaSelecionada;
                mantemProjetos.principal = this;
                mantemProjetos.MdiParent = this.MdiParent;
                mantemProjetos.Show();
                mantemProjetos.WindowState = FormWindowState.Normal;
                mantemProjetos.Focus();

                principal.JanelasAbertas();
            }

            principal.InterrompeAguarde();

        }

        private void frmProjetos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.MdiChildren.Length != 0)
            {
                e.Cancel = true;
            }
        }
    }
}
