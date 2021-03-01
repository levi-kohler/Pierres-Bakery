namespace Bakery.Models
{
  public class Bread
  {
    public int BreadPrice { get; set; }
    public int BreadAmount { get; set; }
    public int TotalBreadPrice { get; set; }

    public Bread(int breadPrice, int breadAmount)
    {
      BreadPrice = breadPrice;
      BreadAmount = breadAmount;
    }

    public int BreadCost()
    {
      int breadPrice = 5;

      if (BreadAmount % 3 == 0)
      {
        return (breadPrice * BreadAmount) - ((BreadAmount/3) * breadPrice);
      }
      else if (BreadAmount < 3)
      {
        return (breadPrice * BreadAmount);
      }  
      else if ((BreadAmount - 1) % 3 == 0)
      {
        return (breadPrice * (BreadAmount - 1))-((BreadAmount/3) * breadPrice) + breadPrice;
      }
      else
      {
        return (breadPrice * (BreadAmount - 2))-((BreadAmount/3) * breadPrice) + (breadPrice * 2);
      }
    }

    public int GetBreadCost()
    {
      BreadCost();
      return TotalBreadPrice;
    }
  }
}