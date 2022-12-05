
namespace MQ_Test2.Tests
{
    public class Tests
    {
        protected Tests()
        {
            JsonToObjectConverterService = new JsonToObjectConverterService();
            AddressService = new AddressService();
            SENProvisionDetailsService = new SENProvisionDetailsService();
            ServiceChildService = new ServiceChildService();
            LanguageDetailsService = new LanguageDetailsService();
            EthnicityMapperService = new EthnicityMapperService();
            YearGroupService = new YearGroupService();
            ObjectToOutputConverterService = new ObjectToOutputConverterService(AddressService, SENProvisionDetailsService, ServiceChildService, LanguageDetailsService, EthnicityMapperService, YearGroupService);
            Builder = new Fixture();
        }
        protected IJsonToObjectConverterService JsonToObjectConverterService { get; }
        protected IObjectToOutputConverterService ObjectToOutputConverterService { get; }
        protected IAddressService AddressService { get; }
        protected ISENProvisionDetailsService SENProvisionDetailsService { get; }
        protected IServiceChildService ServiceChildService { get; }
        protected ILanguageDetailsService LanguageDetailsService { get; }
        protected IEthnicityMapperService EthnicityMapperService { get; }
        protected IYearGoupService YearGroupService { get; }
        protected IFixture Builder { get; }
    }
}