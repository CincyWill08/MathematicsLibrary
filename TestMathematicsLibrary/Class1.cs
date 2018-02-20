using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathematicsLibrary.Tests
{
    
    public class MathLibTests
    {
        MathLib mathlib;

        [TestInintialize]
        public void Initialization()
        {
            mathlib = new MathLib();
        }

        [TestMethod()]
        public void AddTest()
        {
            Assert.AreEqual(4.5, mathlib.Add(1.5, 3.0));
            Assert.AreEqual(9, mathlib.Add(4.5, 4.5));
            Assert.AreEqual(1.4, mathlib.Add(2.7, -1.3));
        
            [Ignore]
            [TestMethod()]
            public void SubtractTest()
        {

        }

    }
    {
    }
}
