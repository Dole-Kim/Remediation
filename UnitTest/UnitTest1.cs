using Microsoft.VisualStudio.TestTools.UnitTesting;
using Remediation;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var s1 = Singleton.GetInstance();
            var s2 = Singleton.GetInstance();

            Assert.AreEqual(s1, s2);

        }


    }
}
