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
    
    public partial class ItemTransaction
    {
        public int ID { get; set; }
        public int TransactionId { get; set; }
        public int ItemId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Count { get; set; }
        public Nullable<bool> IsNotFinal { get; set; }
    
        public virtual Item Item { get; set; }
        public virtual Transaction Transaction { get; set; }
    }
}
