using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eVoucherManagementSystem_Api.Models
{
    public class eVoucherRequestModel
    {
        public string eVoucherId { get; set; }
        public string UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ExpiryDate { get; set; }
        public string Image { get; set; }
        public decimal Amount { get; set; }
        public EnumPaymentMethod PaymentMethod { get; set; }
        public string Quantity { get; set; }
        public EnumBuyType BuyType { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public int MaxeVoucherlimit { get; set; }
        public string GiftperUserlimit { get; set; }
        public bool IsActive { get; set; }
        public string CardNumber { get; set; }
        public string CardholderName { get; set; }
        public string CVCcode { get; set; }
        public string ExpirationDate { get; set; }
        public string PromoCode { get; set; }
        public string Base64ForQR { get; set; }
        public bool IsUsed { get; set; }
    }
}
