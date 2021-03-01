namespace Bakery.Models
{
  public class Pastry
  {
    public int PastryPrice { get; set; }
    public int PastryAmount { get; set; }
    public int TotalPastryPrice { get; set; }

    public Pastry(int pastryPrice, int pastryAmount)
    {
      PastryPrice = pastryPrice;
      PastryAmount = pastryAmount;
    }

    public int PastryCost()
    {
      int pastryPrice = 2;

      if (PastryAmount % 3 == 0)
      {
        return ((PastryAmount/3) * 5);
      }
      else if (PastryAmount < 3)
      {
        return (pastryPrice * PastryAmount);
      }  
      else if ((PastryAmount - 1) % 3 == 0)
      {
        return ((PastryAmount - 1) / 3) * 5 + pastryPrice;
      }
      else
      {
        return ((PastryAmount - 2) / 3)* 5 + (PastryPrice + 2);
      }
    }

    public int GetPastryCost()
    {
      PastryCost();
      return TotalPastryPrice;
    }
  }
}