using Task.Models;
using Task.Models.Enums;

class TestTask
{
    public static int Main(string[] args)
    {
        // evaluating expressions
        // uninitialized variable
        double uninitVar;
        // initialized variable without type
        var initVar = "Anna";
        // uninitialized array
        double[] emptyArray;
        // initialized array
        int[] filledArray = { 1, 2, 3, 5, 6, 7, 8, 9};
        
        var petName = "Kitty";
        var petSpecies = Specieses.CAT;
        int petAge = 8;
        
        //instantiation of Animal class object
        var pet = new Animal(petName, petSpecies, petAge, initVar);
        
        // simple function with args
        static int SimpleFunctionWithArgs(int a, int b)
        {
            return a + b;
        }
        return 0;
    }
}