using System;
using System.Windows.Forms;
using ArchitecturePro.ControlView;
using ArchitecturePro.DataBase;
using DevExpress.Data.Linq;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

namespace ArchitecturePro.Forms.FormUtil
{
    public partial class frmBuscaItem : Form
    {
        public DataBaseControler baseControl = new DataBaseControler();
        public int linhaSelecionada = 0;
        public TrocaSelecaoDados trocaObjeto;
        public frmBuscaItem()
        {
            InitializeComponent();
        }

        public void CarregaTabela(object dataSource)
        {
            grdItem.DataSource = null;
            grdItem.DataSource = dataSource;
            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.BestFitColumns();
            gridView1.VertScrollVisibility = ScrollVisibility.Auto;
            gridView1.HorzScrollVisibility = ScrollVisibility.Auto;
        }

        private void grdItem_ClickRow(object sender, RowClickEventArgs e)
        {
            try
            {
                trocaObjeto.Id = int.Parse(((GridView)sender).GetRowCellValue(e.RowHandle, "Id").ToString());
            }
            catch (Exception)
            {

            }
        }

        private void frmBuscaItem_Load(object sender, EventArgs e)
        {
            gridView1.RowClick += grdItem_ClickRow;
        }

        private void grdItem_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceitar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            trocaObjeto.Id = 0;
            this.Close();
        }
    }
}
