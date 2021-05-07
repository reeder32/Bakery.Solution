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

      int result = bread.getNumberOfLoaves();

      Assert.AreEqual(numberOfLoaves, result);
    }
  }
}