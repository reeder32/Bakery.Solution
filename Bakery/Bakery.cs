using System;
using Items.Models;
class Bakery
{
  static void Main()
  {
    Console.WriteLine("Welcome to Nick's Bakery...What can we get you today?");
    Console.WriteLine("Our specials today are for every 2 loaves of bread you buy, the 3rd one is free, and save $1 for every 3 pastries you buy.");
    Console.WriteLine("Type 'b' for Bread 'p' for Pastry or 'a' for both");
    string input = Console.ReadLine();
    Order newOrder = GetOrderWith(input);
    Console.WriteLine("Would you like to check out? (y/n)");
    string reply = Console.ReadLine();
    if (reply.ToLower() == "y")
    {
      string orderTotalString = newOrder.GetOrderPrice().ToString();
      Console.WriteLine("Your total is ${0}", orderTotalString);
    }
    else
    {
      newOrder = ReviseOrder(newOrder);
      string orderTotalString = newOrder.GetOrderPrice().ToString();
      Console.WriteLine("Your new total is ${0}", orderTotalString);
    }
    Main();

  }

  static Order ReviseOrder(Order order)
  {
    Console.WriteLine("Would you like to add or remove items from your order?");
    Console.WriteLine("You can add items by typing 'b+' for bread or 'p+' for pastries");
    Console.WriteLine("Or you can type 'b- ' for removing bread or 'p-' for pastries");
    Console.WriteLine("Or 'e' for exit");
    string reply = Console.ReadLine();
    if (reply.ToLower() == "e")
    {
      return order;
    }
    else
    {
      if (reply.ToLower().Contains("b-"))
      {
        Console.Write("How many loaves or bread are we removing? ");
        int quantity = int.Parse(Console.ReadLine());
        order.RemoveBreadItem(quantity);
        ReviseOrder(order);
      }
      else if (reply.ToLower().Contains("b+"))
      {
        Console.Write("How many loaves of bread are we adding? ");
        int quantity = int.Parse(Console.ReadLine());
        order.AddBreadItem(quantity);
        ReviseOrder(order);
      }
      else if (reply.ToLower().Contains("p-"))
      {
        Console.Write("How many pastries are we removing? ");
        int quantity = int.Parse(Console.ReadLine());
        order.RemovePastryItem(quantity);
        ReviseOrder(order);
      }
      else if (reply.ToLower().Contains("p+"))
      {
        Console.Write("How many pastries are we adding? ");
        int quantity = int.Parse(Console.ReadLine());
        order.AddPastryItem(quantity);
        ReviseOrder(order);
      }
      else
      {
        Console.WriteLine("That input is not recognized...");
        ReviseOrder(order);
      }
    }


    return order;

  }

  static Order GetOrderWith(string input)
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