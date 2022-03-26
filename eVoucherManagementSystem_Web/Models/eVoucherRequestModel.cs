using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eVoucherManagementSystem_Web.Models
{
    public class eVoucherRequestModel
    {
        public string UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ExpiryDate { get; set; }
        public string Image { get; set; }
        public string Amount { get; set; }
        public string PaymentMethod { get; set; }
        public string Quantity { get; set; }
        public string BuyType { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string MaxeVoucherlimit { get; set; }
        public string GiftperUserlimit { get; set; }
        public string IsActive { get; set; }
    }
}
