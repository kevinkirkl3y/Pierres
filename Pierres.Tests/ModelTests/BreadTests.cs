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
      int loafCount = 3;
      Bread newOrder = new Bread(loafCount);
      int result = newOrder.LoafCount;
      Assert.AreEqual(loafCount, result);
    }
  }
}