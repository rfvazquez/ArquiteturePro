using System;
using System.Windows.Forms;
using ArchitecturePro.DataBase;
using ArchitecturePro.Util;

namespace ArchitecturePro.Forms.Usuario
{
    public partial class frmSenhaUsuario : Form
    {
        private DataBaseControler baseControl = new DataBaseControler();
        public frmSenhaUsuario()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSenhaUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            var principal = (frmPrincipal)this.MdiParent;
            principal.JanelasAbertas();
        }

        private bool ValidaCampos()
        {
            var ret = true;
            if (String.IsNullOrEmpty(txtNovaSenha.Text))
            {
                Mensagem.MensagemShow("Senha é um campo obrigatório!", "Camila Moraes Arquitetura",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                ret = false;
            }
            
            return ret;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                var principal = (frmPrincipal)this.MdiParent;
                var usuario = principal.usuarioLogado;
                usuario.usr_Senha = txtNovaSenha.Text;
                if (baseControl.MantemUsuarios(usuario))
                {
                    Mensagem.MensagemShow("Usuário alterado com sucesso!", "Camila Moraes Arquitetura", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                    txtNovaSenha.Enabled = false;
                }
            }
        }

        private void frmSenhaUsuario_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }
    }
}
