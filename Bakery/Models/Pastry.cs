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
  }
}