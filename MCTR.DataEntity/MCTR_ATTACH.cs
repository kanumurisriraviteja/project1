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
    
    public partial class MCTR_ATTACH
    {
        public int MCTR_NO { get; set; }
        public byte ATTACH_NO { get; set; }
        public string ATTACH_FILENAME { get; set; }
        public string BEMS { get; set; }
        public Nullable<System.DateTime> DATE_ENTERED { get; set; }
        public string ATTACH_DESCR { get; set; }
        public byte[] ATTACH_BLOB { get; set; }
    
        public virtual MCTR_HEADER MCTR_HEADER { get; set; }
    }
}
