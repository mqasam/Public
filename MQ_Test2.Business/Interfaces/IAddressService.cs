﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQ_Test2.Business.Interfaces
{
    public interface IAddressService
    {
        string CreateAddressLine1(string number, string street);

        string CreateTownCity(string town, string city);
        string CreateCounty(string county);
        string CreateCountry(string country);
        string CreatePostcode(string postcode);
    }
}
