using Hosipital_Managment_Interface_Layer.Master_Interface;
using Hospital_Managment_Model_Layer.Master_Model;
using System;
using System.Web.Mvc;
namespace Hospital_Managment_Web_Module.Controllers
{

    public class Designation_MasterController : Controller
    {
        #region
        IDesignation_Master _IDesignation_Master;
        #endregion
        public Designation_MasterController(IDesignation_Master Init_Designation_Master)
        {
            _IDesignation_Master = Init_Designation_Master;
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Designation_Master_View()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SaveOrUpdate(Designation_information_Model model)
        {

            try
            {

                int i = _IDesignation_Master.AddOrSave(model);

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