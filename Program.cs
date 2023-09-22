
using System.Collections.Generic;
using System.Linq;

namespace ExerciseCollection;

class Program
{
    static void Main(string[] args)
    {
        /*try
        {
            // Instansiera en person, kommer du direkt åt variablerna?
            // Ja, jag kan direkt åt och sätte värden för dess properties
            var person = new Person();

            person.Age = 100;
            person.FName = "Marie";
            person.LName = "La";
            person.Height = 1.66;
            person.Weight = 54;

            // Validate the person object
            bool isValid = person.Validate();

            if (isValid)
                Console.WriteLine($"{person.FName} {person.LName} is {person.Age} years old. She is {person.Weight} kg and {person.Height} meter tall.");
        }

        catch (ArgumentException ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }*/


        // create a new instance of PersonHandler
        var personHandler = new PersonHandler();
       
        // create person object using CreatePerson method from PersonHandler class
        var person = personHandler.CreatePerson(45, "Maya", "Kory", 167, 50);

        Console.WriteLine($"New person:{person.FName} {person.LName} has created!");

        var per = new Person();

        var bmi = personHandler.CalculateBMI(per, 39, "Kay", "Larson", 180, 55);

        Console.WriteLine(bmi);

        // create a list of UserErrors
        List<UserError> userErrors = new List<UserError>();
      
        var numericInputError = new NumericInputError();
        var textInputError = new TextInputError();
        var customError1 = new CustomError1();
        var customError2 = new CustomError2();
        var customError3 = new CustomError3();

        userErrors.Add(numericInputError);
        userErrors.Add(textInputError);
        userErrors.Add(customError1);
        userErrors.Add(customError2);
        userErrors.Add(customError3);

        foreach(var error in userErrors)
        {
           Console.WriteLine(error.UEMessage());
        }

        // create a list of Animals
        List<Animal> animals = new List<Animal>
        {
            new Horse { Name = "Fido", Age = 3, Species = "Equine", Gender = "Male", Weight = 1000 },
            new Bird { Name = "Tweety", Age = 2, Species = "Bird", Gender = "Female", Weight = 0.1 },
            new Dog { Name = "Rex", Age = 5, Species = "Canine", Gender = "Male", Weight = 25 },
            new Wolfman { Name = "Wolfgang", Age = 30, Species = "Wolfman", Gender = "Male", Weight = 180 },
            new Swan { Name = "Grace", Age = 8, Species = "Swan", Gender = "Female", Weight = 10 }
        };

        // using foreach loop through Animal list
        foreach (var animal in animals)
        {
            // 
            if (animal is Wolfman wolfman)
            {
                if (wolfman is IPerson)
                {
                    Console.WriteLine($"I am a {wolfman.GetType().Name} and {wolfman.Talk()}");
                }
            }
            else
            {
                Console.WriteLine($"{animal.Name} is a {animal.GetType().Name}");
            }

        }

        // create a list of dogs with a horse in
        // Varför fungerar int de?
        // för att List<Dog> kan bara innerhåll objekt av typen dog eller dess subklasser.Horse klass är inte subklass av Dog.

        // Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans.
        //en gemensam överordnad klass, ett gemensamt interface, object

        List<object> dogs = new List<object>
        {
            new Horse{ Name = "Fido", Age = 3, Species = "Equine", Gender = "Male", Weight = 1000 },
            new Dog { Name = "Rex", Age = 5, Species = "Canine", Gender = "Male", Weight = 25 },
            new Wolfman { Name = "Wolfgang", Age = 30, Species = "Wolfman", Gender = "Male", Weight = 180 },
            new Swan { Name = "Grace", Age = 8, Species = "Swan", Gender = "Female", Weight = 10 }
        };

        // print out all animals Stats
        // förklara vad det är som händer?
        // jag använder en foreach loop för att skriva ut samtliga animals stats.

        foreach (var animal in animals)
        {
            // Check the current animal is of type of Dog, customDog is a new variable of type Dog
            if (animal is Dog customDog)
            {
                // so the customDog to call CustomMethod() from Dog class
                Console.WriteLine($"{animal.Stats()}\n{customDog.CustomMethod()}");
            }
            else
            {
                Console.WriteLine($"{animal.Name}");
            }
        }

    }
}

