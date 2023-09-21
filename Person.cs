using System;
namespace ExerciseCollection
{
	public class Person
	{
        // define private properties in the field
        private int	age;
		private string fName="";
		private string lName="";
		private double height;
		private double weight;

        // define getter and setter for properties
        public int Age
        {
            get { return age; }
            set { age = value;}
        }

        public string FName
        {
            get { return fName; }
            set { fName = value; }
        }

        public string LName
        {
            get { return lName; }
            set { lName = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }


        // Validate properties

        public bool Validate()
        {
            var isValid = true;

            if (Age <= 0)
            {
                throw new ArgumentException("Age must be bigger than 0.");
            }
            if (!string.IsNullOrWhiteSpace(FName))
            {
                if(FName.Length < 2 || FName.Length > 10)
                    throw new ArgumentException("First name must be between 2 and 10 characters.");
            }
            if (!string.IsNullOrWhiteSpace(LName))
                
            {
                if (LName.Length < 3 || LName.Length > 15)

                    throw new ArgumentException("Last name must be between 3 and 15 characters.");
            }
            return isValid;
        }

     
    }
}

