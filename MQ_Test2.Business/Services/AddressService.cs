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
            else if (!string.IsNullOrEmpty(number))
            {
                return number;
            }
            else if (!string.IsNullOrEmpty(street))
            {
                return street;
            }

            return string.Empty;
        }

        public string CreateCountry(string country)
        {
            if(!string.IsNullOrEmpty(country))
            {
                return country;
            }

            return string.Empty;
        }

        public string CreateCounty(string county)
        {
            if (!string.IsNullOrEmpty(county))
            {
                return county;
            }

            return string.Empty;
        }

        public string CreatePostcode(string postcode)
        {
            if (!string.IsNullOrEmpty(postcode))
            {
                return postcode;
            }

            return string.Empty;
        }

        public string CreateTownCity(string town, string city)
        {
            if (!string.IsNullOrEmpty(town) && !string.IsNullOrEmpty(city))
            {
                return string.Join(" ", new[] { town, city });
            }
            else if (!string.IsNullOrEmpty(town))
            {
                return town;
            }
            else if (!string.IsNullOrEmpty(city))
            {
                return city;
            }

            return string.Empty;
        }
    }
}
