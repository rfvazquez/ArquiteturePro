using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ArchitecturePro.ControlView;
using ArchitecturePro.DataBase;
using ArchitecturePro.Forms.Usuario;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using ArchitecturePro.Util;

namespace ArchitecturePro.Forms.Usuario
{
    public partial class frmUsuario : Form
    {
        public DataBaseControler baseControl = new DataBaseControler();
        public int linhaSelecionada = 0;
        public frmUsuario()
        {
            InitializeComponent();
        }

        public void CarregaTabela()
        {
            var listUserData = baseControl.BuscaUsuariosExibir();
            var listUserView = new List<ViewUsuario>();
            foreach (var userData in listUserData)
            {
                var user = new ViewUsuario()
                {
                    Id = (int)userData.usr_Id,
                    Ativo = userData.usr_Ativo,
                    Data = userData.usr_Data,
                    EMail = userData.usr_Email,
                    Nome = userData.usr_Nome
                };
                listUserView.Add(user);
            }
            grdUsuario.DataSource = null;
            grdUsuario.DataSource = listUserView;
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            gridView1.RowClick += grdUsuario_ClickRow;
            CarregaTabela();
            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.BestFitColumns();
            gridView1.VertScrollVisibility = ScrollVisibility.Auto;
            gridView1.HorzScrollVisibility = ScrollVisibility.Auto;
        }

        private void grdUsuario_ClickRow(object sender, RowClickEventArgs e)
        {
            linhaSelecionada = int.Parse(((GridView)sender).GetRowCellValue(e.RowHandle, "Id").ToString());
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var principal = (frmPrincipal)this.MdiParent;
            principal.IniciaAguarde();

            var mantemUsuario = new frmMantemUsuario();
            if (linhaSelecionada == 0)
            {
                Mensagem.MensagemShow("Selecione uma linha para Editar!", "Camila Moraes Arquitetura", MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
            }
            else
            {
                mantemUsuario.IdUsuario = linhaSelecionada;
                mantemUsuario.principal = this;
                mantemUsuario.MdiParent = this.MdiParent;
                mantemUsuario.Show();
                mantemUsuario.WindowState = FormWindowState.Normal;
                mantemUsuario.Focus();
                principal.JanelasAbertas();
            }
            principal.InterrompeAguarde();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            var principal = (frmPrincipal)this.MdiParent;
            principal.IniciaAguarde();

            var mantemUsuario = new frmMantemUsuario();
            mantemUsuario.principal = this;
            mantemUsuario.MdiParent = this.MdiParent;
            mantemUsuario.Show();
            mantemUsuario.WindowState = FormWindowState.Normal;
            mantemUsuario.Focus();
            principal.JanelasAbertas();
        }

        private void grdUsuario_Click(object sender, EventArgs e)
        {

        }

        private void frmUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            var principal = (frmPrincipal)this.MdiParent;
            principal.JanelasAbertas();
        }
    }
}
