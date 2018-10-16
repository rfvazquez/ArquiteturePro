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
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using ArchitecturePro.Util;

namespace ArchitecturePro.Forms.Servicos
{
    public partial class frmServicos : Form
    {
        public DataBaseControler baseControl = new DataBaseControler();
        public int linhaSelecionada = 0;
        public frmServicos()
        {
            InitializeComponent();
        }

        public void CarregaTabela()
        {
            var listServicosData = baseControl.BuscaTodosServicos();
            var listServicosView = new List<ViewServicos>();
            foreach (var servicosData in listServicosData)
            {
                var servicos = new ViewServicos()
                {
                    Id = (int)servicosData.ser_Id,
                    Descricao = servicosData.ser_Descricao,
                    Data = servicosData.ser_Data,
                    Ativo = servicosData.ser_Ativo,
                    Unidade = servicosData.tb_unidade.uni_Descricao,
                    Valor = servicosData.ser_Valor
                };
                listServicosView.Add(servicos);
            }
            grdServicos.DataSource = null;
            grdServicos.DataSource = listServicosView;
            
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            ;
        }

        private void frmServicos_FormClosed(object sender, FormClosedEventArgs e)
        {
            var principal = (frmPrincipal)this.MdiParent;
            principal.JanelasAbertas();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            var principal = (frmPrincipal)this.MdiParent;
            principal.IniciaAguarde();

            var mantemServico = new frmMantemServico();
            mantemServico.principal = this;
            mantemServico.MdiParent = this.MdiParent;
            mantemServico.Show();
            mantemServico.WindowState = FormWindowState.Normal;
            mantemServico.Focus();
            principal.JanelasAbertas();
        }

        private void frmServicos_Load(object sender, EventArgs e)
        {
            gridView1.RowClick += grdServicos_ClickRow;
            CarregaTabela();

            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.BestFitColumns();
            gridView1.VertScrollVisibility = ScrollVisibility.Auto;
            gridView1.HorzScrollVisibility = ScrollVisibility.Auto;
        }
        private void grdServicos_ClickRow(object sender, RowClickEventArgs e)
        {
            linhaSelecionada = int.Parse(((GridView)sender).GetRowCellValue(e.RowHandle, "Id").ToString());
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var principal = (frmPrincipal)this.MdiParent;
            principal.IniciaAguarde();

            var mantemServico = new frmMantemServico();
            if (linhaSelecionada == 0)
            {
                Mensagem.MensagemShow("Selecione uma linha para Editar!", "Camila Moraes Arquitetura", MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
            }
            else
            {
                mantemServico.IdServico = linhaSelecionada;
                mantemServico.principal = this;
                mantemServico.MdiParent = this.MdiParent;
                mantemServico.Show();
                mantemServico.WindowState = FormWindowState.Normal;
                mantemServico.Focus();
                principal.JanelasAbertas();
            }

            principal.InterrompeAguarde();
        }
    }
}
