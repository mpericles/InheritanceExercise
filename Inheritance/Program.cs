using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class

            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            //to create an object is the same as creating an instance
            Bird pigeon = new Bird();
            pigeon.CanFly = true;
            pigeon.CanSwim = true;
            pigeon.Hasfeathers = true;
            pigeon.LandAnimal = true;

            //Display the values
            Console.WriteLine($" My Pigeon can Fly: {pigeon.CanFly} and can swim {pigeon.CanSwim}. My Pigeon has feathers : {pigeon.Hasfeathers} and is a land Animal : {pigeon.LandAnimal}");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             * 
             */
            Reptile lizzard = new Reptile();
            lizzard.CanFly = false;
            lizzard.CanSwim = false;
            lizzard.CanClimb = true;
            lizzard.WarmWeather = true;

            Console.WriteLine($" My Lizzard can Fly: {lizzard.CanFly} and can swim  {lizzard.CanSwim}. My lizzard can climb : {lizzard.CanClimb} and is lives in Warm Weather : {lizzard.WarmWeather}");

        }
    }
}
