using MQ_Test2.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQ_Test2.Business.Services
{
    public class YearGroupService : IYearGoupService
    {
        public string CreateSourceId(DateTime dateOfEntry, int currentSchoolYear)
        {

            var sourceId = string.Empty;
            
            if(dateOfEntry != null && dateOfEntry != DateTime.MinValue && currentSchoolYear > 0)
            {
                var year = dateOfEntry.Year + currentSchoolYear + 1;
                var schoolYear1 = dateOfEntry.Year + currentSchoolYear;
                var schoolYear2 = dateOfEntry.Year + currentSchoolYear + 1;

                var schoolYear1Text = schoolYear1.ToString().Remove(0, 2);
                var schoolYear2Text = schoolYear2.ToString().Remove(0, 2);

                sourceId = $"{year}-{schoolYear1Text}{schoolYear2Text}"; 
            }

            return sourceId;
        }
    }
}
