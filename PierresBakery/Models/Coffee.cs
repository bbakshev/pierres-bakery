namespace PierresBakery.Models
{
  public class Coffee
  {
    public int NumberOfCofees {get; set;}
    public decimal CostPerCoffee {get;} = 2.5m;

    public decimal TotalCostCoffee()
    {
      return NumberOfCofees * CostPerCoffee;
    }

  }
}