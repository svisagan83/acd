//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace academica.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class country
    {
        public int country_id { get; set; }
        public string country_code { get; set; }
        public string country_name { get; set; }
        public short active_status { get; set; }
        public System.DateTime inactive_date { get; set; }
        public short is_default { get; set; }
    }
}
