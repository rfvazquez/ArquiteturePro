using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitecturePro.ControlView
{
    public class ViewItemPedido
    {
        public int Id { set; get; }
        public string Item { set; get; }
        public int Qtde { set; get; }
        public Decimal Valor { set; get; }

    }
}
