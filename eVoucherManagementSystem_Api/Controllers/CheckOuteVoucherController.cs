using eVoucherManagementSystem_Api.BusinessLogic;
using eVoucherManagementSystem_Api.Entities;
using eVoucherManagementSystem_Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eVoucherManagementSystem_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CheckOuteVoucherController : ControllerBase
    {

        private readonly ILogger<CheckOuteVoucherController> _logger;
        private readonly eVoucherBLService l_eVoucherBLService;

        public CheckOuteVoucherController(ILogger<CheckOuteVoucherController> logger)
        {
            _logger = logger;
            l_eVoucherBLService = new eVoucherBLService();
        }

        [HttpPost]
        public async Task<eVoucherResponseModel> CheckOuteVoucher(eVoucherRequestModel reqModel)
        {
            eVoucherResponseModel model = new eVoucherResponseModel();

            #region Assign Value

            string l_Id = reqModel.UserId;
            string l_Title = reqModel.Title;
            string l_Description = reqModel.Description;
            string l_ExpiryDate = reqModel.ExpiryDate;
            decimal l_Amount = reqModel.Amount;
            string l_Quantity = reqModel.Quantity;
            EnumBuyType l_BuyType = reqModel.BuyType;
            string l_Name = reqModel.Name;
            string l_PhoneNo = reqModel.PhoneNumber;
            int l_MaxVoucherlimit = reqModel.MaxeVoucherlimit;
            string l_GiftPerUserlimit = reqModel.GiftperUserlimit;
            EnumPaymentMethod l_PaymentMethod = reqModel.PaymentMethod;
            string l_CardNumber = reqModel.CardNumber;
            string l_CardholderName = reqModel.CardholderName;
            string l_CVCcode = reqModel.CVCcode;
            string l_ExpirationDate = reqModel.ExpirationDate;

            #endregion

            model = l_eVoucherBLService.CheckOuteVoucher(new eVoucherRequestModel
            {
                UserId = l_Id,
                Title = l_Title,
                Description = l_Description,
                ExpiryDate = l_ExpiryDate,
                Amount = l_Amount,
                Quantity = l_Quantity,
                BuyType = l_BuyType,
                Name = l_Name,
                PhoneNumber = l_PhoneNo,
                MaxeVoucherlimit = l_MaxVoucherlimit,
                GiftperUserlimit = l_GiftPerUserlimit,
                PaymentMethod = l_PaymentMethod,
                CardNumber = l_CardNumber,
                CardholderName = l_CardholderName,
                CVCcode = l_CVCcode,
                ExpirationDate = l_ExpirationDate
            });
            return await Task.FromResult(model);
        }




    }
}
