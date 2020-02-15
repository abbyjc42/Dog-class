using System;

class Dog
{
    public enum Gender
    {
        Male,
        Female,
    }

    public string name;
    public string owner;
    public int age;
    public Gender gender;

    public Dog(string name, string owner, int age, Gender gender)
    {
        this.name = name;
        this.owner = owner;
        this.age = age;
        this.gender = gender;
    }

    /* These are to be assigned according to the gender and age
    so that the string in the GetTag method makes sense. */
    public string pronoun1;
    public string pronoun2;
    public string yearOrYears = "year";

    public string GetTag()
    {
        if (gender == Gender.Male)
        {
            pronoun1 = "His";
            pronoun2 = "he";
        }
        else
        {
            pronoun1 = "Her";
            pronoun2 = "she";
        }
        if (age > 1)
        {
            yearOrYears += "s";
        }

        return ($"If lost, call {owner}. {pronoun1} name is {name}" +
        $" and {pronoun2} is {age} {yearOrYears} old.");
    }

    public void Bark(int numberOfTimes)
    {
        for (int i = 1; i <= numberOfTimes; i++)
        {
            Console.WriteLine("Woof!");
        }
    }
    static void Main(string[] args)
    {
        /* These are just test values to ensure an instance is created
        properly and the GetTag method returns what it should. */
        Dog puppy = new Dog("Orion", "Shawn", 1, Gender.Male);
        puppy.Bark(3);
        Console.WriteLine(puppy.GetTag());

        Dog myDog = new Dog("Lileu", "Dale", 4, Gender.Female);
        myDog.Bark(1);
        Console.WriteLine(myDog.GetTag());
    }
}
