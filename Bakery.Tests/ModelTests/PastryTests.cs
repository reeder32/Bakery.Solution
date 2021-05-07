using Microsoft.VisualStudio.TestTools.UnitTesting;
using Items.Models;

namespace PastryModels.Tests
{
  [TestClass]

  public class PastryModelsTests
  {
    [TestMethod]

    public void PastryShouldBeInitializedWithCorrectQuantity_Int()
    {
      int numberOfPastries = 2;
      Pastry Pastry = new Pastry(numberOfPastries);
      int result = Pastry.GetItemQuantity();

      Assert.AreEqual(numberOfPastries, result);
    }

    [TestMethod]

    public void ShouldBeAbleToAddPastryLoaves_Int()
    {
      int numberOfPastries = 2;
      Pastry Pastry = new Pastry(numberOfPastries);
      Pastry.AddItem(numberOfPastries);

      int result = Pastry.GetItemQuantity();

      Assert.AreEqual(4, result);
    }

    [TestMethod]

    public void ShouldBeAbleToRemovePastryLoaves_Int()
    {
      int numberOfPastries = 2;
      Pastry Pastry = new Pastry(numberOfPastries);
      Pastry.RemoveItem(numberOfPastries);

      int result = Pastry.GetItemQuantity();

      Assert.AreEqual(0, result);
    }

    [TestMethod]

    public void ShouldGetPriceForQuantiy_Int()
    {
      int numberOfPastries = 2;
      Pastry Pastry = new Pastry(numberOfPastries);


      int result = Pastry.GetPrice();

      Assert.AreEqual(4, result);
    }

    [TestMethod]

    public void ShouldApplyDiscountWhenPurchasingInMultiplesOfThree_Int()
    {
      int numberOfPastries = 3;
      Pastry Pastry = new Pastry(numberOfPastries);


      int price = Pastry.GetPrice();
      int discount = Pastry.ApplyDiscount();

      int result = price - discount;
      Assert.AreEqual(5, result);
    }
  }
}