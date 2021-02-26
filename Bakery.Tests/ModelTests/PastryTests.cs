using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreateInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(2, 1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void PastryPrice_ReturnPriceOfOnePastry_Int()
    {
      int pastryPrice = 2;
      int pastryAmount = 1;
      Pastry newPastry = new Pastry(pastryPrice, pastryAmount);

      int result = newPastry.PastryPrice;

      Assert.AreEqual(pastryPrice, result);
    }

        [TestMethod]
    public void PastryAmount_ReturnAmountOfPastries_Int()
    {
      int pastryPrice = 5;
      int pastryAmount = 3;
      Pastry newPastry = new Pastry(pastryPrice, pastryAmount);

      int amount = newPastry.PastryAmount;

      Assert.AreEqual(pastryAmount, amount);
    }
  }
}