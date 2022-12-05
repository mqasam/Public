using MQ_Test2.Business.Models;

namespace MQ_Test2.Tests
{
    internal class ObjectToOutputConverterServiceTests : Tests
    {
        private MisInputData _request;


        [Test]
        public void ObjectConvertedToCorrectOutput_WhenObjectsProvided_ExpectSuccess()
        {
            Stub();

            Act();

            Assert.Pass();
        }

        private void Stub()
        {
            _request = Builder.Build<MisInputData>().With(x=>x.DateOfEntry, DateTime.Now.ToString()).Create();
        }

        private MisOutputData Act()
        {
            return ObjectToOutputConverterService.Convert(_request);
        }
    }
}
