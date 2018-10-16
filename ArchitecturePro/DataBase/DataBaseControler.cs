using ArchitecturePro.Util;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;

namespace ArchitecturePro.DataBase
{
    public class DataBaseControler
    {
        #region Usuario
        public tb_usuario LoginUsuario(string email, string senha)
        {
            var context = new CamilaMoraes();
            tb_usuario retorno = null;
            try
            {
                retorno =
                    context.tb_usuario.FirstOrDefault(
                        x => x.usr_Ativo && x.usr_Email == email && x.usr_Senha == senha);
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow($"Erro na Conexão do Banco de dados: \n\r {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return retorno;
        }

        public List<tb_usuario> BuscaUsuariosExibir()
        {
            var context = new CamilaMoraes();
            var ret = new List<tb_usuario>();
            try
            {
                ret = context.tb_usuario.ToList();
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow($"Erro na Conexão do Banco de dados: \n\r {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ret;

        }

        public tb_usuario BuscaUsuariosId(int id)
        {
            var context = new CamilaMoraes();
            return context.tb_usuario.FirstOrDefault(x => x.usr_Id == id);
        }

        public bool MantemUsuarios(tb_usuario user)
        {
            var context = new CamilaMoraes();
            var ret = true;
            try
            {
                context.tb_usuario.AddOrUpdate(user);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow($"Erro na Conexão do Banco de dados: \n\r {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ret;
        }

        public string BuscaNumeroMsg(int UserId)
        {
            var ret = "";

            try
            {
                var context = new CamilaMoraes();
                ret = context.tb_mensagens.Where(x => x.msg_UsrId == UserId && x.msg_Lida == 0).ToList().Count.ToString();
            }
            catch(Exception ex)
            {
                Mensagem.MensagemShow($"Erro na Conexão do Banco de dados: \n\r {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ret;
        }

        public List<tb_mensagens> BuscaMsg(int UserId)
        {
            var ret = new List<tb_mensagens>();

            try
            {
                var context = new CamilaMoraes();
                ret = context.tb_mensagens.Where(x => x.msg_UsrId == UserId).ToList();
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow($"Erro na Conexão do Banco de dados: \n\r {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ret;
        }

        public tb_mensagens BuscaMsgUnica(int UserId, DateTime dataHora)
        {
            var ret = new tb_mensagens();

            try
            {
                var context = new CamilaMoraes();
                ret = context.tb_mensagens.FirstOrDefault(x => x.msg_UsrIdEnvio == UserId && x.msg_DataHora == dataHora);
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow($"Erro na Conexão do Banco de dados: \n\r {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ret;
        }

        public bool MarcarMensagensComoLidas(int UserId, int UserRecebimento)
        {
            var ret = true;
            try
            {
                var context = new CamilaMoraes();
                var msgAtualizar = context.tb_mensagens.Where(x => x.msg_UsrIdEnvio == UserRecebimento && x.msg_UsrId == UserId && x.msg_Lida==0).ToList();
                foreach(var msg in msgAtualizar)
                {
                    msg.msg_Lida = 1;
                    context.tb_mensagens.AddOrUpdate(msg);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                ret = false;
                Mensagem.MensagemShow($"Erro na Conexão do Banco de dados: \n\r {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ret;
        }

        public List<tb_mensagens> BuscaConversa(int UserId, int UserRecebimento)
        {
            var ret = new List<tb_mensagens>();
            try
            {
                var context = new CamilaMoraes();
                ret = context.tb_mensagens.Where(x => (x.msg_UsrIdEnvio == UserId && x.msg_UsrId == UserRecebimento) || (x.msg_UsrIdEnvio == UserRecebimento && x.msg_UsrId == UserId)).OrderBy(y=> y.msg_DataHora).ToList();
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow($"Erro na Conexão do Banco de dados: \n\r {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ret;
        }


        public bool CriaMensagem(tb_mensagens msg)
        {
            var ret = true;

            try
            {
                var context = new CamilaMoraes();
                context.tb_mensagens.AddOrUpdate(msg);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                ret = false;
                Mensagem.MensagemShow($"Erro na Conexão do Banco de dados: \n\r {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ret;
        }
        #endregion

        #region Clientes

        public List<tb_cliente> BuscaTodosClientes()
        {
            var context = new CamilaMoraes();
            var ret = new List<tb_cliente>();
            try
            {
                ret = context.tb_cliente.ToList();
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow($"Erro na Conexão do Banco de dados: \n\r {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ret;
        }

        public List<tb_cliente> BuscaTodosClientesAtivos()
        {
            var context = new CamilaMoraes();
            var ret = new List<tb_cliente>();
            try
            {
                ret = context.tb_cliente.Where(x => x.cli_Ativo).ToList();
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow($"Erro na Conexão do Banco de dados: \n\r {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ret;
        }

        public bool MantemCliente(tb_cliente cliente)
        {
            var context = new CamilaMoraes();
            var ret = true;
            try
            {
                context.tb_cliente.AddOrUpdate(cliente);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow($"Erro na Conexão do Banco de dados: \n\r {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ret;

        }

        public tb_cliente BuscaClenteId(int id)
        {
            var context = new CamilaMoraes();
            return context.tb_cliente.FirstOrDefault(x => x.cli_Id == id);
        }
        #endregion

        #region GrupoFinanceiro

        public int BuscaGrupoFinanceiroEntrada()
        {
            var context = new CamilaMoraes();
            var ret = 0;
            try
            {
                ret = (int)context.tb_grupoFinanceiro.FirstOrDefault(x => x.grf_Descricao == "Entrada").grf_Id;
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow($"Erro na Conexão do Banco de dados: \n\r {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ret;
        }

        public bool MatemGrupoFinanceiro(tb_grupoFinanceiro gf)
        {
            var context = new CamilaMoraes();
            var ret = true;
            try
            {
                context.tb_grupoFinanceiro.AddOrUpdate(gf);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow($"Erro na Conexão do Banco de dados: \n\r {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ret;
        }

        public List<tb_grupoFinanceiro> BuscaTodosGruposFinanceiros()
        {
            var context = new CamilaMoraes();
            var ret = new List<tb_grupoFinanceiro>();
            try
            {
                ret = context.tb_grupoFinanceiro.ToList();
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow($"Erro na Conexão do Banco de dados: \n\r {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ret;
        }

        public List<tb_grupoFinanceiro> BuscaGruposFinanceirosAtivo()
        {
            var context = new CamilaMoraes();
            var ret = new List<tb_grupoFinanceiro>();
            try
            {
                ret = context.tb_grupoFinanceiro.Where(x => x.grf_Ativo).ToList();
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow($"Erro na Conexão do Banco de dados: \n\r {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ret;
        }

        public tb_grupoFinanceiro BuscaGrupoFinanceiroId(int id)
        {
            var context = new CamilaMoraes();
            return context.tb_grupoFinanceiro.FirstOrDefault(x => x.grf_Id == id);
        }

        #endregion

        #region Unidades
        public List<tb_unidade> BuscaTodasUnidades()
        {
            var context = new CamilaMoraes();
            var ret = new List<tb_unidade>();
            try
            {
                ret = context.tb_unidade.ToList();
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow($"Erro na Conexão do Banco de dados: \n\r {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ret;
        }

        public tb_unidade BuscaUnidadeId(int id)
        {
            var context = new CamilaMoraes();
            return context.tb_unidade.FirstOrDefault(x => x.uni_Id == id);
        }

        public bool MatemUnidade(tb_unidade uni)
        {
            var context = new CamilaMoraes();
            var ret = true;
            try
            {
                context.tb_unidade.AddOrUpdate(uni);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow($"Erro na Conexão do Banco de dados: \n\r {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ret;
        }



        #endregion

        #region Servicos


        public List<tb_servicos> BuscaServicosAtivos()
        {
            var context = new CamilaMoraes();
            var ret = new List<tb_servicos>();
            try
            {
                ret = context.tb_servicos.Where(x => x.ser_Ativo).ToList();
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow($"Erro na Conexão do Banco de dados: \n\r {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ret;
        }

        public List<tb_servicos> BuscaTodosServicos()
        {
            var context = new CamilaMoraes();
            var ret = new List<tb_servicos>();
            try
            {
                ret = context.tb_servicos.ToList();
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow($"Erro na Conexão do Banco de dados: \n\r {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ret;
        }

        public tb_servicos BuscaServicosId(int id)
        {
            var context = new CamilaMoraes();
            return context.tb_servicos.FirstOrDefault(x => x.ser_Id == id);
        }

        public bool MatemServico(tb_servicos servico)
        {
            var context = new CamilaMoraes();
            var ret = true;
            try
            {
                context.tb_servicos.AddOrUpdate(servico);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow($"Erro na Conexão do Banco de dados: \n\r {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ret;
        }

        #endregion

        #region Projetos
        public List<tb_projeto> BuscaTodosProjetos()
        {
            var context = new CamilaMoraes();
            var ret = new List<tb_projeto>();
            try
            {
                ret = context.tb_projeto.ToList();
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow($"Erro na Conexão do Banco de dados: \n\r {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ret;
        }

        public tb_projeto BuscaProjetoId(int id)
        {
            var context = new CamilaMoraes();
            return context.tb_projeto.FirstOrDefault(x => x.prj_Id == id);
        }

        public int BuscaUltimoProjeto()
        {
            var context = new CamilaMoraes();
            var ret = 0;
            try
            {
                ret = Convert.ToInt32(context.tb_projeto.Max(x => x.prj_Id));
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow($"Erro na Conexão do Banco de dados: \n\r {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ret;
        }

        public int MantemProjeto(tb_projeto pr)
        {
            var context = new CamilaMoraes();
            var ret = 0;
            try
            {
                context.tb_projeto.AddOrUpdate(pr);
                context.SaveChanges();
                ret = Convert.ToInt32(pr.prj_Id);
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow($"Erro na Conexão do Banco de dados: \n\r {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ret;
        }

        #endregion

        #region Fluxo Caixa
        public bool MatemFluxoCaixa(tb_fluxoCaixa fc)
        {
            var context = new CamilaMoraes();
            var ret = true;
            try
            {
                context.tb_fluxoCaixa.AddOrUpdate(fc);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow($"Erro na Conexão do Banco de dados: \n\r {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ret;
        }

        public System.Nullable<decimal> CalculaValorPrevistoProjeto(int projetoId)
        {
            var context = new CamilaMoraes();
            System.Nullable<decimal> ret = 0;
            try
            {
                ret = context.tb_orcamento.Where(x => x.orc_PrjId == projetoId).Sum(x => (x.orc_Qtde * x.tb_servicos.ser_Valor));
            }
            catch (Exception) { }
            return ret;
        }


        public List<tb_fluxoCaixa> BuscaFluxoCaixaDia(DateTime fluxoCaixa)
        {
            try
            {
                var context = new CamilaMoraes();
                var retorno = context.tb_fluxoCaixa.ToList();
                return retorno.Where(x => x.flc_DataCaixa.Date == fluxoCaixa.Date).ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public tb_fluxoCaixa BuscaFluxoCaixaId(int id)
        {
            var context = new CamilaMoraes();
            return context.tb_fluxoCaixa.FirstOrDefault(x => x.flc_Id == id);
        }

        public List<tb_fluxoCaixa> BuscaFluxoCaixa()
        {
            var context = new CamilaMoraes();
            return context.tb_fluxoCaixa.ToList();
        }


        public void DeletaItemFluxoCaixa(int idFluxoCaixa)
        {
            var context = new CamilaMoraes();
            try
            {
                var fc = context.tb_fluxoCaixa.FirstOrDefault(x => x.flc_Id == idFluxoCaixa);
                context.tb_fluxoCaixa.Remove(fc);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow($"Erro na Conexão do Banco de dados: \n\r {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Item Pedido
        public List<tb_ItemPedido> BuscaItemPedidoProjeto(int projetoId)
        {
            var context = new CamilaMoraes();
            var ret = new List<tb_ItemPedido>();
            try
            {
                ret = context.tb_ItemPedido.Where(x => x.ipo_PrjId == projetoId).ToList();
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow($"Erro na Conexão do Banco de dados: \n\r {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ret;
        }
        #endregion

        #region Orcamento
        public tb_orcamento BuscaOrcamento(int id)
        {
            var context = new CamilaMoraes();
            return context.tb_orcamento.FirstOrDefault(x => x.orc_Id == id);
        }

        public bool MantemOrcamento(tb_orcamento orc)
        {
            var context = new CamilaMoraes();
            var ret = true;
            try
            {
                context.tb_orcamento.AddOrUpdate(orc);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow($"Erro na Conexão do Banco de dados: \n\r {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ret;
        }

        public List<tb_orcamento> BuscaOrcamentosProjeto(int projetoId)
        {
            var context = new CamilaMoraes();
            var ret = new List<tb_orcamento>();
            try
            {
                ret = context.tb_orcamento.Where(x => x.orc_PrjId == projetoId).ToList();
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow($"Erro na Conexão do Banco de dados: \n\r {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ret;
        }

        public void DeletaOrcamento(int id)
        {
            var context = new CamilaMoraes();
            try
            {
                var orc = context.tb_orcamento.FirstOrDefault(x => x.orc_Id == id);
                context.tb_orcamento.Remove(orc);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow($"Erro na Conexão do Banco de dados: \n\r {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Item Pedido
        public tb_ItemPedido BuscaItemPedido(int id)
        {
            var context = new CamilaMoraes();
            return context.tb_ItemPedido.FirstOrDefault(x => x.ipo_Id == id);
        }

        public bool MantemItemPedido(tb_ItemPedido itemPedido)
        {
            var context = new CamilaMoraes();
            var ret = true;
            try
            {
                context.tb_ItemPedido.AddOrUpdate(itemPedido);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow($"Erro na Conexão do Banco de dados: \n\r {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ret;
        }

        public System.Nullable<decimal> CalculaValorTotalItensProjeto(int projetoId)
        {
            var context = new CamilaMoraes();
            System.Nullable<decimal> ret = 0;
            try
            {
                ret = context.tb_ItemPedido.Where(x => x.ipo_PrjId == projetoId).Sum(x => x.ipo_Valor);
            }
            catch (Exception) { }
            return ret;
        }


        public void DeletaItemPedido(int id)
        {
            var context = new CamilaMoraes();
            try
            {
                var itemPedido = context.tb_ItemPedido.FirstOrDefault(x => x.ipo_Id == id);

                context.tb_ItemPedido.Remove(itemPedido);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow($"Erro na Conexão do Banco de dados: \n\r {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Projeto Fluxo de Caixa

        public List<tb_projetoFluxoCaixa> BuscaFluxoProjeto(int prjId, bool tipo)
        {
            var context = new CamilaMoraes();
            return context.tb_projetoFluxoCaixa.Where(x => x.pfc_PrjId == prjId && x.pfc_Despesa == tipo).ToList();
        }

        public System.Nullable<decimal> CalculaInformacoesTotalProjeto(int projetoId, bool despesa)
        {
            var context = new CamilaMoraes();
            System.Nullable<decimal> ret = 0;
            try
            {
                ret =
                    context.tb_projetoFluxoCaixa.Where(x => x.pfc_PrjId == projetoId && x.pfc_Despesa == despesa)
                        .Sum(x => (x.tb_fluxoCaixa.flc_Valor));
            }
            catch (Exception) {
               // Mensagem.MensagemShow($"Erro na Conexão do Banco de dados: \n\r {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ret;
        }


        public tb_projetoFluxoCaixa BuscaProjetoFluxoCaixa(int id)
        {
            var context = new CamilaMoraes();
            return context.tb_projetoFluxoCaixa.FirstOrDefault(x => x.pfc_Id == id);
        }

        public int BuscaIdFluxoCaixaPeloProjetoFluxoCaixaId(int id)
        {
            var context = new CamilaMoraes();
            return (int)context.tb_projetoFluxoCaixa.FirstOrDefault(x => x.pfc_Id == id).pfc_FlcId;
        }

        public tb_projeto BuscaProjetoFluxoCaixaId(int id)
        {
            var context = new CamilaMoraes();
            return (tb_projeto)context.tb_projetoFluxoCaixa.FirstOrDefault(x => x.pfc_FlcId == id).tb_projeto;
        }


        public bool MatemProjetoFluxoCaixa(tb_fluxoCaixa fc, int idProjeto)
        {
            var context = new CamilaMoraes();
            var ret = true;
            try
            {
                context.tb_fluxoCaixa.AddOrUpdate(fc);
                context.SaveChanges();

                var pfc = new tb_projetoFluxoCaixa()
                {
                    pfc_FlcId = fc.flc_Id,
                    pfc_PrjId = idProjeto,
                    pfc_Despesa = !fc.flc_Entrada
                };

                context.tb_projetoFluxoCaixa.AddOrUpdate(pfc);
                context.SaveChanges();

            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow($"Erro na Conexão do Banco de dados: \n\r {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ret;
        }

        public void DeletaProjetoFluxoCaixa(int projetoFluxoCaixa)
        {
            var context = new CamilaMoraes();
            try
            {
                var pfc = context.tb_projetoFluxoCaixa.FirstOrDefault(x => x.pfc_Id == projetoFluxoCaixa);
                context.tb_fluxoCaixa.Remove(pfc.tb_fluxoCaixa);
                context.tb_projetoFluxoCaixa.Remove(pfc);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow($"Erro na Conexão do Banco de dados: \n\r {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Despesas 
        public tb_despesas BuscaDespesasDescricao(string descricao)
        {
            var context = new CamilaMoraes();
            return context.tb_despesas.FirstOrDefault(x => x.des_Descricao == descricao);
        }

        public List<tb_despesas> BuscaTodasDespesas()
        {
            var context = new CamilaMoraes();
            var ret = new List<tb_despesas>();
            try
            {
                ret = context.tb_despesas.ToList();
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow($"Erro na Conexão do Banco de dados: \n\r {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ret;
        }


        public tb_despesas BuscaDespesasId(int id)
        {
            var context = new CamilaMoraes();
            return context.tb_despesas.FirstOrDefault(x => x.des_Id == id);
        }

        public bool MantemDespesas(tb_despesas despesa)
        {
            var context = new CamilaMoraes();
            var ret = true;
            try
            {
                context.tb_despesas.AddOrUpdate(despesa);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow($"Erro na Conexão do Banco de dados: \n\r {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ret;
        }

        #endregion

        #region Fases
        public List<tb_fases> BuscaFases()
        {
            var context = new CamilaMoraes();
            var ret = new List<tb_fases>();
            try
            {
                ret = context.tb_fases.ToList();
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow($"Erro na Conexão do Banco de dados: \n\r {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ret;
        }

        public List<tb_fases> BuscaFasesAtivas()
        {
            var context = new CamilaMoraes();
            var ret = new List<tb_fases>();
            try
            {
                ret = context.tb_fases.Where(x => x.fas_Ativo).ToList();
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow($"Erro na Conexão do Banco de dados: \n\r {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ret;
        }

        public tb_fases BuscaFasesId(int Id)
        {
            var context = new CamilaMoraes();
            var ret = new tb_fases();
            try
            {
                ret = context.tb_fases.FirstOrDefault(x => x.fas_Id == Id);
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow($"Erro na Conexão do Banco de dados: \n\r {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ret;
        }

        public bool MantemFase(tb_fases fase)
        {
            var context = new CamilaMoraes();
            var ret = true;
            try
            {
                context.tb_fases.AddOrUpdate(fase);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow($"Erro na Conexão do Banco de dados: \n\r {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ret;
        }
        #endregion

        #region Fases do Projeto
        public List<tb_fasesProjeto> BuscaFasesProjeto(int prjId)
        {
            var context = new CamilaMoraes();
            return context.tb_fasesProjeto.Where(x => x.fap_PrjId == prjId).ToList();
        }

        public tb_fasesProjeto BuscaFasesProjetoId(int Id)
        {
            var context = new CamilaMoraes();
            return context.tb_fasesProjeto.FirstOrDefault(x => x.fap_Id == Id);
        }
        public bool MantemFaseProjeto(tb_fasesProjeto faseProjeto)
        {
            var context = new CamilaMoraes();
            var ret = true;
            try
            {
                context.tb_fasesProjeto.AddOrUpdate(faseProjeto);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow($"Erro na Conexão do Banco de dados: \n\r {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ret;
        }

        public bool DeletaFaseProjeto(int idFaseProjeto)
        {
            var context = new CamilaMoraes();
            var ret = true;
            try
            {
                var faseProjeto = context.tb_fasesProjeto.FirstOrDefault(x => x.fap_Id == idFaseProjeto);
                context.tb_fasesProjeto.Remove(faseProjeto);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow($"Erro na Conexão do Banco de dados: \n\r {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ret;
        }
        #endregion

        #region Configuracoes
        public tb_empresa BuscaDadosEmpresa()
        {
            var context = new CamilaMoraes();
            var ret = new tb_empresa();
            try
            {
                ret = context.tb_empresa.FirstOrDefault();
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow($"Erro na Conexão do Banco de dados: \n\r {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ret;
        }


        public string TestaBancoDados()
        {
            var context = new CamilaMoraes();
            var ret = "";
            try
            {
                context.tb_empresa.FirstOrDefault();
                ret = "";
                
            }
            catch (Exception ex)
            {
                ret = $"Erro no acesso de banco de dados: \n\r {ex.Message}";
            }
            return ret;
        }

        public bool SalvaDadosEmpresa(tb_empresa empresa)
        {
            var context = new CamilaMoraes();
            var ret = true;
            try
            {
                var empresaBanco = context.tb_empresa.FirstOrDefault();
                if(empresaBanco != null)
                {
                    empresa.emp_VersaoSistema = empresaBanco.emp_VersaoSistema;
                    empresa.emp_LocalVersao = empresaBanco.emp_LocalVersao;
                }

                context.tb_empresa.AddOrUpdate(empresa);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow($"Erro na Conexão do Banco de dados: \n\r {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ret = false;
            }
            return ret;
        }
        #endregion

        #region Controle Acesso

        public bool SalvaAcessosUsuario(List<tb_telas> telas, int usuario)
        {
            var context = new CamilaMoraes();
            var ret = true;
            try
            {
                var deletar = context.tb_acessos.Where(x => x.ace_UsrId == usuario);
                context.tb_acessos.RemoveRange(deletar);
                context.SaveChanges();
                foreach(var tela in telas)
                {
                    var acesso = new tb_acessos() {
                        ace_TelasId = tela.tel_Id,
                        ace_UsrId = usuario
                    };
                    context.tb_acessos.Add(acesso);
                    context.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                Mensagem.MensagemShow($"Erro na Conexão do Banco de dados: \n\r {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ret = false;
            }
            return ret;
        }

        public List<tb_telas> BuscaTelas(int usuarioId)
        {
            var context = new CamilaMoraes();
            var ret = new List<tb_telas>();
            try
            {
                var acessos = context.tb_acessos.Where(y => y.ace_UsrId == usuarioId).ToList();
                foreach (var acesso in acessos)
                {
                    var tela = context.tb_telas.FirstOrDefault(x => x.tel_Id == acesso.ace_TelasId);
                    ret.Add(tela);
                }
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow($"Erro na Conexão do Banco de dados: \n\r {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ret = null;
            }
            return ret;
        }

        public List<tb_telas> BuscaTelas()
        {
            var context = new CamilaMoraes();
            var ret = new List<tb_telas>();
            try
            {
                ret = context.tb_telas.OrderByDescending(z => z.tel_Id).ToList();
            }
            catch (Exception ex)
            {
                Mensagem.MensagemShow($"Erro na Conexão do Banco de dados: \n\r {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ret = null;
            }
            return ret;
        }
        #endregion 

    }
}
