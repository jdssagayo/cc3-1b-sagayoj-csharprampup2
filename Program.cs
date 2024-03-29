﻿using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Weight in pounds (lbs): ");
        double pounds = Convert.ToDouble(Console.ReadLine());
        double kilograms = pounds * 0.45359237;
        Console.WriteLine("Weight converted to kilograms (kg): " + kilograms);
        Console.WriteLine("====================================================== ");

        Console.Write("Length in Miles (mi): ");
        double miles = Convert.ToDouble(Console.ReadLine());
        double kilometers = miles * 1.6;
        Console.WriteLine("Length Converted to (km) " + kilometers);
        Console.WriteLine("======================================================= ");

        Console.Write("Temperature in Fareinheit (°F): ");
        double Fahrenheit = Convert.ToDouble(Console.ReadLine());
        double Celsius = (Fahrenheit - 32) * 5 / 9;
        Console.WriteLine("Temperature in celsius is: " + Celsius);
        Console.WriteLine("=======================================================");



        int numberOfStudents = 10;
        int[] ages = new int[numberOfStudents];

        Console.WriteLine("Enter the age of 10 students:");

        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.Write($"Student {i + 1}: ");
            ages[i] = int.Parse(Console.ReadLine());
        }

        double averageAge = CalculateAverage(ages);

        Console.WriteLine($"Average Age: {averageAge:F2}");

        static double CalculateAverage(int[] values)
        {
            int sum = 0;

            foreach (var value in values)
            {
                sum += value;
            }

            return (double)sum / values.Length;
        }

        // Character names
        string heroName = "Eldrick";
        string mageName = "Seraphina";
        string rogueName = "Sylvan";
        string dwarfName = "Thrain";
        string villainName = "Malgrimor";

        // Equipment and item names
        string swordName = "Blade of Luminosity";
        string staffName = "Aetherial Scepter";
        string bowName = "Shadowstrike Bow";
        string axeName = "Forgehammer";
        string amuletName = "Crimson Heartstone";

        // Abilities
        string heroAbility = "Radiant Slash";
        string mageAbility = "Arcane Nova";
        string rogueAbility = "Stealthy Ambush";
        string dwarfAbility = "Mighty Cleave";
        string villainAbility = "Dark Obliteration";

        // Story
        string story = $@"
In the mystical land of Eldoria, a hero named {heroName} wielded the legendary {swordName} with the ability known as '{heroAbility}'. {heroName}'s quest was to vanquish the evil sorcerer {villainName}, who sought to plunge the world into eternal darkness.

Accompanying {heroName} on this perilous journey was the wise mage {mageName}, who carried the powerful {staffName} and could unleash the devastating '{mageAbility}'. The swift and cunning rogue {rogueName} armed with the {bowName} was ever-ready to strike with the stealthy '{rogueAbility}'.

A stout dwarf, {dwarfName}, clad in resilient armor and wielding the mighty {axeName}, possessed the ability to deliver a '{dwarfAbility}' - a swing that could cleave through multiple foes. The party carried a mysterious amulet known as the '{amuletName}', said to hold the key to unlocking ancient secrets.

As the group ventured into the treacherous Darkwood Forest, they encountered the malevolent {villainName}. With a wicked grin, {villainName} unleashed the '{villainAbility}', a dark force that threatened to consume all.

Bravery, magic, and skill would be tested as our heroes faced the ultimate battle against {villainName}. Little did they know, the {amuletName} held the key to turning the tides in their favor. The fate of Eldoria hung in the balance.";

        Console.WriteLine(story);
// Part 2
// 1
        Console.Write("Enter a positive integer: ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Invalid input");
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
// 2
        Console.Write("Enter a positive integer: ");
        int x = int.Parse(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Invalid input");
        }
        else
        {
            int sum = 0;
            for (int i = 1; i <= x; i++)
            {
                sum += i;
            }
            
            Console.WriteLine($"Sum of natural numbers from 1 to {n} is: {sum}");
            //3
            Console.Write("Enter a positive integer: ");
            int v = int.Parse(Console.ReadLine());

            if (v <= 0)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                for (int i = v; i >= 1; i--) 
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }

}




