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
            var eagle = new Bird();
            eagle.WingSpan = 7;
            eagle.SizeOfBrood = 3;
            eagle.NumOfLegs = 2;
            eagle.IsLiving = true;

            Console.WriteLine($"The Eagle has a wingspan of {eagle.WingSpan} and has an average broodsize of {eagle.SizeOfBrood}.");
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var gecko = new Reptile();
            gecko.NativeRegion = "south-asian Afghanistan";
            gecko.Regeneration = true;
            gecko.TypeOfBirth = "egg";
            string regen = "regenerate";
            if(gecko.Regeneration == false)
            {
                regen = "not regenerate";
            }
            Console.WriteLine($"the gecko is birthed from an {gecko.TypeOfBirth} and can {regen}.");
        }
    }
}
