using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_Managment_Model_Layer.Master_Model;
namespace Hosipital_Managment_Interface_Layer.Master_Interface
{
    public interface IUnit_Master
    {
        int AddOrSave(Unit_Information_Model model);
    }
}
