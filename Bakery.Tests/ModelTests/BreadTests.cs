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
      Bread newBread = new Bread(5, 1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void BreadPrice_ReturnPriceOfOneLoaf_Int()
    {
      int breadPrice = 5;
      int breadAmount = 1;
      Bread newBread = new Bread(breadPrice, breadAmount);

      int result = newBread.BreadPrice;

      Assert.AreEqual(breadPrice, result);
    }

    [TestMethod]
    public void BreadAmount_ReturnAmountOfLoaves_Int()
    {
      int breadPrice = 5;
      int breadAmount = 3;
      Bread newBread = new Bread(breadPrice, breadAmount);

      int amount = newBread.BreadAmount;

      Assert.AreEqual(breadAmount, amount);
    }

        [TestMethod]
    public void BreadPrice_ReturnPriceOfThreeLoaves_Int()
    {
      int breadPrice = 5;
      int breadAmount = 8;

      Bread newBread = new Bread(breadPrice, breadAmount);

      int totalPrice = newBread.BreadCost();

      Assert.AreEqual(30, totalPrice);
    }



  }
}