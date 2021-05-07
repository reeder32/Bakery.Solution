namespace Items.Models
{
  public class Order
  {
    public Order(Bread breadOrder, Pastry pastryOrder)
    {
      _breadOrder = breadOrder;
      _pastryOrder = pastryOrder;
    }
    private Bread _breadOrder { get; set; }
    private Pastry _pastryOrder { get; set; }


    public int GetBreadOrder()
    {
      return _breadOrder.GetItemQuantity();
    }
    public int GetPastryOrder()
    {
      return _pastryOrder.GetItemQuantity();
    }

    public void RemoveBreadItem(int quantity)
    {
      _breadOrder.RemoveItem(quantity);
    }

    public void RemovePastryItem(int quantity)
    {
      _pastryOrder.RemoveItem(quantity);
    }

    public void AddBreadItem(int quantity)
    {
      _breadOrder.AddItem(quantity);
    }

    public void AddPastryItem(int quantity)
    {
      _pastryOrder.AddItem(quantity);
    }

    public int GetOrderPrice()
    {
      int originalBreadPrice = _breadOrder.GetPrice();
      int originalPastryPrice = _pastryOrder.GetPrice();
      int discountBreadPrice = originalBreadPrice - _breadOrder.ApplyDiscount();
      int discountPastryPrice = originalPastryPrice - _pastryOrder.ApplyDiscount();
      return discountBreadPrice + discountPastryPrice;
    }

  }
}

