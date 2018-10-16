using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitecturePro.ControlView
{
    public class ViewUsuario
    {
        public int Id { set; get; }
        public string Nome { set; get; }
        public string EMail { set; get; }
        public bool Ativo { set; get; }
        public DateTime Data { set; get; }

    }
}
