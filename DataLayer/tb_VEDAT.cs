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
    
    public partial class tb_VEDAT
    {
        public int IDVEDAT { get; set; }
        public string EMAIL { get; set; }
        public Nullable<int> AIRCRAFTSEATISD { get; set; }
        public string TRANGTHAI { get; set; }
    
        public virtual tb_AIRCRAFTSEATS tb_AIRCRAFTSEATS { get; set; }
        public virtual tb_Member tb_Member { get; set; }
    }
}
