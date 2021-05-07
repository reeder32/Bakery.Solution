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

    private int _orderPrice { get; set; }


    // public  int GetOrderPrice()
    // {
    //   int originalBreadPrice = _breadOrder.GetPrice();
    //   int originalPastryPrice = _pastryOrder.GetPrice();
    //   return originalBreadPrice.ApplyDiscount() + originalPastryPrice.ApplyDiscount();
    // }

  }
}

