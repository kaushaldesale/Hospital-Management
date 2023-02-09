using Hospital_Managment_Model_Layer.Master_Model;

namespace Hosipital_Managment_Interface_Layer.Master_Interface
{
    public interface IMaterial_Type_Master
    {
        int AddOrSave(Material_Type_Information_Model model);
    }
}
