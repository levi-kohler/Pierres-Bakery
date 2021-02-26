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

      else 
      {
        return (pastryPrice * PastryAmount);
      }  
    }

    public int GetPastryCost()
    {
      PastryCost();
      return TotalPastryPrice;
    }
  }
}