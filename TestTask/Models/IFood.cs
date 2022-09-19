namespace Task.Models
{

    public interface IFood
    {
        String Name { get; }
        int? Amount { get; set; }
        bool isPlant { get; set; }
    }
}