using Hospital_Managment_Model_Layer.Master_Model;
namespace Hosipital_Managment_Interface_Layer.Master_Interface
{
    public interface IEmployee_Master
    {
        int AddOrSave(Employee_Information_Model model);
        string Genrate_Employee_Code();
    }
}
