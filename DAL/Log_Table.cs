//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Log_Table
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int ProcessID { get; set; }
        public int ProcessType { get; set; }
        public string ProcessCategoryType { get; set; }
        public System.DateTime ProcessDate { get; set; }
    
        public virtual ProcessType ProcessType1 { get; set; }
        public virtual T_User T_User { get; set; }
    }
}
