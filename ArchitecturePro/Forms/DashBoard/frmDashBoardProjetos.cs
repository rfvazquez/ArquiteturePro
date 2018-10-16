using System;
using System.Linq;
using System.Windows.Forms;
using ArchitecturePro.Componentes;
using ArchitecturePro.DataBase;
using ArchitecturePro.Forms.Projetos;

namespace ArchitecturePro.Forms.DashBoard
{
    public partial class frmDashBoardProjetos : Form
    {
        public DataBaseControler baseControl = new DataBaseControler();
        public frmDashBoardProjetos()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDashBoardProjetos_FormClosed(object sender, FormClosedEventArgs e)
        {
            var principal = (frmPrincipal)this.MdiParent;
            principal.JanelasAbertas();
        }

        private void frmDashBoardProjetos_Load(object sender, EventArgs e)
        {
            pnlDash.Controls.Clear();
            pnlDash.AutoScroll = true;
            var projetos = baseControl.BuscaTodosProjetos().Where(x=> x.tb_fasesProjeto.Where(y=> y.fap_Finalizada==false).Count() > 0);
            foreach (var projeto in projetos)
            {
                var compProj = new ControleProjeto();
                compProj.MontaResumoProjeto(projeto);
                compProj.DoubleClick += AcessaProjeto;
                compProj.Dock = DockStyle.Top;
                pnlDash.Controls.Add(compProj);
            }
        }

        public void AcessaProjeto(object sender, EventArgs e)
        {
            var obj = (ControleProjeto)sender;
            var frmPrj = new frmProjetos();
            frmPrj.MdiParent = this.MdiParent;
            var mantemProjetos = new frmMantemProjetos();

            mantemProjetos.IdProjeto = (int)obj.prj.prj_Id;
            mantemProjetos.principal = frmPrj;
            mantemProjetos.MdiParent = this.MdiParent;
            mantemProjetos.Show();
            mantemProjetos.WindowState = FormWindowState.Normal;
            mantemProjetos.Focus();
            var principal = (frmPrincipal)this.MdiParent;
            principal.JanelasAbertas();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

            var principal = (frmPrincipal)this.MdiParent;
            principal.IniciaAguarde();

            frmDashBoardProjetos_Load(null, null);

            principal.InterrompeAguarde();
        }
    }
}
