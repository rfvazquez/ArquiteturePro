using System;
using System.Drawing;
using System.Windows.Forms;
using ArchitecturePro.Forms;
using ArchitecturePro.Forms.FluxoCaixa;

namespace ArchitecturePro.Componentes
{
    public partial class ControleFluxoCaixa : UserControl
    {
        private DateTime dataGeral;
        public frmFluxoCaixa principal;
        public ControleFluxoCaixa()
        {
            InitializeComponent();
        }

        public ControleFluxoCaixa(DockStyle dock)
        {
            InitializeComponent();
            this.Dock = dock;
            this.BackColor = Color.Gray;
        }
        public void SetaInformacao(string dia, string valor, bool nevativo, DateTime data)
        {
            dataGeral = data;
            lblDia.Text = dia;
            lblSaldo.Text = valor;
            if (nevativo)
            {
                lblSaldo.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblSaldo.ForeColor = System.Drawing.Color.Blue;
            }

            if (DateTime.Now.Date == data.Date)
            {
                this.BackColor = Color.BurlyWood;
            }
        }

        private void ControleFluxoCaixa_DoubleClick(object sender, EventArgs e)
        {
            if (principal != null)
            {
                var menu = (frmPrincipal)principal.MdiParent;
                var detalhe = new frmDetalheFluxoCaixa();
                detalhe.dataControle = dataGeral;
                detalhe.principal = principal;
                detalhe.MdiParent = menu;
                detalhe.Show();
                menu.JanelasAbertas();
            }
        }

        private void ControleFluxoCaixa_Load(object sender, EventArgs e)
        {

        }

        private void lblSaldo_DoubleClick(object sender, EventArgs e)
        {
            ControleFluxoCaixa_DoubleClick(sender, e);
        }

        private void lblDia_DoubleClick(object sender, EventArgs e)
        {
            ControleFluxoCaixa_DoubleClick(sender, e);
        }
    }
}
