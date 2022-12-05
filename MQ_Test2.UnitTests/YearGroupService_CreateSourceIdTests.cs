using MQ_Test2.Business.Models;

namespace MQ_Test2.Tests
{
    internal class YearGroupService_CreateSourceIdTests : Tests
    {
        private DateTime _dob;

        [Test]
        public void CreateSourceId_WhenDobProvided_ExpectSuccess()
        {
            Stub();

            Act();

            Assert.Pass();
        }

        private void Stub()
        {
            _dob = DateTime.Now;
        }

        private string Act()
        {
            return YearGroupService.CreateSourceId(_dob);
        }
    }
}
