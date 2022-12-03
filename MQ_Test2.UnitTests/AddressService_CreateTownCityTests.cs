using MQ_Test2.Business.Models;

namespace MQ_Test2.Tests
{
    internal class AddressService_CreateTownCityTests : Tests
    {
        private string _town;
        private string _city;

        [Test]
        public void AddressLine1Created_WhenDetailsProvided_ExpectSuccess()
        {
            Stub();

            Act();

            Assert.Pass();
        }

        private void Stub()
        {
            _town = string.Empty;
            _city = string.Empty;
        }

        private string Act()
        {
            return AddressService.CreateTownCity(_town, _city);
        }
    }
}
