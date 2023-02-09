using Hosipital_Managment_Interface_Layer.Master_Interface;
using Hospital_Managment_Model_Layer.Master_Model;
using System;
using System.Web.Mvc;
namespace Hospital_Managment_Web_Module.Controllers
{

    public class Hospital_MasterController : Controller
    {
        #region
        IHospital_Information _IHospital_Information;

        public Hospital_MasterController(IHospital_Information _interface)
        {
            _IHospital_Information = _interface;
        }
        #endregion
        // GET: Hospital_Master
        public ActionResult Index()
        {
            Hospital_Information_Model model;

            model = new Hospital_Information_Model()
            {

            };
            return View(model);
        }

        public ActionResult Hospital_Master_View()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SaveOrUpdate(Hospital_Information_Model model)
        {

            try
            {

                int i = _IHospital_Information.AddOrSave(model);

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