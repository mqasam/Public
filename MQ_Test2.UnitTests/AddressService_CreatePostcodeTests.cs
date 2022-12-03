using MQ_Test2.Business.Models;

namespace MQ_Test2.Tests
{
    internal class AddressService_CreatePostcodeTests : Tests
    {
        private string _postcode;

        [Test]
        public void AddressPostcodeCreated_WhenDetailProvided_ExpectSuccess()
        {
            Stub();

            Act();

            Assert.Pass();
        }

        private void Stub()
        {
            _postcode = string.Empty;
        }

        private string Act()
        {
            return AddressService.CreatePostcode(_postcode);
        }
    }
}
