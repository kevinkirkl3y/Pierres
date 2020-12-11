using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pierres;

namespace Pierres.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void Bread_CreatesInstanceOfBreadClass_True()
    {
      Bread newOrder = new Bread();
      Assert.AreEqual(typeof(Bread), newOrder.GetType());
    }
    [TestMethod]
    public void Bread_ReturnsNumberOfLoaves_Int()
    {
      Bread newOrder = new Bread();
      newOrder.loafCount = 3;
      int result = newOrder.loafCount;
      Assert.AreEqual(newOrder.loafCount, result);
    }
  }
}