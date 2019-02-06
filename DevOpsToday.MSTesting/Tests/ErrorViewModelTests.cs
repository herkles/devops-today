using Microsoft.VisualStudio.TestTools.UnitTesting;
using DevOpsToday.MSTesting.Models;

namespace NetOps.MSTesting.Tests
{
  [TestClass]
  public class ErrorViewModelTests
  {
    [TestMethod]
    public void Test_ShowRequestIdMethod()
    {
      var sut = new ErrorViewModel(){ RequestId = "sean" };

      Assert.IsTrue(sut.ShowRequestId);
    }
  }
}