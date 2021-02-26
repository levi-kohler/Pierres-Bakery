using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadPriceTests
  {
  
    [TestMethod]
    public void BreadConstructor_CreateInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(5);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

      [TestMethod]
      public void BreadPrice_ReturnPriceOfOneLoaf_Int()
    {
      int breadPrice = 5;
      Bread newBread = new Bread(breadPrice);

      int result = newBread.BreadPrice;

      Assert.AreEqual(breadPrice, result);
    }

  }
}