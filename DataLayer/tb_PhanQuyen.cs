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
    
    public partial class tb_PhanQuyen
    {
        public int ID { get; set; }
        public string FUNC_CODE { get; set; }
        public string IDCHUCVU { get; set; }
        public string QUYEN { get; set; }
    
        public virtual tb_CHUCVU tb_CHUCVU { get; set; }
        public virtual tb_FUNC tb_FUNC { get; set; }
    }
}
