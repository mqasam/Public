using MQ_Test2.Business.Models;

namespace MQ_Test2.Tests
{
    internal class SENProvisionDetailsService_CreateProvisionTypeCodeTests : Tests
    {
        private string _provisionTypeCode;


        [Test]
        public void ProvisionTypeCodeCreated_WhenDetailsProvided_ExpectSuccess()
        {
            Stub();

            Act();

            Assert.Pass();
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
