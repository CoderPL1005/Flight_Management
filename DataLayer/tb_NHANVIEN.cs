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
    
    public partial class tb_NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_NHANVIEN()
        {
            this.tb_TAIKHOANNHANVIEN = new HashSet<tb_TAIKHOANNHANVIEN>();
        }
    
        public string IDNV { get; set; }
        public string HOTEN { get; set; }
        public string DIENTHOAI { get; set; }
        public string EMAIL { get; set; }
        public string GIOITINH { get; set; }
        public Nullable<System.DateTime> NGAYSINH { get; set; }
        public string DIACHI { get; set; }
        public Nullable<System.DateTime> NGAYVAOLAM { get; set; }
        public string IDCHUCVU { get; set; }
        public Nullable<bool> DISABLED { get; set; }
    
        public virtual tb_CHUCVU tb_CHUCVU { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_TAIKHOANNHANVIEN> tb_TAIKHOANNHANVIEN { get; set; }
    }
}
