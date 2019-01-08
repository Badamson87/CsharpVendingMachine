namespace vendingMachine.Interfaces
{
  interface IPurchasable
  {
    string Name { get; set; }
    decimal Price { get; set; }
    string Grid { get; set; }
  }
}