using eVoucherManagementSystem_Api.BusinessLogic;
using eVoucherManagementSystem_Api.Entities;
using eVoucherManagementSystem_Api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eVoucherManagementSystem_Api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class EditeVoucherController : ControllerBase
    {
      
        private readonly ILogger<EditeVoucherController> _logger;
        private readonly evouchermanagementsystemContext _db;
        private readonly eVoucherBLService l_eVoucherBLService;

        public EditeVoucherController(ILogger<EditeVoucherController> logger, evouchermanagementsystemContext db)
        {
            _logger = logger;
            _db = db;
            l_eVoucherBLService = new eVoucherBLService();
        }

        [HttpPost]
        public async Task<eVoucherResponseModel> EditeVoucher(eVoucherRequestModel reqModel)
        {
            eVoucherResponseModel model = new eVoucherResponseModel();

            #region Assign Value 

            string l_eVoucherId = reqModel.eVoucherId;
            string l_UserId = reqModel.UserId;
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

            #endregion

            model = l_eVoucherBLService.EditeVoucher(new eVoucherRequestModel
            {
                eVoucherId = l_eVoucherId,
                Title = l_Title,
                Description = l_Description,
                ExpiryDate = l_ExpiryDate,
                Amount = l_Amount,
                UserId = l_UserId,
                Quantity = l_Quantity,
                BuyType = l_BuyType,
                Name = l_Name,
                PhoneNumber = l_PhoneNo,
                MaxeVoucherlimit = l_MaxVoucherlimit,
                GiftperUserlimit = l_GiftPerUserlimit
            }) ;
            return await Task.FromResult(model);
        }

      


    }
}
