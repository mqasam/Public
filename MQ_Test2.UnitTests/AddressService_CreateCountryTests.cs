
namespace MQ_Test2.Tests
{
    internal class AddressService_CreateCountryTests : Tests
    {
        private string _country;

        [Test]
        public void AddressCountyCreated_WhenCountyProvided_ExpectSuccess()
        {
            Stub();

            var county = Act();

            Assert.IsInstanceOf<string>(county);
            Assert.AreEqual(county, _country);
        }

        private void Stub()
        {
            _country = "WM";
        }

        private string Act()
        {
            return AddressService.CreateCountry(_country);
        }
    }
}
