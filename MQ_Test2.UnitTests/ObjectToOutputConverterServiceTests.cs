
namespace MQ_Test2.Tests
{
    internal class ObjectToOutputConverterServiceTests : Tests
    {
        private MisInputData _request;

        [Test]
        public void ObjectConvertedToCorrectOutput_WhenObjectsProvided_ExpectSuccess()
        {
            Stub();

            var output = Act();

            string jsonOutputData = JsonConvert.SerializeObject(output);
            JObject objectToValidate = JObject.Parse(jsonOutputData);

            Assert.IsInstanceOf<MisOutputData>(output);
            Assert.AreEqual(47, objectToValidate.Count);

        }

        private void Stub()
        {
            _request = Builder.Build<MisInputData>()
                .With(x => x.DateOfEntry, DateTime.Now.Date.ToString())
                .With(x => x.DateOfBirth, DateTime.Now.Date.ToString())
                .With(x => x.Ethnicity, "WBRI")
                .With(x => x.ServiceChild, "N")
                .With(x => x.Year, "7")
                .Create();
        }

        private MisOutputData Act()
        {
            return ObjectToOutputConverterService.Convert(_request);
        }
    }
}
