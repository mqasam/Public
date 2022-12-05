using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQ_Test2.Business.Interfaces
{
    public interface ISENProvisionDetailsService
    {
        DateTime? CreateReviewDate(DateTime? reviewDate);
        string CreateProvisionTypeCode(string provisionTypeCode);

    }
}
