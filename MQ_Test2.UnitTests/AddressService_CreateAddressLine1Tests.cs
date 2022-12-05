
namespace MQ_Test2.Tests
{
    internal class AddressService_CreateAddressLine1Tests : Tests
    {
        private string _number;
        private string _street;
        private string _addressLine1;

        [Test]
        public void AddressLine1Created_WhenDetailsProvided_ExpectSuccess()
        {
            Stub();

            var addressLine1 = Act();

            Assert.IsInstanceOf<string>(addressLine1);
            Assert.AreEqual(_addressLine1, addressLine1);
        }

        private void Stub()
        {
            _number = "10";
            _street = "Test Street";
            _addressLine1 = _number + " " + _street;
        }

        private string Act()
        {
            return AddressService.CreateAddressLine1(_number, _street);
        }
    }
}
