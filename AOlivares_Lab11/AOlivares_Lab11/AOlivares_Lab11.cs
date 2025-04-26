using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Person
{
    // Properties
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int DayOfBirth { get; set; }
    public int MonthOfBirth { get; set; }
    public int YearOfBirth { get; set; }

    // Constructor
    public Person()
    {
        // Default constructor
    }

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public Person(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        CalculateBirthDateFromAge(age);
    }

    // Methods
    public bool IsAdult()
    {
        // Age 18 or above is considered adult
        return CalculateAge() >= 18;
    }

    public string GetWesternSunSign()
    {
        int day = DayOfBirth;
        int month = MonthOfBirth;

        if ((month == 3 && day >= 21) || (month == 4 && day <= 19))
            return "Aries";
        else if ((month == 4 && day >= 20) || (month == 5 && day <= 20))
            return "Taurus";
        else if ((month == 5 && day >= 21) || (month == 6 && day <= 20))
            return "Gemini";
        else if ((month == 6 && day >= 21) || (month == 7 && day <= 22))
            return "Cancer";
        else if ((month == 7 && day >= 23) || (month == 8 && day <= 22))
            return "Leo";
        else if ((month == 8 && day >= 23) || (month == 9 && day <= 22))
            return "Virgo";
        else if ((month == 9 && day >= 23) || (month == 10 && day <= 22))
            return "Libra";
        else if ((month == 10 && day >= 23) || (month == 11 && day <= 21))
            return "Scorpio";
        else if ((month == 11 && day >= 22) || (month == 12 && day <= 21))
            return "Sagittarius";
        else if ((month == 12 && day >= 22) || (month == 1 && day <= 19))
            return "Capricorn";
        else if ((month == 1 && day >= 20) || (month == 2 && day <= 18))
            return "Aquarius";
        else if ((month == 2 && day >= 19) || (month == 3 && day <= 20))
            return "Pisces";
        else
            return "Unknown";
    }

    public string GetChineseZodiacSign()
    {
        string[] chineseZodiacSigns = {
            "Monkey", "Rooster", "Dog", "Pig", "Rat", "Ox",
            "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Goat"
        };

        int startYear = 1900; // Start of the Chinese zodiac cycle
        int animalIndex = (YearOfBirth - startYear) % 12;
        return chineseZodiacSigns[animalIndex];
    }

    private int CalculateAge()
    {
        DateTime today = DateTime.Today;
        int age = today.Year - YearOfBirth;
        if (MonthOfBirth > today.Month || (MonthOfBirth == today.Month && DayOfBirth > today.Day))
            age--;
        return age;
    }

    private void CalculateBirthDateFromAge(int age)
    {
        DateTime today = DateTime.Today;
        int currentYear = today.Year;
        int birthYear = currentYear - age;
        // Defaulting to January 1st of the calculated birth year
        YearOfBirth = birthYear;
        MonthOfBirth = 1;
        DayOfBirth = 1;
    }
}

namespace AOlivares_Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testing the Person class
            Person person1 = new Person("Andres", "Olivares") { MonthOfBirth = 4, DayOfBirth = 06, YearOfBirth = 1996 };
            Person person2 = new Person("John", "Doe", 30);

            Console.WriteLine($"{person1.FirstName} {person1.LastName} is an adult: {person1.IsAdult()}\n");
            Console.WriteLine($"{person2.FirstName} {person2.LastName} is an adult: {person2.IsAdult()}\n");

            Console.WriteLine($"{person1.FirstName} {person1.LastName}'s Western Sun sign is {person1.GetWesternSunSign()}\n");
            Console.WriteLine($"{person2.FirstName} {person2.LastName}'s Western Sun sign is {person2.GetWesternSunSign()}\n");

            Console.WriteLine($"{person1.FirstName} {person1.LastName}'s Chinese Zodiac sign is {person1.GetChineseZodiacSign()}\n");
            Console.WriteLine($"{person2.FirstName} {person2.LastName}'s Chinese Zodiac sign is {person2.GetChineseZodiacSign()}\n");
        }
    }
}