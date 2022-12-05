using MQ_Test2.Business.Models;

namespace MQ_Test2.Business.Interfaces
{
    public interface IObjectToOutputConverterService
    {
        MisOutputData Convert(MisInputData inputData);
    }
}
