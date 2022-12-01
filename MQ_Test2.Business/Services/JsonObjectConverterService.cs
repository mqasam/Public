using MQ_Test2.Business.Interfaces;
using MQ_Test2.Business.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQ_Test2.Business.Services
{
    public class JsonObjectConverterService : IJsonObjectConverterService
    {
        public MisInputData ConvertObjects(string filePath)
        {
            //Create model for objects
            // deserialize JSON directly from a file
            using (StreamReader file = File.OpenText(filePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                MisInputData misInputData = (MisInputData)serializer.Deserialize(file, typeof(MisInputData));
            }


            throw new NotImplementedException();
        }
    }
}
