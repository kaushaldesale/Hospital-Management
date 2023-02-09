using System;
using System.ComponentModel.DataAnnotations;
namespace Hospital_Managment_Model_Layer.Master_Model
{
    public class Department_Information_Model
    {


        public long department_id { get; set; }
        public Nullable<System.DateTime> department_start_date { get; set; }
        public string department_code { get; set; }
        [Required(ErrorMessage = "This field is required ")]
        [MaxLength(50), MinLength(3)]
        public string department_name { get; set; }
        public string deparment_address { get; set; }
        public string deparment_description { get; set; }
        public Nullable<long> hospital_id { get; set; }
        public Nullable<int> created_by { get; set; }
        public Nullable<System.DateTime> created_date { get; set; }
        public Nullable<System.DateTime> updated_date { get; set; }
        public Nullable<int> updated_by { get; set; }
    }
}
