using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Data.Mask;

namespace ArchitecturePro.ControlView
{
    public class ViewProjeto
    {
        public int Id { set; get; }
        public string Cliente { set; get; }
        public DateTime DataInicio { set; get; }
        public DateTime DataFimPrevista { set; get; }
        public DateTime DataFimReal { set; get; }
        public string UsuarioInclusao { set; get; }

    }
}
