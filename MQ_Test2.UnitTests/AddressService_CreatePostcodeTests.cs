
namespace MQ_Test2.Tests
{
    internal class AddressService_CreatePostcodeTests : Tests
    {
        private string _postcode;

        [Test]
        public void AddressPostcodeCreated_WhenPostcodeProvided_ExpectSuccess()
        {
            Stub();

            var postcode = Act();

            Assert.IsInstanceOf<string>(postcode);
            Assert.AreEqual(postcode, _postcode);
        }

        private void Stub()
        {
            _postcode = "T35 7PC";
        }

        private string Act()
        {
            return AddressService.CreatePostcode(_postcode);
        }
    }
}
