using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DataAccesLayer.Helpers;


namespace BasicUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
             
            var connection = new DbConnectionHelper().Connection;
            Assert.AreEqual(connection.State.toString(), "Open" );
        }
    }
}
