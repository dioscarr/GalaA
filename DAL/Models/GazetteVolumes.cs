//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class GazetteVolumes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GazetteVolumes()
        {
            this.Gazette = new HashSet<Gazette>();
        }
    
        public int Id { get; set; }
        public string GazetteVolume { get; set; }
        public Nullable<System.DateTime> PublishedDate { get; set; }
        public Nullable<System.DateTime> Created_ { get; set; }
        public System.DateTime Modified { get; set; }
        public bool isDeleted { get; set; }
        public Nullable<int> Order { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Gazette> Gazette { get; set; }
    }
}
