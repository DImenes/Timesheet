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
    
    public partial class TS_UserProject
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Project { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
    
        public virtual TS_Project TS_Project { get; set; }
        public virtual TS_User TS_User { get; set; }
    }
}
