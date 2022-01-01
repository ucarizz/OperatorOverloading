using System;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            DecimalNumber decimalNumber1 = new DecimalNumber(5);
            DecimalNumber decimalNumber2 = new DecimalNumber(6);

            var res = decimalNumber1 + decimalNumber2;
            Console.WriteLine(res.Value);
        }
    }

    public class DecimalNumber {
        public DecimalNumber(decimal value)
        {
            this.Value = value;
        }

        public decimal Value { get; set; }
        public int Precision { get; set; }

        public static DecimalNumber operator +(DecimalNumber number1, DecimalNumber number2)
        {
            return new DecimalNumber(number1.Value + number2.Value);
        }
        public static DecimalNumber operator +(DecimalNumber number1, int number2)
        {
            return new DecimalNumber(number1.Value + number2);
        }
    }
}
