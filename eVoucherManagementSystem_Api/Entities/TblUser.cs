using System;
using System.Collections.Generic;

#nullable disable

namespace eVoucherManagementSystem_Api.Entities
{
    public partial class TblUser
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
    }
}
