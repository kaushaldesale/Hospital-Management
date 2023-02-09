using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hospital_Managment_Model_Layer.Master_Model;
using Hosipital_Managment_Interface_Layer.Master_Interface;
using Hosipital_Managment_Interface_Layer.Common_Function;
namespace Hospital_Managment_Web_Module.Controllers
{
    public class Material_Type_MasterController : Controller
    {
        #region
        IMaterial_Type_Master _IMaterial_Type_Master;
        ICls_Drop_Down_List_Function _ICls_Drop_Down_List_Function;
        #endregion

        public Material_Type_MasterController(IMaterial_Type_Master init_IMaterial_Type_Master ,ICls_Drop_Down_List_Function _init)
        {
            _ICls_Drop_Down_List_Function = _init;
            _IMaterial_Type_Master = init_IMaterial_Type_Master;
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Material_Type_Master_View()
        {

            return View();
        }
        public ActionResult SaveOrUpdate(Material_Type_Information_Model model)
        {

            try
            {

                int i = _IMaterial_Type_Master.AddOrSave(model);

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