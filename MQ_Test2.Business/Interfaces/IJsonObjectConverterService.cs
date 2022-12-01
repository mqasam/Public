using MQ_Test2.Business.Models;

namespace MQ_Test2.Business.Interfaces
{
    public interface IJsonObjectConverterService
    {
        MisInputData ConvertObjects(string filePath);
    }
}
