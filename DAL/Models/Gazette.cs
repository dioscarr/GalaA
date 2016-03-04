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
    
    public partial class Gazette
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Gazette()
        {
            this.GMLink = new HashSet<GMLink>();
        }
    
        public int Id { get; set; }
        public string header { get; set; }
        public string Content { get; set; }
        public Nullable<int> MemberID { get; set; }
        public Nullable<int> GazetteVolumeID { get; set; }
        public Nullable<int> FirmID { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime Modified { get; set; }
        public bool isDeleted { get; set; }
    
        public virtual Firm Firm { get; set; }
        public virtual GazetteVolumes GazetteVolumes { get; set; }
        public virtual Team Team { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GMLink> GMLink { get; set; }
    }
}
