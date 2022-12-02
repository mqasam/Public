
namespace MQ_Test2.Tests
{
    public class Tests
    {
        protected Tests()
        {
            JsonToObjectConverterService = new JsonToObjectConverterService();
            ObjectToOutputConverterService = new ObjectToOutputConverterService();
            AddressService = new AddressService();
        }
        protected IJsonToObjectConverterService JsonToObjectConverterService { get; }
        protected IObjectToOutputConverterService ObjectToOutputConverterService { get; }
        protected IAddressService AddressService { get; }
    }
}