/*
// Author: Josephine Carrillo
// Course: COMP-003A
// Faculty: Jonathan Cruz 
// Purpose: Zoo management system demonstrating inheritance, abstraction, polymorphism, and methos overloading in C#
*/

using System.Globalization;

namespace COMP003A.ZooManagementSystem
{
    /// shows the animal class and the name and the species
    abstract class Animal
    {
       // Private strings/ fields 
       private string _name;
       private string _species;

        // properties
        public string AnimalName 
        { 
            get { return _name; } 
            set 
            {
                if (string.IsNullOrEmpty(value))
                    new ArgumentException("name cannot be empty.");
                _name = value;
            }
           
        }
        public string Species
        {
            get { return _species; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    new ArgumentException("Species cannot be empty");
                _species = value;
            }
        }

            /// constructor for animal 
            public Animal(string name, string species)
        {
            AnimalName = name;
            Species = species;
        }

        /// abstract method to override the classes that need animals to make sound 
        public abstract void MakeSound();
    }

    /// the lion class that comes from animal 
    class lion : Animal  
    {
        /// the lion class that comes from animal 
        public lion (string name, string species) : base(name, species) { } // calls animal constructor 

        /// override makesound() methods to read lion sound 
        public override void MakeSound() 
        {
            Console.WriteLine($"the lion roars. {AnimalName}, {Species}");
        }
    }

    /// that parrot class that comes from animal 
    class Parrot : Animal
    {
        /// Constuctor for parrot 
        public Parrot(string name, string species) : base (name, species) { } // calls animal constructor 

        /// override makesoun() methos to read parrot sound

        public override void MakeSound() 
        { 
            Console.WriteLine($"the parrot squawks. ({AnimalName}, {Species})");
        }
    }

    /// uses class and methods to describle the animals
    class ZooUtility
    {
        /// shows the animal name 
        public static void DescribeAnimal (string name)
        {
            Console.WriteLine($"animal name: {name}");
        }

        /// shows the animals name and species 
        public static void DescribeAnimal(string name, string species)
        {
            DescribeAnimal(name);
            Console.WriteLine($"species: {species}"); // calls the method above
        }

        /// shows the animals name and species and age 
        public static void DescribeAnimal(string name, string species, int age)
        {
            DescribeAnimal(name, species);
            Console.WriteLine($"age:{age}"); // calls the method above
        }
    }

    /// main program where all the questions are awsered  
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> zooAnimals = new List<Animal>();

            while (true)
            {
                Console.WriteLine("\nWelcome to the zoo management system.");
                Console.WriteLine("1. add a lion");
                Console.WriteLine("2. add a parrot");
                Console.WriteLine("3. display all animals");
                Console.WriteLine("4. describe an animal");
                Console.WriteLine("5. exit");
                Console.WriteLine("Your chooice: ");

                string choice = Console.ReadLine();

               
                    switch (choice)
                    {
                        case "1":
                            Console.WriteLine("enter the name of the lion: ");
                            string lionName = Console.ReadLine();
                            Console.WriteLine("Enter the species of the lion: ");
                            string lionSpecies = Console.ReadLine();

                            Animal lion = new lion(lionName, lionSpecies);
                            zooAnimals.Add(lion);
                            Console.WriteLine("Lion added successsfully");
                            break;

                        case "2":
                            Console.Write("Enter the name of the parrot: ");
                            string parrotName = Console.ReadLine();
                            Console.Write("Enter the species of the parrot: ");
                            string parrotSpecies = Console.ReadLine();

                            Animal parrot = new Parrot(parrotName, parrotSpecies);
                            zooAnimals.Add(parrot);
                            Console.WriteLine("Parrot added successfully!");
                            break;

                        case "3":
                            Console.WriteLine("Displaying all animals:");
                            foreach (var animal in zooAnimals)
                            {
                                Console.WriteLine($"name: {animalname}, species{animalspecies}");
                            }
                            break;

                        case "4":
                            Console.Write("Enter the animal name: ");
                            string animalName = Console.ReadLine();

                            Console.Write("Enter the animal species: ");
                            string animalSpecies = Console.ReadLine();

                            Console.Write("Enter the animal age: ");
                            string ageInput = Console.ReadLine();

                        case "5":
                            Console.WriteLine("exit");
                            return;

                        default:
                            Console.WriteLine("Invalid number please pick a number 1-5.");
                            break;
                            
                        }
                    }
            }
        }
    }
}
