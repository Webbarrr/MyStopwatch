using System;

namespace MyStopwatch
{
    public class Stopwatch
    {
        private TimeSpan _duration;
        private DateTime _start;

        public Stopwatch()
        {
            ZeroStart();
        }

        public void Start()
        {
            if (_start != DateTime.MinValue)
                throw new InvalidOperationException("The stopwatch has already been started.");

            _start = DateTime.Now;
        }

        public TimeSpan Stop()
        {
            if (_start == DateTime.MinValue)
                throw new InvalidOperationException("The stopwatch has not been started.");

            _duration = DateTime.Now - _start;
            ZeroStart();
            return _duration;
        }

        private void ZeroStart()
        {
            _start = DateTime.MinValue;
        }
    }
}
