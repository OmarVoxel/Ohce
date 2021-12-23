using System;
using System.Collections.Generic;
using System.Linq;

namespace Ohce
{
    public class Echo
    {
        private readonly string _name;
        private readonly IClock _clock;
        public bool Stopped { get; private set; }  = false;

        public Echo(string name, IClock clock)
        {
            _name = name;
            _clock = clock;
        }

        public string Answer()
        {
            if(TimeBetween(_clock.TimeSpan, 
                new TimeSpan(6, 0, 0), 
                new TimeSpan(12, 0, 0))
            )
                return $"¡Buenas dias {_name}!";
            
            if(TimeBetween(_clock.TimeSpan, 
                new TimeSpan(13, 0, 0), 
                new TimeSpan(20, 0, 0))
            )
                return $"¡Buenas tardes {_name}!";
            
            return TimeBetween(_clock.TimeSpan, 
                new TimeSpan(21, 0, 0), 
                new TimeSpan(5, 0, 0)) ? $"¡Buenas noches {_name}!" : "";
        }
        
        
       private bool TimeBetween(TimeSpan timeSpan, TimeSpan start, TimeSpan end)
        {
            if (start < end)
                return start <= timeSpan && timeSpan <= end;
            return !(end < timeSpan && timeSpan < start);
        }
       
       public string Reply(string word)
       {
           if (word == "Stop!")
           {
               Stopped = true;
               return $"Adios {_name}";
           }

           return word.SequenceEqual(word.Reverse())
               ? $"{new string(word.Reverse().ToArray())}\n¡Bonita palabra!"
               : $"{new string(word.Reverse().ToArray())}";
       }
    }
}