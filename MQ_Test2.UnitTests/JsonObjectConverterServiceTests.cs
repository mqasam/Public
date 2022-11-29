using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQ_Test2.Tests
{
    internal class JsonObjectConverterServiceTests : Tests
    {
        private List<string> _request;

        [Test]
        public void Test1()
        {
            Stub();

            Act();

            Assert.Pass();
        }

        private void Stub()
        {
            _request = new List<string>();
        }

        private List<string> Act()
        {
            return JsonObjectConverterService.ConvertObjects(_request);
        }
    }
}
