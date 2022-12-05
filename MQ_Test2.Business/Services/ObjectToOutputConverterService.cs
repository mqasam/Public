using MQ_Test2.Business.Interfaces;
using MQ_Test2.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQ_Test2.Business.Services
{
    public class ObjectToOutputConverterService : IObjectToOutputConverterService
    {
        private IAddressService _addressService;
        private ISENProvisionDetailsService _senProvisionDetailsService;
        private IServiceChildService _serviceChildService;
        private ILanguageDetailsService _languageDetailsService;
        private IEthnicityMapperService _ethnicityMapperService;

        public ObjectToOutputConverterService(IAddressService addressService, ISENProvisionDetailsService senProvisionDetailsService, IServiceChildService serviceChildService, ILanguageDetailsService languageDetailsService, IEthnicityMapperService ethnicityMapperService)
        {
            _addressService = addressService;
            _senProvisionDetailsService = senProvisionDetailsService;
            _serviceChildService = serviceChildService;
            _languageDetailsService = languageDetailsService;
            _ethnicityMapperService = ethnicityMapperService;
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
                dob = inputData.DateOfBirth,
                upn = inputData.UPN,
                former_upn = inputData.FormerUPN,
                uln = inputData.ULN,
                is_eal = inputData.EAL,
                ethnicity_code = inputData.Ethnicity,
                enrolment_status = inputData.EnrolementStatus.ToString(),
                start_date = DateTime.Parse(inputData.DateOfEntry),
                ever_in_care = inputData.IsLookedAfterorAdoptedFromCare.GetValueOrDefault(),
                looked_after = inputData.IsLookedAfterorAdoptedFromCare != null ? true : false // had a few ways of determining this including using contact details to check for priority 1 and if that contact has parental responsibilities but would need thinking about if the person was fostered then the foster mother/father would have parental responsibilities (would be worth bringing this up when it came to it to see best way of approaching this)
            };

            //for this example will only pass in first as we know there is only one but can easily be adapted to take in a list and make modifications to service
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

            outputData.ethnicity_code = ethnicityCode;
            outputData.nationalities = ethnicityCode;
            outputData.country_of_birth = ethnicityCode;



            return outputData;

            //https://www.medway.gov.uk/info/200163/apply_for_a_school_place/363/which_year_group_is_my_child_in

        }
    }
}
