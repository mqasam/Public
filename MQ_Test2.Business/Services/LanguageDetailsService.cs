using MQ_Test2.Business.Interfaces;

namespace MQ_Test2.Business.Services
{
    public class LanguageDetailsService : ILanguageDetailsService
    {
        public string GetLanguageCode(string languageCode)
        {
            return languageCode;
        }
    }
}
