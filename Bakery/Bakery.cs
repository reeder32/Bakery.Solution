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
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    if (reply.ToLower() == "y")
    {
      string orderTotalString = newOrder.GetOrderPrice().ToString();
      Console.WriteLine("\nYour total is ${0}\n", orderTotalString);
    }
    else
    {
      newOrder = ReviseOrder(newOrder);
      string orderTotalString = newOrder.GetOrderPrice().ToString();
      Console.WriteLine("\nYour new total is ${0}\n", orderTotalString);
    }

    StartOver();
  }

  static void StartOver()
  {
    Console.ResetColor();
    Console.WriteLine("Would you like to start again? (y/n)");
    string reply = Console.ReadLine();
    if (reply == "y")
    {

      Main();
    }
    else
    {
      Console.WriteLine("See ya later!");
      Environment.Exit(0);
    }
  }

  static Order ReviseOrder(Order order)
  {
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Would you like to add or remove items from your order?");
    Console.WriteLine("You can add items by typing 'b+' for bread or 'p+' for pastries");
    Console.WriteLine("Or you can type 'b- ' for removing bread or 'p-' for pastries");
    Console.WriteLine("Or 'done' for exit");
    string reply = Console.ReadLine();
    if (reply.ToLower() == "done")
    {
      return order;
    }
    else
    {
      if (reply.ToLower().Contains("b-"))
      {
        Console.Write("How many loaves or bread are we removing? ");
        try
        {
          int quantity = int.Parse(Console.ReadLine());
          order.RemoveBreadItem(quantity);
          ReviseOrder(order);
        }
        catch (Exception ex)
        {
          HandleError(ex.Message);
        }

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
        try
        {
          int quantity = int.Parse(Console.ReadLine());
          order.RemovePastryItem(quantity);
          ReviseOrder(order);
        }
        catch (Exception ex)
        {
          HandleError(ex.Message);
        }

      }
      else if (reply.ToLower().Contains("p+"))
      {
        Console.Write("How many pastries are we adding? ");
        try
        {
          int quantity = int.Parse(Console.ReadLine());
          order.AddPastryItem(quantity);
          ReviseOrder(order);
        }
        catch (Exception ex)
        {
          HandleError(ex.Message);
        }

      }
      else
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("That input is not recognized...");
        ReviseOrder(order);
      }
    }


    return order;

  }

  static void HandleError(string message)
  {
    HandleError(message);
  }
  static Order GetOrderWith(string input)
  {
    Console.ForegroundColor = ConsoleColor.Magenta;
    Bread bread = new Bread(0);
    Pastry pastry = new Pastry(0);
    if (input.ToLower() == "b")
    {
      Console.Write("How many loaves of bread would you like?");
      try
      {
        int numberOfLoaves = int.Parse(Console.ReadLine());
        bread.AddItem(numberOfLoaves);
      }
      catch (Exception ex)
      {
        HandleError(ex.Message);
      }

    }
    else if (input.ToLower() == "p")
    {
      Console.Write("How many pastries would you like?");
      try
      {
        int numberOfPastries = int.Parse(Console.ReadLine());
        pastry.AddItem(numberOfPastries);
      }
      catch (Exception ex)
      {
        Console.ForegroundColor = ConsoleColor.Red;
        HandleError(ex.Message);
      }

    }
    else if (input.ToLower() == "a")
    {
      Console.WriteLine("Let's start with the bread. How many loaves today?");
      try
      {
        int numberOfLoaves = int.Parse(Console.ReadLine());
        bread.AddItem(numberOfLoaves);
      }
      catch (Exception ex)
      {
        HandleError(ex.Message);
      }

      Console.Write("And how many pastries? ");
      try
      {
        int numberOfPastries = int.Parse(Console.ReadLine());
        pastry.AddItem(numberOfPastries);
      }
      catch (Exception ex)
      {
        HandleError(ex.Message);
      }

    }
    else
    {
      Console.ForegroundColor = ConsoleColor.Red;
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