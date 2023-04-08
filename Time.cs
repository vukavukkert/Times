using System;
using System.Collections.Generic;
using System.Text;

namespace Times
{
    class Time
    {
        public Time(int hours = 0, int minutes = 0, int seconds = 0)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
       
        public static bool operator >(Time time1, Time time2)
        {
            return time1.ToSeconds() > time2.ToSeconds();
        }
        public static bool operator <(Time time1, Time time2)
        {
            return time1.ToSeconds() < time2.ToSeconds();
        }
        public static bool operator ==(Time time1, Time time2)
        {
            return time1.ToSeconds() == time2.ToSeconds();
        }
        public static bool operator !=(Time time1, Time time2)
        {
            return time1.ToSeconds() != time2.ToSeconds();
        }
        public static Time operator +(Time time1, Time time2)
        {
            return new Time { Seconds = time1.Seconds + time2.Seconds, Minutes = time1.Minutes + time2.Minutes, Hours = time1.Hours + time2.Hours };
        }
        public static Time operator -(Time time1, Time time2)
        {
            return new Time { Seconds = time1.Seconds - time2.Seconds, Minutes = time1.Minutes - time2.Minutes, Hours = time1.Hours - time2.Hours };
        }
        public static Time operator --(Time time)
        {
            return new Time { Seconds = time.Seconds - 1 };
        }
        public static Time operator ++(Time time)
        {
            return new Time { Seconds = time.Seconds + 1, Minutes = time.Minutes, Hours = time.Hours };
        }
        int ToSeconds()
        {
            return Seconds + Minutes * 60 + Hours * 3600;
        }
        private int minutes;
        public int Minutes
        {
            set
            {
                if (value < 0 || value >= 60)
                {
                    while(value >= 60)
                    {
                        Hours++;
                        value -= 60;
                    }
                    if(value >= 0)
                    {
                        minutes = value;
                    }
                }
                else
                {
                    minutes = value;
                }
            }
            get { return minutes; }
        }
        private int hours;
        public int Hours
        {
            set
            {
                hours = value;
            }
            get { return hours; }
        }
        private int seconds;
        public int Seconds
        {
            set
            {
                if (value < 0 || value >= 60)
                {
                    while (value >= 60)
                    {
                        Minutes++;
                        value -= 60;
                    }
                    if (value >= 0)
                    {
                        seconds = value;
                    }
                }
                else
                {
                    seconds = value;
                }
            }
            get { return seconds; }
        }
        public override string ToString()
        {
            return $"Hours: {hours}, Minutes: {minutes}, Seconds: {seconds}.";
        }
    }
}
