using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArchitecturePro.DataBase;
using ArchitecturePro.Forms.Clientes;
using ArchitecturePro.Util;

namespace ArchitecturePro.Forms.Servicos
{
    public partial class frmMantemServico : Form
    {
        private DataBaseControler baseControl = new DataBaseControler();
        public int IdServico = 0;
        public frmServicos principal = null;
        public frmMantemServico()
        {
            InitializeComponent();
        }

        private void carregaCombos()
        {
            var unidades = baseControl.BuscaTodasUnidades();

            cbxUnidade.Items.Clear();
            cbxUnidade.DataSource = unidades;
            cbxUnidade.DisplayMember = "uni_Descricao";
            cbxUnidade.ValueMember = "uni_Id";

        }

        private void frmMantemServico_Load(object sender, EventArgs e)
        {
            carregaCombos();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            if (IdServico != 0)
            {
                var servico = baseControl.BuscaServicosId(IdServico);
                txtDescricao.Text = servico.ser_Descricao;
                ckbAtivo.Checked = servico.ser_Ativo;
                txtValor.Text = servico.ser_Valor.ToString();
                cbxUnidade.SelectedItem = servico.tb_unidade.uni_Id;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMantemServico_FormClosed(object sender, FormClosedEventArgs e)
        {
            var incial = (frmPrincipal)principal.MdiParent;
            incial.JanelasAbertas();
        }


        private void BloqueiaCampos(bool status)
        {
            txtDescricao.Enabled = status;
            ckbAtivo.Enabled = status;
            btnSalvar.Enabled = status;
            txtValor.Enabled = status;
            cbxUnidade.Enabled = status;
        }

        private bool ValidaCampos()
        {
            var ret = true;
            if (String.IsNullOrEmpty(txtDescricao.Text))
            {
                Mensagem.MensagemShow("Descrição é um campo obrigatório!", "Camila Moraes Arquitetura",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                ret = false;
            }
            return ret;
        }



        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                if (IdServico == 0)
                {
                    var servico = new tb_servicos()
                    {
                        ser_Descricao = txtDescricao.Text,
                        ser_Ativo = ckbAtivo.Checked,
                        ser_Data = DateTime.Now,
                        ser_Valor = Convert.ToDecimal(txtValor.Text),
                        ser_UniId = Convert.ToInt32(cbxUnidade.SelectedValue)
                    };
                    if (baseControl.MatemServico(servico))
                    {
                        Mensagem.MensagemShow("Serviço Criado com sucesso!", "Camila Moraes Arquitetura", MessageBoxButtons.OK,
                            MessageBoxIcon.Asterisk);
                        BloqueiaCampos(false);
                    }
                }
                else
                {
                    var servico = baseControl.BuscaServicosId(IdServico);
                    servico.ser_Descricao = txtDescricao.Text;
                    servico.ser_Ativo = ckbAtivo.Checked;
                    servico.ser_Data = DateTime.Now;
                    servico.ser_Valor = Convert.ToDecimal(txtValor.Text);
                    servico.ser_UniId = Convert.ToInt32(cbxUnidade.SelectedValue);
                    if (baseControl.MatemServico(servico))
                    {
                        //new Util.EnviarEmail().SendMail(txtEmail.Text, "Senha Sistema Camila Moraes Arquitetura",
                        //    String.Format("Sua senha para acesso ao sistema é: {0}", usuario.usr_Senha.ToString()));

                        Mensagem.MensagemShow("Serviço alterado com sucesso!", "Camila Moraes Arquitetura", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                        BloqueiaCampos(false);
                    }
                }
            }
            principal.CarregaTabela();
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == ',' || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' && txtValor.Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}