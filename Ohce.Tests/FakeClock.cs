using System;

namespace Ohce.Tests
{
    public class FakeClock : IClock
    {
        public TimeSpan TimeSpan { get; }

        public FakeClock(TimeSpan timeSpan)
        {
            TimeSpan = timeSpan;
        }
    }
}