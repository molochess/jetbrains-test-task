namespace Task.Models;

public class NaturalFood:IFood
{
    public string Name { get; set; }
    public bool isPlant { get; set; }
    public int? Amount { get; set; }
    
    public NaturalFood(string name, bool isPlant, int? amount)
    {
        Name = name;
        this.isPlant = isPlant;
        Amount = amount;
    }
}