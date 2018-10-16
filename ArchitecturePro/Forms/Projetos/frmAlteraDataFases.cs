using ArchitecturePro.DataBase;
using ArchitecturePro.Util;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ArchitecturePro.Forms.Projetos
{
    public partial class frmAlteraDataFases : Form
    {

        private DataBaseControler baseControl = new DataBaseControler();
        public int IdProjeto = 0;
        public frmMantemProjetos principal = null;

        public frmAlteraDataFases()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAlteraDataFases_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try {
                var fasesProjeto = baseControl.BuscaFasesProjeto(IdProjeto).Where(x => x.fap_Finalizada == false).ToList();
                foreach (var fase in fasesProjeto)
                {
                    fase.fap_DataPrevista = fase.fap_DataPrevista.AddDays((double)nupDias.Value);
                    baseControl.MantemFaseProjeto(fase);
                }
                principal.CarregaFaseProjeto();
                Mensagem.MensagemShow("Data das fases atualizada com sucesso!", "Camila Moraes Arquitetura", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch(Exception ex)
            {
                Mensagem.MensagemShow("Erro ao tentar alterar as datas do projeto: " + ex.Message, "Camila Moraes Arquitetura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
