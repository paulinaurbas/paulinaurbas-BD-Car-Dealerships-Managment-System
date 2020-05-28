//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BD_CDMS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Order
    {
        public int Id { get; set; }
        public int IdCar { get; set; }
        public int IdCustomer { get; set; }
        public string IdSeller { get; set; }
        [Required, StringLength(20)]
        public string Status { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual AspNetUsers AspNetUsers { get; set; }
        public virtual Person Person { get; set; }
        public virtual Car Car { get; set; }
    }
}
