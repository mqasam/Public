using MQ_Test2.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQ_Test2.Business.Services
{
    public class EthnicityMapperService : IEthnicityMapperService
    {
        public string ConvertToEthnicityCode(string ethnicity)
        {
            //would ideally use an api to pass the ethnity in and get a code back but for this example i will just do a basic converter

            string ethnicityCode = string.Empty;

            if (!string.IsNullOrEmpty(ethnicity))
            {
                switch(ethnicity)
                {
                    case "WBRI":
                        ethnicityCode = "GBR";
                        break;
                    default:
                        ethnicityCode = string.Empty;
                        break;
                }
            }

            return ethnicityCode;
        }
    }
}
