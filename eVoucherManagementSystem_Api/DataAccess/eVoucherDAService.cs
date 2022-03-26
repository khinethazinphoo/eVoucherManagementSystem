using eVoucherManagementSystem_Api.Entities;
using eVoucherManagementSystem_Api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;

namespace eVoucherManagementSystem_Api.DataAccess
{
    public class eVoucherDAService
    {
        private evouchermanagementsystemContext _db;
        public eVoucherDAService()
        {
            _db = new evouchermanagementsystemContext();
        }

        public bool InserteVoucher(eVoucherRequestModel reqModel)
        {
            try
            {
                int res = 0;
                TblEvoucher item = reqModel.Change();
                _db.TblEvouchers.Add(item);
                res = _db.SaveChanges();
                return res == 1;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool EditeVoucher(eVoucherRequestModel reqModel)
        {
            try
            {
                bool res = false;
                int l_eVoucherId = reqModel.eVoucherId.CheckEntityItem<int>();
                TblEvoucher item = _db.TblEvouchers
              .Where(x =>
                         x.UserId == reqModel.UserId &&
                         x.EvoucherId == l_eVoucherId).FirstOrDefault();
                if (item != null)
                {
                    item = item.ChangeEdit(reqModel);
                    _db.TblEvouchers.Update(item);
                    int count = _db.SaveChanges();
                    res = count == 1;
                }
                return res;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool SetInActiveeVoucher(eVoucherRequestModel reqModel)
        {
            try
            {
                bool res = false;
                int l_eVoucherId = reqModel.eVoucherId.CheckEntityItem<int>();
                TblEvoucher item = _db.TblEvouchers
              .Where(x =>
                         x.UserId == reqModel.UserId &&
                         x.EvoucherId == l_eVoucherId).FirstOrDefault();
                if (item != null)
                {
                    item = item.ChangeInActive(reqModel);
                    _db.TblEvouchers.Update(item);
                    int count = _db.SaveChanges();
                    res = count == 1;
                }
                return res;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<TblEvoucher> GeteVoucher(string l_UserId)
        {
            try
            {
                TblEvoucher reqModel = new TblEvoucher { UserId = l_UserId };
                List<TblEvoucher> lstItem = _db.TblEvouchers
                    .Where(x =>
                       x.UserId == reqModel.UserId).AsNoTracking().ToList();
                return lstItem;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<TblPurchasehistory> ListPurchaseHistory(string l_UserId)
        {
            try
            {
                TblPurchasehistory reqModel = new TblPurchasehistory { UserId = l_UserId };
                List<TblPurchasehistory> lstItem = _db.TblPurchasehistories
                    .Where(x =>
                       x.UserId == reqModel.UserId).AsNoTracking().ToList();
                return lstItem;
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public TblEvoucher DetaileVoucher(int I_eVoucherId)
        {
            try
            {
                TblEvoucher reqModel = new TblEvoucher { EvoucherId = I_eVoucherId };
                TblEvoucher item = _db.TblEvouchers
                    .Where(x =>
                       x.EvoucherId == reqModel.EvoucherId).AsNoTracking().FirstOrDefault();
                return item;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool VerifyPromoCode(eVoucherRequestModel reqModel)
        {
            try
            {
                bool res = false;
                TblPurchasehistory item = _db.TblPurchasehistories
                    .Where(x =>
                       x.UserId == reqModel.UserId &&
                       x.PhoneNumber == reqModel.PhoneNumber &&
                       x.PromoCode == reqModel.PromoCode &&
                       x.IsActive == reqModel.IsActive
                       ).AsNoTracking().FirstOrDefault();
                if (item.MaxeVoucherlimit == 0)
                {
                    goto Result;
                }
                if (item != null && item.MaxeVoucherlimit > 1 || item.IsUsed == true)
                {
                    item.MaxeVoucherlimit = item.MaxeVoucherlimit - 1;
                }
                
                item.IsUsed = true;
                _db.TblPurchasehistories.Update(item);
                int count = _db.SaveChanges();
                res = count == 1;
                Result: 
                return res;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool CheckOuteVoucher(eVoucherRequestModel reqModel)
        {
            try
            {
                int res = 0;
                TblPurchasehistory item = reqModel.ChangePurchase();
                _db.TblPurchasehistories.Add(item);
                res = _db.SaveChanges();
                return res == 1;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public TblPurchasehistory GetPromoCode(string l_UserId,string l_PromoCode)
        {
            try
            {
                TblPurchasehistory reqModel = new TblPurchasehistory { UserId = l_UserId , PromoCode = l_PromoCode};
               TblPurchasehistory item = _db.TblPurchasehistories
                    .Where(x =>
                       x.UserId == reqModel.UserId && 
                       x.PromoCode == reqModel.PromoCode).AsNoTracking().FirstOrDefault();
                return item;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
