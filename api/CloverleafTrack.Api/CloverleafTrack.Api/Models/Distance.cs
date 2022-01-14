﻿using System;

namespace CloverleafTrack.Api.Models
{
    public struct Distance : IEquatable<Distance>, IComparable<Distance>
    {
        private const double MetersPerKilometer = 1000.0;
        private const double CentimetersPerMeter = 100.0;
        private const double CentimetersPerInch = 2.54;
        private const double InchesPerFoot = 12.0;
        private const double FeetPerYard = 3.0;
        private const double InchesPerMeter = CentimetersPerMeter / CentimetersPerInch;

        private readonly double feet;
        private readonly double inches;

        public Distance(double feet, double inches)
        {
            this.feet = feet;
            this.inches = inches;
        }

        public double TotalKilometers => TotalMeters / MetersPerKilometer;
        public double TotalMeters => TotalInches / InchesPerMeter;
        public double TotalCentimeters => TotalInches * CentimetersPerInch;
        public double TotalYards => TotalFeet / FeetPerYard;
        public double TotalFeet => feet + (inches / InchesPerFoot);
        public double TotalInches => (feet * InchesPerFoot) + inches;

        public static Distance FromMeters(double meters)
        {
            var totalInches = meters * InchesPerMeter;
            var feet = Math.Truncate(totalInches / InchesPerFoot);
            var inches = totalInches - (feet * InchesPerFoot);

            return new Distance(feet, inches);
        }

        public static Distance FromInches(double inches)
        {
            var feet = Math.Truncate(inches / InchesPerFoot);
            var leftoverInches = inches - (feet * InchesPerFoot);

            return new Distance(feet, leftoverInches);
        }

        public static Distance operator +(Distance a, Distance b)
        {
            return FromInches(a.TotalInches + b.TotalInches);
        }

        public static Distance operator -(Distance a, Distance b)
        {
            return FromInches(a.TotalInches - b.TotalInches);
        }

        public static Distance operator -(Distance a)
        {
            return FromInches(-a.TotalInches);
        }

        public static bool operator >(Distance a, Distance b)
        {
            return a.CompareTo(b) > 0;
        }
        public static bool operator <(Distance a, Distance b)
        {
            return a.CompareTo(b) < 0;
        }

        public override bool Equals(object obj)
        {
            return obj is Distance distance && Equals(distance);
        }

        public bool Equals(Distance other)
        {
            return Math.Abs(this.TotalInches - other.TotalInches) < 0.01;
        }

        public int CompareTo(Distance other)
        {
            return TotalInches.CompareTo(other.TotalInches);
        }

        public override int GetHashCode()
        {
            return TotalInches.GetHashCode();
        }

        public override string ToString()
        {
            return $"{feet:000}-{inches:00.00}";
        }
    }
}