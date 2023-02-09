using Hosipital_Managment_Interface_Layer.Master_Interface;
using Hospital_Managment_Data_Access_Layer;
using Hospital_Managment_Model_Layer.Master_Model;
using System;
using System.Data.Entity;

namespace Hospital_Managment_Business_Layer.Business_Master
{

    public class BHospital_Master_Repository : IHospital_Information
    {
        #region
        int _return = 0;
        Db_Hospital_ManagmentEntities _db;
        #endregion
        public BHospital_Master_Repository()
        {
            _db = new Db_Hospital_ManagmentEntities();
        }
        public int AddOrSave(Hospital_Information_Model model)
        {
            using (_db = new Db_Hospital_ManagmentEntities())
            {
                using (var transaction = _db.Database.BeginTransaction())
                {
                    int _hospital_id_check_add_or_update = model.hospital_id;
                    try
                    {
                        if (_hospital_id_check_add_or_update == 0)
                        {
                            Hospital_Managment_Data_Access_Layer.m_hospital_information objm_hospital_information = new Hospital_Managment_Data_Access_Layer.m_hospital_information()
                            {
                                hospital_name = model.hospital_name,
                                hospital_web_site = model.hospital_web_site,
                                hospital_address = model.hospital_address,
                                hospital_contact_number = model.hospital_contact_number,
                                hospital_gst_number = model.hospital_gst_number,
                                hospital_contact_number1 = model.hospital_contact_number1,
                                hospital_city = model.hospital_city,
                                hospital_email_address = model.hospital_email_address,
                                hospital_pan = model.hospital_pan,
                                created_by = 1,
                                created_date = System.DateTime.Now,
                            };
                            _db.Entry(objm_hospital_information).State = EntityState.Added;
                            _return = 1;
                        }

                        else
                        {
                            Hospital_Managment_Data_Access_Layer.m_hospital_information objm_hospital_information = new Hospital_Managment_Data_Access_Layer.m_hospital_information()
                            {
                                hospital_id = model.hospital_id,
                                hospital_name = model.hospital_name,
                                hospital_web_site = model.hospital_web_site,
                                hospital_address = model.hospital_address,
                                hospital_contact_number = model.hospital_contact_number,
                                hospital_gst_number = model.hospital_gst_number,
                                hospital_contact_number1 = model.hospital_contact_number1,
                                hospital_city = model.hospital_city,
                                hospital_email_address = model.hospital_email_address,
                                hospital_pan = model.hospital_pan,
                                updated_by = 2,
                                updated_date = System.DateTime.Now,
                            };
                            _db.Entry(objm_hospital_information).State = EntityState.Modified;
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
