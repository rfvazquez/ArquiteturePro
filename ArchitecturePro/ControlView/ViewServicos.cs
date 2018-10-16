using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Data.Mask;

namespace ArchitecturePro.ControlView
{
    public class ViewServicos
    {
        public int Id { set; get; }
        public string Descricao { set; get; }
        public decimal Valor { set; get; }
        public bool Ativo { set; get; }
        public DateTime Data { set; get; }
        public string Unidade { set; get; }
    }
}
