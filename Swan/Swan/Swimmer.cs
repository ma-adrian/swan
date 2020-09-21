using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swan
{
    public class Swimmer
    {
        public readonly int id;
        public readonly string first_name;
        public readonly string last_name;
        public readonly DateTime date_of_birth;
        public readonly string email;
        public readonly string home_number;
        public readonly string mobile_number;
        public readonly string street;
        public readonly string city;
        public readonly string zip;
        public readonly string emergency_contact;
        public readonly string emergency_number;
        public readonly string comments;

        public TimeSpan lastLap = TimeSpan.Zero;
        public TimeSpan splitTime = TimeSpan.Zero;
        public List<Tuple<TimeSpan, TimeSpan>> allLaps = new List<Tuple<TimeSpan, TimeSpan>>();
        public DateTime startDate = DateTime.MinValue;
        private System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
        private TimeSpan lastElapsed = TimeSpan.Zero;

        public Swimmer(int _id, List<string> swimmerData, DateTime dob)
        {
            id = _id;
            first_name = swimmerData[0];
            last_name = swimmerData[1];
            date_of_birth = dob;
            email = swimmerData[2];
            home_number = swimmerData[3];
            mobile_number = swimmerData[4];
            street = swimmerData[5];
            city = swimmerData[6];
            zip = swimmerData[7];
            emergency_contact = swimmerData[8];
            emergency_number = swimmerData[9];
            comments = swimmerData[10];
        }

        public TimeSpan elapsedMillisecondStopwatch()
        {
            return watch.Elapsed;
        }

        public bool isRunningStopwatch()
        {
            return watch.IsRunning;
        }

        public void startStopwatch()
        {
            watch.Start();
            startDate = DateTime.Now;
        }

        public void stopStopwatch()
        {
            watch.Stop();
        }

        public void lapStopwatch()
        {
            TimeSpan ts = watch.Elapsed;
            splitTime = ts;
            lastLap = ts - lastElapsed;
            allLaps.Add(Tuple.Create(lastLap, ts));
            lastElapsed = ts;
            //allLaps.ForEach(i => Console.WriteLine("LapTime: {0}, TotalTime: {1}", i.Item1, i.Item2));
        }

        public void resetStopwatch()
        {
            if (!watch.IsRunning)
            {
                watch.Reset();
                lastElapsed = TimeSpan.Zero;
                lastLap = TimeSpan.Zero;
                splitTime = TimeSpan.Zero;
                allLaps.Clear();
                startDate = DateTime.MinValue;
            }
        }
    }
}
