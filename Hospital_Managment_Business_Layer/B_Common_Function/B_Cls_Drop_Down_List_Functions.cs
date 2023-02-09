using Hosipital_Managment_Interface_Layer.Common_Function;
using Hospital_Managment_Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
namespace Hospital_Managment_Business_Layer.B_Common_Function
{
    public class B_Cls_Drop_Down_List_Functions : ICls_Drop_Down_List_Function
    {
        #region
        Db_Hospital_ManagmentEntities _db;
        #endregion
        public B_Cls_Drop_Down_List_Functions()
        {
            _db = new Db_Hospital_ManagmentEntities();
        }
        public List<SelectListItem> Get_Employee_Name_Drop_Down()
        {

            var _selectList = new List<SelectListItem>();
            _selectList.Add(new SelectListItem { Value = "0", Text = "--Select--" });
            var get_employee_name = (dynamic)null;
            try
            {
                using (_db = new Db_Hospital_ManagmentEntities())
                {
                    get_employee_name = (from x in _db.m_employee_information
                                         select new
                                         {
                                             x.employee_id,
                                             x.employee_name
                                         });

                    foreach (var item in get_employee_name)
                    {
                        _selectList.Add(new SelectListItem { Value = item.employee_id.ToString(), Text = item.employee_name.ToString() });
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (get_employee_name != null)
                    get_employee_name = null;

            }
            return _selectList;
        }
        public List<SelectListItem> Get_Hospital_Name_Drop_Down()
        {

            var _selectList = new List<SelectListItem>();
            _selectList.Add(new SelectListItem { Value = "0", Text = "--Select--" });
            var get_hosptial_name = (dynamic)null;
            try
            {
                using (_db = new Db_Hospital_ManagmentEntities())
                {
                    get_hosptial_name = (from x in _db.m_hospital_information
                                         select new
                                         {
                                             x.hospital_id,
                                             x.hospital_name
                                         });

                    foreach (var item in get_hosptial_name)
                    {
                        _selectList.Add(new SelectListItem { Value = item.hospital_id.ToString(), Text = item.hospital_name.ToString() });
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (get_hosptial_name != null)
                    get_hosptial_name = null;

            }
            return _selectList;
        }
        public List<SelectListItem> Get_Title_Drop_Down()
        {

            var _selectList = new List<SelectListItem>();
            _selectList.Add(new SelectListItem { Value = "0", Text = "--Select--" });
            var get_title = (dynamic)null;
            try
            {
                using (_db = new Db_Hospital_ManagmentEntities())
                {
                    get_title = (from x in _db.a_m_lookup_line
                                 where x.lookup_id == 4
                                 select new
                                 {
                                     x.line_id,
                                     x.line_name
                                 });

                    foreach (var item in get_title)
                    {
                        _selectList.Add(new SelectListItem { Value = item.line_id.ToString(), Text = item.line_name.ToString() });
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (get_title != null)
                    get_title = null;

            }
            return _selectList;
        }
        public List<SelectListItem> Get_Gender_Drop_Down()
        {

            var _selectList = new List<SelectListItem>();
            _selectList.Add(new SelectListItem { Value = "0", Text = "--Select--" });
            var get_gender = (dynamic)null;
            try
            {
                using (_db = new Db_Hospital_ManagmentEntities())
                {
                    get_gender = (from x in _db.a_m_lookup_line
                                  where x.lookup_id == 3
                                  select new
                                  {
                                      x.line_id,
                                      x.line_name
                                  });

                    foreach (var item in get_gender)
                    {
                        _selectList.Add(new SelectListItem { Value = item.line_id.ToString(), Text = item.line_name.ToString() });
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (get_gender != null)
                    get_gender = null;

            }
            return _selectList;
        }

        public List<SelectListItem> Get_Bank_Name_Drop_Down()
        {

            var _selectList = new List<SelectListItem>();
            _selectList.Add(new SelectListItem { Value = "0", Text = "--Select--" });
            var get_bank_name = (dynamic)null;
            try
            {
                using (_db = new Db_Hospital_ManagmentEntities())
                {
                    get_bank_name = (from x in _db.a_m_lookup_line
                                     where x.lookup_id == 2
                                     select new
                                     {
                                         x.line_id,
                                         x.line_name
                                     });

                    foreach (var item in get_bank_name)
                    {
                        _selectList.Add(new SelectListItem { Value = item.line_id.ToString(), Text = item.line_name.ToString() });
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (get_bank_name != null)
                    get_bank_name = null;

            }
            return _selectList;
        }

        public List<SelectListItem> Get_Designation_Drop_Down()
        {

            var _selectList = new List<SelectListItem>();
            _selectList.Add(new SelectListItem { Value = "0", Text = "--Select--" });
            var get_designation = (dynamic)null;
            try
            {
                using (_db = new Db_Hospital_ManagmentEntities())
                {
                    get_designation = (from x in _db.m_designation_information

                                       select new
                                       {
                                           x.designation_id,
                                           x.designation_name
                                       });

                    foreach (var item in get_designation)
                    {
                        _selectList.Add(new SelectListItem { Value = item.designation_id.ToString(), Text = item.designation_name.ToString() });
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (get_designation != null)
                    get_designation = null;

            }
            return _selectList;
        }

        public List<SelectListItem> Get_Department_Drop_Down()
        {

            var _selectList = new List<SelectListItem>();
            _selectList.Add(new SelectListItem { Value = "0", Text = "--Select--" });
            var get_department = (dynamic)null;
            try
            {
                using (_db = new Db_Hospital_ManagmentEntities())
                {
                    get_department = (from x in _db.m_department_information

                                      select new
                                      {
                                          x.department_id,
                                          x.department_name
                                      });

                    foreach (var item in get_department)
                    {
                        _selectList.Add(new SelectListItem { Value = item.department_id.ToString(), Text = item.department_name.ToString() });
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (get_department != null)
                    get_department = null;

            }
            return _selectList;
        }

        public List<SelectListItem> Get_Material_Type_Drop_Down()
        {

            var _selectList = new List<SelectListItem>();
            _selectList.Add(new SelectListItem { Value = "0", Text = "--Select--" });
            var get_material_type = (dynamic)null;
            try
            {
                using (_db = new Db_Hospital_ManagmentEntities())
                {
                    get_material_type = (from x in _db.m_material_type_infromation

                                      select new
                                      {
                                          x.material_type_id,
                                          x.material_type
                                      });

                    foreach (var item in get_material_type)
                    {
                        _selectList.Add(new SelectListItem { Value = item.material_type_id.ToString(), Text = item.material_type.ToString() });
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (get_material_type != null)
                    get_material_type = null;

            }
            return _selectList;
        }

        public List<SelectListItem> Get_Unit_Type_Drop_Down()
        {

            var _selectList = new List<SelectListItem>();
            _selectList.Add(new SelectListItem { Value = "0", Text = "--Select--" });
            var get_Unit_Type = (dynamic)null;
            try
            {
                using (_db = new Db_Hospital_ManagmentEntities())
                {
                    get_Unit_Type = (from x in _db.m_unit_information

                                         select new
                                         {
                                             x.unit_id,
                                             x.Unit_name
                                         });

                    foreach (var item in get_Unit_Type)
                    {
                        _selectList.Add(new SelectListItem { Value = item.unit_id.ToString(), Text = item.Unit_name.ToString() });
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (get_Unit_Type != null)
                    get_Unit_Type = null;

            }
            return _selectList;
        }


        public List<SelectListItem> Get_Material_Drop_Down()
        {

            var _selectList = new List<SelectListItem>();
            _selectList.Add(new SelectListItem { Value = "0", Text = "--Select--" });
            var get_Unit_Type = (dynamic)null;
            try
            {
                using (_db = new Db_Hospital_ManagmentEntities())
                {
                    get_Unit_Type = (from x in _db.m_material_type_infromation

                                     select new
                                     {
                                         x.material_type_id,
                                         x.material_type
                                     });

                    foreach (var item in get_Unit_Type)
                    {
                        _selectList.Add(new SelectListItem { Value = item.material_type_id.ToString(), Text = item.material_type.ToString() });
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (get_Unit_Type != null)
                    get_Unit_Type = null;

            }
            return _selectList;
        }

    }
}
