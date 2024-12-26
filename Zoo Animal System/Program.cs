/* Zoo Animal System
 * create a Animal base class with a sound() method
 * derive sublcasses like lion, elephant and bird
 * ovverride the sound() method to simulate specific animal sounds
 * create an array of animals and call the sound() method for each */

using System;



namespace ZooAnimalSystem
{
    // Base class
    class Animal
    {
        // Common properties
        public string Species { get; set; }
        public string Habitat { get; set; }

        // Constructor
        public Animal(string species, string habitat)
        {
            Species = species;
            Habitat = habitat;
        }

        // Virtual method to simulate the sound
        public virtual void Sound()
        {
            Console.WriteLine("This animal makes a generic sound.");
        }

        // Method to display animal details
        public void DisplayDetails()
        {
            Console.WriteLine($"Species: {Species}");
            Console.WriteLine($"Habitat: {Habitat}");
        }
    }

    // Derived class: Lion
    class Lion : Animal
    {
        // Constructor
        public Lion(string habitat) : base("Lion", habitat) { }

        // Override Sound method
        public override void Sound()
        {
            Console.WriteLine("Roar!");
        }
    }

    // Derived class: Elephant
    class Elephant : Animal
    {
        // Constructor
        public Elephant(string habitat) : base("Elephant", habitat) { }

        // Override Sound method
        public override void Sound()
        {
            Console.WriteLine("Trumpet!");
        }
    }

    // Derived class: Bird
    class Bird : Animal
    {
        // Constructor
        public Bird(string habitat) : base("Bird", habitat) { }

        // Override Sound method
        public override void Sound()
        {
            Console.WriteLine("Chirp!");
        }
    }

    // Main Program
    class Program
    {
        static void Main(string[] args)
        {
            // Create an array of animals
            Animal[] animals = new Animal[]
            {
                new Lion("Savanna"),
                new Elephant("Grassland"),
                new Bird("Forest")
            };

            // Call the Sound method for each animal
            foreach (Animal animal in animals)
            {
                animal.DisplayDetails();
                animal.Sound();
                Console.WriteLine();
            }
        }
    }
}

