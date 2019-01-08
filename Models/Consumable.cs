namespace vendingMachine.Models
{
  abstract class Consumable
  {
    public int Calories { get; set; }
    public string Healthy { get; set; }



    public Consumable(int calories, string healthy)
    {
      Calories = calories;
      Healthy = healthy;


    }


  }
}