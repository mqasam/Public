
namespace MQ_Test2.Tests
{
    internal class SENProvisionDetailsService_CreateProvisionTypeCodeTests : Tests
    {
        private string _provisionTypeCode;


        [Test]
        public void ProvisionTypeCodeCreated_WhenDetailsProvided_ExpectSuccess()
        {
            Stub();

            var provisionTypeCode = Act();

            Assert.IsInstanceOf<string>(provisionTypeCode);
            Assert.AreEqual(_provisionTypeCode, provisionTypeCode);
        }

        private void Stub()
        {
            _provisionTypeCode = "M";
        }

        private string Act()
        {
            return SENProvisionDetailsService.CreateProvisionTypeCode(_provisionTypeCode);
        }
    }
}
