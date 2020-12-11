using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pierres;

namespace Pierres.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void Pastry_CreatesInstanceOfPastryClass_True()
    {
      Pastry newOrder = new Pastry();
      Assert.AreEqual(typeof(Pastry), newOrder.GetType());
    }
  }
}