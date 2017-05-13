using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var hw = new HelloWorld();
            Assert.AreEqual("hello world", HelloWorld.GetMessage());

        }
    }
}
