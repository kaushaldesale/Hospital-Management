using Hospital_Managment_Data_Access_Layer;
using Hospital_Managment_Model_Layer.Master_Model;
using System;
using Hosipital_Managment_Interface_Layer.Master_Interface;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Managment_Business_Layer.Business_Master
{
    public class BUnit_Master_Repository : IUnit_Master
    {
        #region
        int _return = 0;
        Db_Hospital_ManagmentEntities _db;
        #endregion

        public BUnit_Master_Repository()
        {
            _db = new Db_Hospital_ManagmentEntities();
        }
        public int AddOrSave(Unit_Information_Model model)
        {
            using (_db = new Db_Hospital_ManagmentEntities())
            {
                using (var transaction = _db.Database.BeginTransaction())
                {
                    long _unit_id_add_update_check = model.unit_id;
                    try
                    {
                        if (_unit_id_add_update_check == 0)
                        {
                            Hospital_Managment_Data_Access_Layer.m_unit_information objm_unit_information = new Hospital_Managment_Data_Access_Layer.m_unit_information()
                            {
                                Unit_name = model.Unit_name,
                                created_date = System.DateTime.Now,
                                created_by = 1
                            };
                            _db.Entry(objm_unit_information).State = EntityState.Added;
                            _return = 1;
                        }

                        else
                        {
                            Hospital_Managment_Data_Access_Layer.m_unit_information objm_unit_information = new Hospital_Managment_Data_Access_Layer.m_unit_information()
                            {
                                unit_id = model.unit_id,
                                Unit_name = model.Unit_name,
                                updated_by = 1,
                                updated_date = System.DateTime.Now,
                            };
                            _db.Entry(objm_unit_information).State = EntityState.Modified;
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
