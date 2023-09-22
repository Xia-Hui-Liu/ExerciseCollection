using System;

namespace ExerciseCollection
{
    internal abstract class Animal
    {
        public Animal()
        {
            // om vi under utveckligen kommer fram till att samtliga fåglar behöver ett nytt attribut, i vilken klass bör vi lägg det?
            // om alla djur behöver det nya attributet, vart skulle man lägga det då?

            // Svaret för båda är basklass, eftersom alla djur, inklusive fåglar, ärver från Animal.
        }
        public string ? Name { get; set; }
        public int Age { get; set; }
        public string ? Species  { get; set; }
        public string ? Gender { get; set; }
        public double Weight { get; set; }

        public virtual string DoSound()
        {
            return "Generic Animal";
        }

        public virtual string Stats()
        {
            return $"Name: {Name}\nAge: {Age}\nSpecies: {Species}\nGender: {Gender}\nWeight: {Weight}";
        }
    }

    internal class Horse : Animal
    {
        public double Speed { get; set; }

        public override string DoSound()
        {
            return "neigh";
        }
    }

    internal class Dog : Animal
    {
        public bool IsGoodWithChildren{get; set;}

        public override string DoSound()
        {
            return "Bark";
        }
        // Kommer du åt den metoden från Animals listan? Varför int?
        // nej. Animals listan innerhåller inte dess metod därför har den ingen åtkomst.
        public string CustomMethod()
        {
            return "This is a crazyyy dog.";
        }
    }

    internal class Hedgehog : Animal
    {
        public int NrOfSpikes { get; set; }

        public override string DoSound()
        {
            return "akjkj";
        }
    }

    internal class Worm : Animal
    {
        public bool IsPoisonous { get; set; }
        public override string DoSound()
        {
            return "nnnnn";
        }
    }

    internal class Bird : Animal
    {
        public double WingSpan { get; set; }
        public override string DoSound()
        {
            return "Tweet";
        }
    }

    internal class Wolf : Animal
    {
        public double TerritorySize {get; set;}

        public override string DoSound()
        {
            return "wu....";
        }

        //public override string GetType()
        //{
        //    return "Wolf";
        //}
    }

     internal class Pelican : Bird
    {
        public double PouchCapacity {get; set;}

        public override string DoSound()
        {
            return "";
        }
    }

     internal class Flamingo : Bird
    {
        public double LegColor {get; set;}

        public override string DoSound()
        {
            return "honk";
        }
    }

     internal class Swan : Bird
    {
        public double MatingPairBond {get; set;}

        public override string DoSound()
        {
            return "trumpet";
        }
    }

    internal class Wolfman: Wolf, IPerson
    {
        public string Talk()
        {
            return "I can speak like a human.";
        }
    }
}
