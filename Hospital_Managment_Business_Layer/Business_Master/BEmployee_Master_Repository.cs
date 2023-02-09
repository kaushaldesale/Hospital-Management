using Hosipital_Managment_Interface_Layer.Master_Interface;
using Hospital_Managment_Data_Access_Layer;
using Hospital_Managment_Model_Layer.Master_Model;
using System;
using System.Data.Entity;
using System.Linq;
using Hospital_Managment_Business_Layer.B_Common_Function;
using Hospital_Managment_Business_Layer.Common_Functions;

namespace Hospital_Managment_Business_Layer.Business_Master
{
    public class BEmployee_Master_Repository : IEmployee_Master
    {
        #region
        int _return = 0;
        Db_Hospital_ManagmentEntities _db;
        _ClsFunction _ClsFunction = new _ClsFunction();
        #endregion
        public int AddOrSave(Employee_Information_Model model)
        {
            using (_db = new Db_Hospital_ManagmentEntities())
            {
                using (var transaction = _db.Database.BeginTransaction())
                {
                    long _employee_id_add_update_check = model.employee_id;
                    try
                    {
                        if (_employee_id_add_update_check == 0)
                        {
                            Hospital_Managment_Data_Access_Layer.m_employee_information objm_employee_information = new Hospital_Managment_Data_Access_Layer.m_employee_information()
                            {

                                employee_code = model.employee_code,
                                employee_title = model.employee_title,
                                employee_gender = model.employee_gender,
                                employee_name = model.employee_name,
                                employye_designation = model.employye_designation,
                                employee_department = model.employee_department,
                                employee_dob = model.employee_dob,
                                employee_joing_date = model.employee_joing_date,
                                employee_Address = model.employee_Address,
                                employee_Address1 = model.employee_Address1,
                                employee_city = model.employee_city,
                                employee_pan = model.employee_pan,
                                employee_adharchard = model.employee_adharchard,
                                employee_alternet_no = model.employee_alternet_no,
                                employee_mobile = model.employee_mobile,
                                employee_email_id = model.employee_email_id,
                                employee_bank_name = model.employee_bank_name,
                                employee_account_no = model.employee_account_no,
                                employee_ifsc_code = model.employee_ifsc_code,
                                employee_branch = model.employee_branch,
                                employee_photo = model.employee_photo,
                                created_by = model.created_by,
                                created_date = model.created_date,
                                active_flag = model.active_flag,
                                attr1 = model.attr1,
                                attr2 = model.attr2,
                                attr3 = model.attr3,
                                attr4 = model.attr4

                            };
                            _db.Entry(objm_employee_information).State = EntityState.Added;
                            _return = 1;
                        }

                        else
                        {
                            Hospital_Managment_Data_Access_Layer.m_employee_information objm_employee_information = new Hospital_Managment_Data_Access_Layer.m_employee_information()
                            {
                                employee_id = model.employee_id,
                                employee_code = model.employee_code,
                                employee_title = model.employee_title,
                                employee_gender = model.employee_gender,
                                employee_name = model.employee_name,
                                employye_designation = model.employye_designation,
                                employee_department = model.employee_department,
                                employee_dob = model.employee_dob,
                                employee_joing_date = model.employee_joing_date,
                                employee_Address = model.employee_Address,
                                employee_Address1 = model.employee_Address1,
                                employee_city = model.employee_city,
                                employee_pan = model.employee_pan,
                                employee_adharchard = model.employee_adharchard,
                                employee_alternet_no = model.employee_alternet_no,
                                employee_mobile = model.employee_mobile,
                                employee_email_id = model.employee_email_id,
                                employee_bank_name = model.employee_bank_name,
                                employee_account_no = model.employee_account_no,
                                employee_ifsc_code = model.employee_ifsc_code,
                                employee_branch = model.employee_branch,
                                employee_photo = model.employee_photo,
                                updated_by = model.updated_by,
                                updated_date = model.updated_date,
                                active_flag = model.active_flag,
                                attr1 = model.attr1,
                                attr2 = model.attr2,
                                attr3 = model.attr3,
                                attr4 = model.attr4

                            };
                            _db.Entry(objm_employee_information).State = EntityState.Modified;
                            _return = 2;
                        }
                        _db.SaveChanges();
                    }
                    catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
                    {
                        Exception raise = dbEx;
                        foreach (var validationErrors in dbEx.EntityValidationErrors)
                        {
                            foreach (var validationError in validationErrors.ValidationErrors)
                            {
                                string message = string.Format("{0}:{1}",
                                    validationErrors.Entry.Entity.ToString(),
                                    validationError.ErrorMessage);
                                raise = new InvalidOperationException(message, raise);
                            }

                        }
                        _return = 0;
                    }
                    finally
                    {
                        transaction.Commit();
                        transaction.Dispose();
                        _db.Database.Connection.Close();
                    }
                }
                return _return;
            }
        }

        public string Genrate_Employee_Code()
        {
            string _employee_code = string.Empty;
            try
            {
                using (_db = new Db_Hospital_ManagmentEntities())
                {

                    var count_code = (from x in _db.m_employee_information
                                      select new { x.employee_id }).Count();
                    if (count_code == 0)
                    {
                        return _employee_code = _ClsFunction.Genrate_Code_For_User_View("EMP", "1");
                    }
                    else
                    {
                        int convert_count_code = 0;
                        int.TryParse(count_code.ToString(), out convert_count_code);
                        convert_count_code++;
                        return _employee_code = _ClsFunction.Genrate_Code_For_User_View("EMP", convert_count_code.ToString());
                    }

                }

            }
            catch (Exception ex)
            {
                return ex.InnerException.ToString();
            }
        }
    }
}
