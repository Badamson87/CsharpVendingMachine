namespace vendingMachine.Models
{
  class VendingMachine
  {
    public string Name { get; set; }
    public Dictionary<string, List<Item>> Items { get; private set; }

    public List<IPurchasable> Inventory { get; set; }

    public void AddItem(string type, Item purchasable)
    {
      if (!Items.ContainsKey(type))
      {
        Items.Add(type, new List<Item>());
      }
      Items[type].Add(purchasable);
    }

  }
}