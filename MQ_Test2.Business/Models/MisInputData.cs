using System;
using System.Collections.Generic;

namespace MQ_Test2.Business.Models
{
    public class MisInputData
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
        public int? FundedHours { get; set; }
        public int? HoursAtSetting { get; set; }
        public int? UnitContactTime { get; set; }
        public bool SchoolLunchTaken { get; set; }
        public string MealType { get; set; }
        public bool AsylumSeeker { get; set; }
        public string Religion { get; set; }
        public bool EAL { get; set; }
        public bool? IsEconomicCriteria { get; set; }
        public bool? IsHighLevelSENorDisability { get; set; }
        public bool? IsLookedAfterorAdoptedFromCare { get; set; }
        public string PhoneDetails { get; set; }
        public List<AddressDetail> AddressDetails { get; set; }
        public List<ContactDetail> ContactDetails { get; set; }
        public List<SiblingDetail> SiblingDetails { get; set; }
        public List<DisabilityDetail> DisabilityDetails { get; set; }
        public List<LanguageDetail> LanguageDetails { get; set; }
        public List<SENProvisionDetail> SENProvisionDetails { get; set; }
        public bool? SENMajorNeedsDetails { get; set; }

        public class AddressDetail
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

        public class ContactDetail
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

        public class DisabilityDetail
        {
            public int DisabilityId { get; set; }
            public string Disability { get; set; }
            public string DisabilityName { get; set; }
        }

        public class LanguageDetail
        {
            public int LanguageUsageId { get; set; }
            public string TypeCode { get; set; }
            public string LanguageCode { get; set; }
            public string LevelOfLanguage { get; set; }
            public string Description { get; set; }
        }

        public class SENProvisionDetail
        {
            public int ProvisionId { get; set; }
            public string ProvisionTypeCode { get; set; }
            public string StartDate { get; set; }
            public DateTime? ReviewDate { get; set; }
            public DateTime? EndDate { get; set; }
        }

        public class SiblingDetail
        {
            public int LearnerId { get; set; }
            public string LearnerCode { get; set; }
        }


    }
}
