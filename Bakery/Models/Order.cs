namespace Items.Models
{
  public class Order
  {
    private Bread _breadOrder { get; set; }
    private Pastry _pastryOrder { get; set; }

    private int _orderPrice { get; set; }

    public Order(Bread breadOrder, Pastry pastryOrder)
    {
      _breadOrder = breadOrder;
      _pastryOrder = pastryOrder;
    }

  }
}