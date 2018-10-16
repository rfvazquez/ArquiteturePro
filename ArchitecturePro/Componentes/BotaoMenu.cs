using System;
using System.Linq;
using System.Windows.Forms;
using ArchitecturePro.Forms;
using ArchitecturePro.Forms.Clientes;
using ArchitecturePro.Forms.DashBoard;
using ArchitecturePro.Forms.Despesas;
using ArchitecturePro.Forms.Fases;
using ArchitecturePro.Forms.FluxoCaixa;
using ArchitecturePro.Forms.GrupoFinanceiro;
using ArchitecturePro.Forms.Projetos;
using ArchitecturePro.Forms.Servicos;
using ArchitecturePro.Forms.Unidades;
using ArchitecturePro.Forms.Usuario;
using ArchitecturePro.Util;

namespace ArchitecturePro.Componentes
{
    public partial class BotaoMenu : UserControl
    {

        public string formulario { set; get; }
        public string nome { set; get; }
        public string icone { set; get; }

        public frmPrincipal principal { set; get; }
        public void CriaBotao()
        {
            btnMenu.Text = nome;
            var arquivo = $"{Application.StartupPath}/Imagens/{icone}";
            btnMenu.Image = System.Drawing.Image.FromFile(arquivo);
            btnMenu.Click += new EventHandler(btnMenu_Click);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            try
            {
                principal.IniciaAguarde();
                var appName = System.AppDomain.CurrentDomain.FriendlyName.Replace(".vshost.exe", "");
                Form obj = Activator.CreateInstance(appName, $"{appName}.Forms.{formulario}").Unwrap() as Form;

                var nome = formulario.Substring(formulario.IndexOf(".") + 1);

                if (Application.OpenForms.OfType<Form>().FirstOrDefault(x => x.Name == nome) != null)
                {
                    Application.OpenForms.OfType<Form>().FirstOrDefault(x => x.Name == nome).Focus();
                }
                else
                {
                    obj.MdiParent = principal;
                    obj.Show();
                }
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow($"Erro ao tentar criar o botão {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            principal.JanelasAbertas();
        }
        public BotaoMenu()
        {
            InitializeComponent();
        }

        private void btnMenu_Click_1(object sender, EventArgs e)
        {

        }
    }
}
