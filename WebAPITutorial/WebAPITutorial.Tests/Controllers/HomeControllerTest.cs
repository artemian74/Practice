using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAPITutorial;
using WebAPITutorial.Controllers;

namespace WebAPITutorial.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // 정렬
            HomeController controller = new HomeController();

            // 작동
            ViewResult result = controller.Index() as ViewResult;

            // 어설션
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
