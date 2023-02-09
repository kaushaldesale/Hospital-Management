using System;
using System.ComponentModel.DataAnnotations;
namespace Hospital_Managment_Model_Layer.Master_Model
{
    public class Employee_Information_Model
    {
        public int employee_id { get; set; }
        public string employee_code { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Please select title.")]
        public Nullable<int> employee_title { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Please select gender.")]
        public Nullable<int> employee_gender { get; set; }
        [Required(ErrorMessage = "This field is required ")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Name should be minimum 4 character and maximum 50 character ")]
        public string employee_name { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Please select designation.")]
        public int employye_designation { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Please select department.")]
        public int employee_department { get; set; }
        public Nullable<System.DateTime> employee_dob { get; set; }
        public Nullable<System.DateTime> employee_joing_date { get; set; }
        [Required(ErrorMessage = "This field is required ")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Address should be minimum 4 character and maximum 50 character ")]
        public string employee_Address { get; set; }
        public string employee_Address1 { get; set; }
        public string employee_city { get; set; }
        public string employee_pan { get; set; }
        public string employee_adharchard { get; set; }
        public string employee_alternet_no { get; set; }
        [Required(ErrorMessage = "This field is required ")]
        [RegularExpression(@"^[+-]?(?=.?\d)\d*(\.\d{0,9})?$", ErrorMessage = "Please enter valid input")] // this expression only pass the numaric data to fild.
        [StringLength(12, MinimumLength = 10, ErrorMessage = "Mobile number should be minimum 10 digit and maximum 12 digit")]
        public string employee_mobile { get; set; }
        public string employee_email_id { get; set; }
        public Nullable<int> employee_bank_name { get; set; }
        public string employee_account_no { get; set; }
        public string employee_ifsc_code { get; set; }
        public Nullable<int> employee_branch { get; set; }
        public string employee_photo { get; set; }
        public Nullable<int> created_by { get; set; }
        public Nullable<int> updated_by { get; set; }
        public Nullable<System.DateTime> created_date { get; set; }
        public Nullable<System.DateTime> updated_date { get; set; }
        public Nullable<bool> active_flag { get; set; }
        public string attr1 { get; set; }
        public string attr2 { get; set; }
        public string attr3 { get; set; }
        public Nullable<int> attr4 { get; set; }
    }
}
