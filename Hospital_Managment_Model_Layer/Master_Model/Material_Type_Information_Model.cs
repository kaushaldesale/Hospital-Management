using System;


namespace Hospital_Managment_Model_Layer.Master_Model
{
    public class Material_Type_Information_Model
    {
        public long material_type_id { get; set; }
        public string material_type { get; set; }
        public Nullable<int> created_by { get; set; }
        public Nullable<System.DateTime> created_date { get; set; }
        public Nullable<int> updated_by { get; set; }
        public Nullable<System.DateTime> updated_date { get; set; }
    }
}
