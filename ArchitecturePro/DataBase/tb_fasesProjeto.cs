//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ArchitecturePro.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_fasesProjeto
    {
        public long fap_Id { get; set; }
        public long fap_FasId { get; set; }
        public long fap_PrjId { get; set; }
        public System.DateTime fap_DataPrevista { get; set; }
        public System.DateTime fap_DataReal { get; set; }
        public bool fap_Finalizada { get; set; }
    
        public virtual tb_fases tb_fases { get; set; }
        public virtual tb_projeto tb_projeto { get; set; }
    }
}
