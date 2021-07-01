using System;
namespace LinearLibrary
{
    public class Fraction
    {
        public int whole { get; set; }
        public double numerator { get; set; }
        public double denumerator { get; set; }

        public string sign = "+";

        private int gcd;

        public Fraction(int whole, double numerator, double denumerator)
        {
            this.whole = whole;
            this.numerator = numerator;
            this.denumerator = denumerator;
            InitSign();
            if (denumerator != 0)
            {
                SimplificationFraction();
            }
        }

        public  int GreatestCommonDivisor(int a , int b)
        {
            while (b != 0)
            {
                var t = b;
                b = a % b;
                a = t;
            }
            return a;
        }

        public void InitSign()
        {
            if (numerator < 0 && denumerator < 0 || numerator > 0 && denumerator > 0) 
            {
                numerator = Math.Abs(numerator);
                denumerator = Math.Abs(denumerator);
                sign = "+";
            }
            else
            {
                numerator = Math.Abs(numerator);
                denumerator = Math.Abs(denumerator);
                sign = "-";
            }

        }
            
        public void SimplificationFraction()
        {
            gcd = GreatestCommonDivisor((int)numerator, (int)denumerator);
            whole = (int)numerator / (int)denumerator;
            numerator -= whole * (int)denumerator;
            denumerator /= gcd;
            numerator /= gcd;    
        }

        public override string ToString()
        {
            if (sign == "-")
            {
                if (whole >= 0 && whole < 1)
                    return $"{sign} {numerator}/{denumerator}";
                if (numerator == 0)
                    return $"{sign} {whole}";
                else
                    return $"{sign} {whole} {numerator}/{denumerator}";
            }
            else
            {
                if (whole >= 0 && whole < 1)
                    return $"{numerator}/{denumerator}";
                if (numerator == 0)
                    return $"{whole}";
                else
                    return $"{whole} {numerator}/{denumerator}";
            }
        }
        
    }
} 

