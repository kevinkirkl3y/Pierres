namespace Pierres.Models
{
  public class Pastry
  {
    public int PastryCount { get; set; }
    
    public Pastry(int aPastryCount)
    {
      PastryCount = aPastryCount;
    }
    public int PastryPricing()
    {
      if (PastryCount == 1)
      {
        int price = PastryCount * 2;
        return price;
      }
      else
      {
       int price = (PastryCount * 2) - ((PastryCount / 3)); 
      return price;
      }      
    }
  }
}