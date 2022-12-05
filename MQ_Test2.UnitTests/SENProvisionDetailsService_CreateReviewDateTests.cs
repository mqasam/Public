using MQ_Test2.Business.Models;

namespace MQ_Test2.Tests
{
    internal class SENProvisionDetailsService_CreateReviewDateTests : Tests
    {
        private DateTime? _reviewDate;


        [Test]
        public void ReviewDateCreated_WhenDateIsNotNull_ExpectSuccess()
        {
            Stub();

            Act();

            Assert.Pass();
        }

        [Test]
        public void ReviewDateCreated_WhenDateIsNull_ExpectSuccess()
        {
            _reviewDate = null;

            Act();

            Assert.Pass();
        }

        private void Stub()
        {
            _reviewDate = DateTime.Now;
        }

        private DateTime? Act()
        {
            return SENProvisionDetailsService.CreateReviewDate(_reviewDate);
        }
    }
}
