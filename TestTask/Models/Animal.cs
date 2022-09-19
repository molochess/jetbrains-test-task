using Task.Models.Enums;

namespace Task.Models
{
    public class Animal:IAnimal
    {
        /// <summary>
        /// Public property that implements interface property
        /// </summary>
        public String Name { get; set; }
        /// <summary>
        /// Public property that implements interface property
        /// </summary>
        public Specieses Species { get; set; }
        /// <summary>
        /// Public property 
        /// </summary>
        public int Age { get; }
        /// <summary>
        /// Private property
        /// </summary>
        private List<IFood> Foods { get; set; }
        /// <summary>
        /// Protected property
        /// </summary>
        protected String OwnerName { get; set; }
        
        /// <summary>
        /// Class constructor with params
        /// </summary>
        public Animal(String name, Specieses species, int age, String ownerName)
        {
            Name = name;
            Species = species;
            Age = age;
            Foods = new List<IFood>();
            OwnerName = ownerName;
        }
        
        ///<summary>
        /// Public method with void response
        /// </summary>
        public void AddFood(IFood food)
        {
            Foods.Add(food);
        }

        ///<summary>
        /// Private method with simple type response
        /// </summary>
        private bool RemoveFood(String name)
        {
            try
            {
               var food = Foods.Find(_ => _.Name == name);
               return Foods.Remove(food);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine($"Element with name: {name} doesn't exist in current context.");
                throw;
            }
        }
        
        ///<summary>
        /// Method that override standard object function
        /// </summary>
        public override string? ToString()
        {
            return $"{Name} is a {Age} years old {Species}.";
        }

        /// <summary>
        /// Method that always throw an exception
        /// </summary>
        /// <exception cref="Exception">NotImplementedException</exception>
        public String OwnerContacts()
        {
            throw new NotImplementedException();
        }

    }

}