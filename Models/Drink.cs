using vendingMachine.Interfaces;

namespace vendingMachine.Models
{
  class Drink : Consumable, IPurchasable
  {
    public Drink(int calories, string healthy) : base(calories, healthy)
    {
    }

    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Grid { get; set; }



  }
}