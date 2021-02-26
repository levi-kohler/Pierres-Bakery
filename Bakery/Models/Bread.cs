namespace Bakery.Models
{
  public class Bread
  {
    public int BreadPrice { get; }
    public int BreadAmount { get; }

    public Bread(int breadPrice, int breadAmount)
    {
      BreadPrice = breadPrice;
      BreadAmount = breadAmount;
    }
  }
}