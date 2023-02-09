using Hospital_Managment_Model_Layer.Master_Model;

namespace Hosipital_Managment_Interface_Layer.Master_Interface
{
    public interface IDesignation_Master
    {
        int AddOrSave(Designation_information_Model model);
    }
}
