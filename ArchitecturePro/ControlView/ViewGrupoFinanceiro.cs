using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ArchitecturePro.ControlView
{
    public class ViewGrupoFinanceiro
    {
        public int Id { set; get; }
        public string Descricao { set; get; }
        public bool Ativo { set; get; }
        public DateTime Data { set; get; }
    }
}
