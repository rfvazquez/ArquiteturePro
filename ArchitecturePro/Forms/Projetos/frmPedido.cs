using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using ArchitecturePro.DataBase;

namespace ArchitecturePro.Forms.Projetos
{
    public partial class frmPedido : Form
    {
        public DataBaseControler baseControl = new DataBaseControler();
        public int IdCliente = 0;
        public int IdPedido = 0;
        private Panel pannel = null;
        private Bitmap MemoryImage;
        public string valorPedido;
        public string Observacao = "";
        
        public frmPedido()
        {
            InitializeComponent();
            printDocument1.PrintPage += new PrintPageEventHandler(printdoc1_PrintPage);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnlBotoes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        public void MontaListaItens()
        {
            lblItem.Text = "";
            lblDescricao.Text = "";
            lblQtde.Text = "";
            lblValor.Text = "";

            var itens = baseControl.BuscaItemPedidoProjeto(IdPedido);
            var cont = 1;
            foreach (var item in itens)
            {
                lblItem.Text = String.Format("{2}{0}{1}", cont, Environment.NewLine, lblItem.Text);
                lblDescricao.Text = String.Format("{2}{0}{1}", item.tb_servicos.ser_Descricao, Environment.NewLine, lblDescricao.Text);
                lblQtde.Text = String.Format("{2}{0}{1}", item.ipo_Qtde, Environment.NewLine, lblQtde.Text);
                lblValor.Text = String.Format("{2}{0}{1}", item.ipo_Valor, Environment.NewLine, lblValor.Text);
                cont++;
            }
        }

        private void pnlImprimir_Paint(object sender, PaintEventArgs e)
        {

        
        }

        

        public void GetPrintArea(Panel pnl)
        {
            MemoryImage = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(MemoryImage, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            if (MemoryImage != null)
            {
                e.Graphics.DrawImage(MemoryImage, 0, 0);
                base.OnPaint(e);
            }
        }
        void printdoc1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(MemoryImage, (pagearea.Width / 2) - (pannel.Width / 2), pannel.Location.Y);
        }
        public void Print(Panel pnl)
        {
            pannel = pnl;
            GetPrintArea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Print(this.pnlImprimir);
        }

        private void lblValor_Click(object sender, EventArgs e)
        {

        }

        private void gbxDetalhamento_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void printPreviewDialog1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            lblNOrcamento.Text = String.Format("{0}/{1}", IdPedido, DateTime.Now.Year);
            var cliente = baseControl.BuscaClenteId(IdCliente);
            lblDadosCliente.Text = String.Format("{0} - {1}{2}{3} - {4}{5}{6}{7}{8}",
                cliente.cli_Fantasia,
                cliente.cli_CpfCnpj,
                Environment.NewLine,
                cliente.cli_Celular,
                cliente.cli_Email,
                Environment.NewLine,
                cliente.cli_Logradouro + "," + cliente.cli_Numero + " - " + cliente.cli_Bairro,
                Environment.NewLine,
                cliente.cli_Cidade + "," + cliente.cli_Estado + " - " + cliente.cli_CEP);

            MontaListaItens();

            lblValorTotal.Text = String.Format("R${0}", Math.Round(Convert.ToDecimal(baseControl.CalculaValorTotalItensProjeto(IdPedido)), 2));

            lblObs.Text = Observacao;

            Print(this.pnlImprimir);
        }
    }
}
