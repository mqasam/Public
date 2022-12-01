using MQ_Test2.Business.Models;

namespace MQ_Test2.Tests
{
    internal class JsonObjectConverterServiceTests : Tests
    {
        private string _filePath;

        [Test]
        public void Test1()
        {
            Stub();

            Act();

            Assert.Pass();
        }

        private void Stub()
        {
            _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\input_mis_data.json"); 
        }

        private MisInputData Act()
        {
            return JsonObjectConverterService.ConvertObjects(_filePath);
        }
    }
}
