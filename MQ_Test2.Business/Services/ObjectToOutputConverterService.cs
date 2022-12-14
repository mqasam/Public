using MQ_Test2.Business.Interfaces;
using MQ_Test2.Business.Models;
using System;
using System.Linq;

namespace MQ_Test2.Business.Services
{
    public class ObjectToOutputConverterService : IObjectToOutputConverterService
    {
        private IAddressService _addressService;
        private ISENProvisionDetailsService _senProvisionDetailsService;
        private IServiceChildService _serviceChildService;
        private ILanguageDetailsService _languageDetailsService;
        private IEthnicityMapperService _ethnicityMapperService;
        private IYearGoupService _yearGoupService;

        public ObjectToOutputConverterService(IAddressService addressService, 
            ISENProvisionDetailsService senProvisionDetailsService, 
            IServiceChildService serviceChildService, 
            ILanguageDetailsService languageDetailsService, 
            IEthnicityMapperService ethnicityMapperService, 
            IYearGoupService yearGoupService)
        {
            _addressService = addressService;
            _senProvisionDetailsService = senProvisionDetailsService;
            _serviceChildService = serviceChildService;
            _languageDetailsService = languageDetailsService;
            _ethnicityMapperService = ethnicityMapperService;
            _yearGoupService = yearGoupService;
        }

        public MisOutputData Convert(MisInputData inputData)
        {
            MisOutputData outputData = new MisOutputData
            {
                source_id = inputData.LearnerId.ToString(),
                pupil_admission_number = inputData.LearnerCode,
                first_name = inputData.Forename,
                legal_first_name = inputData.LegalForename,
                middle_name = inputData.MiddleName,
                last_name = inputData.Surname,
                legal_last_name = inputData.LegalSurname,
                former_last_name = inputData.FormerSurname,
                gender = inputData.Gender,
                year_code = inputData.Year,
                dob = DateTime.Parse(inputData.DateOfBirth).ToString("dd/MM/yyyy HH:mm:ss"),
                upn = inputData.UPN,
                former_upn = inputData.FormerUPN,
                uln = inputData.ULN,
                is_eal = inputData.EAL,
                ethnicity_code = inputData.Ethnicity,
                enrolment_status = inputData.EnrolementStatus.ToString(),
                start_date = DateTime.Parse(inputData.DateOfEntry).ToString("dd/MM/yyyy HH:mm:ss"),
                ever_in_care = inputData.IsLookedAfterorAdoptedFromCare,
                looked_after = inputData.IsLookedAfterorAdoptedFromCare != null ? true : false, // had a few ways of determining this including using contact details to check for priority 1 and if that contact has parental responsibilities but would need thinking about if the person was fostered then the foster mother/father would have parental responsibilities (would be worth bringing this up when it came to it to see best way of approaching this)
            };

            //for this example will only pass in first as we know there is only one but can easily be adapted to take in a list and make modifications to service
            //parsed items can be changed in the input class too but for this example will just parse the strings
            outputData.address_line_1 = _addressService.CreateAddressLine1(inputData.AddressDetails.FirstOrDefault().Number, inputData.AddressDetails.FirstOrDefault().Street);
            outputData.town_city = _addressService.CreateTownCity(inputData.AddressDetails.FirstOrDefault().Town, "");
            outputData.county = _addressService.CreateCounty(inputData.AddressDetails.FirstOrDefault().County);
            outputData.country = _addressService.CreateCountry(inputData.AddressDetails.FirstOrDefault().Country);
            outputData.postcode = _addressService.CreatePostcode(inputData.AddressDetails.FirstOrDefault().PostCode);

            outputData.sen_category = _senProvisionDetailsService.CreateProvisionTypeCode(inputData.SENProvisionDetails.FirstOrDefault().ProvisionTypeCode);
            outputData.fsm_review_date = _senProvisionDetailsService.CreateReviewDate(inputData.SENProvisionDetails.FirstOrDefault().ReviewDate);

            outputData.service_child = _serviceChildService.ConvertIsServiceChild(inputData.ServiceChild);

            outputData.first_language_code = _languageDetailsService.GetLanguageCode(inputData.LanguageDetails.FirstOrDefault().LanguageCode);

            var ethnicityCode = _ethnicityMapperService.ConvertToEthnicityCode(inputData.Ethnicity);
            outputData.nationalities = ethnicityCode;
            outputData.country_of_birth = ethnicityCode;

            outputData.year_group_source_id = _yearGoupService.CreateSourceId(DateTime.Parse(inputData.DateOfEntry), int.Parse(inputData.Year));

            return outputData;

        }
    }
}
