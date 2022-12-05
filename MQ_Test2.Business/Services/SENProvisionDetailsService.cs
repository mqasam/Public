using MQ_Test2.Business.Interfaces;
using System;

namespace MQ_Test2.Business.Services
{
    public class SENProvisionDetailsService : ISENProvisionDetailsService
    {
        public string CreateProvisionTypeCode(string provisionTypeCode)
        {
            return provisionTypeCode;
        }

        public DateTime? CreateReviewDate(DateTime? reviewDate)
        {
            return reviewDate;
        }
    }
}
