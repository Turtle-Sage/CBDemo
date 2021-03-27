using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Authentication.ExtendedProtection;
using System.Text;

namespace CBDataLibrary.Models
{
    public class LearnerModel
    {
        public int LearnerId { get; set; }
        public int PersonId { get; set; }
        public string LearnerCode { get; set; }
        public string UPN { get; set; }
        public string ULN { get; set; }
        public string Surname { get; set; }
        public string Forename { get; set; }
        public string LegalSurname { get; set; }
        public string LegalForename { get; set; }
        public string DateOfBirth { get; set; }
        public string Year { get; set; }
        public string Course { get; set; }
        public string DateOfEntry { get; set; }
        public string Gender { get; set; }
        public string RegGroup { get; set; }
        public string Ethnicity { get; set; }
        public string EthnicityMappedTo { get; set; }
        public string EthnicitySource { get; set; }
        public string EnrolementStatus { get; set; }
        public string NCYear { get; set; }
        public string Status { get; set; }
        public string AcademicHouse { get; set; }
        public string MiddleName { get; set; }
        public string FormerSurname { get; set; }
        public string EmailAddress { get; set; }
        public string Notes { get; set; }
        public string HomeSalutation { get; set; }
        public string Boarder { get; set; }
        public bool PartTime { get; set; }
        public string FormerUPN { get; set; }
        public bool GAndT { get; set; }
        public bool MedicalFlag { get; set; }
        public string YSSAIndicator { get; set; }
        public string ServiceChild { get; set; }
        public string ServiceChildSource { get; set; }
        public bool TopUpFunding { get; set; }
        public object FundedHours { get; set; }
        public object HoursAtSetting { get; set; }
        public object UnitContactTime { get; set; }
        public bool SchoolLunchTaken { get; set; }
        public string MealType { get; set; }
        public bool AsylumSeeker { get; set; }
        public string Religion { get; set; }
        public bool EAL { get; set; }
        public object IsEconomicCriteria { get; set; }
        public object IsHighLevelSENorDisability { get; set; }
        public object IsLookedAfterorAdoptedFromCare { get; set; }
        public object PhoneDetails { get; set; }
        public List<AddressDetailModel> AddressDetails { get; set; }
        public List<ContactDetailModel> ContactDetails { get; set; }
        public List<SiblingDetailModel> SiblingDetails { get; set; }
        public List<DisabilityDetailModel> DisabilityDetails { get; set; }
        public List<LanguageDetailModel> LanguageDetails { get; set; }
        public List<SENProvisionDetailModel> SENProvisionDetails { get; set; }
        public object SENMajorNeedsDetails { get; set; }
    }
}
