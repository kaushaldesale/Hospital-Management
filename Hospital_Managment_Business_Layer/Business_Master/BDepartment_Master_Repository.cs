using Hosipital_Managment_Interface_Layer.Master_Interface;
using Hospital_Managment_Data_Access_Layer;
using Hospital_Managment_Model_Layer.Master_Model;
using System;
using System.Data.Entity;

namespace Hospital_Managment_Business_Layer.Business_Master
{
    public class BDepartment_Master_Repository : IDepartment_Master
    {
        #region
        int _return = 0;
        Db_Hospital_ManagmentEntities _db;
        #endregion
        public BDepartment_Master_Repository()
        {
            _db = new Db_Hospital_ManagmentEntities();
        }
        public int AddOrSave(Department_Information_Model model)
        {
            using (_db = new Db_Hospital_ManagmentEntities())
            {
                using (var transaction = _db.Database.BeginTransaction())
                {
                    long _department_id_add_update_check = model.department_id;
                    try
                    {
                        if (_department_id_add_update_check == 0)
                        {
                            Hospital_Managment_Data_Access_Layer.m_department_information objm_department_informationn = new Hospital_Managment_Data_Access_Layer.m_department_information()
                            {
                                department_name = model.department_name,
                                department_code = model.department_code,
                                deparment_description = model.deparment_description,
                                deparment_address = model.deparment_address,
                                department_start_date = model.department_start_date,
                                created_date = System.DateTime.Now,
                                created_by = 1
                            };
                            _db.Entry(objm_department_informationn).State = EntityState.Added;
                            _return = 1;
                        }

                        else
                        {
                            Hospital_Managment_Data_Access_Layer.m_department_information objm_department_informationn = new Hospital_Managment_Data_Access_Layer.m_department_information()
                            {
                                department_name = model.department_name,
                                deparment_description = model.deparment_description,
                                department_code = model.department_code,
                                deparment_address = model.deparment_address,
                                department_start_date = model.department_start_date,
                                updated_by = 1,
                                updated_date = System.DateTime.Now,
                            };
                            _db.Entry(objm_department_informationn).State = EntityState.Modified;
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
    }
}
