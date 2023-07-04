using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
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

    /*Create an object of your Reptile class
     *  give values to your members using the object of your Reptile class
     *  
     * Creatively display the class member values 
     */

    //internal class Animal
    //public class Animal
    //{
    //
    //}

    internal class Animal
    {
    // 4 Members in the class; common to all Animals
        public int Legs { get; set; }

        public bool CanFly { get; set; }

        public bool CanSwim { get; set; }
        public bool LandAnimal { get; set; }
    }
    
    
}
