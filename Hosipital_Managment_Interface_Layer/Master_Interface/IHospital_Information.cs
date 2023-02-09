using Hospital_Managment_Model_Layer.Master_Model;
namespace Hosipital_Managment_Interface_Layer.Master_Interface
{
    public interface IHospital_Information
    {
        int AddOrSave(Hospital_Information_Model model);
    }
}
