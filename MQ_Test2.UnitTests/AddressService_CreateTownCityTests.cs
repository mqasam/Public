using MQ_Test2.Business.Models;

namespace MQ_Test2.Tests
{
    internal class AddressService_CreateTownCityTests : Tests
    {
        private string _town;
        private string _city;
        private string _townCity;

        [Test]
        public void AddressTownCityCreated_WhenTownAndCityProvided_ExpectSuccess()
        {
            Stub();

            var townCity = Act();

            Assert.IsInstanceOf<string>(townCity);
            Assert.AreEqual(townCity, _townCity);
        }

        [Test]
        public void AddressTownCityCreated_WhenOnlyTownProvided_ExpectSuccess()
        {
            Stub();
            _city = string.Empty;  

            var townCity = Act();

            Assert.IsInstanceOf<string>(townCity);
            Assert.AreEqual(townCity, _townCity);
        }

        [Test]
        public void AddressTownCityCreated_WhenOnlyCityProvided_ExpectSuccess()
        {
            Stub();
            _town = string.Empty;

            var townCity = Act();

            Assert.IsInstanceOf<string>(townCity);
            Assert.AreEqual(townCity, _townCity);
        }

        private void Stub()
        {
            _town = "Town";
            _city = "City";
            _townCity = !string.IsNullOrEmpty(_town) && !string.IsNullOrEmpty(_city) ? _town + " " + _city : !string.IsNullOrEmpty(_town) ? _town : !string.IsNullOrEmpty(_city) ? _city : string.Empty;
        }

        private string Act()
        {
            return AddressService.CreateTownCity(_town, _city);
        }
    }
}
