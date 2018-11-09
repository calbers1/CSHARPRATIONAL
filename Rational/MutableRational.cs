/*pair programmed by Connor Albers and Caleb Herring*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rational
{
    public class MutableRational
    {
        private int numerator;
        private int denominator;

        
    public String toString()
        {
            String result = numerator + "/" + denominator;
            return result;
        }

        //default constructor
        public MutableRational()
        {
            numerator = 0;
            denominator = 1;
        }

        public MutableRational(int passedNumerator)
        {
            numerator = passedNumerator;
            denominator = 1;
        }

        public MutableRational(int passedNumerator, int passedDenominator)
        {
            //check to see if the passed denominator is valid
            //(make sure the denominator isn't zero

            if (passedDenominator == 0)
            {
                throw new Exception("IllegalArgument");
            }

            numerator = passedNumerator;
            denominator = passedDenominator;
            reduce();
        }

        public void add(MutableRational rational)
        {
            int LCM = leastCommonMultiple(denominator, rational.denominator);
            int LCMDivision = LCM / denominator;
            int temp1 = numerator * LCMDivision;
            int LCMDivision2 = LCM / rational.denominator;
            int temp2 = rational.numerator * LCMDivision2;

            numerator = temp1 + temp2;
            denominator = LCM;
            reduce();
        }

        public void add(int value)
        {
            MutableRational rational = new MutableRational(value);

            int LCM = leastCommonMultiple(denominator, rational.denominator);
            denominator = LCM;
            numerator = (numerator * (LCM / denominator)) + (rational.numerator * (LCM / rational.denominator));
            reduce();
        }

        public void subtraction(MutableRational rational)
        {
            int LCM = leastCommonMultiple(denominator, rational.denominator);
            int LCMDivision = LCM / denominator;
            int temp1 = numerator * LCMDivision;
            int LCMDivision2 = LCM / rational.denominator;
            int temp2 = rational.numerator * LCMDivision2;

            numerator = temp1 - temp2;
            denominator = LCM;
            reduce();
        }

        public void subtraction(int value)
        {
            value = value * denominator;
            numerator = numerator - value;
            //        // we need to create a new mutable rational
            //        MutableRational rational = new MutableRational(value);
            //        
            //       //create a LCM variable, assining it the lcm function
            //        int LCM = leastCommonMultiple(denominator, rational.denominator);
            //        denominator = LCM;
            //        numerator = (numerator * (LCM/denominator));
            reduce();
        }

        public void multiply(MutableRational rational)
        {
            numerator *= rational.numerator;
            denominator *= rational.denominator;
            reduce();
        }

        public void multiply(int value)
        {
            //create a new rational when passed a value
            MutableRational rational = new MutableRational(value);

            //implement logic for the multiply function concernning type  rational
            numerator *= rational.numerator;
            denominator *= rational.denominator;
            reduce();
        }

        public void divide(int value)
        {
            //create a new Rational
            MutableRational rational = new MutableRational(value);

            //check to see if denominator is valid
            if (rational.denominator == 0)
            {
                throw new Exception("IllegalArgument");
            }
            denominator = denominator * rational.numerator;
            numerator = numerator * rational.denominator;
            reduce();
        }

        public void divide(MutableRational rational)
        {
            //we need to check to see if the denominator is a valid value
            //IE not Zero

            if (rational.denominator == 0)
            {
                throw new Exception("IllegalArgument");
            }
            denominator = denominator * rational.numerator;
            numerator = numerator * rational.denominator;
            reduce();
        }


        private int leastCommonMultiple(int x, int y)
        {
            int lcm = x;
            while (lcm % y != 0)
            {
                lcm += x;
            }
            return lcm;
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
        private void reduce()
        {
            int GCD = greatestCommonDivisor(numerator, denominator);

            numerator = numerator / GCD;
            denominator = denominator / GCD;

        }
        public bool AreEqual(Object obj)
        {
            MutableRational rValue = (MutableRational)obj;
            bool result = false;
            if (rValue.numerator == numerator && rValue.denominator == denominator)
            {
                result = true;
            }
            return result;
        }
    }
}
