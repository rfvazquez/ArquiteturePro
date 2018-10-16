using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitecturePro.ControlView
{
    class ViewFasesProjeto
    {
        public int Id { set; get; }
        public string Fase { set; get; }
        public DateTime DataPrevista { set; get; }
        public DateTime DataReal { set; get; }
        public bool FaseFinalizada { set; get; }
    }
}
