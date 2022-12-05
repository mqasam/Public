using MQ_Test2.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
