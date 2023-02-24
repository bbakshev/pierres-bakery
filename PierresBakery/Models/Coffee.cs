namespace PierresBakery.Models
{
  public class Coffee
  {
    public int NumberOfCofees {get; set;}
    public decimal CostPerCoffee {get; set;}

    public decimal TotalCostCoffee()
    {
      return NumberOfCofees * CostPerCoffee;
    }

  }
}