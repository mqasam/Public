using MQ_Test2.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQ_Test2.Business.Services
{
    public class AddressService : IAddressService
    {
        public string CreateAddressLine1(string number, string street)
        {
            if(!string.IsNullOrEmpty(number) && !string.IsNullOrEmpty(street))
            {
                return string.Join(" ", new[] { number, street });
            }

            return string.Empty;
        }

        public string CreateCountry(string country)
        {
            throw new NotImplementedException();
        }

        public string CreateCounty(string county)
        {
            throw new NotImplementedException();
        }

        public string CreatePostcode(string postcode)
        {
            throw new NotImplementedException();
        }

        public string CreateTownCity(string town, string city)
        {
            throw new NotImplementedException();
        }
    }
}
