using System;

namespace MQ_Test2.Business.Interfaces
{
    public interface ISENProvisionDetailsService
    {
        DateTime? CreateReviewDate(DateTime? reviewDate);
        string CreateProvisionTypeCode(string provisionTypeCode);

    }
}
