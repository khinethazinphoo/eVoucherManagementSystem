using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace eVoucherManagementSystem_Api.Models
{
    public enum EnumBuyType
    {
        [Description("O")]
        Onlyme = 0,
        [Description("G")]
        Gift = 1
    }

    public enum EnumPaymentMethod
    {
        [Description("V")]
        VISA = 0,
        [Description("C")]
        Cash = 1
    }
}
