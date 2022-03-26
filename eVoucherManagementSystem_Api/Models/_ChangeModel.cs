using eVoucherManagementSystem_Api.Entities;
using eVoucherManagementSystem_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public static class ChangeModel
{

    public static TblEvoucher Change(this eVoucherRequestModel reqModel)
    {
        TblEvoucher model = new TblEvoucher();
        model.Title = reqModel.Title;
        model.Description = reqModel.Description;
        model.Amount = reqModel.Amount.CheckEntityItem<decimal>();
        model.UserId = reqModel.UserId;
        model.Quantity = reqModel.Quantity;
        model.PhoneNumber = reqModel.PhoneNumber;
        model.BuyType = reqModel.BuyType.ToString();
        model.Name = reqModel.Name;
        model.PhoneNumber = reqModel.PhoneNumber;
#warning
        //model.MaxeVoucherlimit = reqModel.MaxeVoucherlimit;
        model.GiftperUserlimit = reqModel.GiftperUserlimit;
        model.DateExpire = reqModel.ExpiryDate;
        model.IsActive = true;
        return model;
    }

    public static TblPurchasehistory ChangePurchase(this eVoucherRequestModel reqModel)
    {
        TblPurchasehistory model = new TblPurchasehistory();
        model.Title = reqModel.Title;
        model.Description = reqModel.Description;
        model.Amount = reqModel.Amount.CheckEntityItem<decimal>();
        model.UserId = reqModel.UserId;
        model.Quantity = reqModel.Quantity;
        model.PhoneNumber = reqModel.PhoneNumber;
        model.BuyType = reqModel.BuyType.ToString();
        model.Name = reqModel.Name;
        model.PhoneNumber = reqModel.PhoneNumber;
        model.MaxeVoucherlimit = reqModel.MaxeVoucherlimit;
        model.GiftperUserlimit = reqModel.GiftperUserlimit;
        model.ExpiryDate = reqModel.ExpiryDate;
        model.IsActive = true;
        model.PromoCode = reqModel.PromoCode;
        model.Base64ForQr = reqModel.Base64ForQR;
        model.PaymentMethod = reqModel.PaymentMethod.CheckEntityItem<string>();
        model.IsUsed = false;
        return model;
    }

    public static TblEvoucher ChangeEdit(this TblEvoucher model, eVoucherRequestModel reqModel)
    {
        model.UserId = reqModel.UserId;
        model.Amount = reqModel.Amount.CheckEntityItem<decimal>();
        model.Quantity = reqModel.Quantity;
        model.PhoneNumber = reqModel.PhoneNumber;
        model.BuyType = reqModel.BuyType.ToString();
        model.Name = reqModel.Name;
        model.PhoneNumber = reqModel.PhoneNumber;
        model.MaxeVoucherlimit = reqModel.MaxeVoucherlimit;
        model.GiftperUserlimit = reqModel.GiftperUserlimit;
        model.IsActive = true;
        return model;
    }

    public static TblEvoucher ChangeInActive(this TblEvoucher model, eVoucherRequestModel reqModel)
    {
        model.UserId = reqModel.UserId;
        model.IsActive = reqModel.IsActive.CheckEntityItem<bool>();
        return model;
    }

    public static eVoucherResponseModel Change(this TblEvoucher reqModel)
    {
        eVoucherResponseModel model = new eVoucherResponseModel();
        model.Amount = reqModel.Amount.CheckEntityItem<decimal>();
        return model;
    }

    public static eVoucherResponseModel Changelst(this TblEvoucher reqModel)
    {
        eVoucherResponseModel model = new eVoucherResponseModel();
        model.Title = reqModel.Title;
        model.Description = reqModel.Description;
        model.Amount = reqModel.Amount.CheckEntityItem<decimal>();
        model.UserId = reqModel.UserId;
        model.Quantity = reqModel.Quantity;
        model.PhoneNumber = reqModel.PhoneNumber;
        model.BuyType = reqModel.BuyType.ChangeEnum<EnumBuyType>();
        model.Name = reqModel.Name;
        model.PhoneNumber = reqModel.PhoneNumber;
        model.MaxeVoucherlimit = reqModel.MaxeVoucherlimit.CheckEntityItem<int>();
        model.GiftperUserlimit = reqModel.GiftperUserlimit;
        model.ExpiryDate = reqModel.DateExpire;
        model.IsActive = true;
        return model;
    }

    public static eVoucherResponseModel ChangelstModel(this TblPurchasehistory reqModel)
    {
        eVoucherResponseModel model = new eVoucherResponseModel();
        model.Title = reqModel.Title;
        model.Description = reqModel.Description;
        model.Amount = reqModel.Amount.CheckEntityItem<decimal>();
        model.UserId = reqModel.UserId;
        model.Quantity = reqModel.Quantity;
        model.PhoneNumber = reqModel.PhoneNumber;
        model.BuyType = reqModel.BuyType.ChangeEnum<EnumBuyType>();
        model.Name = reqModel.Name;
        model.PhoneNumber = reqModel.PhoneNumber;
        model.MaxeVoucherlimit = reqModel.MaxeVoucherlimit.CheckEntityItem<int>();
        model.GiftperUserlimit = reqModel.GiftperUserlimit;
        model.ExpiryDate = reqModel.ExpiryDate;
        model.IsActive = reqModel.IsActive.CheckEntityItem<bool>();
        return model;
    }

    public static QRGenerateResponseModel Changelst(this TblPurchasehistory reqModel)
    {
        QRGenerateResponseModel model = new QRGenerateResponseModel();
        if(reqModel.PromoCode != null)
        {
            model.PromoCode = reqModel.PromoCode;
        }
        if(reqModel.Base64ForQr != null)
        {
            model.Base64ForQR = reqModel.Base64ForQr;
        }
        if(reqModel.IsUsed != null)
        {
            model.IsUsed = reqModel.IsUsed.CheckEntityItem<bool>();
        }
        return model;
    }


    public static T CheckEntityItem<T>(this object obj)
    {
        T res = default(T);
        try
        {
            if (obj != null && !string.IsNullOrEmpty(obj.ToString()) && obj is string)
                res = (T)Convert.ChangeType(obj.ToString().Trim(), typeof(T));
            else if (obj != null && !string.IsNullOrEmpty(obj.ToString()))
                res = (T)Convert.ChangeType(obj, typeof(T));
        }
        catch (Exception ex)
        {
            // string message = ex;
        }

        return res;
    }

    public static T ChangeEnum<T>(this string l_Value)
    {
        return (T)Enum.Parse(typeof(T), l_Value, true);
    }
}
