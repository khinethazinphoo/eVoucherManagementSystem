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
    public class ListPurchaseHistoryController : ControllerBase
    {

        private readonly ILogger<ListPurchaseHistoryController> _logger;
        private readonly eVoucherBLService l_eVoucherBLService;

        public ListPurchaseHistoryController(ILogger<ListPurchaseHistoryController> logger, evouchermanagementsystemContext db)
        {
            _logger = logger;
            l_eVoucherBLService = new eVoucherBLService();
        }

        [HttpPost]
        public async Task<eVoucherResponseModel> ListPurchaseHistory(eVoucherRequestModel reqModel)
        {
            eVoucherResponseModel model = new eVoucherResponseModel();

            #region Assign Value

            string l_UserId = reqModel.UserId;
          

            #endregion

            model = l_eVoucherBLService.ListPurchaseHistory(new eVoucherRequestModel
            {
                UserId = l_UserId
              
            });
            return await Task.FromResult(model);
        }




    }
}
