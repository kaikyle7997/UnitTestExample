using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WCFService;

namespace WCFServiceTest
{
    [TestClass]
    public class MyServiceTest
    {
        private MyService target;

        public MyServiceTest()
        {
            target = new MyService();
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void GetDataTest1()
        {
            string expected = "You entered: 92525";

            string actual = target.GetData(92525);

            Assert.AreEqual(expected, actual);           
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void GetDataTest2()
        {
            string expected = "owo";

            string actual = target.GetData(9999);

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void GetDataUsingDataContractTest()
        {
            string expected = "Hi Cubee!Suffix";

            CompositeType ctInput = new CompositeType();
            ctInput.StringValue = "Hi Cubee!";
            ctInput.BoolValue = true;

            CompositeType actual = target.GetDataUsingDataContract(ctInput);

            Assert.AreEqual(expected, actual.StringValue);
        }
    }
}
