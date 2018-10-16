using ArchitecturePro.Componentes;
using ArchitecturePro.DataBase;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ArchitecturePro.Forms.Mensagens
{
    public partial class frmTrocaMensagem : Form
    {
        private DataBaseControler baseControl = new DataBaseControler();
        public tb_usuario usuarioLogado { set; get; }
        public string usuarioTrocaMsg { set; get; }
        public int idUsuarioTrocaMsg { set; get; }

        private System.Threading.Thread threadMsg = null;
        delegate void SetTextCallback(tb_mensagens mensagens);

        public frmTrocaMensagem()
        {
            InitializeComponent();
        }

        public void MontaTela()
        {
            this.Text = $"Conversa com {usuarioTrocaMsg}";
            if (usuarioTrocaMsg.ToUpper() == "SISTEMA")
            {
                txtMsg.Enabled = false;
                btnEnviar.Enabled = false;
            }
            else
            {
                txtMsg.Enabled = true;
                btnEnviar.Enabled = true;
            }
            baseControl.MarcarMensagensComoLidas((int)usuarioLogado.usr_Id, idUsuarioTrocaMsg);
        }


        public void MontaMensagem(tb_mensagens mensagens)
        {
            var msg = new MensagemUsuario();

            msg.msg = mensagens.msg_Texto;
            msg.corFundo = new Color();
            if (usuarioLogado.usr_Id == mensagens.msg_UsrId)
            {
                msg.corFundo = Color.FromArgb(255, 228, 181);
                msg.usuario = $"{usuarioTrocaMsg} em {mensagens.msg_DataHora.ToString("dd/MM/yyyy hh:mm:ss")}";
            }
            else
            {
                msg.corFundo = Color.FromArgb(224, 255, 255);
                msg.usuario = $"{usuarioLogado.usr_Nome} em {mensagens.msg_DataHora.ToString("dd/MM/yyyy hh:mm:ss")}";
            }
            msg.Dock = DockStyle.Top;
            msg.MontaMensagem();
            pnlConversa.Controls.Add(msg);
        }


        private void VerificaMensagens()
        {
            threadMsg = new System.Threading.Thread(new System.Threading.ThreadStart(MontaMensagensTela));
            threadMsg.Start();
        }

        public void MontaMensagensTela()
        {
            var jaMostradas = new System.Collections.Generic.List<int>();
            while (true)
            {
                try
                {
                    var conversas = baseControl.BuscaConversa((int)usuarioLogado.usr_Id, idUsuarioTrocaMsg);
                    foreach (var msg in conversas)
                    {
                        if (!jaMostradas.Contains((int)msg.msg_Id))
                        {
                            jaMostradas.Add((int)msg.msg_Id);
                            SetTextCallback d = new SetTextCallback(MontaMensagem);
                            this.Invoke(d, new object[] { msg });
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                Thread.Sleep(5000);
            }
        }


        private void frmTrocaMensagem_Load(object sender, EventArgs e)
        {
            MontaTela();
            VerificaMensagens();

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtMsg.Text))
            {
                var msg = new tb_mensagens()
                {
                    msg_DataHora = DateTime.Now,
                    msg_Lida = 0,
                    msg_Texto = txtMsg.Text,
                    msg_UsrId = idUsuarioTrocaMsg,
                    msg_UsrIdEnvio = usuarioLogado.usr_Id
                };
                baseControl.CriaMensagem(msg);
                txtMsg.Text = String.Empty;
            }
        }

        private void frmTrocaMensagem_FormClosed(object sender, FormClosedEventArgs e)
        {
            threadMsg.Abort();
        }

        private void txtMsg_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMsg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btnEnviar_Click(null, null);
                e.Handled = false;
            }
        }
    }
}
