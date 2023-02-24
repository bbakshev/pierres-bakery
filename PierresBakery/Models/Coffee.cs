namespace PierresBakery.Models
{
  public class Coffee
  {
    public int NumberOfCofees {get; set;}
    public decimal CostPerCoffe {get; set;}

    public decimal TotalCostCoffee()
    {
      return NumberOfCofees * CostPerCoffe;
    }

  }
}