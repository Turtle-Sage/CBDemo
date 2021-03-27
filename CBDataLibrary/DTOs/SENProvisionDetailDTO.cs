using System;
using System.Collections.Generic;
using System.Text;

namespace CBDataLibrary.DTOs
{
    public class SENProvisionDetailDTO
    {
        public int ProvisionId { get; set; }
        public string ProvisionTypeCode { get; set; }
        public string StartDate { get; set; }
        public object ReviewDate { get; set; }
        public object EndDate { get; set; }
    }
}
