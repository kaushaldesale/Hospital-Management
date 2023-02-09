using System;
using System.ComponentModel.DataAnnotations;

namespace Hospital_Managment_Model_Layer.Master_Model
{
    public class Hospital_Information_Model
    {
        public int hospital_id { get; set; }
        [Required(ErrorMessage = "This field is required ")]
        [MaxLength(50), MinLength(5)]
        public string hospital_name { get; set; }
        [Required(ErrorMessage = "This field is required ")]
        [MaxLength(150), MinLength(5)]
        public string hospital_address { get; set; }
        [Required(ErrorMessage = "This field is required ")]
        [MaxLength(150), MinLength(5)]

        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string hospital_email_address { get; set; }
        public byte[] logo { get; set; }
        [Required(ErrorMessage = "This field is required ")]
        [MaxLength(150), MinLength(5)]
        public string hospital_city { get; set; }
        public string hospital_pan { get; set; }
        public string hospital_gst_number { get; set; }
        [Required(ErrorMessage = "This field is required ")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public string hospital_contact_number { get; set; }
        public string hospital_contact_number1 { get; set; }
        public string hospital_web_site { get; set; }
        public Nullable<int> created_by { get; set; }
        public Nullable<System.DateTime> created_date { get; set; }
        public Nullable<int> updated_by { get; set; }
        public Nullable<System.DateTime> updated_date { get; set; }
    }
}
