using System;
using System.Windows.Forms;
using ArchitecturePro.DataBase;
using ArchitecturePro.Forms;
using ArchitecturePro.Forms.Configuracoes;
using ArchitecturePro.Util;
using ArchitecturePro.Forms.FormUtil;
using System.Threading;
using System.Diagnostics;
using System.Linq;

namespace ArchitecturePro
{
    public partial class frmLogin : Form
    {
        private DataBaseControler dataBase = new DataBaseControler();
        public string nomeSistema;
        private bool abreConfig;
        private tb_usuario usuario;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Realiza login no sistema e redireciona para o principal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {

            lblMsg.Text = "";
            usuario = dataBase.LoginUsuario(txtEmail.Text, txtSenha.Text);
            if (usuario != null)
            {
                if (usuario.usr_Nome != null)
                {
                    if (abreConfig)
                    {
                        Mensagem.MensagemShow($"Não foram encontradas configurações para o sistema.\n\r Você será redirecionado para tela de configuração.", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var config = new frmConfiguracoesEmpresa();
                        config.frmLogin = this;
                        config.configuracaoInicial = true;
                        config.Show();
                    }
                    else
                    {
                        LoginSistema();
                    }
                }
                else
                {
                    lblMsg.Text = "Login ou Senha Inválidos!";
                }
            }
            else
            {
                lblMsg.Text = "Login ou Senha Inválidos!";
            }
        }

        public void LoginSistema()
        {
            var principal = new frmPrincipal();
            principal.usuarioLogado = usuario;
            Mensagem.nomeSistema = nomeSistema;
            principal.Show();
            this.Hide();
            return;
        }

        private void lblMsg_Click(object sender, EventArgs e)
        {

        }


        private void ShowSplash()
        {
            var splash = new SplashScreen();
            splash.ShowDialog();
        }


        /// <summary>
        /// Inicialização do sistema. Aqui vamos carregar as informações e buscar informações de outros sistemas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLogin_Load(object sender, EventArgs e)
        {
            //REF1234
            //para teste.
            //IntegracaoPagSeguro.email = "contato@camilamoraesarquitetura.com";
            //IntegracaoPagSeguro.token = "5EF6FE13FFE649FEB76A80F1FEE16387";
            //IntegracaoPagSeguro.isSandbox = true;
            //IntegracaoPagSeguro.configurado = true;


            //IntegracaoPagSeguro.ConsultaPagamentoPeloId("REF1234");



            var splashScreen = new Thread(new System.Threading.ThreadStart(ShowSplash));
            splashScreen.Start();
            Mensagem.nomeSistema = "Architecture Pro";
            this.Text = "Architecture Pro - Login";
            try
            {
                var testeBanco = dataBase.TestaBancoDados();
                if (!String.IsNullOrEmpty(testeBanco))
                {
                    Mensagem.MensagemShow($"{testeBanco} \n\r Verifique sua conexão com a Internet!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                    return;
                }


                var empresa = dataBase.BuscaDadosEmpresa();
                if (empresa != null)
                {
                    if (empresa.emp_VersaoSistema != System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString())
                    {
                        if (Mensagem.MensagemShow($"A Versão {System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString()} está desatualizada. \n\r Deseja atualizar a versão agora?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {
                            ProcessStartInfo start = new ProcessStartInfo();
                            start.Arguments = empresa.emp_LocalVersao;
                            start.FileName = "AutoUpdate.exe";
                            start.WindowStyle = ProcessWindowStyle.Normal;
                            start.CreateNoWindow = true;
                            System.Diagnostics.Process.Start(start);

                            Application.Exit();
                            return;
                        }
                    }

                    if (String.IsNullOrEmpty(empresa.emp_Nome))
                    {
                        abreConfig = true;
                    }
                    else
                    {
                        nomeSistema = empresa.emp_Nome;
                        this.Text = $"Architecture Pro by {nomeSistema} - Login";
                        abreConfig = false;

                        EnviarEmail.nomeEmpresa = empresa.emp_Nome;
                        EnviarEmail.email = empresa.emp_Email;
                        EnviarEmail.senha = empresa.emp_SenhaEmail;

                        if (String.IsNullOrEmpty(empresa.emp_LoginPagSeguro))
                        {
                            IntegracaoPagSeguro.configurado = false;
                        }
                        else
                        {
                            IntegracaoPagSeguro.email = empresa.emp_LoginPagSeguro;
                            IntegracaoPagSeguro.token = empresa.emp_TokenPagSeguro;
                            IntegracaoPagSeguro.isSandbox = empresa.emp_TestePagSeguro == "1";
                            IntegracaoPagSeguro.configurado = true;

                            // aqui vamos verificar se existe algum projeto para dar baixa na pagseguro.
                            var fluxoCaixa = dataBase.BuscaFluxoCaixa().Where(x => x.flc_PagamentoConfirmado == 0 && x.flc_PagSeguro == 1).ToList();
                            foreach (var fluxo in fluxoCaixa)
                            {
                                var projetoId = fluxo.tb_projetoFluxoCaixa.FirstOrDefault().pfc_PrjId;
                                var pagamentos = IntegracaoPagSeguro.ConsultaPagamentoPeloId(projetoId.ToString());
                                foreach (var pagamento in pagamentos.Transactions.ToList())
                                {
                                    if(pagamento.TransactionStatus== Uol.PagSeguro.Enums.TransactionStatus.Paid) // agora está ok.
                                    {
                                        //Alterando o status do pagamento
                                        fluxo.flc_PagamentoConfirmado = 1;
                                        dataBase.MatemFluxoCaixa(fluxo);
                                        //Ajustando a data para iniciar o projeto
                                        var proj = dataBase.BuscaProjetoId((int)projetoId);
                                        proj.prj_DataInicio = DateTime.Now;

                                        //Aqui vamos informar que o projeto já está pago.
                                        var usuarios = dataBase.BuscaUsuariosExibir();
                                        foreach(var user in usuarios)
                                        {
                                            var mensagem = new tb_mensagens()
                                            {
                                                msg_DataHora = DateTime.Now,
                                                msg_Lida = 0,
                                                msg_Texto = $"Pagamento do projeto {projetoId} liberado no PagSeguro.",
                                                msg_UsrId = user.usr_Id
                                            };
                                            dataBase.CriaMensagem(mensagem);
                                        }// while dos usuários de aviso da msg
                                    }// If de parcela paga
                                }// while de pagamentos
                            }// while do fluxo de caixa
                        }//If configuração pag seguro
                    }//if Configuração do sistema
                }// if(primeira Execucao do sistema
                else
                {
                    abreConfig = true;
                }
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow($"Erro na inicialização do Software \n\r {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                abreConfig = true;
            }
            //Thread.Sleep(5000);
            splashScreen.Abort();
        }
    }
}
