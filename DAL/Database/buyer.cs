//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class buyer
    {
        public int id { get; set; }
        public int uid { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string occupation { get; set; }
        public Nullable<int> netincome { get; set; }
    
        public virtual user user { get; set; }
    }
}
