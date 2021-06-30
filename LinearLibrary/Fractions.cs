using System;
namespace LinearLibrary
{
    public class Fraction
    {
        public double whole { get; set; }
        public double numerator { get; set; }
        public double denumerator { get; set; }

        public string sign = "+";
        
        public Fraction(double whole, double numerator, double denumerator)
        {
            this.whole = whole;
            this.numerator = numerator;
            this.denumerator = denumerator;
        }

        static int GCD(int a, int b)
        {
            while (b != 0)
            {
                var t = b;
                b = a % b;
                a = t;
            }
            return a;
        }

        public void getSign()
        {
            if (numerator < 0 && denumerator < 0 || numerator < 0 && denumerator < 0) 
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
            whole = (int)numerator / (int)denumerator;
            numerator -= whole * (int)denumerator;
            denumerator /= GCD((int)numerator, (int)denumerator);
            numerator /= GCD((int)numerator, (int)denumerator);    
        }

        public override string ToString()
        {
            getSign();
            SimplificationFraction();
            if (whole >= 0 && whole < 1)
                return $"{sign} {numerator}/{denumerator}";
            if (numerator == 0)
                return $"{sign} {whole}";
            else
                return $"{sign} {whole} {numerator}/{denumerator}";
        }
        
    }
} 

