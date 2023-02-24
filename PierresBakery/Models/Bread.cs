namespace PierresBakery.Models
{
  public class Bread
  {
    public int NumberOfLoaves{get; set;}

    public double TotalCost()
    {
      int singleLoafOfBread = NumberOfLoaves % 3;
      return singleLoafOfBread * 5;
    }
  }
}