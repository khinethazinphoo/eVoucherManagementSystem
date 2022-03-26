using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eVoucherManagementSystem_Api.Models
{
    public class QRGenerateResponseModel : SubResponseModel
    {
        public string Base64ForQR { get; set; }
        public string PhoneNo { get; set; }
        public string PromoCode { get; set; }
        public bool IsUsed { get; set; }
    }
}
