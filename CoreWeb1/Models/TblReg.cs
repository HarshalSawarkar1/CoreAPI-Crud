using System;
using System.Collections.Generic;

namespace CoreWeb1.Models
{
    public partial class TblReg
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Age { get; set; }
        public string Address { get; set; }
        public string Pincode { get; set; }
        public string City { get; set; }
        public string Password { get; set; }
    }
}
