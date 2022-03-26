using System;
using System.Collections.Generic;

#nullable disable

namespace eVoucherManagementSystem_Api.Entities
{
    public partial class TblPurchasehistory
    {
        public int PurchaseHistoryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ExpiryDate { get; set; }
        public string Image { get; set; }
        public decimal? Amount { get; set; }
        public string PaymentMethod { get; set; }
        public string Quantity { get; set; }
        public string BuyType { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public int? MaxeVoucherlimit { get; set; }
        public string GiftperUserlimit { get; set; }
        public bool? IsActive { get; set; }
        public string PromoCode { get; set; }
        public string UserId { get; set; }
        public string Base64ForQr { get; set; }
        public bool? IsUsed { get; set; }
    }
}
