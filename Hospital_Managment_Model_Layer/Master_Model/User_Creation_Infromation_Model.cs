using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Hospital_Managment_Model_Layer.Master_Model
{
    public class User_Creation_Infromation_Model
    {
        public int user_id { get; set; }

        [Required(ErrorMessage = "This field is required ")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "user name should be minimum 4 character and maximum 10 character ")]
        public string user_name { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "This field is required ")]
        public string user_password { get; set; }
        [DataType(DataType.Password)]
        [Compare("user_password", ErrorMessage = "Password and confirmation password must match.")]
        public string user_confirm_password { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Please select employee name.")]
        public Nullable<int> Employee_id { get; set; }
        public Nullable<int> created_by { get; set; }
        public Nullable<System.DateTime> created_date { get; set; }
        public Nullable<int> updated_by { get; set; }
        public Nullable<System.DateTime> update_date { get; set; }
        public string attr1 { get; set; }
        public string attr2 { get; set; }
        public string attr3 { get; set; }
        public string attr4 { get; set; }
    }
}
