//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CamDoAnhTu.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public Nullable<decimal> Loan { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> AmountPaid { get; set; }
        public Nullable<decimal> RemainingAmount { get; set; }
        public Nullable<int> DayPaids { get; set; }
        public string Code { get; set; }
        public System.DateTime StartDate { get; set; }
        public string Description { get; set; }
        public Nullable<int> NgayNo { get; set; }
        public int ID { get; set; }
        public Nullable<int> DayBonus { get; set; }
        public string OldCode { get; set; }
        public string Note { get; set; }
        public Nullable<int> CodeSort { get; set; }
        public Nullable<int> type { get; set; }
    }
}
