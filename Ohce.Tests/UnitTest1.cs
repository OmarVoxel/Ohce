using Xunit;
using FluentAssertions;

namespace Ohce.Tests
{

    public class UnitTest1
    {
        [Fact]
        public void ReturnBuenasTardesToName()
        {
            Echo echo = new Echo("Omar");
            echo.Answer().Should().Be("¡Buenas tardes Omar!");
        }
    }
}