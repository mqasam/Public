
namespace MQ_Test2.Tests
{
    public class Tests
    {
        protected Tests()
        {
            JsonObjectConverterService = new JsonObjectConverterService();
        }
        protected IJsonObjectConverterService JsonObjectConverterService { get; }

        [SetUp]
        public void Setup()
        {
        }
    }
}