using System;

namespace MQ_Test2.Business.Interfaces
{
    public interface IYearGoupService
    {
        string CreateSourceId(DateTime dateOfEntry, int currentSchoolYear);
    }
}
