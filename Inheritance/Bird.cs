using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // TODO Be sure to follow best practice when creating your classes

    // Create a class Bird
    // give this class 4 members that are specific to Bird
    // Set this class to inherit from your Animal Class

    
    internal class Bird : Animal
    {
        public bool HasWings { get; set; }

        public bool HasBeck { get; set; }

        public bool LaysEggs { get; set; }

        // can set the value to Trus that is optional
        //public bool Hasfeathers { get; set; } = true; // did not know how to call it when the value was set
        public bool Hasfeathers { get; set; } 


    }
}
