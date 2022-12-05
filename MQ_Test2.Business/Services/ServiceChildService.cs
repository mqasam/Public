using MQ_Test2.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQ_Test2.Business.Services
{
    public class ServiceChildService : IServiceChildService
    {
        public bool ConvertIsServiceChild(string isServiceChild)
        {
            bool serviceChild = false;

            if(!string.IsNullOrEmpty(isServiceChild))
            {
                switch(isServiceChild)
                {
                    case "N": 
                        serviceChild = false;
                        break;
                    case "Y": 
                        serviceChild = true;
                        break;
                    default: 
                        serviceChild = false;
                        break;
                }
            }

            return serviceChild;
        }
    }
}
