using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathematicsLibrary;

namespace MathematicsLibraryTests
{

    [TestClass()]
    public class MathLibTests
    {
        MathLib mathlib;
        double errorFactor = 1.1;

        [TestInitialize]
        public void Initialization()
        {
            mathlib = new MathLib();
            
        }

        //[Ignore]
        [TestMethod()]
        public void AddTest()
        {
            Assert.AreEqual(4.5, mathlib.Add(1.5, 3.0));
            Assert.AreEqual(9, mathlib.Add(4.5, 4.5));
            Assert.AreEqual(1.4, mathlib.Add(2.7, -1.3), 0.1);
        }

        //[Ignore]
        [TestMethod()]
        public void SubtractTest()
        {
            Assert.AreEqual(3, mathlib.Subtract(10, 7));
            Assert.AreEqual(1.4, mathlib.Subtract(2.5, 1.1), 0.1);
            Assert.AreEqual(-30, mathlib.Subtract(70, 100), 0.1);
            Assert.AreEqual(-70, mathlib.Subtract(-50, 20));
        }

        //[Ignore]
        [TestMethod()]
        public void MultiplyTest()
        {
            Assert.AreEqual(70, mathlib.Multiply(10, 7));
            Assert.AreEqual(2.75, mathlib.Multiply(2.5, 1.1), 0.1);
            Assert.AreEqual(-2.75, mathlib.Multiply(2.5, -1.1), 0.1);
            Assert.AreEqual(120, mathlib.Multiply(-20, -6), 0.1);
        }

        //[Ignore]
        [TestMethod()]
        public void DivideTest()
        {
            Assert.AreEqual(1, mathlib.Divide(10, 7), 1.5);
            Assert.AreEqual(-5, mathlib.Divide(10, -2), 0.1);
            Assert.AreEqual(3, mathlib.Divide(-9, -3), 0.1);
        }

        //[Ignore]
        [TestMethod()]
        public void SquareRootTest()
        {
            Assert.AreEqual(13, mathlib.SqrRoot(169));
            Assert.AreEqual(3, mathlib.SqrRoot(9));
            //Assert.AreEqual(13, mathlib.SqrRoot(20));
        }

        //[Ignore]
        [TestMethod()]
        public void InverseTest()
        {
            Assert.AreEqual(0.2, mathlib.Inverse(5), errorFactor);
        }

        //[Ignore]
        [TestMethod()]
        public void NegateTest()
        {
            Assert.AreEqual(-169, mathlib.Negate(169));
        }
    }
}

