using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hospital_Managment_Model_Layer.Master_Model;
using System.Web.Mvc;
using Hosipital_Managment_Interface_Layer.Master_Interface;
namespace Hospital_Managment_Web_Module.Controllers
{
    public class UnitMasterController : Controller
    {
        #region
        IUnit_Master _IUnit_Master;
        #endregion
        public UnitMasterController(IUnit_Master init_IUnit_Master)
        {
            _IUnit_Master = init_IUnit_Master;
        }

        // GET: UnitMaster
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Unit_Master_View()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SaveOrUpdate(Unit_Information_Model model)
        {

            try
            {

                int i = _IUnit_Master.AddOrSave(model);

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