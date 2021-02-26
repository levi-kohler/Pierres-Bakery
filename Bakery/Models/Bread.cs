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
      int singleLoaf = 5;

      if (BreadAmount % 3 == 0)
      {
        return (singleLoaf * BreadAmount) - ((BreadAmount/3) * singleLoaf);
      }

      else 
      {
        return (singleLoaf * BreadAmount);
      }  
    }

    public int GetBreadCost()
    {
      BreadCost();
      return TotalBreadPrice;
    }
  }
}