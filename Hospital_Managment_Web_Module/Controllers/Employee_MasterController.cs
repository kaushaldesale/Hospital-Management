using Hosipital_Managment_Interface_Layer.Common_Function;
using Hosipital_Managment_Interface_Layer.Master_Interface;
using Hospital_Managment_Model_Layer.Master_Model;
using System;
using System.Web.Mvc;
namespace Hospital_Managment_Web_Module.Controllers
{
    public class Employee_MasterController : Controller
    {
        #region
        ICls_Drop_Down_List_Function _ICls_Drop_Down_List_Function;
        IEmployee_Master _IEmployee_Master;
        Employee_Information_Model model;
        #endregion
        public Employee_MasterController(ICls_Drop_Down_List_Function init_ICls_Drop_Down_List_Function,
            IEmployee_Master init_IEmployee_Master)
        {
            _ICls_Drop_Down_List_Function = init_ICls_Drop_Down_List_Function;
            _IEmployee_Master = init_IEmployee_Master;
        }
              

        public ActionResult Index()
        {
            

            ViewBag.employee_bank_name = _ICls_Drop_Down_List_Function.Get_Bank_Name_Drop_Down();
            ViewBag.employee_title = _ICls_Drop_Down_List_Function.Get_Title_Drop_Down();
            ViewBag.employee_gender = _ICls_Drop_Down_List_Function.Get_Gender_Drop_Down();
            ViewBag.employye_designation = _ICls_Drop_Down_List_Function.Get_Designation_Drop_Down();
            ViewBag.employye_designation = _ICls_Drop_Down_List_Function.Get_Designation_Drop_Down();
            ViewBag.employee_department = _ICls_Drop_Down_List_Function.Get_Department_Drop_Down();
            string str_employee_code = "";
            str_employee_code = _IEmployee_Master.Genrate_Employee_Code();

            model = new Employee_Information_Model() {
                employee_code = str_employee_code
            };
            return View(model);
        }
        public ActionResult Employee_Master_View()
        {
            return View();
        }
        public ActionResult SaveOrUpdate(Employee_Information_Model model)
        {

            try
            {

                int i = _IEmployee_Master.AddOrSave(model);

                if (i == 1)
                {
                    TempData["message"] = "Your Data Save Successfuly..";
                }
                else if (i == 2)
                {
                    TempData["message"] = "Your Data Update Successfuly";
                }
                else
                {
                    TempData["Error"] = "Opps Somthing Wrong !!!";
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message }, JsonRequestBehavior.AllowGet);
            }
            return RedirectToAction("index");
        }
    }
}