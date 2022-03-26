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
    public class DetaileVoucherController : ControllerBase
    {
      
        private readonly ILogger<DetaileVoucherController> _logger;
        private readonly evouchermanagementsystemContext _db;
        private readonly eVoucherBLService l_eVoucherBLService;

        public DetaileVoucherController(ILogger<DetaileVoucherController> logger, evouchermanagementsystemContext db)
        {
            _logger = logger;
            _db = db;
            l_eVoucherBLService = new eVoucherBLService();
        }

        [HttpPost]
        public async Task<eVoucherResponseModel> GeteVoucher(eVoucherRequestModel reqModel)
        {
            eVoucherResponseModel model = new eVoucherResponseModel();

            #region Assign Value
            
            string l_Id = reqModel.eVoucherId;
         
            #endregion

            model = l_eVoucherBLService.DetaileVoucher(new eVoucherRequestModel
            {
                eVoucherId = l_Id
            }) ;
            return await Task.FromResult(model);
        }

      


    }
}
