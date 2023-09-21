namespace ExerciseCollection
{
    public class PersonHandler
	{
		
		public void SetAge(Person per, int age)
		{
			per.Age = age;
		}

		// create a new person object
		public Person CreatePerson(int age, string fname, string lname, double height, double weight)
		{
			var person = new Person
							{
								Age = age,
								FName = fname,
								LName = lname,
								Height = height,
								Weight = weight
							};


			return person;

        }

        // calculate BMI for a person and log out information
        public string CalculateBMI(Person per, int age, string fname, string lname, double height, double weight)
		{
            per.Age = age;
            per.FName = fname;
            per.LName = lname;
            per.Height = height;
			per.Weight = weight;

			var h = per.Height;

			if (per.Height > 3)
			{
				h = per.Height / 100;
            }

            var bmi = per.Weight / (h * h);

            if (bmi <= 18.4)
            {
                return $"Name: {per.FName} {per.LName}\nAge: {per.Age}\nHeight: {per.Height} meters\nWeight: {per.Weight} kilograms\nBMI: Underweight (keep your weight up)";
            }
            else if (bmi <= 24.9)
            {
                return $"Name: {per.FName} {per.LName}\nAge: {per.Age}\nHeight: {per.Height} meters\nWeight: {per.Weight} kilograms\nBMI: Normal (healthy weight)";
            }
            else
            {
                return $"Name: {per.FName} {per.LName}\nAge: {per.Age}\nHeight: {per.Height} meters\nWeight: {per.Weight} kilograms\nBMI: Overweight (over weight)";
            }

		}

	}
}

