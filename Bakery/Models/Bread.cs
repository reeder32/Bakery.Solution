using System.Collections.Generic;

namespace Items.Models
{
  public class Bread : IBakeryItem
  {
    private static int _numberOfLoaves { get; set; }
    private static int _itemPrice { get; set; } = 3;
    public Bread(int numberOfLoaves)
    {
      _numberOfLoaves = numberOfLoaves;
    }

    public int GetItemQuantity()
    {
      return _numberOfLoaves;
    }

    public void AddItem(int quantity)
    {
      _numberOfLoaves += quantity;
    }

    public void RemoveItem(int quantity)
    {
      _numberOfLoaves -= quantity;
    }

    public int GetPrice()
    {
      return _numberOfLoaves * _itemPrice;
    }
  }
}