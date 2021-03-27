using System;
using System.Collections.Generic;
using System.Text;

namespace CBDataLibrary.DTOs
{
    public class LanguageDetailDTO
    {
        public int LanguageUsageId { get; set; }
        public string TypeCode { get; set; }
        public string LanguageCode { get; set; }
        public object LevelOfLanguage { get; set; }
        public string Description { get; set; }
    }
}
