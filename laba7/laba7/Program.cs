using System;
using System.Globalization;
namespace laba7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nRational number: \n");
            RationalNumber r1 = new RationalNumber(15, 10);
            Console.WriteLine(r1);
            RationalNumber r2 = new RationalNumber(7, 3);
            Console.WriteLine(r2);
            Console.WriteLine("\nMathematical operations : \n");
            RationalNumber sum = r1 + r2;
            Console.WriteLine($"{r1}+{r2} = {sum}");
            RationalNumber sub = r1 - r2;
            Console.WriteLine($"{r1}-{r2} = {sub}");
            RationalNumber mult = r1 * r2;
            Console.WriteLine($"{r1}*{r2} = {mult}");
            RationalNumber div = r1 / r2;
            Console.WriteLine($"{r1}/{r2} = {div}");
            Console.WriteLine("\nComparison operations: \n");
            Console.WriteLine($"{r1} > {r2} - {r1 > r2}");
            Console.WriteLine($"{r1} < {r2} - {r1 < r2}");
            Console.WriteLine($"{r1} >= {r2} - {r1 >= r2}");
            Console.WriteLine($"{r1} <= {r2} - {r1 <= r2}");
            Console.WriteLine($"{r1} = {r2} - {r1 == r2}");
            Console.WriteLine($"{r1} != {r2} - {r1 != r2}\n");
            Console.WriteLine(sum.GetHashCode());
            Console.WriteLine("\nReduce method test : \n");
            RationalNumber red = sum.Reduce();
            Console.WriteLine(red);
            Console.WriteLine("\nConvert methods tests : \n");
            var provider = CultureInfo.CurrentCulture;
            TypeCode typeCode = r1.GetTypeCode();
            Console.WriteLine($"Type - {typeCode}");
            bool toBool = r1.ToBoolean(provider);
            Console.WriteLine($"Bool - {toBool}");
            byte toByte = r1.ToByte(provider);
            Console.WriteLine($"Byte - {toByte}");
            char toChar = r1.ToChar(provider);
            Console.WriteLine($"Char - {toChar}");
            DateTime toDT = r1.ToDateTime(provider);
            Console.WriteLine($"Data - {toDT}");
            decimal toDecimal = r1.ToDecimal(provider);
            Console.WriteLine($"Decimal - {toDecimal}");
            double toDouble = r1.ToDouble(provider);
            Console.WriteLine($"Double - {toDouble}");
            Int16 toInt16 = r1.ToInt16(provider);
            Console.WriteLine($"Int16 - {toInt16}");
            Int32 toInt32 = r1.ToInt32(provider);
            Console.WriteLine($"Int32 - {toInt32}");
            Int64 toInt64 = r1.ToInt64(provider);
            Console.WriteLine($"Int64 - {toInt64}");
            SByte toSByte = r1.ToSByte(provider);
            Console.WriteLine(toSByte);
            Single toSingle = r1.ToSingle(provider);
            Console.WriteLine(toSingle);
            UInt16 toUInt16 = r1.ToUInt16(provider);
            Console.WriteLine(toUInt16);
            UInt32 toUInt32 = r1.ToUInt32(provider);
            Console.WriteLine(toUInt32);
            UInt64 toUInt64 = r1.ToUInt64(provider);
            Console.WriteLine(toUInt64);
            ulong toType = (ulong)r1.ToType(typeof(ulong), provider);
            Console.WriteLine(toType);
            Console.WriteLine("\nConvert operators : \n");
            Console.WriteLine($"Int - {(int)r1}");
            Console.WriteLine($"Long - {(long)r1}");
            Console.WriteLine($"Decimal - {(decimal)r1}");
            Console.WriteLine($"Double - {(double)r1}");
            Console.WriteLine($"Float - {(float)r1}");
            int testInt = 10;
            RationalNumber testIntRn = testInt;
            Console.WriteLine(testIntRn);
            long testLong = 10;
            RationalNumber testLongRn = testLong;
            Console.WriteLine(testLongRn);
            decimal testDecimal = 10.2m;
            RationalNumber testDecimalRn = testDecimal;
            Console.WriteLine(testDecimalRn);
            double testDouble = 10.2;
            RationalNumber testDoubleRn = testDouble;
            Console.WriteLine(testDoubleRn);
            float testFloat = 10.2f;
            RationalNumber testFloatRn = testFloat;
            Console.WriteLine(testFloatRn);
            Console.WriteLine("\nFormat tests : \n");
            Console.WriteLine(r1.ToString("F"));
            Console.WriteLine(r1.ToString("D"));
            Console.WriteLine(r1.ToString("P"));
            Console.WriteLine(r1.ToString("N"));
            try
            {
                Console.WriteLine(r1.ToString("None"));
            }
            catch (Exception e)
            {

                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}