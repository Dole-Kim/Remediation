using Microsoft.VisualStudio.TestTools.UnitTesting;
using Remediation.Entities;
using Remediation.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class AbstractFactoryTest
    {
        [TestMethod]
        public void TestMethod()
        {
            var factory = new ModernFactory();

            var sofa = factory.CreateSofa();

            ModernSofa sofaModern = new ModernSofa();

            Assert.AreEqual(sofa, sofaModern);

            //Assert.IsInstanceOfType(sofa, typeof(ModernSofa));

        }
    }
}
