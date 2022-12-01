using MQ_Test2.Business.Interfaces;
using MQ_Test2.Business.Models;
using Newtonsoft.Json;
using System.IO;

namespace MQ_Test2.Business.Services
{
    public class JsonObjectConverterService : IJsonObjectConverterService
    {
        public MisInputData ConvertObjects(string filePath)
        {
            // deserialize JSON directly from a file
            using (StreamReader file = File.OpenText(filePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                MisInputData misInputData = (MisInputData)serializer.Deserialize(file, typeof(MisInputData));
                return misInputData;
            }
        }
    }
}
