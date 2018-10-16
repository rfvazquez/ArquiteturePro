using System;
using System.Windows.Forms;
using ArchitecturePro.DataBase;
using System.Linq;
using System.Collections.Generic;
using ArchitecturePro.Util;

namespace ArchitecturePro.Forms.Usuario
{
    public partial class frmMantemUsuario : Form
    {
        private DataBaseControler baseControl = new DataBaseControler();
        public int IdUsuario = 0;
        public frmUsuario principal = null;
        public frmMantemUsuario()
        {
            InitializeComponent();
        }

        private void CarregaListaAcessos()
        {
            cblAcessos.Items.Clear();
            cblAcessos.Items.AddRange(baseControl.BuscaTelas().ToArray());
            cblAcessos.DisplayMember = "tel_Nome";
            cblAcessos.ValueMember = "tel_Id";
        }

        private void MarcaAcesso()
        {
            try
            {
                var acesssosUsuario = baseControl.BuscaTelas(IdUsuario);
                for (int i = 0; i <= (cblAcessos.Items.Count - 1); i++)
                {
                    var idTela = (tb_telas)cblAcessos.Items[i];
                  if (acesssosUsuario.FirstOrDefault(x => x.tel_Id == idTela.tel_Id) != null)
                    {
                        cblAcessos.SetItemCheckState(i, CheckState.Checked);
                    }
                    else
                    {
                        cblAcessos.SetItemCheckState(i, CheckState.Unchecked);
                    }
                }
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow($"Erro ao carregar os acessos do usuário \n\r {ex.Message}", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }


        private void frmMantemUsuario_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            if (IdUsuario != 0)
            {
                var usuario = baseControl.BuscaUsuariosId(IdUsuario);
                txtNomeUsuario.Text = usuario.usr_Nome;
                ckbAtivo.Checked = usuario.usr_Ativo;
                txtEmail.Text = usuario.usr_Email;
            }
            CarregaListaAcessos();
            MarcaAcesso();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlBotoes_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool ValidaCampos()
        {
            var ret = true;
            if (String.IsNullOrEmpty(txtNomeUsuario.Text))
            {
                Mensagem.MensagemShow("Nome do usuário é um campo obrigatório!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                ret = false;
            }
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                Mensagem.MensagemShow("E-Mail é um campo obrgatório!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                ret = false;
            }
            return ret;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (ValidaCampos())
            {
                if (IdUsuario == 0)
                {
                    Random random = new Random();
                    var senha = random.Next(1000, 9999);
                    var usuario = new tb_usuario()
                    {
                        usr_Nome = txtNomeUsuario.Text,
                        usr_Ativo = ckbAtivo.Checked,
                        usr_Email = txtEmail.Text,
                        usr_Senha = senha.ToString(),
                        usr_Data = DateTime.Now
                    };
                    if (baseControl.MantemUsuarios(usuario))
                    {
                        if (Util.EnviarEmail.SendMail(txtEmail.Text, "Senha Sistema Architecture Pro",
                            String.Format("Sua senha para acesso ao sistema é: {0}", senha.ToString())))
                        {
                            Mensagem.MensagemShow("Usuário criado com sucesso!", MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk);
                        }
                        BloqueiaCampos(false);
                    }
                }
                else
                {
                    var usuario = baseControl.BuscaUsuariosId(IdUsuario);
                    usuario.usr_Nome = txtNomeUsuario.Text;
                    usuario.usr_Ativo = ckbAtivo.Checked;
                    usuario.usr_Email = txtEmail.Text;
                    usuario.usr_Data = DateTime.Now;
                    if (baseControl.MantemUsuarios(usuario))
                    {
                        //new Util.EnviarEmail().SendMail(txtEmail.Text, "Senha Sistema Camila Moraes Arquitetura",
                        //    String.Format("Sua senha para acesso ao sistema é: {0}", usuario.usr_Senha.ToString()));

                        Mensagem.MensagemShow("Usuário alterado com sucesso!", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                        BloqueiaCampos(false);
                    }
                }
                var telas = new List<tb_telas>();
                foreach (object itemChecked in cblAcessos.CheckedItems)
                {
                    var item = (tb_telas)itemChecked;
                    telas.Add(item);
                }
                baseControl.SalvaAcessosUsuario(telas, IdUsuario);
            }
            principal.CarregaTabela();
        }

        private void BloqueiaCampos(bool status)
        {
            txtNomeUsuario.Enabled = status;
            txtEmail.Enabled = status;
            ckbAtivo.Enabled = status;
            btnSalvar.Enabled = status;
        }

        private void frmMantemUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            var incial = (frmPrincipal)principal.MdiParent;
            incial.JanelasAbertas();
        }
    }

}
