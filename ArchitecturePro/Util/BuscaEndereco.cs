using System.Net;
using System.Text;
using ArchitecturePro.ControlView;
using Newtonsoft.Json;

namespace ArchitecturePro.Util
{
    public class BuscaEndereco
    {
        public EnderecoMaps BuscaDadosEndereco(string cep)
        {
            EnderecoMaps retorno = null;
            if (cep.Length == 9)
            {
                var url = string.Format("https://viacep.com.br/ws/{0}/json", cep.Replace("-", ""));
                var webCliente = new WebClient();
                webCliente.Encoding  = Encoding.UTF8;
                var jsonRetorno = webCliente.DownloadString(url);
                retorno = JsonConvert.DeserializeObject<EnderecoMaps>(jsonRetorno);
            }
            return retorno;
        }

        public string ConvertUf(string uf)
        {
            var retorno = "";
            switch (uf)
            {
                case "AC":
                    retorno = "Acre";
                    break;
                case "AL":
                    retorno = "Alagoas";
                    break;
                case "AP":
                    retorno = "Amapá";
                    break;
                case "AM":
                    retorno = "Amazonas";
                    break;
                case "BA":
                    retorno = "Bahia";
                    break;
                case "CE":
                    retorno = "Ceará";
                    break;
                case "DF":
                    retorno = "Distrito Federal";
                    break;
                case "ES":
                    retorno = "Espírito Santo";
                    break;
                case "GO":
                    retorno = "Goiás";
                    break;
                case "MA":
                    retorno = "Maranhão";
                    break;
                case "MT":
                    retorno = "Mato Grosso";
                    break;
                case "MS":
                    retorno = "Mato Grosso do Sul";
                    break;
                case "MG":
                    retorno = "Minas Gerais";
                    break;
                case "PA":
                    retorno = "Pará";
                    break;
                case "PB":
                    retorno = "Paraíba";
                    break;
                case "PR":
                    retorno = "Paraná";
                    break;
                case "PE":
                    retorno = "Pernambuco";
                    break;
                case "PI":
                    retorno = "Piauí";
                    break;
                case "RJ":
                    retorno = "Rio de Janeiro";
                    break;
                case "RN":
                    retorno = "Rio Grande do Norte";
                    break;
                case "RS":
                    retorno = "Rio Grande do Sul";
                    break;
                case "RO":
                    retorno = "Rondônia";
                    break;
                case "RR":
                    retorno = "Roraima";
                    break;
                case "SC":
                    retorno = "Santa Catarina";
                    break;
                case "SP":
                    retorno = "São Paulo";
                    break;
                case "SE":
                    retorno = "Sergipe";
                    break;
                case "TO":
                    retorno = "Tocantins";
                    break;
            }
            return retorno;
        }

    }
}
