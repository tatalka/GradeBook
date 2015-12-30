using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GradeBookNamespace;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            GradeBook book = new GradeBook();
            bool condition = false;
            Assert.IsFalse(condition);
           
        }
    }
}
