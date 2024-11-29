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
    
    public partial class tb_FLIGHTS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_FLIGHTS()
        {
            this.tb_BOOKINGS = new HashSet<tb_BOOKINGS>();
        }
    
        public int FLIGHT_ID { get; set; }
        public string AIRLINE { get; set; }
        public Nullable<int> ORIGIN_AIRPORT_ID { get; set; }
        public Nullable<int> DESTINATION_AIRPORT_ID { get; set; }
        public Nullable<System.DateTime> DEPARTURE_TIME { get; set; }
        public Nullable<System.DateTime> ARRIVAL_TIME { get; set; }
        public Nullable<int> AIRCRAFT_ID { get; set; }
        public string FLIGHT_STATUS { get; set; }
        public string GATE { get; set; }
    
        public virtual tb_AIRCRAFT tb_AIRCRAFT { get; set; }
        public virtual tb_AIRPORTS tb_AIRPORTS { get; set; }
        public virtual tb_AIRPORTS tb_AIRPORTS1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_BOOKINGS> tb_BOOKINGS { get; set; }
    }
}