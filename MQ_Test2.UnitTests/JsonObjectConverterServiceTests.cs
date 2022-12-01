using MQ_Test2.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQ_Test2.Tests
{
    internal class JsonObjectConverterServiceTests : Tests
    {
        private string _filePath;

        [Test]
        public void Test1()
        {
            Stub();

            Act();

            Assert.Pass();
        }

        private void Stub()
        {
            _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\input_mis_data.json"); 
        }

        private MisInputData Act()
        {
            return JsonObjectConverterService.ConvertObjects(_filePath);
        }
    }
}
