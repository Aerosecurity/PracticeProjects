using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using HelloWorld;

namespace HelloWorldTests
{
    [TestClass]
    public class HelloWorldTests
    {
        [TestMethod]
        public void GetMessage()
        {
            var hello = new HelloWorld.HelloWorld();

            Assert.AreEqual(hello.GetMessage(), "Hello World");
        }
    }
}
