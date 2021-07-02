using System;
using System.Text;
namespace LinearLibrary
{
    public class Fraction
    {
        public int whole { get; private set; }
        public double numerator { get; set; }
        public double denominator { get; set; }

        private string sign = "+";

        private int gcd;

        public Fraction(int whole, double numerator, double denominator)
        {
            this.whole = whole;
            this.numerator = numerator;
            this.denominator = denominator;

            InitSign();

            if (denominator != 0)
                SimplificationFraction();
        }

        private void InitSign()
        {
            if (numerator < 0 && denominator > 0
                || numerator > 0 && denominator < 0)
                sign = "-";

            numerator = Math.Abs(numerator);
            denominator = Math.Abs(denominator);
        }

        private void SimplificationFraction()
        {
            whole = (int)numerator / (int)denominator;
            numerator -= whole * (int)denominator;

            gcd = GreatestCommonDivisor((int)numerator, (int)denominator);
            denominator /= gcd;
            numerator /= gcd;
        }

        public  int GreatestCommonDivisor(int a , int b)
        {
            while (b != 0)
            {
                var temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            if (sign == "-")
                result.Append($"{sign} ");

            if (whole != 0)
                result.Append($"{whole} ");

            if (numerator != 0)
                result.Append($"{numerator}/{denominator}");

            return result.ToString();   
        }

        public string ToStringWithPositiveSign()
        {
            return sign == "+" ? $"+ {ToString()}" : ToString();
        }
    }
} 