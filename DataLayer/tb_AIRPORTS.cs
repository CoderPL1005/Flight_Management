//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_AIRPORTS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_AIRPORTS()
        {
            this.tb_FLIGHTS = new HashSet<tb_FLIGHTS>();
            this.tb_FLIGHTS1 = new HashSet<tb_FLIGHTS>();
        }
    
        public int AIRPORT_ID { get; set; }
        public string AIPORT_NAME { get; set; }
        public string CITY { get; set; }
        public string COUNTRY { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_FLIGHTS> tb_FLIGHTS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_FLIGHTS> tb_FLIGHTS1 { get; set; }
    }
}
