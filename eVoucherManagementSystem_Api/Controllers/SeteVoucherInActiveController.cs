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
    public class SeteVoucherInActiveController : ControllerBase
    {
      
        private readonly ILogger<SeteVoucherInActiveController> _logger;
        private readonly evouchermanagementsystemContext _db;
        private readonly eVoucherBLService l_eVoucherBLService;

        public SeteVoucherInActiveController(ILogger<SeteVoucherInActiveController> logger, evouchermanagementsystemContext db)
        {
            _logger = logger;
            _db = db;
            l_eVoucherBLService = new eVoucherBLService();
        }

        [HttpPost]
        public async Task<eVoucherResponseModel> SeteVoucherInActive(eVoucherRequestModel reqModel)
        {
            eVoucherResponseModel model = new eVoucherResponseModel();

            #region Assign Value
            
            bool l_IsActive = reqModel.IsActive;//0
            string l_eVoucherId = reqModel.eVoucherId;
            string l_UserId = reqModel.UserId;
            #endregion

            model = l_eVoucherBLService.SetInActiveeVoucher(new eVoucherRequestModel
            {
              IsActive = l_IsActive,
              eVoucherId = l_eVoucherId,
              UserId = l_UserId
            }) ;
            return await Task.FromResult(model);
        }

      


    }
}
