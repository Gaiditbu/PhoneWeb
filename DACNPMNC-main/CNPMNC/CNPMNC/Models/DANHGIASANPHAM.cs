//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CNPMNC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DANHGIASANPHAM
    {
        public int DANHGIAID { get; set; }
        public Nullable<int> KHACHHANGID { get; set; }
        public Nullable<int> DIENTHOAIID { get; set; }
        public string DANHGIA { get; set; }
        public Nullable<System.DateTime> NGAYTAO { get; set; }
    
        public virtual DIENTHOAI DIENTHOAI { get; set; }
        public virtual KHACHHANG KHACHHANG { get; set; }
    }
}
