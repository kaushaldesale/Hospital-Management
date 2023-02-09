using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Managment_Model_Layer.Master_Model
{
    public class Item_Information_Model
    {
        public int item_id { get; set; }
        public string item_code { get; set; }
        public Nullable<int> item_type { get; set; }
        public string item_name { get; set; }
        public string item_manufaction_name { get; set; }
        public Nullable<int> item_pacinking { get; set; }
        public string item_use_name { get; set; }
        public string item_description { get; set; }
        public Nullable<System.DateTime> item_start_date { get; set; }
        public Nullable<System.DateTime> item_end_date { get; set; }
        public Nullable<int> item_first_unit { get; set; }
        public Nullable<int> item_second_unit { get; set; }
        public Nullable<decimal> item_conversion_first_factor { get; set; }
        public Nullable<decimal> item_conversion_second_factor { get; set; }
        public Nullable<bool> item_is_stockebal { get; set; }
        public Nullable<bool> item_quality_check { get; set; }
        public Nullable<bool> item_return_policy { get; set; }
        public Nullable<decimal> item_min_qty { get; set; }
        public Nullable<decimal> item_max_qty { get; set; }
        public string item_hsn_code { get; set; }
        public Nullable<int> item_po_type { get; set; }
        public Nullable<bool> item_tax_apply { get; set; }
        public Nullable<decimal> item_po_tax_group { get; set; }
        public Nullable<decimal> item_sale_tax_group { get; set; }
        public Nullable<int> created_by { get; set; }
        public Nullable<System.DateTime> created_date { get; set; }
        public Nullable<int> updated_by { get; set; }
        public Nullable<System.DateTime> updated_date { get; set; }
        public Nullable<bool> activ_flag { get; set; }
        public string attr1 { get; set; }
        public string attr2 { get; set; }
        public string attr3 { get; set; }
        public Nullable<int> attr4 { get; set; }
        public Nullable<int> attr5 { get; set; }
        public Nullable<int> attr6 { get; set; }
    }
}
