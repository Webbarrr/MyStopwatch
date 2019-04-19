using System;

namespace MyStopwatch
{
    public class Stopwatch
    {
        private DateTime _startTime;

        public TimeSpan Duration { get; private set; }
        public bool IsRunning { get; private set; }

        public void Start()
        {
            if (IsRunning)
                throw new InvalidOperationException("The stopwatch has already been started.");

            _startTime = DateTime.UtcNow;
            IsRunning = true;
        }

        public void Stop()
        {
            if (!IsRunning)
                throw new InvalidOperationException("The stopwatch has not been started.");

            IsRunning = false;
            Duration = DateTime.UtcNow - _startTime;
        }
    }
}
