using Microsoft.VisualStudio.TestTools.UnitTesting;
using Items.Models;

namespace BreadModels.Tests
{
  [TestClass]

  public class BreadModelTests
  {
    [TestMethod]

    public void BreadShouldBeInitializedWithCorrectQuantity_Int()
    {
      int numberOfLoaves = 2;
      Bread bread = new Bread(numberOfLoaves);
      int result = bread.GetItemQuantity();

      Assert.AreEqual(numberOfLoaves, result);
    }

    [TestMethod]

    public void ShouldBeAbleToAddBreadLoaves_Int()
    {
      int numberOfLoaves = 2;
      Bread bread = new Bread(numberOfLoaves);
      bread.AddItem(numberOfLoaves);

      int result = bread.GetItemQuantity();

      Assert.AreEqual(4, result);
    }

    [TestMethod]

    public void ShouldBeAbleToRemoveBreadLoaves_Int()
    {
      int numberOfLoaves = 2;
      Bread bread = new Bread(numberOfLoaves);
      bread.RemoveItem(numberOfLoaves);

      int result = bread.GetItemQuantity();

      Assert.AreEqual(0, result);
    }

    [TestMethod]

    public void ShouldGetPriceForQuantiy_Int()
    {
      int numberOfLoaves = 2;
      Bread bread = new Bread(numberOfLoaves);


      int result = bread.GetPrice();

      Assert.AreEqual(0, result);
    }
  }
}