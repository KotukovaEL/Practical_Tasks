using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Methods.Tests
{
    public class ReadDoubleTests
    {
        [Fact]
        public void Should_throw_Exception_for_incorrect_read_double()
        {
            var stringValue = "mnlkk";
            Assert.Throws<Exception>(() => Class1.ReadDouble(stringValue));
        }
    }
}
