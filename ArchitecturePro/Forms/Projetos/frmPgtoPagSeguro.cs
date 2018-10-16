using ArchitecturePro.DataBase;
using ArchitecturePro.Util;
using System;
using System.Diagnostics;
using System.Web;
using System.Windows.Forms;

namespace ArchitecturePro.Forms.Projetos
{
    public partial class frmPgtoPagSeguro : Form
    {
        public tb_projeto projeto { set; get; }
        public string linkPagSeguro { set; get; }
        public frmPgtoPagSeguro()
        {
            InitializeComponent();
        }

        public string GeraMensagem()
        {
            var msg = "";

            msg = $"Caro {projeto.tb_cliente.cli_Contato}, Segue link para pagamento do projeto de código {projeto.prj_Id} ";
            msg = $"{msg} {linkPagSeguro} ";
            msg = $"{msg} Qualquer dúvida estámos à disposição.";
            msg = $"{msg} Atenciosamente";

            return msg;
        }

        private void MontaTelaEmail()
        {
            txtMailCliente.Text = projeto.tb_cliente.cli_Email;
            txtMensagem.Text = GeraMensagem();
            txtTelefone.Text = projeto.tb_cliente.cli_Celular;
        }

        private void frmPgtoPagSeguro_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            MontaTelaEmail();
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtMailCliente.Text))
            {
                var principal = (frmPrincipal)this.MdiParent;

                if (Util.EnviarEmail.SendMail(txtMailCliente.Text, $"Cobrança {Mensagem.nomeSistema}", txtMensagem.Text))
                {
                    Mensagem.MensagemShow("E-Mail Enviado com Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Mensagem.MensagemShow("Erro ao tentar realizar o envio do Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Mensagem.MensagemShow("Entre com o Email do Cliente para Envio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnWhatsApp_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtTelefone.Text))
            {
                var telFormatado = txtTelefone.Text.Replace(")", "").Replace("(", "").Replace("-", "").Replace(" ","").Trim();
                var link = HttpUtility.UrlEncode(txtMensagem.Text).Replace("+"," ");
                ProcessStartInfo sInfo = new ProcessStartInfo($"https://api.whatsapp.com/send?phone=55{telFormatado}&text={link}");
                Process.Start(sInfo);
            }
            else
            {
                Mensagem.MensagemShow("Entre com o Numero de Telefone para envio do WhatsApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}