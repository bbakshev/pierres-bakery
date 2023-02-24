namespace PierresBakery.Models
{
  public class Pastry
  {
    public int NumberOfPastries {get; set;}

    public double TotalCostPastry()
    {
      int singlePastry = NumberOfPastries % 4;
      int multiplePastries = NumberOfPastries / 4;
      return (multiplePastries * 3 * 2) + (singlePastry * 2);
    }
  }
}