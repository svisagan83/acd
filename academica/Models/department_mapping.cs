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
    
    public partial class department_mapping
    {
        public int id { get; set; }
        public int department_id { get; set; }
        public int university_id { get; set; }
        public string department_code { get; set; }
        public int college_id { get; set; }
        public int stream_id { get; set; }
    }
}
