//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hospital_Managment_Data_Access_Layer
{
    using System;
    using System.Collections.Generic;
    
    public partial class a_m_lookup_line
    {
        public int line_id { get; set; }
        public Nullable<int> client_id { get; set; }
        public Nullable<int> gloabl_id { get; set; }
        public Nullable<int> lookup_id { get; set; }
        public string line_name { get; set; }
        public string line_description { get; set; }
        public Nullable<int> created_by { get; set; }
        public Nullable<System.DateTime> created_date { get; set; }
        public Nullable<int> updated_by { get; set; }
        public Nullable<System.DateTime> updated_date { get; set; }
    }
}
