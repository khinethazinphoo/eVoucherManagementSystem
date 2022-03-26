using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eVoucherManagementSystem_Api.Models
{
    public class eVoucherResponseModel : SubResponseModel
    {
        public string UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ExpiryDate { get; set; }
        public string Image { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }
        public string Quantity { get; set; }
        public EnumBuyType BuyType { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public int MaxeVoucherlimit { get; set; }
        public string GiftperUserlimit { get; set; }
        public bool IsActive { get; set; }

        public QRGenerateResponseModel QrGenerate { get; set; }
        public List<QRGenerateResponseModel> lstQrGenerate { get; set; }
        public List<eVoucherResponseModel> lstModel { get; set; }
    }
}
