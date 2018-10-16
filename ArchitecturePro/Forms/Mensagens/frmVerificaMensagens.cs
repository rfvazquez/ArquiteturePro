using ArchitecturePro.ControlView;
using ArchitecturePro.DataBase;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ArchitecturePro.Forms.Mensagens
{
    public partial class frmVerificaMensagens : Form
    {
        private DataBaseControler baseControl = new DataBaseControler();
        public int idUnidade = 0;
        public tb_usuario usuario = null;

        public frmVerificaMensagens()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVerificaMensagens_FormClosed(object sender, FormClosedEventArgs e)
        {
            var incial = (frmPrincipal)this.MdiParent;
            incial.JanelasAbertas();
        }

        private void grdUnidades_Load(object sender, EventArgs e)
        {

        }

        public void CarregaMensagens()
        {
            var listMensagensView = new List<ViewMensagens>();
            var users = baseControl.BuscaUsuariosExibir();
            users.Add(new tb_usuario() { usr_Nome = "Sistema", usr_Id = 0});
            foreach (var user in users)
            {
                if (user.usr_Id != usuario.usr_Id)
                {
                    var viewMsg = new ViewMensagens();
                    var conversas = baseControl.BuscaConversa((int)usuario.usr_Id, (int)user.usr_Id);
                    if (conversas.Count > 0)
                    {
                        viewMsg.DataUltimaMensagem = conversas.Max(x => x.msg_DataHora).ToString("dd/MM/yyyy hh:mm:ss");
                        viewMsg.MensagemNova = conversas.FirstOrDefault(x => x.msg_Lida == 0 && x.msg_UsrId == usuario.usr_Id) == null ? false : true;
                    }
                    else
                    {
                        viewMsg.DataUltimaMensagem = "";
                        viewMsg.MensagemNova = false;
                    }
                    viewMsg.NomeUsuario = user.usr_Nome;
                    viewMsg.UsuarioId = (int)user.usr_Id;
                    listMensagensView.Add(viewMsg);
                }
            }



            grdMensagens.DataSource = null;
            grdMensagens.DataSource = listMensagensView;


            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.BestFitColumns();
            gridView1.VertScrollVisibility = ScrollVisibility.Auto;
            gridView1.HorzScrollVisibility = ScrollVisibility.Auto;

        }

        private void frmVerificaMensagens_Load(object sender, EventArgs e)
        {
            CarregaMensagens();
            gridView1.RowClick += grdMensagens_DoubleClick;
        }


        private void grdMensagens_DoubleClick(object sender, RowClickEventArgs e)
        {
            AbreJanelaTrocaMsg(((GridView)sender).GetRowCellValue(e.RowHandle, "UsuarioId").ToString(), ((GridView)sender).GetRowCellValue(e.RowHandle, "NomeUsuario").ToString());
        }


        private void AbreJanelaTrocaMsg(string idUsuario, string nomeUsuario)
        {
            var principal = (frmPrincipal)this.MdiParent;
            var trocaMsg = new frmTrocaMensagem();
            trocaMsg.usuarioLogado = principal.usuarioLogado;
            trocaMsg.usuarioTrocaMsg = nomeUsuario;
            trocaMsg.idUsuarioTrocaMsg = Convert.ToInt32(idUsuario);
            trocaMsg.MdiParent = principal;
            trocaMsg.Show();
        }

        private void grdMensagens_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

        }
    }
}
