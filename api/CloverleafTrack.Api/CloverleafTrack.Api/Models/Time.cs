using System;

namespace CloverleafTrack.Api.Models
{
    public struct Time : IEquatable<Time>, IComparable<Time>
    {
        private const double SecondsPerMinute = 60;

        private readonly double minutes;
        private readonly double seconds;

        public Time(double minutes, double seconds)
        {
            this.minutes = minutes;
            this.seconds = seconds;
        }

        public double TotalMinutes => minutes + (seconds / SecondsPerMinute);
        public double TotalSeconds => (minutes * SecondsPerMinute) + seconds;

        public static Time FromSeconds(double seconds)
        {
            var minutes = Math.Truncate(seconds / SecondsPerMinute);
            var leftoverSeconds = seconds - (minutes * SecondsPerMinute);

            return new Time(minutes, leftoverSeconds);
        }

        public static Time operator +(Time a, Time b)
        {
            return Time.FromSeconds(a.TotalSeconds + b.TotalSeconds);
        }

        public static Time operator -(Time a, Time b)
        {
            return Time.FromSeconds(a.TotalSeconds - b.TotalSeconds);
        }

        public static Time operator -(Time a)
        {
            return Time.FromSeconds(-a.TotalSeconds);
        }

        public static bool operator >(Time a, Time b)
        {
            return a.CompareTo(b) > 0;
        }
        public static bool operator <(Time a, Time b)
        {
            return a.CompareTo(b) < 0;
        }

        public override bool Equals(object obj)
        {
            return obj is Time distance && Equals(distance);
        }

        public bool Equals(Time other)
        {
            return Math.Abs(this.TotalSeconds - other.TotalSeconds) < 0.01;
        }

        public int CompareTo(Time other)
        {
            return this.TotalSeconds.CompareTo(other.TotalSeconds);
        }

        public override int GetHashCode()
        {
            return this.TotalSeconds.GetHashCode();
        }

        public override string ToString()
        {
            return $"{minutes:00}:{seconds:00.00}";
        }
    }
}