using System;
using System.Collections.Generic;
using System.Text;

namespace CBDataLibrary.Models
{
    public class ContactDetailModel
    {
        public int ContactId { get; set; }
        public string ForeName { get; set; }
        public string SurName { get; set; }
        public string Relationship { get; set; }
        public string Description { get; set; }
        public string WrittenCommunication { get; set; }
        public int Priority { get; set; }
        public string ContactPrioritySource { get; set; }
        public string EmergencyContactLevel { get; set; }
        public bool NextOfKin { get; set; }
        public bool AddressDisclosure { get; set; }
        public bool AddressTransferred { get; set; }
        public bool ParentalResponsibility { get; set; }
        public bool FeePayer { get; set; }
        public bool ParentalPortal { get; set; }
        public bool HomeAddressLink { get; set; }
        public bool OtherHomeAddressLink { get; set; }
        public bool SendSMS { get; set; }
        public string Title { get; set; }
        public string Gender { get; set; }

    }
}
