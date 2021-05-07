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
      int result = bread.GetNumberOfLoaves();

      Assert.AreEqual(numberOfLoaves, result);
    }

    [TestMethod]

    public void ShouldBeAbleToAddBreadLoaves_Int()
    {
      int numberOfLoaves = 2;
      Bread bread = new Bread(numberOfLoaves);
      bread.AddToLoaves(numberOfLoaves);

      int result = bread.GetNumberOfLoaves();

      Assert.AreEqual(4, result);
    }

    [TestMethod]

    public void ShouldBeAbleToRemoveBreadLoaves_Int()
    {
      int numberOfLoaves = 2;
      Bread bread = new Bread(numberOfLoaves);
      bread.RemoveLoaves(numberOfLoaves);

      int result = bread.GetNumberOfLoaves();

      Assert.AreEqual(0, result);
    }
  }
}