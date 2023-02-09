using Hosipital_Managment_Interface_Layer.Master_Interface;
using Hospital_Managment_Data_Access_Layer;
using Hospital_Managment_Model_Layer.Master_Model;
using System;
using System.Data.Entity;

namespace Hospital_Managment_Business_Layer.Business_Master
{
    public class BDesignation_Master_Repository : IDesignation_Master
    {
        #region
        int _return = 0;
        Db_Hospital_ManagmentEntities _db;
        #endregion

        public int AddOrSave(Designation_information_Model model)
        {
            using (_db = new Db_Hospital_ManagmentEntities())
            {
                using (var transaction = _db.Database.BeginTransaction())
                {
                    long _designation_id_add_update_check = model.designation_id;
                    try
                    {
                        if (_designation_id_add_update_check == 0)
                        {
                            Hospital_Managment_Data_Access_Layer.m_designation_information objm_designation_information = new Hospital_Managment_Data_Access_Layer.m_designation_information()
                            {
                                designation_name = model.designation_name,
                                designation_qualification = model.designation_qualification,
                                designation_code = model.designation_code,
                                designation_description = model.designation_description,
                                created_date = System.DateTime.Now,
                                created_by = 1
                            };
                            _db.Entry(objm_designation_information).State = EntityState.Added;
                            _return = 1;
                        }

                        else
                        {
                            Hospital_Managment_Data_Access_Layer.m_designation_information objm_designation_information = new Hospital_Managment_Data_Access_Layer.m_designation_information()
                            {
                                designation_name = model.designation_name,
                                designation_description = model.designation_description,
                                designation_qualification = model.designation_qualification,
                                designation_code = model.designation_code,
                                updated_by = 1,
                                updated_date = System.DateTime.Now,
                            };
                            _db.Entry(objm_designation_information).State = EntityState.Modified;
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
