using Hosipital_Managment_Interface_Layer.Common_Function;
using Hosipital_Managment_Interface_Layer.Master_Interface;
using Hospital_Managment_Model_Layer.Master_Model;
using System;
using System.Web.Mvc;
namespace Hospital_Managment_Web_Module.Controllers
{a

//Added By kaushal Desale
    public class Department_MasterController : Controller
    {
        #region
        IDepartment_Master _IDepartment_Master;
        ICls_Drop_Down_List_Function _IclsFunction;
        #endregion

        public Department_MasterController(IDepartment_Master init_department_master, ICls_Drop_Down_List_Function init_clsFunction)
        {
            _IDepartment_Master = init_department_master;
            _IclsFunction = init_clsFunction;
        }
        public ActionResult Index()
        {
            ViewBag.hospital_name = _IclsFunction.Get_Hospital_Name_Drop_Down();
            return View();
        }
        public ActionResult Department_Master_View()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SaveOrUpdate(Department_Information_Model model)
        {

            try
            {

                int i = _IDepartment_Master.AddOrSave(model);

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
