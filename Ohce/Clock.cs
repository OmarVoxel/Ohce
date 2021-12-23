using System;

namespace Ohce
{
    public class Clock : IClock
    {
        public TimeSpan TimeSpan { get; } = DateTime.Now.TimeOfDay;
    }
}