using System;
namespace ExerciseCollection
{
	public class Person
	{
        // define private properties in the field
        private int	age = 0;
		private string fName="";
		private string lName="";
		private double height;
		private double weight;

        // define getter and setter for properties
        public int Age
        {
            get { return age; }
            set 
            { 
                if (value < 0)
                {
                    throw new ArgumentException("Age must be bigger than 0.");
                }
                else
                {
                    age = value;  
                }
                    
            }
        }
        public string FName
        {
            get { return fName; }
            set 
            { 
                if(value.Length < 2 || value.Length > 10)
                {
                    throw new ArgumentException("First name must be between 2 and 10 characters.");
                }
                else
                {
                    fName = value;
                } 
            }
        }

        public string LName
        {
            get { return lName; }
            set 
            { 
                if (value.Length < 3 || value.Length > 15)   
                {
                   throw new ArgumentException("Last name must be between 3 and 15 characters.");
                }
                else
                {
                    lName = value;
                }
            }
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

    }
}

