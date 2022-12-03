using MQ_Test2.Business.Models;

namespace MQ_Test2.Tests
{
    internal class AddressService_CreateCountyTests : Tests
    {
        private string _country;

        [Test]
        public void AddressCountryCreated_WhenCountryProvided_ExpectSuccess()
        {
            Stub();

            var country = Act();

            Assert.IsInstanceOf<string>(country);
            Assert.AreEqual(country, _country);
        }

        private void Stub()
        {
            _country = "PK";
        }

        private string Act()
        {
            return AddressService.CreateCountry(_country);
        }
    }
}
