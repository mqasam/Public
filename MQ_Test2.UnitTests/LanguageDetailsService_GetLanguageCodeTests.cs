using MQ_Test2.Business.Models;

namespace MQ_Test2.Tests
{
    internal class LanguageDetailsService_GetLanguageCodeTests : Tests
    {
        private string _languageCode;

        [Test]
        public void GetLanguageCodeCreated_WhenDetailsProvided_ExpectSuccess()
        {
            Stub();

            var languageCode = Act();

            Assert.IsInstanceOf<string>(languageCode);
            Assert.AreEqual(_languageCode, languageCode);
        }

        private void Stub()
        {
            _languageCode = "PK";
        }

        private string Act()
        {
            return LanguageDetailsService.GetLanguageCode(_languageCode);
        }
    }
}
