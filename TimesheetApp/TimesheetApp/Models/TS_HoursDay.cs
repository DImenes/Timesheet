//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TimesheetApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TS_HoursDay
    {
        public int Id { get; set; }
        public int TS_HoursKind_Id { get; set; }
        public int TS_Client_Id { get; set; }
        public int TS_User_Id { get; set; }
        public System.DateTime Date { get; set; }
        public decimal Hours { get; set; }
        public string Description { get; set; }
    
        public virtual TS_Client TS_Client { get; set; }
        public virtual TS_HoursKind TS_HoursKind { get; set; }
        public virtual TS_User TS_User { get; set; }
    }
}
