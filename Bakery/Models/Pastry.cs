using System.Collections.Generic;

namespace Items.Models
{
  public class Pastry : IBakeryItem
  {
    private static int _numberOfPastries { get; set; }
    private static int _itemPrice { get; set; } = 2;
    public Pastry(int numberOfPastries)
    {
      _numberOfPastries = numberOfPastries;
    }

    public int GetItemQuantity()
    {
      return _numberOfPastries;
    }

    public void AddItem(int quantity)
    {
      _numberOfPastries += quantity;
    }

    public void RemoveItem(int quantity)
    {
      if (quantity > _numberOfPastries)
      {
        _numberOfPastries = 0;
      }
      else
      {
        _numberOfPastries -= quantity;
      }

    }

    public int GetPrice()
    {
      return _numberOfPastries * _itemPrice;
    }

    public int ApplyDiscount()
    {
      if (_numberOfPastries > 2)
      {
        int discountPrice = _numberOfPastries / 3;
        return discountPrice;
      }
      else
      {
        return 0;
      }
    }
  }
}