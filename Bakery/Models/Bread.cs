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

    public int GetNumberOfLoaves()
    {
      return _numberOfLoaves;
    }

    public void AddToLoaves(int numberOfLoaves)
    {
      _numberOfLoaves += numberOfLoaves;
    }

    public int RemoveLoaves(int numberOfLoaves)
    {
      return numberOfLoaves;
    }
  }
}