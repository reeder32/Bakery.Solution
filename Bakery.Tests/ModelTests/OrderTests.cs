using Microsoft.VisualStudio.TestTools.UnitTesting;
using Items.Models;

namespace OrderModel.Tests
{
  [TestClass]

  public class OrderModelTests
  {
    [TestMethod]

    public void OrderShouldInStantiateWithBreadAndPastryOrder_Int()
    {
      int numberOfLoaves = 2;
      Bread bread = new Bread(numberOfLoaves);
      Pastry pastry = new Pastry(numberOfLoaves);

      Order order = new Order(bread, pastry);

      Assert.AreEqual(4, order.GetBreadOrder() + order.GetPastryOrder());
    }

    [TestMethod]

    public void OrderShouldReturnPriceForBreadAndPastry_Int()
    {
      int numberOfLoaves = 2;
      Bread bread = new Bread(numberOfLoaves);
      Pastry pastry = new Pastry(numberOfLoaves);

      Order order = new Order(bread, pastry);

      int result = order.GetOrderPrice();
      Assert.AreEqual(14, result);
    }

    [TestMethod]

    public void OrderShouldReturnPriceForBreadAndPastryOrderGreaterThanTwo_Int()
    {
      int numberOfLoaves = 3;
      Bread bread = new Bread(numberOfLoaves);
      Pastry pastry = new Pastry(numberOfLoaves);

      Order order = new Order(bread, pastry);

      int result = order.GetOrderPrice();
      Assert.AreEqual(15, result);
    }

    [TestMethod]

    public void OrderShouldRemoveBreadItem_Int()
    {
      int numberOfLoaves = 3;
      Bread bread = new Bread(numberOfLoaves);
      Pastry pastry = new Pastry(numberOfLoaves);

      Order order = new Order(bread, pastry);

      order.RemoveBreadItem(1);

      int result = order.GetBreadOrder();
      Assert.AreEqual(2, result);
    }

    [TestMethod]

    public void OrderShouldRemovePastry_Int()
    {
      int numberOfLoaves = 3;
      Bread bread = new Bread(numberOfLoaves);
      Pastry pastry = new Pastry(numberOfLoaves);

      Order order = new Order(bread, pastry);

      order.RemovePastryItem(1);

      int result = order.GetPastryOrder();
      Assert.AreEqual(2, result);
    }

    [TestMethod]

    public void OrderShouldAddBread_Int()
    {
      int numberOfLoaves = 3;
      Bread bread = new Bread(numberOfLoaves);
      Pastry pastry = new Pastry(numberOfLoaves);

      Order order = new Order(bread, pastry);

      order.AddBreadItem(3);

      int result = order.GetBreadOrder();
      Assert.AreEqual(6, result);
    }

    [TestMethod]

    public void OrderShouldAddPastry_Int()
    {
      int numberOfLoaves = 3;
      Bread bread = new Bread(numberOfLoaves);
      Pastry pastry = new Pastry(numberOfLoaves);

      Order order = new Order(bread, pastry);

      order.AddPastryItem(3);

      int result = order.GetPastryOrder();
      Assert.AreEqual(6, result);
    }

    [TestMethod]

    public void GetOriginalPrice_OrderShouldReturnOriginalPriceBeforeDiscount_21()
    {
      int numberOfLoaves = 3;
      Bread bread = new Bread(numberOfLoaves);
      Pastry pastry = new Pastry(numberOfLoaves);

      Order order = new Order(bread, pastry);

      order.AddPastryItem(3);

      int result = order.GetOrginalPrice();
      Assert.AreEqual(21, result);
    }

  }
}