using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hosipital_Managment_Interface_Layer.Master_Interface;
using Hosipital_Managment_Interface_Layer.Common_Function;
namespace Hospital_Managment_Web_Module.Controllers
{
    public class Item_MasterController : Controller
    {
        #region
        IItem_Master _IItem_Master;
        ICls_Drop_Down_List_Function _ICls_Drop_Down_List_Function;
        #endregion
        public Item_MasterController(IItem_Master init_IItem_Master, ICls_Drop_Down_List_Function init_ICls_Drop_Down_List_Function)
        {
            _IItem_Master = init_IItem_Master;
            _ICls_Drop_Down_List_Function = init_ICls_Drop_Down_List_Function;
        }
        public ActionResult Index()
        {
            ViewBag.item_type = _ICls_Drop_Down_List_Function.Get_Material_Type_Drop_Down();
            ViewBag.item_first_unit = _ICls_Drop_Down_List_Function.Get_Unit_Type_Drop_Down();
            return View();
        }
        public ActionResult Item_Master_View()
        {
            return View();
        }
    }
} 