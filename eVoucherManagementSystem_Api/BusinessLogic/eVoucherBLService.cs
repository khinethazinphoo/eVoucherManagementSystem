using eVoucherManagementSystem_Api.DataAccess;
using eVoucherManagementSystem_Api.Entities;
using eVoucherManagementSystem_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eVoucherManagementSystem_Api.BusinessLogic
{
    public class eVoucherBLService
    {
        private readonly eVoucherDAService l_eVoucherDAService;
        private readonly QRGenerateBLService l_QRGenerateBLService;
        public eVoucherBLService()
        {
            l_eVoucherDAService = new eVoucherDAService();
            l_QRGenerateBLService = new QRGenerateBLService();
        }

        public eVoucherResponseModel CreateeVoucher(eVoucherRequestModel reqModel)
        {
            eVoucherResponseModel model = new eVoucherResponseModel();

            if (reqModel.MaxeVoucherlimit.CheckEntityItem<int>() >= 4)
            {
                model.RespCode = "999";
                model.RespDesp = "You can't buy greater than over limit";
                goto Result;
            }

            if (reqModel.GiftperUserlimit.CheckEntityItem<int>() >= 3)
            {
                model.RespCode = "999";
                model.RespDesp = "You can't  buy greater than 3 users";
                goto Result;
            }

            l_eVoucherDAService.InserteVoucher(reqModel);

            model.RespCode = "000";
            model.RespDesp = "Create Successfully!!";

        Result:
            return model;
        }

        public eVoucherResponseModel EditeVoucher(eVoucherRequestModel reqModel)
        {
            eVoucherResponseModel model = new eVoucherResponseModel();
            l_eVoucherDAService.EditeVoucher(reqModel);
            model.RespCode = "000";
            model.RespDesp = "Update Successfully!!";
            return model;
        }

        public eVoucherResponseModel GeteVoucher(eVoucherRequestModel reqModel)
        {
            eVoucherResponseModel model = new eVoucherResponseModel();
            List<eVoucherResponseModel> lstModel = new List<eVoucherResponseModel>();
            var lst = l_eVoucherDAService.GeteVoucher(reqModel.UserId);

            if (lst != null && lst.Count > 0)
            {
                lstModel = lst.AsEnumerable().Select(dr => dr.Changelst()).ToList();
                model.lstModel = lstModel;
            }

            //List<eVoucherResponseModel> lst = new List<eVoucherResponseModel>();
            model.RespCode = "000";
            model.RespDesp = "Success";
            return model;
        }

        public eVoucherResponseModel DetaileVoucher(eVoucherRequestModel reqModel)
        {
            eVoucherResponseModel model = new eVoucherResponseModel();
            TblEvoucher item = l_eVoucherDAService.DetaileVoucher(reqModel.eVoucherId.CheckEntityItem<int>());

            model.RespCode = "000";
            model.RespDesp = "Success";
            return model;
        }

        public eVoucherResponseModel SetInActiveeVoucher(eVoucherRequestModel reqModel)
        {
            eVoucherResponseModel model = new eVoucherResponseModel();
            l_eVoucherDAService.SetInActiveeVoucher(reqModel);

            model.RespCode = "000";
            model.RespDesp = "Success";
            return model;
        }

        public eVoucherResponseModel CheckOuteVoucher(eVoucherRequestModel reqModel)
        {
            eVoucherResponseModel model = new eVoucherResponseModel();
            CardInfoModel l_CardInfo = new CardInfoModel();


            if (reqModel.PaymentMethod == EnumPaymentMethod.VISA)
            {
                if (reqModel.CardNumber != "123456789")
                {
                    model.RespCode = "999";
                    model.RespDesp = "Invalid CardNumber";
                    goto Result;
                }
                if (reqModel.CardholderName != "Mg Mg")
                {
                    model.RespCode = "999";
                    model.RespDesp = "Invalid Card Name";
                    goto Result;
                }
                if (reqModel.CVCcode != "123")
                {
                    model.RespCode = "999";
                    model.RespDesp = "Invalid CVCcode";
                    goto Result;
                }
                if (reqModel.ExpirationDate != "05/23")
                {
                    model.RespCode = "999";
                    model.RespDesp = "Invalid Card Name";
                    goto Result;
                }

                if (reqModel.CardNumber == "123456789" &&
                    reqModel.CardholderName == "Mg Mg" &&
                   reqModel.CVCcode == "123" &&
                   reqModel.ExpirationDate == "05/23")
                {
                    double l_Amt = reqModel.Amount.CheckEntityItem<double>();
                    reqModel.Amount = (l_Amt - (l_Amt * 0.1)).CheckEntityItem<decimal>();
                    QRGenerateRequestModel l_QrGenerate = new QRGenerateRequestModel();

                    l_QrGenerate.PromoCode = RandomString(5, 6);
                    //var promocode = l_QrGenerate.PromoCode;
                    //TblPurchasehistory item = l_eVoucherDAService.GetPromoCode(reqModel.UserId, l_QrGenerate.PromoCode);
                    //if(promocode == item.PromoCode)
                    //{
                    //    l_QrGenerate.PromoCode = RandomString(5, 6);
                    //}
                    //if(item.PromoCode == null)
                    //{
                        model.QrGenerate = l_QRGenerateBLService.QRGenerate(l_QrGenerate);
                        reqModel.PromoCode = l_QrGenerate.PromoCode;
                        reqModel.Base64ForQR = model.QrGenerate.Base64ForQR;
                        var result = l_eVoucherDAService.CheckOuteVoucher(reqModel);
                   // }
                }
            }

            model.RespCode = "000";
            model.RespDesp = "Success";
        Result:
            return model;
        }

        public eVoucherResponseModel VerifyPromoCode(eVoucherRequestModel reqModel)
        {
            eVoucherResponseModel model = new eVoucherResponseModel();
            var result = l_eVoucherDAService.VerifyPromoCode(reqModel);
            if (result)
            {
                model.RespCode = "000";
                model.RespDesp = "Verify Promo Code";
                goto Result;
            }
            else
            {
                model.RespCode = "999";
                model.RespDesp = "Already Used this Promo Code";
                goto Result;
            }
        Result:
            return model;
        }

        public eVoucherResponseModel ListPurchaseHistory(eVoucherRequestModel reqModel)
        {
            eVoucherResponseModel model = new eVoucherResponseModel();
            List<eVoucherResponseModel> lstModel = new List<eVoucherResponseModel>();
            List<QRGenerateResponseModel> lstQR = new List<QRGenerateResponseModel>();
            var lst = l_eVoucherDAService.ListPurchaseHistory(reqModel.UserId);

            if (lst != null && lst.Count > 0)
            {
                lstQR = lst.AsEnumerable().Select(dr => dr.Changelst()).ToList();
                lstModel = lst.AsEnumerable().Select(dr => dr.ChangelstModel()).ToList();
                model.lstQrGenerate = lstQR;
                model.lstModel = lstModel;
            }

            model.RespCode = "000";
            model.RespDesp = "Success";
            return model;
        }

        private static Random random = new Random();
        public static string RandomString(int charlength, int digitlength)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string digit = "0123456789";


            string ran = new string(Enumerable.Repeat(chars, charlength)
              .Select(s => s[random.Next(s.Length)]).ToArray());
            string dig = new string(Enumerable.Repeat(digit, digitlength)
              .Select(s => s[random.Next(s.Length)]).ToArray());
            var result = ran + dig;
            //var aa = result.ToArray();

            return result;
        }

    }

}
