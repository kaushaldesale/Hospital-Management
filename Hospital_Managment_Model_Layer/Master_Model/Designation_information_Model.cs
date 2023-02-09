using System;

namespace Hospital_Managment_Model_Layer.Master_Model
{
    public class Designation_information_Model
    {
        public long designation_id { get; set; }

        public string designation_code { get; set; }
        public string designation_name { get; set; }
        public string designation_qualification { get; set; }
        public Nullable<System.DateTime> created_date { get; set; }
        public Nullable<System.DateTime> updated_date { get; set; }
        public Nullable<int> created_by { get; set; }
        public Nullable<int> updated_by { get; set; }
        public string designation_description { get; set; }
        public Nullable<bool> ac_flag { get; set; }
    }
}
