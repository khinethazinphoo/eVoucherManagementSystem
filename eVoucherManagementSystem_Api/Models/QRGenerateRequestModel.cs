using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eVoucherManagementSystem_Api.Models
{
    public class QRGenerateRequestModel
    {
        public string UserId { get; set; }
        public string PhoneNo { get; set; }
        public string PromoCode { get; set; }
    }
}
