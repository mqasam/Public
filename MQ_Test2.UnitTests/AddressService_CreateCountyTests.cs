using MQ_Test2.Business.Models;

namespace MQ_Test2.Tests
{
    internal class AddressService_CreateCountyTests : Tests
    {
        private string _country;

        [Test]
        public void AddressLine1Created_WhenDetailsProvided_ExpectSuccess()
        {
            Stub();

            Act();

            Assert.Pass();
        }

        private void Stub()
        {
            _country = string.Empty;
        }

        private string Act()
        {
            return AddressService.CreateCountry(_country);
        }
    }
}
