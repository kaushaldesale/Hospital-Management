using Hospital_Managment_Data_Access_Layer;
using System;
using Hospital_Managment_Model_Layer.Master_Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Hosipital_Managment_Interface_Layer.Master_Interface;
namespace Hospital_Managment_Business_Layer.Business_Master
{
    public class BMaterial_Type_Master_Repository : IMaterial_Type_Master
    {
        #region
        int _return = 0;
        Db_Hospital_ManagmentEntities _db;
        #endregion
        public BMaterial_Type_Master_Repository()
        {
            _db = new Db_Hospital_ManagmentEntities();
        }
        public int AddOrSave(Material_Type_Information_Model model)
        {
            using (_db = new Db_Hospital_ManagmentEntities())
            {
                using (var transaction = _db.Database.BeginTransaction())
                {
                    long _material_type_id_add_update_check = model.material_type_id;
                    try
                    {
                        if (_material_type_id_add_update_check == 0)
                        {
                            Hospital_Managment_Data_Access_Layer.m_material_type_infromation objm_material_type_infromation = new Hospital_Managment_Data_Access_Layer.m_material_type_infromation()
                            {
                                material_type=model.material_type,
                                created_date = System.DateTime.Now,
                                created_by = 1
                            };
                            _db.Entry(objm_material_type_infromation).State = EntityState.Added;
                            _return = 1;
                        }

                        else
                        {
                            Hospital_Managment_Data_Access_Layer.m_material_type_infromation objm_material_type_infromation = new Hospital_Managment_Data_Access_Layer.m_material_type_infromation()
                            {
                                material_type_id=model.material_type_id,
                                material_type=model.material_type,
                                updated_by = 1,
                                updated_date = System.DateTime.Now,
                            };
                            _db.Entry(objm_material_type_infromation).State = EntityState.Modified;
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
