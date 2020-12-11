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
      Pastry newOrder = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newOrder.GetType());
    }
    [TestMethod]
    public void Pastry_ReturnsNumberOfPastries_Int()
    {
      int pastryCount = 3;
      Pastry newOrder = new Pastry(pastryCount);
      int result = newOrder.PastryCount;
      Assert.AreEqual(result, pastryCount);
    }
    [TestMethod]
    public void PastryPricing_CorrectlyDisplaysPricingOfOnePastry_Int()
    {
      int pastryCount = 1;
      Pastry newOrder = new Pastry(pastryCount);
      int result = newOrder.PastryPricing();
      Assert.AreEqual(result, 2);
    }
  }
}