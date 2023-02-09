using Hospital_Managment_Model_Layer.Master_Model;
namespace Hosipital_Managment_Interface_Layer.Master_Interface
{
    public interface IDepartment_Master
    {
        int AddOrSave(Department_Information_Model model);
    }
}
