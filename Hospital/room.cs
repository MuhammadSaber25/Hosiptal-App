//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hospital
{
    using System;
    using System.Collections.Generic;
    
    public partial class room
    {
        public int R_ID { get; set; }
        public string R_Status { get; set; }
        public System.DateTime R_Date_In { get; set; }
        public System.DateTime R_Date_Out { get; set; }
        public string R_Type { get; set; }
        public int P_ID { get; set; }
    
        public virtual patient patient { get; set; }
    }
}