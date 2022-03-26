using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eVoucherManagementSystem_Api.Models
{
    public class CardInfoModel
    {
        public string CardNumber { get; set; }
        public string CardholderName { get; set; }
        public string CVCcode { get; set; }
        public string ExpirationDate { get; set; }
    }
}
