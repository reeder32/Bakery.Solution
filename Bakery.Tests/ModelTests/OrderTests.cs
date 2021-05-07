using Microsoft.VisualStudio.TestTools.UnitTesting;
using Items.Models;

namespace OrderModel.Tests
{
  [TestClass]

  public class OrderModelTests
  {
    [TestMethod]

    public void OrderShouldInStntiateWithBreadAndPastryOrder_Int()
    {
      int numberOfLoaves = 2;
      Bread bread = new Bread(numberOfLoaves);
      Pastry pastry = new Pastry(numberOfLoaves);

      Order order = new Order(bread, pastry);

      Assert.AreEqual(4, order.GetBreadOrder() + order.GetPastryOrder());
    }

  }
}