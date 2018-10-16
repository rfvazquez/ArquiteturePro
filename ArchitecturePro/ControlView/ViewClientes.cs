using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ArchitecturePro.ControlView
{
    public class ViewClientes
    {
        public int Id { set; get; }
        public string Descricao { set; get; }
        public string Fantasia { set; get; }
        public string Cpf { set; get; }
        public string Logradouro { set; get; }
        public string Numero { set; get; }

        public string Bairro { set; get; }
        public string Cidade { set; get; }
        public string Estado { set; get; }
        public string CEP { set; get; }
        public string Complemento { set; get; }
        public string Contato { set; get; }
        public string Telefone { set; get; }
        public string Celular { set; get; }
        public string EMail { set; get; }
        public DateTime Data { set; get; }
        public bool Ativo { set; get; }
        public string LogradouroObra { set; get; }
        public string NumeroObra { set; get; }
        public string BairroObra { set; get; }
        public string CidadeObra { set; get; }
        public string EstadoObra { set; get; }
        public string CEPObra { set; get; }
        public string ComplementoObra { set; get; }

    }
}
