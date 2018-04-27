using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RabbitPRC;

namespace Tests
{
    [TestFixture]
    public class MessageClientTest
    {
        [Test]
        public void Send()
        {
            MessageClient client = new MessageClient();
            client.Call("sdfsdf");
        }
    }
}
