namespace Task.Models
{

    public class ComercialFood : IFood
    {
        public string Name { get; set; }
        public int? Amount { get; set; }
        public bool isPlant { get; set; }
        public bool IsHolistic { get; }

        public ComercialFood(string name, bool isPlant, int? amount, bool isHolistic)
        {
            Name = name;
            this.isPlant = isPlant;
            Amount = amount;
            IsHolistic = isHolistic;
        }
    }
}