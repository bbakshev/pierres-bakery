namespace PierresBakery.Models
{
  public class Bread
  {
    public int NumberOfLoaves{get; set;}

    public double TotalCostBread()
    {
      int singleLoafOfBread = NumberOfLoaves % 3;
      int multipleLoavesOfBread = NumberOfLoaves / 3;

      return (multipleLoavesOfBread * 2 * 5) + (singleLoafOfBread * 5);
    }
  }
}