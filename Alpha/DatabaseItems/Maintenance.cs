//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Alpha.DatabaseItems
{
    using System;
    using System.Collections.Generic;
    
    public partial class Maintenance
    {
        public int ID { get; set; }
        public int ClientId { get; set; }
        public Nullable<int> TransactionId { get; set; }
        public int ItemId { get; set; }
        public string ItemDescription { get; set; }
        public bool IsWarranty { get; set; }
        public Nullable<int> WarrantyId { get; set; }
        public decimal Cost { get; set; }
        public int DurationInDays { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Item Item { get; set; }
        public virtual Transaction Transaction { get; set; }
        public virtual Warranty Warranty { get; set; }
    }
}