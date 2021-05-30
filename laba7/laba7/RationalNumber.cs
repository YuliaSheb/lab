using System;
using System.Globalization;
namespace laba7
{
    class RationalNumber : IEquatable<RationalNumber>, IComparable<RationalNumber>, IConvertible, IFormattable
    {
        private int Numerator { get; }
        private int Denominator { get; }
        public RationalNumber(int Numerator, int Denominator)
        {
            this.Numerator = Numerator;
            this.Denominator = (Denominator > 0) ? Denominator : 1;
        }
        public static RationalNumber operator +(RationalNumber r1, RationalNumber r2)
        {
            return r1.Add(r2);
        }
        public static RationalNumber operator -(RationalNumber r1, RationalNumber r2)
        {
            return r1.Subtract(r2);
        }
        public static RationalNumber operator *(RationalNumber r1, RationalNumber r2)
        {
            return r1.Multiply(r2);
        }
        public static RationalNumber operator /(RationalNumber r1, RationalNumber r2)
        {
            return r1.Divide(r2);
        }
        public static bool operator ==(RationalNumber r1, RationalNumber r2)
        {
            return r1.Equals(r2);
        }
        public static bool operator !=(RationalNumber r1, RationalNumber r2)
        {
            return !r1.Equals(r2);
        }
        public static bool operator <(RationalNumber r1, RationalNumber r2)
        {
            return r1.CompareTo(r2) < 0;
        }
        public static bool operator >(RationalNumber r1, RationalNumber r2)
        {
            return r1.CompareTo(r2) > 0;
        }
        public static bool operator <=(RationalNumber r1, RationalNumber r2)
        {
            return r1.CompareTo(r2) <= 0;
        }
        public static bool operator >=(RationalNumber r1, RationalNumber r2)
        {
            return r1.CompareTo(r2) >= 0;
        }
        public RationalNumber Add(RationalNumber other)
        {
            int numerator = (Numerator * other.Denominator) + (other.Numerator * Denominator);
            int denominator = Denominator * other.Denominator;
            return new RationalNumber(numerator, denominator);
        }
        public RationalNumber Subtract(RationalNumber other)
        {
            int numerator = (Numerator * other.Denominator) - (other.Numerator * Denominator);
            int denominator = Denominator * other.Denominator;
            return new RationalNumber(numerator, denominator);
        }
        public RationalNumber Multiply(RationalNumber other)
        {
            int numerator = Numerator * other.Numerator;
            int denominator = Denominator * other.Denominator;
            return new RationalNumber(numerator, denominator);
        }
        public RationalNumber Divide(RationalNumber other)
        {
            int numerator = Numerator * other.Denominator;
            int denominator = (other.Numerator == 0)
                ? throw new DivideByZeroException()
                : other.Numerator * Denominator;
            return new RationalNumber(numerator, denominator);
        }
        public bool Equals(RationalNumber other)
        {
            return this.GetDoubleValue() == other.GetDoubleValue();
        }
        public override bool Equals(object o)
        {
            RationalNumber rn = o as RationalNumber;
            return Equals(rn);
        }
        public int CompareTo(RationalNumber other)
        {
            double thisNumber = this.GetDoubleValue();
            double otherNumber = other.GetDoubleValue();

            if (thisNumber > otherNumber)
                return 1;
            else if (thisNumber < otherNumber)
                return -1;
            else
                return 0;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(this.Numerator, this.Denominator);
        }
        public RationalNumber Reduce()
        {
            int numb = GreatestCommonDivisor(this.Numerator, this.Denominator);
            int numerator = this.Numerator / numb;
            int denominator = this.Denominator / numb;
            if (denominator < 0)
            {
                return new RationalNumber(-numerator, -denominator);
            }
            return new RationalNumber(numerator, denominator);
        }
        public static implicit operator RationalNumber(int value)
        {
            return new RationalNumber(value, 1);
        }
        public static implicit operator RationalNumber(long value)
        {
            return new RationalNumber((int)value, 1);
        }
        public static implicit operator RationalNumber(decimal value)
        {
            return CreateFromDouble((double)value);
        }
        public static implicit operator RationalNumber(double value)
        {
            return CreateFromDouble(value);
        }
        public static implicit operator RationalNumber(float value)
        {
            decimal dec = new decimal(value);
            return CreateFromDouble((double)dec);
        }
        public static explicit operator int(RationalNumber value)
        {
            return (int)value.Numerator / value.Denominator;
        }
        public static explicit operator long(RationalNumber value)
        {
            return (long)value.Numerator / value.Denominator;
        }
        public static explicit operator decimal(RationalNumber value)
        {
            return (decimal)value.Numerator / value.Denominator;
        }
        public static explicit operator double(RationalNumber value)
        {
            return (double)value.Numerator / value.Denominator;
        }
        public static explicit operator float(RationalNumber value)
        {
            return (float)value.Numerator / value.Denominator;
        }
        public TypeCode GetTypeCode()
        {
            return TypeCode.Object;
        }
        public bool ToBoolean(IFormatProvider provider)
        {
            return this.Numerator != 0;
        }
        public byte ToByte(IFormatProvider provider)
        {
            return Convert.ToByte(GetDoubleValue());
        }
        public char ToChar(IFormatProvider provider)
        {
            return Convert.ToChar(ToString(provider)[0]);
        }
        public DateTime ToDateTime(IFormatProvider provider)
        {
            return DateTime.Now;
        }
        public decimal ToDecimal(IFormatProvider provider)
        {
            return Convert.ToDecimal(GetDoubleValue());
        }
        public double ToDouble(IFormatProvider provider)
        {
            return GetDoubleValue();
        }
        public short ToInt16(IFormatProvider provider)
        {
            return Convert.ToInt16(GetDoubleValue());
        }
        public int ToInt32(IFormatProvider provider)
        {
            return Convert.ToInt32(GetDoubleValue());
        }
        public long ToInt64(IFormatProvider provider)
        {
            return Convert.ToInt64(GetDoubleValue());
        }
        public sbyte ToSByte(IFormatProvider provider)
        {
            return Convert.ToSByte(GetDoubleValue());
        }
        public float ToSingle(IFormatProvider provider)
        {
            return Convert.ToSingle(GetDoubleValue());
        }
        public string ToString(IFormatProvider provider)
        {
            return this.ToString("F", CultureInfo.CurrentCulture);
        }
        public object ToType(Type conversionType, IFormatProvider provider)
        {
            return Convert.ChangeType(GetDoubleValue(), conversionType);
        }
        public ushort ToUInt16(IFormatProvider provider)
        {
            return Convert.ToUInt16(GetDoubleValue());
        }
        public uint ToUInt32(IFormatProvider provider)
        {
            return Convert.ToUInt32(GetDoubleValue());
        }
        public ulong ToUInt64(IFormatProvider provider)
        {
            return Convert.ToUInt64(GetDoubleValue());
        }
        public string ToString(string format)
        {
            return this.ToString(format, CultureInfo.CurrentCulture);
        }
        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (String.IsNullOrEmpty(format)) format = "F";
            if (formatProvider == null) formatProvider = CultureInfo.CurrentCulture;
            switch (format.ToUpperInvariant())
            {
                case "F":
                    return $"{this.Numerator}/{this.Denominator}";
                case "D":
                    return GetDoubleValue().ToString();
                case "P":
                    return GetDoubleValue().ToString("P", formatProvider);
                case "N":
                    return GetDoubleValue().ToString("N", formatProvider);
                default:
                    throw new FormatException($"The {format} format string is not supported.");
            }
        }
        private double GetDoubleValue()
        {
            return this.Numerator / this.Denominator;
        }
        private int GreatestCommonDivisor(int a, int b)
        {
            return b == 0 ? Math.Abs(a) : GreatestCommonDivisor(Math.Abs(b), Math.Abs(a) % Math.Abs(b));
        }
        private static RationalNumber CreateFromDouble(double doubleNumber)
        {
            string number = doubleNumber.ToString();
            try
            {
                int intPart = Convert.ToInt32(number.Substring(0, number.IndexOf(",")));
                double doublePart = Convert.ToDouble("0" + number.Substring(number.IndexOf(",") - 1, number.Length - 1));
                int denominator = (int)Math.Pow(10, doublePart.ToString().Length - 2);
                doublePart *= denominator;
                int numerator = (int)(intPart * denominator + doublePart);
                return new RationalNumber(numerator, denominator);
            }
            catch (Exception)
            {
                return new RationalNumber((int)doubleNumber, 1);
            }
        }
    }
}