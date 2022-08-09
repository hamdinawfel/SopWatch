using System;
namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new StopWatch();

            for (int i = 0; i < 2; i++)
            {
                stopwatch.Start();

                Thread.Sleep(1000);

                stopwatch.Stop();

                Console.WriteLine("Duration: " + stopwatch.GetInterval());
                Console.WriteLine("Press Enter to run the StopWatch one more time");
                Console.ReadLine();
            }
        }
    }

    public class StopWatch
    {
        private DateTime _startTime;
        private DateTime _endTime;

        private bool _running = false;
        public void Start()
        {
            if (_running)
                throw new InvalidOperationException("StopWatch is already running!");

            _startTime = DateTime.Now;
            _running = true;

        }

        public void Stop()
        {
            if (!_running)
                throw new InvalidOperationException("StopWatch is not running!");

            _endTime = DateTime.Now;
            _running = false;

        }

        public TimeSpan GetInterval()
        {
            return _endTime - _endTime;
        }

    }
}
