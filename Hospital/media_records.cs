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
    
    public partial class media_records
    {
        public int MR_ID { get; set; }
        public string MR_Problem { get; set; }
        public System.DateTime MR_Date_of_Examinatio { get; set; }
        public int P_ID { get; set; }
    
        public virtual patient patient { get; set; }
    }
}
