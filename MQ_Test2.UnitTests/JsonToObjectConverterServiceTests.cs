
namespace MQ_Test2.Tests
{
    internal class JsonToObjectConverterServiceTests : Tests
    {
        private string _filePath;

        [Test]
        public void FileFound_WhenPathProvided_ExpectSuccess()
        {
            Stub();

            Assert.That(new FileInfo(_filePath), Does.Exist);
        }

        [Test]
        public void ObjectsReturnedTypeIsCorrect_WhenJsonFileIsProvided_ExpectSuccess()
        {
            Stub();

            var request = Act();

            Assert.IsInstanceOf<MisInputData>(request);
            Assert.That(request, Is.TypeOf<MisInputData>());
        }

        [Test]
        public void ObjectConvertedToCorrectOutput_WhenObjectsProvided_ExpectSuccess()
        {
            Stub();

            var request = Act();

            Assert.IsInstanceOf<MisInputData>(request);
            Assert.That(request, Is.TypeOf<MisInputData>());
        }

        private void Stub()
        {
            _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\input_mis_data.json"); 
        }

        private MisInputData Act()
        {
            return JsonToObjectConverterService.Convert(_filePath);
        }
    }
}
