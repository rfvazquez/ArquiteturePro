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
    
    public partial class tb_projetoFluxoCaixa
    {
        public long pfc_Id { get; set; }
        public long pfc_PrjId { get; set; }
        public long pfc_FlcId { get; set; }
        public bool pfc_Despesa { get; set; }
    
        public virtual tb_fluxoCaixa tb_fluxoCaixa { get; set; }
        public virtual tb_projeto tb_projeto { get; set; }
    }
}
