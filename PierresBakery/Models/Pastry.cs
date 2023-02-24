namespace PierresBakery.Models
{
  public class Pastry
  {
    public int NumberOfPastries {get; set;}

    public double TotalCostPastry()
    {
      int singlePastry = NumberOfPastries % 4;
      return singlePastry * 2;
    }
  }
}