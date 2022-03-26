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
    public class QRGenerateController : ControllerBase
    {
      
        private readonly ILogger<QRGenerateController> _logger;
        private readonly evouchermanagementsystemContext _db;
        private readonly QRGenerateBLService l_QRGenerateBLService;

        public QRGenerateController(ILogger<QRGenerateController> logger, evouchermanagementsystemContext db)
        {
            _logger = logger;
            _db = db;
            l_QRGenerateBLService = new QRGenerateBLService();
        }

        [HttpPost]
        public async Task<QRGenerateResponseModel> GeteVoucher(QRGenerateRequestModel reqModel)
        {
            QRGenerateResponseModel model = new QRGenerateResponseModel();

            #region Assign Value
            
            string l_UserId = reqModel.UserId;
            string l_PhoneNo = reqModel.PhoneNo;
         
            #endregion

            //model = l_QRGenerateBLService.QRGenerate(new QRGenerateRequestModel
            //{
            //    UserId = l_UserId,
            //    PhoneNo = l_PhoneNo
            //}) ;
            return await Task.FromResult(model);
        }

      


    }
}
