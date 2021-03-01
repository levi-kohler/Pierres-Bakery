using System;
using Bakery.Models;

namespace Program
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("Single loaves of bread are $5 and single pastries are $2");
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("********************");
      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine("Today's deals are:");
      Console.WriteLine("- Buy 2 loaves of bread and get the third free!");
      Console.WriteLine("- Buy 3 pastries for $5!");
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("********************");
      Console.ForegroundColor = ConsoleColor.White;

      Console.WriteLine("How many loaves of bread would you like to purchase?");
      string userBread = Console.ReadLine();
      int intUserBread = int.Parse(userBread);

      Console.WriteLine("How many pastries would you like to purchase?");
      string userPastry = Console.ReadLine();
      int intUserPastry = int.Parse(userPastry);

      if (intUserBread >= 0 && intUserPastry >= 0)
      {
        Bread userBreadCart = new Bread(5, intUserBread);
        Pastry userPastryCart = new Pastry(2, intUserPastry);
        Console.WriteLine("Your total price for bread is: $"+userBreadCart.BreadCost()+".");
        Console.WriteLine("Your total price for pastries is: $"+userPastryCart.PastryCost()+".");
        Console.WriteLine("Your final total today comes out to: $"+(userBreadCart.BreadCost()+(userPastryCart.PastryCost())));
      }
      else
      Console.Write("Please insert a valid number for bread and/or pastries");

    }
  }
}