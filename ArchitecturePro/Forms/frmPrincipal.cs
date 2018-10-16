using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ArchitecturePro.ControlView;
using ArchitecturePro.DataBase;
using ArchitecturePro.Util;
using ArchitecturePro.Forms.FormUtil;
using ArchitecturePro.Componentes;
using System.Threading;
using System.Linq;
using ArchitecturePro.Forms.Mensagens;

namespace ArchitecturePro.Forms
{
    public partial class frmPrincipal : Form
    {

        public tb_usuario usuarioLogado = null;
        private System.Threading.Thread tFormAguarde = null;
        public DataBaseControler baseControl = new DataBaseControler();
        private System.Threading.Thread threadMsg = null;
        delegate void SetTextCallback(string texto);

        #region Menu do Sistema
        public void GeraMenuSistema()
        {
            var telas = baseControl.BuscaTelas((int)usuarioLogado.usr_Id);
            pnlBtnMenus.Controls.Clear();
            foreach (var tela in telas)
            {
                var btn = new BotaoMenu()
                {
                    nome = tela.tel_Nome,
                    formulario = tela.tel_frmPrincipal,
                    icone = tela.tel_Icone,
                    principal = this
                };
                btn.CriaBotao();
                btn.Dock = DockStyle.Top;
                pnlBtnMenus.Controls.Add(btn);
            }
        }
        #endregion

        #region Aguarde
        public void IniciaAguarde()
        {
            tFormAguarde = new System.Threading.Thread(new System.Threading.ThreadStart(VisibleAguarde));
            tFormAguarde.Start();
        }
        private void VisibleAguarde()
        {
            try
            {
                Form aguarde = new frmAguarde();
                aguarde.ShowDialog();
            }
            catch (Exception ex)
            {

            }
        }
        public void InterrompeAguarde()
        {
            try
            {
                tFormAguarde.Abort();
            }
            catch (Exception ex) { }
        }

        public frmPrincipal()
        {
            InitializeComponent();
            this.Cursor = DefaultCursor;
        }
        #endregion

        #region Verifica Mensagens
        private void VerificaMensagens()
        {
            threadMsg = new System.Threading.Thread(new System.Threading.ThreadStart(VerificaMensagensSystem));
            threadMsg.Start();
        }

        public void DefinirNumeroMsg(string nMensagem)
        {
            try
            {
                this.btnMsg.Text = nMensagem;
            }
            catch (Exception ex)
            {

            }
        }

        private void VerificaMensagensSystem()
        {
            while (true)
            {
                try
                {
                    SetTextCallback d = new SetTextCallback(DefinirNumeroMsg);
                    this.Invoke(d, new object[] { baseControl.BuscaNumeroMsg((int)usuarioLogado.usr_Id) });
                    Thread.Sleep(5000);
                }
                catch (Exception)
                {

                }
            }
        }

        #endregion

        #region Login Google
        private void VerificaStatusGoogle()
        {
            var arquivo = "";
            if (GoogleDrive.CriarServicoGoogleDrive())
            {
                arquivo = $"{Application.StartupPath}/Imagens/GoogleDrive.png";
                lblGoogleDriveText.Text = "Google Drive On-Line";
            }
            else
            {
                arquivo = $"{Application.StartupPath}/Imagens/GoogleDriveOff.png";
                lblGoogleDriveText.Text = "Google Drive Off-Line";
            }
            lblGoogleDriveImage.Image = System.Drawing.Image.FromFile(arquivo);
        }
        #endregion

        #region Eventos do sistema
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.Text = string.Format("Architecture Pro by {2} - Principal - {0} - Versão: {1}", usuarioLogado.usr_Nome, System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString(), Mensagem.nomeSistema);
            GeraMenuSistema();
            VerificaStatusGoogle();
            VerificaMensagens();
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            threadMsg.Abort();
            System.Windows.Forms.Application.Exit();
        }

        #endregion

        #region Lista janelas Abertas

        public void JanelasAbertas()
        {
            try
            {
                ///lstJanelas.Items.Clear();
                var forms = Application.OpenForms;
                lstJanelas.DisplayMember = "Descricao";
                lstJanelas.ValueMember = "Id";
                List<ItensJanela> listJanelas = new List<ItensJanela>();
                foreach (var form in forms)
                {
                    var titulo = form.ToString();
                    titulo = titulo.Substring(titulo.IndexOf("Text:") + 6).Replace(Mensagem.nomeSistema, "");
                    if (!(titulo.Contains("Principal") || titulo.Contains("Login") || titulo.Contains("Aguarde")))
                    {
                        var item = new ItensJanela();
                        item.Id = form.GetHashCode().ToString();
                        item.Descricao = titulo;
                        listJanelas.Add(item);
                        //lstJanelas.Items.Add(String.Format("{0} - {1}", form.GetHashCode(), titulo));
                    }
                }
                lstJanelas.DataSource = listJanelas;
            }
            catch (Exception ex)
            {

            }
            InterrompeAguarde();
        }


        private void lstJanelas_DoubleClick(object sender, EventArgs e)
        {
            //    var selecionado = lstJanelas.SelectedItem;
            //var codigo = selecionado.Substring(0, selecionado.IndexOf("-")).Trim();7

            var codigo = lstJanelas.SelectedValue;
            var forms = Application.OpenForms;
            var pos = 0;
            foreach (var form in forms)
            {
                if (form.GetHashCode().ToString() == codigo.ToString())
                {
                    Application.OpenForms[pos].Focus();
                }
                pos++;
            }

        }
        #endregion

        private void btnMsg_Click(object sender, EventArgs e)
        {
            try
            {
                var msg = new frmVerificaMensagens();
                IniciaAguarde();
                if (Application.OpenForms.OfType<Form>().FirstOrDefault(x => x.Name == "frmVerificaMensagens") != null)
                {
                    Application.OpenForms.OfType<Form>().FirstOrDefault(x => x.Name == "frmVerificaMensagens").Focus();
                }
                else
                {
                    msg.usuario = usuarioLogado;
                    msg.MdiParent = this;
                    msg.Show();
                }
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow($"Erro ao tentar criar o botão {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            JanelasAbertas();
        }
    }
}
