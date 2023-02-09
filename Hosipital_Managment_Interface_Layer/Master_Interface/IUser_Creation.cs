using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_Managment_Model_Layer.Master_Model;
namespace Hosipital_Managment_Interface_Layer.Master_Interface
{
   public interface IUser_Creation
    {
        int AddOrSave(User_Creation_Infromation_Model model);
    }
}
