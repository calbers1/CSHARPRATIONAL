using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rational
{
    class ImmutableRational
    {
        private int numerator;
        private int denominator;

    public String toString()
        {
            String result = numerator + "/" + denominator;
            return result;
        }

        public ImmutableRational()
        {
            numerator = 0;
            denominator = 1;
        }
        public ImmutableRational(int newNumerator)
        {
            numerator = newNumerator;
            denominator = 1;
        }
        public ImmutableRational(int newNumerator, int newDenominator)
        {
            if (newDenominator == 0)
            {
                throw new Exception("IllegalArgument");
            }

            reduce(newNumerator, newDenominator);

        }

        private void reduce(int newNumerator, int newDenominator)
        {
            int GCD = greatestCommonDivisor(newNumerator, newDenominator);

            numerator = newNumerator / GCD;
            denominator = newDenominator / GCD;

        }
        private int greatestCommonDivisor(long x, long y)
        {
            long remainder = x % y;
            while (remainder != 0)
            {
                x = y;
                y = remainder;
                remainder = x % y;
            }
            //we need to specify the data type on the return statement below 
            //to use in the reduce function
            return (int)y;
        }
        public ImmutableRational Add(ImmutableRational rValue)
        {

            int newNumerator = (this.numerator * rValue.denominator) + (this.denominator * rValue.numerator);
            int newDenominator = this.denominator * rValue.denominator;
            ImmutableRational result = new ImmutableRational(newNumerator, newDenominator);

            return result;
        }
        public ImmutableRational Subtract(ImmutableRational rValue)
        {
            int newNumerator = (this.numerator * rValue.denominator) - (this.denominator * rValue.numerator);
            int newDenominator = this.denominator * rValue.denominator;
            ImmutableRational result = new ImmutableRational(newNumerator, newDenominator);
            return result;
        }
        public ImmutableRational Multiply(ImmutableRational rValue)
        {
            int newNumerator = this.numerator * rValue.numerator;
            int newDenominator = this.denominator * rValue.denominator;
            ImmutableRational result = new ImmutableRational(newNumerator, newDenominator);
            return result;
        }
        public ImmutableRational Divide(ImmutableRational rValue)
        {
            int newNumerator = this.numerator * rValue.denominator;
            int newDenominator = this.denominator * rValue.numerator;
            ImmutableRational result = new ImmutableRational(newNumerator, newDenominator);
            return result;
        }
        public bool equals(Object obj)
        {
            ImmutableRational rValue = (ImmutableRational)obj;
            bool result = false;
            if (rValue.numerator == numerator && rValue.denominator == denominator)
            {
                result = true;
            }
            return result;
        }
    }
}
