
namespace MQ_Test2.Tests
{
    internal class EthnicityMapperService_ConvertToEthnicityCodeTests : Tests
    {
        private string _ethnicity;
        private string _ethnicityCode;

        [Test]
        public void EthnicityCodeCreated_WhenDetailProvided_ExpectSuccess()
        {
            Stub();

            var ethnicityCode = Act();

            Assert.IsInstanceOf<string>(ethnicityCode);
            Assert.AreEqual(_ethnicityCode, ethnicityCode);
        }

        private void Stub()
        {
            _ethnicity = "WBRI";
            _ethnicityCode = "GBR";
        }

        private string Act()
        {
            return EthnicityMapperService.ConvertToEthnicityCode(_ethnicity);
        }
    }
}
