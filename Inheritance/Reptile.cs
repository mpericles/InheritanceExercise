using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal
    { 
     // TODO Be sure to follow best practice when creating your classes
          // Create a class Reptile
     // give this class 4 members that are specific to Reptile
     // Set this class to inherit from your Animal Class
     //
    
            //Optionally you can set the value
        //public bool HasScales { get; set; } = true; // did not know how to call it when the value was set
        public bool HasScales { get; set; }

        public bool WarmWeather { get; set; }

        public bool LivInwater { get; set; }

        public bool CanClimb { get; set; }

    }
}
