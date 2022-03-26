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
    public class VerifyPromoCodeController : ControllerBase
    {

        private readonly ILogger<VerifyPromoCodeController> _logger;
        private readonly eVoucherBLService l_eVoucherBLService;

        public VerifyPromoCodeController(ILogger<VerifyPromoCodeController> logger, evouchermanagementsystemContext db)
        {
            _logger = logger;
            l_eVoucherBLService = new eVoucherBLService();
        }

        [HttpPost]
        public async Task<eVoucherResponseModel> VerifyPromoCode(eVoucherRequestModel reqModel)
        {
            eVoucherResponseModel model = new eVoucherResponseModel();

            #region Assign Value

            string l_UserId = reqModel.UserId;
            bool l_IsActive = reqModel.IsActive;//0
            string l_PromoCode = reqModel.PromoCode;
            string l_PhoneNo = reqModel.PhoneNumber;

            #endregion

            model = l_eVoucherBLService.VerifyPromoCode(new eVoucherRequestModel
            {
                UserId = l_UserId,
                IsActive = l_IsActive,
                PromoCode = l_PromoCode,
                PhoneNumber = l_PhoneNo
            });
            return await Task.FromResult(model);
        }




    }
}
