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
*/

// Branch the Flow of Code Using the switch-case Construct in C#

/*
int employeeLevel = 100;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
        // title = "Junior Associate";
        // break;
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");

// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0])
{
    case "01":
        type = "Sweat shirt";
        break;
    case "02":
        type = "T-Shirt";
        break;
    case "03":
        type = "Sweat pants";
        break;
    default:
        type = "Other";
        break;
}

switch (product[1])
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    default:
        color = "White";
        break;
}

switch (product[2])
{
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One Size Fits All";
        break;
}

Console.WriteLine($"Product: {size} {color} {type}");
*/

// Iterate Through a Code Block Using the for Statement in C#

/*
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
}

for (int i = 0; i < 10; i += 3)
{
    Console.WriteLine(i);
}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7) break;
}

string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}

for (int i = 0; i < names.Length; i++)
    if (names[i] == "David") names[i] = "Sammy";

foreach (var name in names) Console.WriteLine(name);


for(int i = 1; i <= 100; i++) {
    Console.Write(i);
    if(i % 3 == 0 || i % 5 == 0)
    {
        Console.WriteLine(" - " + (i % 3 == 0 ? "Fizz":"") + (i % 5 == 0 ? "Buzz":""));
    }
    else {
        Console.WriteLine("");
    }
}
*/

// Add Looping Logic to Your Code Using the do-while and while Statements in C#

/*
Random random = new Random();
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);

    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);


while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");


int heroHealth = 10;
int monsterHealth = 10;
int lostPoints = 0;
do 
{
    // Hero Attacks First.
    lostPoints = random.Next(1, 11);
    monsterHealth -= lostPoints;
    Console.WriteLine("Monster was damaged and lost " + lostPoints + " health and now has " + monsterHealth + " health.");

    if(monsterHealth <= 0) continue;

    // Monster's turn to attack.
    lostPoints = random.Next(1, 11);
    heroHealth -= lostPoints;
    Console.WriteLine("Hero was damaged and lost " + lostPoints + " health and now has " + heroHealth + " health.");

} while (heroHealth > 0 && monsterHealth > 0);

Console.WriteLine((monsterHealth <= 0 ? "Hero" : "Monster") + " wins!");
*/

// Code Project 1

/*
int numericValue = 0;
bool validNumber  = false;
string? readResult;

Console.WriteLine("Enter an integer value between 5 and 10");
do
{
    readResult = Console.ReadLine();
    if (readResult != null && readResult.Length > 0)
    {
        validNumber = int.TryParse(readResult, out numericValue);
        if (validNumber && (numericValue < 5 || numericValue > 10))
        {
            Console.WriteLine("You entered " + numericValue + ". Please enter a number between 5 and 10.");
        }
        else if (!validNumber)
        {
            Console.WriteLine("Sorry, you entered an invalid number, please try again");
        }
    }
    else Console.WriteLine("You didn't enter anything. Please enter a number between 5 and 10.");
} while (validNumber == false || numericValue < 5 || numericValue > 10);

Console.WriteLine("Your input value ("+ numericValue +") has been accepted.");
*/

// Code Project 2

/*
string[] roleOptions = { "administrator", "manager", "user" };
string? readResult;
bool validResult = false;

do
{
    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        readResult = readResult.Trim();
        validResult = Array.Exists(roleOptions, element => element == readResult.ToLower());
        if (!validResult)
        {
             Console.Write("The role name that you entered, \"" + readResult + "\" is not valid. ");
        }
    }
} while (!validResult);

Console.WriteLine("Your input value (" + readResult + ") has been accepted.");
*/

// Code Project 3

/*
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int index = 0;

do
{
    string myString = myStrings[index];
    while (myString.Contains('.'))
    {
        int periodLocation = myString.IndexOf('.');
        Console.WriteLine(myString.Substring(0, periodLocation));
        myString = myString.Remove(0, periodLocation + 1).TrimStart();
    }

    Console.WriteLine(myString);
    index++;

} while (index < myStrings.Length);
*/

// Choose the Correct Data Type in Your C# Code

/*
Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");

Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");
*/

// Convert Data Types Using Casting and Conversion Techniques in C#

/*
int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result);

int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");

myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");

myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;

Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float  : {myFloat}");

string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);

int value = (int)1.5m; // casting truncates
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value2);

string value = "bad";
int result = 0;
if (int.TryParse(value, out result))
{
   Console.WriteLine($"Measurement: {result}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}

if (result > 0)
   Console.WriteLine($"Measurement (w/ offset): {50 + result}");

string[] values = { "12.3", "45", "ABC", "11", "DEF" };

string message = "";
decimal total = 0m;
foreach (string value in values)
{
    if (decimal.TryParse(value, out decimal currVal))
    {
        total += currVal;
    }
    else
    {
        message += value;
    }
}
Console.WriteLine("Message: " + message);
Console.WriteLine("Total: " + total);

int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
int result1 = Convert.ToInt32( value1 / value2 );

Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
decimal result2 = value2 / Convert.ToDecimal(value3);
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
*/

// Perform Operations on Arrays Using Helper Methods in C#

/*
string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
// string result = new string(valueArray);
string result = String.Join(",", valueArray);
Console.WriteLine(result);

string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}

string pangram = "The quick brown fox jumps over the lazy dog";
string[] pangramArray = pangram.Split(" ");
for (int item = 0; item < pangramArray.Length; item++)
{
    pangramArray[item] = String.Join("", pangramArray[item].ToCharArray().Reverse());

}
string newPangram = String.Join(" ", pangramArray);
Console.WriteLine(newPangram);
*/
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orderArray = orderStream.Split(",");
Array.Sort(orderArray);

foreach (string order in orderArray)
{
    Console.WriteLine(order + (order.Length != 4 ? "\t - Error" : ""));
}