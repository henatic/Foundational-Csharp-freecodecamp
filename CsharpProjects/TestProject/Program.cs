﻿// Install and Configure Visual Studio Code

/*
﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello C#!");
*/

// Call Methods From the .NET Class Library Using C#

/*
Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);

int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");

int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue);;

Console.WriteLine(largerValue);
*/

// Add Decision Logic to Your Code Using if, else, and else if statements in C#
// Part 1

/*
Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3)) // Triples
    {
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        total += 6;
    }
    else // Doubles
    {
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
        total += 2;
    }
    Console.WriteLine($"Your total including the bonus: {total}");
}

if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}
*/

// Add Decision Logic to Your Code Using if, else, and else if statements in C#
// Part 2

using System.Formats.Asn1;

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if(daysUntilExpiration <= 10)
{
    if(daysUntilExpiration == 0) {
        Console.WriteLine("Your subscription has expired.");
    }
    else if(daysUntilExpiration == 1)
    {
        Console.WriteLine("Your subscription expires within a day!");
        discountPercentage = 20;
    }
    else if(daysUntilExpiration <= 5)
    {
        Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
        discountPercentage = 10;
    }
    else
    {
        Console.WriteLine("Your subscription will expire soon. Renew now!");
    }

    if (discountPercentage > 0)
    {
        Console.WriteLine($"Renew now and save {discountPercentage}%.");
    }
}