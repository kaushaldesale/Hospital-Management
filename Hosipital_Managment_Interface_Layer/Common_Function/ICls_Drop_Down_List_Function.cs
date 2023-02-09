using System.Collections.Generic;
using System.Web.Mvc;

namespace Hosipital_Managment_Interface_Layer.Common_Function
{
    public interface ICls_Drop_Down_List_Function
    {
        List<SelectListItem> Get_Hospital_Name_Drop_Down();
        List<SelectListItem> Get_Title_Drop_Down();
        List<SelectListItem> Get_Gender_Drop_Down();
        List<SelectListItem> Get_Bank_Name_Drop_Down();
        List<SelectListItem> Get_Designation_Drop_Down();
        List<SelectListItem> Get_Department_Drop_Down();
        List<SelectListItem> Get_Employee_Name_Drop_Down();
        List<SelectListItem> Get_Unit_Type_Drop_Down();
        List<SelectListItem> Get_Material_Type_Drop_Down();
        List<SelectListItem> Get_Material_Drop_Down();
    }
}
