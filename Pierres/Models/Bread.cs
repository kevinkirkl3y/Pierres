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
      if (LoafCount == 1) 
      {
      int price = LoafCount * 5;
      return price;
      }
      else 
      {
        int price = ((LoafCount/3) * 11) + ((LoafCount % 3) * 5);
        return price;
      }
    }

  }
}