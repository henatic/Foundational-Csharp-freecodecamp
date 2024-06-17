// Install and Configure Visual Studio Code

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

/*
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
*/

// Store and Iterate Through Sequences of Data Using Arrays and the foreach Statement in C#
// Part 1

/* // DO NOT COMMENT OUT LATER!
string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";

// fraudulentOrderIDs[3] = "D000";
*/

/*
string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");
*/

// Store and Iterate Through Sequences of Data Using Arrays and the foreach Statement in C#
// Part 2

/*
int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;
foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}

Console.WriteLine($"We have {sum} items in inventory.");
*/

// Store and Iterate Through Sequences of Data Using Arrays and the foreach Statement in C#
// Part 3 - Code challenge

/*
string[] inventory = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach(string inventoryItem in inventory)
{
    if(inventoryItem.StartsWith("B"))
    {
        Console.WriteLine(inventoryItem);
    }
}
*/

// Create Readable Code with Conventions, Whitespace, and Comments in C#

/*
string firstName = "Bob";
int widgetsPurchased = 7;
// Testing a change to the message.
// int widgetsSold = 7;
// Console.WriteLine($"{firstName} sold {widgetsSold} widgets.");
Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");
*/

/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/
/*
Random random = new Random();
string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");

    orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}

// Example 1:
Console
.
WriteLine
(
"Hello Example 1!"
)
;

// Example 2:
string firstWord="Hello";string lastWord="Example 2";Console.WriteLine(firstWord+" "+lastWord+"!");

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) 
{
    if ((roll1 == roll2) && (roll2 == roll3)) 
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6; 
    } 
    else 
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}
*/

/*
    The below code reverses the phrase "The quick brown fox jumps over the lazy dog.",
    counts the number of 'o's in the phrase, and prints the results of both.
*/

/*
string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] reversedMessage = originalMessage.ToCharArray();
Array.Reverse(reversedMessage);

int letterCount = 0;

foreach (char letter in reversedMessage)
{
    if (letter == 'o')
    {
        letterCount++;
    }
}

string newMessage = new String(reversedMessage);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");
*/

// Evaluate Boolean Expressions to Make Decisions in C#

/*
Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine(myValue == "a");

string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

string myValue = "a";
Console.WriteLine(myValue != "a");

Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);

string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));

Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("cow"));

int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;

Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

Random coin = new Random();
int flip = coin.Next(0, 2); // 0 or 1.
Console.WriteLine((flip == 0)? "heads": "tails");

string permission = "Admin|Manager";
int level = 55;

if(permission.Contains("Admin"))
{
    Console.WriteLine("Welcome," + (level > 55 ? " Super" : "") + " Admin user.");
}
else if (permission.Contains("Manager") && level >= 20)
{
    Console.WriteLine("Contact an Admin for access.");
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}
*/

// Control Variable Scope and Logic Using Code Blocks in C#

/*
bool flag = true;
int value = 0;

if (flag)
{
    Console.WriteLine($"Inside the code block: {value}");
}

value = 10;
Console.WriteLine($"Outside the code block: {value}");

if (flag)
    Console.WriteLine(flag);

if (flag) Console.WriteLine(flag);

string name = "steve";
if (name == "bob") Console.WriteLine("Found Bob");
else if (name == "steve") Console.WriteLine("Found Steve");
else Console.WriteLine("Found Chuck");
*/

int[] numbers = { 4, 8, 15, 16, 23, 42 };

int total = 0;

bool found = false;

foreach (int number in numbers)
{
    total += number;

    if (number == 42) found = true;

}

if (found) Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");