using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hosipital_Managment_Interface_Layer.Common_Function;
using Hosipital_Managment_Interface_Layer.Master_Interface;
using Hospital_Managment_Model_Layer.Master_Model;
namespace Hospital_Managment_Web_Module.Controllers
{
    public class User_MasterController : Controller
    {
        #region
        IUser_Creation _IUser_Creation;
        ICls_Drop_Down_List_Function _ICls_Drop_Down_List_Function;
        User_Creation_Infromation_Model model;
        #endregion

        public User_MasterController(IUser_Creation init_IUser_Creation, ICls_Drop_Down_List_Function init_ICls_Drop_Down_List_Function)
        {
            _IUser_Creation = init_IUser_Creation;
            _ICls_Drop_Down_List_Function = init_ICls_Drop_Down_List_Function;

        }

        public ActionResult Index()
        {
            ViewBag.Employee_id = _ICls_Drop_Down_List_Function.Get_Employee_Name_Drop_Down();
            return View();
        }
        public ActionResult User_Creation_View()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SaveOrUpdate(User_Creation_Infromation_Model model)
        {
            try
            {
               

                int i = _IUser_Creation.AddOrSave(model);

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