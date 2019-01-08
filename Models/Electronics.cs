using vendingMachine.Interfaces;

namespace vendingMachine.Models
{
  class Electronics : IPurchasable
  {
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Grid { get; set; }
    public string Maker { get; set; }
    public bool Watch { get; set; }

    public Electronics(string maker, bool watch)
    {
      Maker = maker;
      Watch = watch;
    }


  }
}