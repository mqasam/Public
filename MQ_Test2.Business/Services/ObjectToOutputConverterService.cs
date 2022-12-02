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
                fsm_review_date = inputData.SENProvisionDetails.FirstOrDefault().ReviewDate.ToString(),
                ethnicity_code = inputData.Ethnicity,
                service_child = bool.Parse(inputData.ServiceChild),
                ever_in_care = inputData.IsLookedAfterorAdoptedFromCare.ToString(),
                enrolment_status = inputData.EnrolementStatus.ToString()
            };
            return outputData;

        }
    }
}
