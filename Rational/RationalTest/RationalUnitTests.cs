/*pair programmed by Connor Albers and Caleb Herring*/
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RationalTest
{
    [TestClass]
    public class RationalUnitTests
    {
 
        [TestMethod]
        public void testToString()
        {
            Console.Out.WriteLine("toString");
            Rational.MutableRational instance = new Rational.MutableRational();
            String expResult = "0/1";
            String result = instance.toString();
            Assert.AreEqual(expResult, result);
            
        }
        
        /**
         * Test of add method, of class Rational.MutableRational.
         */
        
    [TestMethod]
        public void testAdd_MutableRational()
        {
            Console.Out.WriteLine("add");
            Rational.MutableRational rational = new Rational.MutableRational(1, 4);
            Rational.MutableRational instance = new Rational.MutableRational(1, 4);
            Rational.MutableRational expResult = new Rational.MutableRational(1, 2);
            instance.add(rational);
            Assert.AreEqual(expResult.toString(), instance.toString());
        }

        /**
         * Test of add method, of class Rational.MutableRational.
         */
        
    [TestMethod]
        public void testAdd_int()
        {
            Console.Out.WriteLine("add");
            int value = 1;
            Rational.MutableRational instance = new Rational.MutableRational(1, 2);
            instance.add(value);
            Rational.MutableRational expResult = new Rational.MutableRational(3, 2);
            Assert.AreEqual(expResult.toString(), instance.toString());
        }

        /**
         * Test of subtraction method, of class Rational.MutableRational.
         */
        
    [TestMethod]
        public void testSubtraction_MutableRational()
        {
            Console.Out.WriteLine("subtraction");
            Rational.MutableRational rational = new Rational.MutableRational(1, 4);
            Rational.MutableRational instance = new Rational.MutableRational(1, 2);
            instance.subtraction(rational);
            Rational.MutableRational expResult = new Rational.MutableRational(1, 4);
            Assert.AreEqual(expResult.toString(), instance.toString());
        }

        /**
         * Test of subtraction method, of class Rational.MutableRational.
         */
        
    [TestMethod]
        public void testSubtraction_int()
        {
            Console.Out.WriteLine("subtraction");
            int value = 1;
            Rational.MutableRational instance = new Rational.MutableRational(3, 2);
            instance.subtraction(value);
            Rational.MutableRational expResult = new Rational.MutableRational(1, 2);
            Assert.AreEqual(expResult.toString(), instance.toString());
        }

        /**
         * Test of multiply method, of class Rational.MutableRational.
         */
        
    [TestMethod]
        public void testMultiply_MutableRational()
        {
            Console.Out.WriteLine("multiply");
            Rational.MutableRational rational = new Rational.MutableRational(1, 2);
            Rational.MutableRational instance = new Rational.MutableRational(1, 2);
            instance.multiply(rational);
            Rational.MutableRational expResult = new Rational.MutableRational(1, 4);
            Assert.AreEqual(expResult.toString(), instance.toString());
        }

        /**
         * Test of multiply method, of class Rational.MutableRational.
         */
        
    [TestMethod]
        public void testMultiply_int()
        {
            Console.Out.WriteLine("multiply");
            int value = 2;
            Rational.MutableRational instance = new Rational.MutableRational(1, 4);
            instance.multiply(value);
            Rational.MutableRational expResult = new Rational.MutableRational(1, 2);
            Assert.AreEqual(expResult.toString(), instance.toString());
        }

        /**
         * Test of divide method, of class Rational.MutableRational.
         */
        
    [TestMethod]
        public void testDivide_int()
        {
            Console.Out.WriteLine("divide");
            int value = 2;
            Rational.MutableRational instance = new Rational.MutableRational(1, 2);
            instance.divide(value);
            Rational.MutableRational expResult = new Rational.MutableRational(1, 4);
            Assert.AreEqual(expResult.toString(), instance.toString());
        }

        /**
         * Test of divide method, of class Rational.MutableRational.
         */
        
    [TestMethod]
        public void testDivide_MutableRational()
        {
            Console.Out.WriteLine("divide");
            Rational.MutableRational rational = new Rational.MutableRational(1, 2);
            Rational.MutableRational instance = new Rational.MutableRational(1, 2);
            instance.divide(rational);
            Rational.MutableRational expResult = new Rational.MutableRational(2, 2);
            Assert.AreEqual(expResult.toString(), instance.toString());
        }



        [TestMethod]
        public void testToStringi()
        {
            Console.Out.WriteLine("toString");
            Rational.ImmutableRational instance = new Rational.ImmutableRational();
            String expResult = "0/1";
            String result = instance.toString();
            Assert.AreEqual(expResult, result);

        }

        /**
         * Test of Add method, of class Rational.ImmutableRational.
         */
        
    [TestMethod]
        public void testAddi()
        {
            Console.Out.WriteLine("Add");
            Rational.ImmutableRational rValue = new Rational.ImmutableRational(1, 4);
            Rational.ImmutableRational instance = new Rational.ImmutableRational(1, 2);
            Rational.ImmutableRational expResult = new Rational.ImmutableRational(3, 4);
            Rational.ImmutableRational result = instance.Add(rValue);
            Assert.AreEqual(expResult.toString(), result.toString());
        }

        /**
         * Test of Subtract method, of class Rational.ImmutableRational.
         */
        
    [TestMethod]
        public void testSubtracti()
        {
            Console.Out.WriteLine("Subtract");
            Rational.ImmutableRational rValue = new Rational.ImmutableRational(1 / 4);
            Rational.ImmutableRational instance = new Rational.ImmutableRational(3 / 4);
            Rational.ImmutableRational expResult = new Rational.ImmutableRational(1 / 2);
            Rational.ImmutableRational result = instance.Subtract(rValue);
            Assert.AreEqual(expResult.toString(), result.toString());
        }

        /**
         * Test of Multiply method, of class Rational.ImmutableRational.
         */
        
    [TestMethod]
        public void testMultiplyi()
        {
            Console.Out.WriteLine("Multiply");
            Rational.ImmutableRational rValue = new Rational.ImmutableRational(1, 2);
            Rational.ImmutableRational instance = new Rational.ImmutableRational(1, 2);
            Rational.ImmutableRational expResult = new Rational.ImmutableRational(1, 4);
            Rational.ImmutableRational result = instance.Multiply(rValue);
            Assert.AreEqual(expResult.toString(), result.toString());
        }

        /**
         * Test of Divide method, of class Rational.ImmutableRational.
         */
        
    [TestMethod]
        public void testDividei()
        {
            Console.Out.WriteLine("Divide");
            Rational.ImmutableRational rValue = new Rational.ImmutableRational(1, 2);
            Rational.ImmutableRational instance = new Rational.ImmutableRational(1, 4);
            Rational.ImmutableRational expResult = new Rational.ImmutableRational(1, 2);
            Rational.ImmutableRational result = instance.Divide(rValue);
            Assert.AreEqual(expResult.toString(), result.toString());
        }




















    }
}
