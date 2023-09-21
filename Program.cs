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
    }
}

