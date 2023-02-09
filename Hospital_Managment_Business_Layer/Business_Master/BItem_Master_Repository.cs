using Hospital_Managment_Data_Access_Layer;
using Hosipital_Managment_Interface_Layer.Master_Interface;
using System;
using Hospital_Managment_Model_Layer.Master_Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Hospital_Managment_Business_Layer.Business_Master
{
    public class BItem_Master_Repository : IItem_Master
    {
        #region
        int _return = 0;
        Db_Hospital_ManagmentEntities _db;
        #endregion

        public BItem_Master_Repository()
        {
            _db = new Db_Hospital_ManagmentEntities();
        }
        public int AddOrSave(Item_Information_Model model)
        {
            using (_db = new Db_Hospital_ManagmentEntities())
            {
                using (var transaction = _db.Database.BeginTransaction())
                {
                    long _item_id_add_update_check = model.item_id;
                    try
                    {
                        if (_item_id_add_update_check == 0)
                        {
                            Hospital_Managment_Data_Access_Layer.m_item_information objm_item_information = new Hospital_Managment_Data_Access_Layer.m_item_information()
                            {
                              
                                item_code = model.item_code,
                                item_type = model.item_type,
                                item_name = model.item_name,
                                item_manufaction_name = model.item_manufaction_name,
                                item_pacinking = model.item_pacinking,
                                item_use_name = model.item_use_name,
                                item_description = model.item_description,
                                item_start_date = model.item_start_date,
                                item_end_date = model.item_end_date,
                                item_first_unit = model.item_first_unit,
                                item_second_unit = model.item_second_unit,
                                item_conversion_first_factor = model.item_conversion_first_factor,
                                item_conversion_second_factor = model.item_conversion_second_factor,
                                item_is_stockebal = model.item_is_stockebal,
                                item_quality_check = model.item_quality_check,
                                item_return_policy = model.item_return_policy,
                                item_min_qty = model.item_min_qty,
                                item_max_qty = model.item_max_qty,
                                item_hsn_code = model.item_hsn_code,
                                item_po_type = model.item_po_type,
                                item_tax_apply = model.item_tax_apply,
                                item_po_tax_group = model.item_po_tax_group,
                                item_sale_tax_group = model.item_sale_tax_group,
                                created_by = model.created_by,
                                created_date = System.DateTime.Now,
                                activ_flag = model.activ_flag,
                                attr1 = model.attr1,
                                attr2 = model.attr2,
                                attr3 = model.attr3,
                                attr4 = model.attr4,
                                attr5 = model.attr5,
                                attr6 = model.attr6

                            };
                            _db.Entry(objm_item_information).State = EntityState.Added;
                            _return = 1;
                        }

                        else
                        {
                            Hospital_Managment_Data_Access_Layer.m_item_information objm_item_information = new Hospital_Managment_Data_Access_Layer.m_item_information()
                            {
                                item_code = model.item_code,
                                item_type = model.item_type,
                                item_name = model.item_name,
                                item_manufaction_name = model.item_manufaction_name,
                                item_pacinking = model.item_pacinking,
                                item_use_name = model.item_use_name,
                                item_description = model.item_description,
                                item_start_date = model.item_start_date,
                                item_end_date = model.item_end_date,
                                item_first_unit = model.item_first_unit,
                                item_second_unit = model.item_second_unit,
                                item_conversion_first_factor = model.item_conversion_first_factor,
                                item_conversion_second_factor = model.item_conversion_second_factor,
                                item_is_stockebal = model.item_is_stockebal,
                                item_quality_check = model.item_quality_check,
                                item_return_policy = model.item_return_policy,
                                item_min_qty = model.item_min_qty,
                                item_max_qty = model.item_max_qty,
                                item_hsn_code = model.item_hsn_code,
                                item_po_type = model.item_po_type,
                                item_tax_apply = model.item_tax_apply,
                                item_po_tax_group = model.item_po_tax_group,
                                item_sale_tax_group = model.item_sale_tax_group,
                                updated_by= model.created_by,
                                updated_date = System.DateTime.Now,
                                activ_flag = model.activ_flag,
                                attr1 = model.attr1,
                                attr2 = model.attr2,
                                attr3 = model.attr3,
                                attr4 = model.attr4,
                                attr5 = model.attr5,
                                attr6 = model.attr6
                            };
                            _db.Entry(objm_item_information).State = EntityState.Modified;
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
