using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP;
using TP.Controllers;

namespace TP.Tests.Controllers
{
    [TestClass]
    public class UnitTest2
    {

        [TestMethod]
        public void TestAddition()
        {
            var controller = new CalculController();
            int res = controller.Addition(2, 3);
            Assert.AreEqual(5, res);



        }
    }
}
