namespace Pierres
{
  public class Bread
  {
    public int LoafCount { get; set;}
    
    public Bread(int aLoafCount)
    {
      LoafCount = aLoafCount;
    } 
    public int LoafPricing()
    {
      int price = LoafCount * 6;
      return price;
    }

  }
}