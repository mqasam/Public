
namespace MQ_Test2.Tests
{
    internal class SENProvisionDetailsService_CreateReviewDateTests : Tests
    {
        private DateTime? _reviewDate;


        [Test]
        public void ReviewDateCreated_WhenDateIsNotNull_ExpectSuccess()
        {
            Stub();

            var reviewDate = Act();

            Assert.IsInstanceOf<DateTime>(reviewDate);
            Assert.AreEqual(_reviewDate, reviewDate);
        }

        [Test]
        public void ReviewDateCreated_WhenDateIsNull_ExpectSuccess()
        {
            _reviewDate = null;

            var reviewDate = Act();

            Assert.IsNull(reviewDate);
            Assert.AreEqual(_reviewDate, reviewDate);
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
