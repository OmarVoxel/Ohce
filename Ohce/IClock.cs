using System;

namespace Ohce
{
    public interface IClock
    {
        public TimeSpan TimeSpan { get; }
    }
}