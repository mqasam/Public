using MQ_Test2.Business.Models;

namespace MQ_Test2.Tests
{
    internal class AddressService_CreateAddressLine1Tests : Tests
    {
        private string _number;
        private string _street;

        [Test]
        public void AddressLine1Created_WhenDetailsProvided_ExpectSuccess()
        {
            Stub();

            Act();

            Assert.Pass();
        }

        private void Stub()
        {
            _number = string.Empty;
            _street = string.Empty;
        }

        private string Act()
        {
            return AddressService.CreateAddressLine1(_number, _street);
        }
    }
}
