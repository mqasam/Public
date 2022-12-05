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

            var isServiceChild = Act();

            Assert.IsInstanceOf<bool>(isServiceChild);
            Assert.AreEqual(false, isServiceChild);
        }

        [Test]
        public void IsChildServiceConverted_WhenChildServiceEqualsY_ExpectSuccess()
        {
            _isServiceChild = "Y";

            var isServiceChild = Act();

            Assert.IsInstanceOf<bool>(isServiceChild);
            Assert.AreEqual(true, isServiceChild);
        }

        [Test]
        public void IsChildServiceConverted_WhenChildServiceNotProvided_ExpectSuccess()
        {
            _isServiceChild = String.Empty;

            var isServiceChild = Act();

            Assert.IsInstanceOf<bool>(isServiceChild);
            Assert.AreEqual(false, isServiceChild);
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
