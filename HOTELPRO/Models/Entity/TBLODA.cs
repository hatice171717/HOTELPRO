//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HOTELPRO.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLODA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLODA()
        {
            this.TBLSATIS = new HashSet<TBLSATIS>();
        }
    
        public int odaId { get; set; }
        public string odaAd { get; set; }
        public Nullable<int> odaKat { get; set; }
        public string odaTur { get; set; }
        public Nullable<decimal> odaFiyat { get; set; }
        public string odaDurum { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLSATIS> TBLSATIS { get; set; }
    }
}
