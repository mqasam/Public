using MQ_Test2.Business.Models;

namespace MQ_Test2.Tests
{
    internal class ServiceChildService_ConvertIsServiceChildTests : Tests
    {
        private string _isServiceChild;


        [Test]
        public void IsChildServiceConverted_WhenChildServiceEqualsN_ExpectSuccess()
        {
            Stub();

            Act();

            Assert.Pass();
        }

        [Test]
        public void IsChildServiceConverted_WhenChildServiceEqualsY_ExpectSuccess()
        {
            Stub();

            Act();

            Assert.Pass();
        }

        [Test]
        public void IsChildServiceConverted_WhenChildServiceNotProvided_ExpectSuccess()
        {
            Stub();

            Act();

            Assert.Pass();
        }

        private void Stub()
        {
            _isServiceChild = "N";
        }

        private bool Act()
        {
            return ServiceChildService.ConvertIsServiceChild(_isServiceChild);
        }
    }
}
