﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQ_Test2.Business.Interfaces
{
    public interface IYearGoupService
    {
        string CreateSourceId(DateTime dateOfEntry, int currentSchoolYear);
    }
}
