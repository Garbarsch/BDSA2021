using System;
using System.IO;
using Xunit;

namespace Lecture01.Tests
{
    public class ProgramTest
    {
        [Fact]
        public void Main_print_Hello_world()
        {
        var writer = new StringWriter();
    Console.SetOut(writer);
    Program.Main(new string[0]);

    var output = writer.GetStringBuilder().ToString();
    Assert.Equal("Hello World!", output);

        }
    }
}
