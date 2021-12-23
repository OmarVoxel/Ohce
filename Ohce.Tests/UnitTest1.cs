using System;
using Xunit;
using FluentAssertions;

namespace Ohce.Tests
{

    public class UnitTest1
    {
        [Fact]
        public void ReturnBuenasTardesToName()
        {
            Echo echo = new Echo("Omar", new FakeClock(new TimeSpan(18,0,0)));
            echo.Answer().Should().Be("¡Buenas tardes Omar!");
        }
        
        [Fact]
        public void ReturnBuenasNochesToNameAt9Pm()
        {
            FakeClock fakeClock = new FakeClock(new TimeSpan(21,0,0));
            Echo echo = new Echo("Omar", fakeClock);
            echo.Answer().Should().Be("¡Buenas noches Omar!");
        }
        
        [Fact]
        public void ReturnBuenasDiasToNameAt6Am()
        {
            FakeClock fakeClock = new FakeClock(new TimeSpan(6,0,0));
            Echo echo = new Echo("Omar", fakeClock);
            echo.Answer().Should().Be("¡Buenas dias Omar!");
        }
        
        [Fact]
        public void ReturnReverseOfAWord()
        {
            FakeClock fakeClock = new FakeClock(new TimeSpan(6,0,0));
            Echo echo = new Echo("Omar", fakeClock);
            echo.Reply("hola").Should().Be("aloh");
        }
        
        [Fact]
        public void ReturnReverseOfAWordAndBonitaPalabraIfTheWordIsPalindrome()
        {
            FakeClock fakeClock = new FakeClock(new TimeSpan(6,0,0));
            Echo echo = new Echo("Omar", fakeClock);
            echo.Reply("ana").Should().Be("ana\n¡Bonita palabra!");
        }
        
        [Fact]
        public void ReturAdiosToNameWhenStopIsIntroduced()
        {
            FakeClock fakeClock = new FakeClock(new TimeSpan(6,0,0));
            Echo echo = new Echo("Omar", fakeClock);    
            echo.Reply("Stop!").Should().Be("Adios Omar");
        }
    }
}