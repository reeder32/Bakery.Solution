using System;
using Items.Models;
class Bakery
{
  static void Main()
  {
    Console.WriteLine("Welcome to Nick's Bakery...What can we get you today?");
    Console.Write("Our specials today are for every 2 loaves of bread you buy, the 3rd one is free, and save $1 for every 3 pastries you buy. What would you like to buy today?");
    Console.WriteLine("Type 'b' for Bread 'p' for Pastry or 'a' for both");
    string input = Console.ReadLine();
    Order newOrder = GetOrderWith(input);

    Order GetOrderWith(string input)
    {
      Bread bread = new Bread(0);
      Pastry pastry = new Pastry(0);
      if (input.ToLower() == "b")
      {
        Console.Write("How many loaves of bread would you like?");
        int numberOfLoaves = int.Parse(Console.ReadLine());
        bread.AddItem(numberOfLoaves);
      }
      else if (input.ToLower() == "p")
      {
        Console.Write("How many pastries would you like?");
        int numberOfPastries = int.Parse(Console.ReadLine());
        pastry.AddItem(numberOfPastries);
      }
      else if (input.ToLower() == "a")
      {
        Console.WriteLine("Let's start with the bread. How many loaves today?");
        int numberOfLoaves = int.Parse(Console.ReadLine());
        bread.AddItem(numberOfLoaves);
        Console.Write("And how many pastries?");
        int numberOfPastries = int.Parse(Console.ReadLine());
        pastry.AddItem(numberOfPastries);
      }
      else
      {
        Console.WriteLine("That input is not recognized. Maybe try the deli down the street...Would you like to start again (y/n)");
        string response = Console.ReadLine();
        if (response.ToLower() == "y")
        {
          Main();
        }
        else
        {
          Console.WriteLine("Alright. See you later!!");
        }
      }
      return new Order(bread, pastry);
    }
  }

}