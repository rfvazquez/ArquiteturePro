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
    
    public partial class tb_servicos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_servicos()
        {
            this.tb_ItemPedido = new HashSet<tb_ItemPedido>();
            this.tb_orcamento = new HashSet<tb_orcamento>();
        }
    
        public long ser_Id { get; set; }
        public string ser_Descricao { get; set; }
        public decimal ser_Valor { get; set; }
        public bool ser_Ativo { get; set; }
        public System.DateTime ser_Data { get; set; }
        public long ser_UniId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_ItemPedido> tb_ItemPedido { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_orcamento> tb_orcamento { get; set; }
        public virtual tb_unidade tb_unidade { get; set; }
    }
}
