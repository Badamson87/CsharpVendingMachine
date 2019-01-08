using vendingMachine.Interfaces;

namespace vendingMachine.Models
{
  class Food : Consumable, IPurchasable
  {

    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Grid { get; set; }
    public Food(int calories, string healthy) : base(calories, healthy)
    {
    }
  }
}
