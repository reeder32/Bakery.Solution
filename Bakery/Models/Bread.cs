using System.Collections.Generic;

namespace Items.Models
{
  public class Bread
  {
    private static int _numberOfLoaves { get; set; }

    public Bread(int numberOfLoaves)
    {
      _numberOfLoaves = numberOfLoaves;
    }

    public int getNumberOfLoaves()
    {
      return _numberOfLoaves;
    }

  }
}