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

        public ObjectToOutputConverterService(IAddressService addressService)
        {
            _addressService = addressService;
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
                start_date = DateTime.Parse(inputData.DateOfEntry)
            };

            outputData.address_line_1 = _addressService.CreateAddressLine1(inputData.AddressDetails.FirstOrDefault().Number, inputData.AddressDetails.FirstOrDefault().Street);
            outputData.town_city = _addressService.CreateTownCity(inputData.AddressDetails.FirstOrDefault().Town, "");
            outputData.county = _addressService.CreateCounty(inputData.AddressDetails.FirstOrDefault().County);
            outputData.country = _addressService.CreateCountry(inputData.AddressDetails.FirstOrDefault().Country);
            outputData.postcode = _addressService.CreatePostcode(inputData.AddressDetails.FirstOrDefault().PostCode);



            return outputData;

        }
    }
}
