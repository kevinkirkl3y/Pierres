using System;
using Pierres.Models;

namespace Pierres
{

  public class Program
  {
    public static void Main()
    {
      Greeting();
      int Price = 0;
      string response = Console.ReadLine();
      if (response == "bread" || response == "Bread")
      {
        BreadOrder(0);
      }
      else if (response == "pastry" || response == "Pastry")
      {
        PastryOrder(0);
      }
    }
    public static void Greeting()
    {
      Console.WriteLine("--------------------------------------------------------------------");
      Console.WriteLine("Welcome to Pierres' Bakery. Purveyor of fine baguettes and pastries.");
      Console.WriteLine("--------------------------------------------------------------------");
      Console.WriteLine("We currently are running the following specials:");
      Console.WriteLine("Baguettes are $5 a peice, buy 2 get one free. Pastries are $2 individually and 3 for $5.");
      Console.WriteLine("--------------------------------------------------------------------");
      Console.WriteLine("What would you like to order? (bread/pastry)");
    }
    
    public static void BreadOrder(int total)
    {
      Console.WriteLine("Of course! How many baguettes would you like? (enter number: Ex.'5')");
      int loafCount = int.Parse(Console.ReadLine());
      Bread breadOrder = new Bread(loafCount);
      Console.WriteLine("Okay, I have you down for " + loafCount + " of our fresh baguettes.");
      Console.WriteLine("Can I get you any pastries or would you like to view your total? (pastry/total)");
      int breadPrice = breadOrder.LoafPricing();
      total += breadOrder.LoafPricing();
      string strBreadPrice = total.ToString();
      string response = Console.ReadLine();
      
      if (response == "pastry" || response == "Pastry")
      {
        Console.WriteLine("Your total for bread is $" + strBreadPrice);
        PastryOrder(total);
      }
      else if (response == "total" || response == "Total")
      {
        Console.WriteLine("Your total for bread is $" + strBreadPrice);
        OrderTotal(total);
      }  
    }
    public static void PastryOrder(int total)
    {
      Console.WriteLine("Of course! How many pastries would you like? (enter number: Ex.'5')");
      int pastryCount = int.Parse(Console.ReadLine());
      Pastry pastryOrder = new Pastry(pastryCount);
      Console.WriteLine("Okay, I have you down for " + pastryCount + " of our fresh pastries.");
      Console.WriteLine("Can I get you any baguettes or would you like to view your total? (bread/total)");
      string response = Console.ReadLine();
      int pastryPrice = pastryOrder.PastryPricing();
      total += pastryOrder.PastryPricing();
      string strPastryPrice = total.ToString();
      if (response == "bread" || response == "Bread")
      {
        Console.WriteLine("Your total for pastries is $" + strPastryPrice);
        BreadOrder(total);
        
      }
      else if (response == "total" || response == "Total")
      {
        Console.WriteLine("Your total for pastries is $" + strPastryPrice);
        OrderTotal(total);
      }
    }
    public static void OrderTotal(int total)
    {
      Console.WriteLine("Your total for both baguettes and pastries is $" + total);
    }
  }
}