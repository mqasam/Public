using MQ_Test2.Business.Models;

namespace MQ_Test2.Tests
{
    internal class YearGroupService_CreateSourceIdTests : Tests
    {
        private DateTime _dateOfEntry;
        private int _currentSchoolYear;

        [Test]
        public void CreateSourceId_WhenDobProvided_ExpectSuccess()
        {
            Stub();

            Act();

            Assert.Pass();
        }

        private void Stub()
        {
            _dateOfEntry = DateTime.Parse("01/09/2010");
            _currentSchoolYear = 7;

        }

        private string Act()
        {
            return YearGroupService.CreateSourceId(_dateOfEntry, _currentSchoolYear);
        }
    }
}
