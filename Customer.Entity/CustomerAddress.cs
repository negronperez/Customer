//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Customer.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class CustomerAddress
    {
        public int CustomerAddresId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public Nullable<int> CityId { get; set; }
        public string ZipCode { get; set; }
        public Nullable<int> CustomerId { get; set; }
    
        public virtual City City { get; set; }
        public virtual Customer Customer { get; set; }
    }
}