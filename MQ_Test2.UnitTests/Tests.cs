
namespace MQ_Test2.Tests
{
    public class Tests
    {
        protected Tests()
        {
            JsonToObjectConverterService = new JsonToObjectConverterService();
            AddressService = new AddressService();
            ObjectToOutputConverterService = new ObjectToOutputConverterService(AddressService);
        }
        protected IJsonToObjectConverterService JsonToObjectConverterService { get; }
        protected IObjectToOutputConverterService ObjectToOutputConverterService { get; }
        protected IAddressService AddressService { get; }
    }
}