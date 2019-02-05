using Microsoft.VisualStudio.TestTools.UnitTesting;
using DevOpsToday.Controllers;

namespace DevOpsToday.MSTesting.Tests
{
  [TestClass]
  public class HomeControllerTests
  {
    [TestMethod]
    public void Test_IndexAction()
    {
      var sut = new HomeController();

      Assert.IsNotNull(sut.Index());
    }

    [TestMethod]
    public void Test_privacyAction()
    {
      var sut = new HomeController();
      Assert.IsNotNull(sut.Privacy());
    }

  }
}