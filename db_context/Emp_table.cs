//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mvc_ProjectCRUD.db_context
{
    using System;
    using System.Collections.Generic;
    
    public partial class Emp_table
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpEmail { get; set; }
        public string EmpMobile { get; set; }
        public string EmpAddress { get; set; }
        public System.DateTime DOB { get; set; }
        public string Password { get; set; }
    }
}