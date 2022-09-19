using Task.Models.Enums;

namespace Task.Models
{
    interface IAnimal
    {
        String Name { get; }
        Specieses Species { get; set; }
        
    }

}