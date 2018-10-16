using ArchitecturePro.DataBase;
using System;
using Uol.PagSeguro.Constants;
using Uol.PagSeguro.Domain;
using Uol.PagSeguro.Exception;
using Uol.PagSeguro.Resources;
using Uol.PagSeguro.Service;

namespace ArchitecturePro.Util
{
    public static class IntegracaoPagSeguro
    {
        public static bool isSandbox = true;
        public static string email { set; get; }
        public static string token { set; get; }
        public static bool configurado  { set; get; }

        public static TransactionSearchResult ConsultaPagamentoPeloId(string projetoId)
        {
            var local = AppDomain.CurrentDomain.BaseDirectory;
            PagSeguroConfiguration.UrlXmlConfiguration = $"{local}Util\\PagSeguroConfiguration\\PagSeguroConfig.xml";
            EnvironmentConfiguration.ChangeEnvironment(isSandbox);
            TransactionSearchResult result = null;
            try
            {
                AccountCredentials credentials = new AccountCredentials(email, token);
                result = TransactionSearchService.SearchByReference(credentials, projetoId);
            }
            catch (PagSeguroServiceException exception)
            {
                Mensagem.MensagemShow($"Erro ao tentar recuperar pagamento no PagSeguro: \n\r {exception.Message}", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return result;
        }

        public static Transaction ConsultaPagamentoPeloCodigo(string idTransacao)
        {
            var local = AppDomain.CurrentDomain.BaseDirectory;
            PagSeguroConfiguration.UrlXmlConfiguration = $"{local}Util\\PagSeguroConfiguration\\PagSeguroConfig.xml";
            EnvironmentConfiguration.ChangeEnvironment(isSandbox);
            Transaction transaction = null;
            try
            {

                AccountCredentials credentials = new AccountCredentials(email, token);
                transaction = TransactionSearchService.SearchByCode(credentials, idTransacao);

            }
            catch (PagSeguroServiceException exception)
            {
                Mensagem.MensagemShow($"Erro ao tentar recuperar pagamento no PagSeguro: \n\r {exception.Message}", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return transaction;
        }


        public static string GeraPagamento(tb_projeto projeto)
        {
            var ret = "";
            var local = AppDomain.CurrentDomain.BaseDirectory;
            PagSeguroConfiguration.UrlXmlConfiguration = $"{local}Util\\PagSeguroConfiguration\\PagSeguroConfig.xml";
            EnvironmentConfiguration.ChangeEnvironment(isSandbox);
            PaymentRequest payment = new PaymentRequest();
            payment.Currency = Currency.Brl;

            var itensPedido = projeto.tb_ItemPedido;
            var idItem = 1;
            foreach(var itemPedido in itensPedido)
            {
                payment.Items.Add(new Item(idItem.ToString(), itemPedido.tb_servicos.ser_Descricao, Convert.ToInt32(itemPedido.ipo_Qtde), itemPedido.ipo_Valor));
                idItem++;
            }
            payment.Reference = projeto.prj_Id.ToString();
            try
            {
                AccountCredentials credentials = new AccountCredentials(email, token);
                Uri paymentRedirectUri = payment.Register(credentials);
                ret = paymentRedirectUri.ToString();
            }
            catch (PagSeguroServiceException exception)
            {
                Mensagem.MensagemShow($"Erro ao tentar gerar URL no PagSeguro: \n\r {exception.Message}", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                ret = "erro";
            }
            return ret;
        }
    }
}
