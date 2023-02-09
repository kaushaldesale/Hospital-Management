using Hospital_Managment_Data_Access_Layer;
using System;
using Hospital_Managment_Model_Layer.Master_Model;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hosipital_Managment_Interface_Layer.Master_Interface;
namespace Hospital_Managment_Business_Layer.Business_Master
{
    public class BUser_Master_Repository : IUser_Creation
    {
        #region
        int _return = 0;
        Db_Hospital_ManagmentEntities _db;
        #endregion
        public BUser_Master_Repository()
        {
            _db = new Db_Hospital_ManagmentEntities();
        }
        public int AddOrSave(User_Creation_Infromation_Model model)
        {
            using (_db = new Db_Hospital_ManagmentEntities())
            {
                using (var transaction = _db.Database.BeginTransaction())
                {
                    int _user_id_check_add_or_update = model.user_id;
                    try
                    {
                        if (_user_id_check_add_or_update == 0)
                        {
                            Hospital_Managment_Data_Access_Layer.m_user_Login_information objm_user_Login_information = new Hospital_Managment_Data_Access_Layer.m_user_Login_information()
                            {

                                user_name = model.user_name,
                                user_password = model.user_password,
                                user_confirm_password = model.user_confirm_password,
                                Employee_id = model.Employee_id,
                                created_by = 1,
                                created_date = System.DateTime.Now,
                                attr1 = model.attr1,
                                attr2 = model.attr2,
                                attr3 = model.attr3,
                                attr4 = model.attr4,

                            };
                            _db.Entry(objm_user_Login_information).State = EntityState.Added;
                            _return = 1;
                        }

                        else
                        {
                            Hospital_Managment_Data_Access_Layer.m_user_Login_information objm_user_Login_information = new Hospital_Managment_Data_Access_Layer.m_user_Login_information()
                            {
                                user_name = model.user_name,
                                user_password = model.user_password,
                                user_confirm_password = model.user_confirm_password,
                                Employee_id = model.Employee_id,
                                updated_by = 1,
                                update_date = System.DateTime.Now,
                                attr1 = model.attr1,
                                attr2 = model.attr2,
                                attr3 = model.attr3,
                                attr4 = model.attr4,

                            };
                            _db.Entry(objm_user_Login_information).State = EntityState.Modified;
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
