//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MCTR.DataEntity
{
    using System;
    using System.Collections.Generic;
    
    public partial class MCTR_STATUS_HIST
    {
        public int MCTR_NO { get; set; }
        public System.DateTime DATE_TIME_ENTERED { get; set; }
        public string PRIOR_STATUS { get; set; }
        public string NEXT_STATUS { get; set; }
        public Nullable<System.DateTime> DATE_TIME_LEFT { get; set; }
        public string REJECT_CODE { get; set; }
    
        public virtual MCTR_HEADER MCTR_HEADER { get; set; }
    }
}
