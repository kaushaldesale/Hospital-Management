using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Managment_Model_Layer.Master_Model
{
    public class Unit_Information_Model
    {
        public long unit_id { get; set; }
        public string Unit_name { get; set; }
        public Nullable<System.DateTime> created_date { get; set; }
        public Nullable<int> created_by { get; set; }
        public Nullable<int> updated_by { get; set; }
        public Nullable<System.DateTime> updated_date { get; set; }
    }
}
