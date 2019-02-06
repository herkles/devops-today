using DevOpsToday.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevOpsToday.MSTesting.Tests
{
  [TestClass]
  public class ErrorViewModelTests
  {
    [TestMethod]
    public void Test_ShowRequestIdMethod()
    {
      var sut = new ErrorViewModel(){RequestId = "sean"};

      Assert.IsTrue(sut.ShowRequestId);
    }
  }
} 