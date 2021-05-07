using System.Collections.Generic;

namespace Items.Models
{
  public class Bread : IBakeryItem
  {
    private static int _numberOfLoaves { get; set; }
    private static int _itemPrice { get; set; } = 5;
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
      if (quantity >= _numberOfLoaves)
      {
        _numberOfLoaves = 0;
      }
      else
      {
        _numberOfLoaves -= quantity;
      }

    }

    public int GetPrice()
    {
      return _numberOfLoaves * _itemPrice;
    }

    public int ApplyDiscount()
    {
      if (_numberOfLoaves > 2)
      {
        int discountPrice = _numberOfLoaves / 3;
        return discountPrice * 5;
      }
      else
      {
        return 0;
      }
    }
  }
}