using System;
using System.Collections.Generic;
using System.Text;

namespace CBDataLibrary.Models
{
    public class AddressDetailModel
    {
        public string Country { get; set; }
        public string Type { get; set; }
        public string Flat { get; set; }
        public string Number { get; set; }
        public string Street { get; set; }
        public string Locality { get; set; }
        public string Town { get; set; }
        public string County { get; set; }
        public string PostCode { get; set; }
        public int AddressId { get; set; }
    }
}
