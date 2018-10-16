using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitecturePro.ControlView
{
    public class ViewDespesas
    {
        public int Id { set; get; }
        public string Descricao { set; get; }
        public DateTime Data { set; get; }
        public Decimal Valor { set; get; }
    }
}
