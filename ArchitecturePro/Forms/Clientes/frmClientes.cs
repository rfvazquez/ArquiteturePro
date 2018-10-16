using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ArchitecturePro.ControlView;
using ArchitecturePro.DataBase;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using ArchitecturePro.Util;

namespace ArchitecturePro.Forms.Clientes
{
    public partial class frmClientes : Form
    {
        public DataBaseControler baseControl = new DataBaseControler();
        public int linhaSelecionada = 0;

        public void CarregaTabela()
        {
            var listClienteData = baseControl.BuscaTodosClientes();
            var listClientesView = new List<ViewClientes>();
            foreach (var clienteData in listClienteData)
            {
                var cliente = new ViewClientes()
                {
                    Id = (int)clienteData.cli_Id,
                    Descricao =  clienteData.cli_Descricao,
                    Fantasia = clienteData.cli_Fantasia, 
                    Cpf = clienteData.cli_CpfCnpj, 
                    Logradouro = clienteData.cli_Logradouro,
                    Numero = clienteData.cli_Numero, 
                    Cidade = clienteData.cli_Cidade, 
                    Estado = clienteData.cli_Estado,
                    CEP = clienteData.cli_CEP, 
                    Complemento = clienteData.cli_Complemento, 
                    Contato = clienteData.cli_Contato, 
                    Telefone = clienteData.cli_Telefone, 
                    Celular = clienteData.cli_Celular,
                    EMail = clienteData.cli_Email,
                    Data = clienteData.cli_Data,
                    Ativo = clienteData.cli_Ativo,
                    LogradouroObra = clienteData.cli_LogradouroObra,
                    NumeroObra = clienteData.cli_NumeroObra,
                    CEPObra = clienteData.cli_CEPObra,
                    CidadeObra = clienteData.cli_CidadeObra,
                    ComplementoObra = clienteData.cli_ComplementoObra,
                    EstadoObra = clienteData.cli_EstadoObra,
                    Bairro = clienteData.cli_Bairro,
                    BairroObra = clienteData.cli_BairroObra
                };
                listClientesView.Add(cliente);
            }
            grdCliente.DataSource = null;
            grdCliente.DataSource = listClientesView;
        }



        public frmClientes()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            gridView1.RowClick += grdCliente_ClickRow;
            CarregaTabela();
            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.BestFitColumns();
            gridView1.VertScrollVisibility = ScrollVisibility.Auto;
            gridView1.HorzScrollVisibility = ScrollVisibility.Auto;

        }

        private void grdCliente_ClickRow(object sender, RowClickEventArgs e)
        {
            linhaSelecionada = int.Parse(((GridView)sender).GetRowCellValue(e.RowHandle, "Id").ToString());
        }

        private void frmClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            var principal = (frmPrincipal)this.MdiParent;
            principal.JanelasAbertas();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {


            var principal = (frmPrincipal)this.MdiParent;
            principal.IniciaAguarde();

            var mantemCliente = new frmMantemClientes();
            mantemCliente.principal = this;
            mantemCliente.MdiParent = this.MdiParent;
            mantemCliente.Show();
            mantemCliente.WindowState = FormWindowState.Normal;
            mantemCliente.Focus();
            principal.JanelasAbertas();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            var principal = (frmPrincipal)this.MdiParent;
            principal.IniciaAguarde();


            var mantemCliente = new frmMantemClientes();
            if (linhaSelecionada == 0)
            {
                Mensagem.MensagemShow("Selecione uma linha para Editar!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                mantemCliente.IdCliente = linhaSelecionada;
                mantemCliente.principal = this;
                mantemCliente.MdiParent = this.MdiParent;
                mantemCliente.Show();
                mantemCliente.WindowState = FormWindowState.Normal;
                mantemCliente.Focus();
                principal = (frmPrincipal)this.MdiParent;
                principal.JanelasAbertas();
            }

            principal.InterrompeAguarde();
        }
    }
}
