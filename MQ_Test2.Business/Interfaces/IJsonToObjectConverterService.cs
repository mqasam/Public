using MQ_Test2.Business.Models;

namespace MQ_Test2.Business.Interfaces
{
    public interface IJsonToObjectConverterService
    {
        MisInputData Convert(string filePath);
    }
}
