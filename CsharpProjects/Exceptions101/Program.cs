/*
try
{
    Process1();
}
catch
{
    Console.WriteLine("An exception has occurred");
}

Console.WriteLine("Exit program");

static void Process1()
{
    try
    {
        WriteMessage();
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine($"Exception caught in Process1: {ex.Message}");
    }
}

static void WriteMessage()
{
    double float1 = 3000.0;
    double float2 = 0.0;
    int number1 = 3000;
    int number2 = 0;
    byte smallNumber;

    try
    {
        Console.WriteLine(float1 / float2);
        Console.WriteLine(number1 / number2);
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine($"Exception caught in WriteMessage: {ex.Message}");
    }
    checked
    {
        try
        {
            smallNumber = (byte)number1;
        }
        catch (OverflowException ex)
        {
            Console.WriteLine($"Exception caught in WriteMessage: {ex.Message}");
        }
    }

}
*/

/*
// inputValues is used to store numeric values entered by a user
string[] inputValues = new string[]{"three", "9999999999", "0", "2" };

foreach (string inputValue in inputValues)
{
    int numValue = 0;
    try
    {
        numValue = int.Parse(inputValue);
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid readResult. Please enter a valid number.");
    }
    catch (OverflowException)
    {
        Console.WriteLine("The number you entered is too large or too small.");
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
*/

try
{
    int num1 = int.MaxValue;
    int num2 = int.MaxValue;
    AddNumbers(num1, num2);

    string str = null;
    StringLength(str);

    int[] numbers = new int[5];
    NumberAtIndex(numbers, 5, 10);

    int num3 = 10;
    int num4 = 0;
    DivideNumbers(num3, num4);
}
catch (OverflowException ex)
{
    Console.WriteLine("Error: The number is too large to be represented as an integer." + ex.Message);
}
catch (NullReferenceException ex)
{
    Console.WriteLine("Error: The reference is null. " + ex.Message);
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine("Error: Index out of range." + ex.Message);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Error: Cannot divide by zero." + ex.Message);
}

Console.WriteLine("Exiting program.");

void AddNumbers(int num1, int num2)
{
    checked
    {
        try
        {
            int result = num1 + num2;
            Console.WriteLine("Result: " + result);
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Error: The number is too large to be represented as an integer. " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.Write("An error ocurred when adding numbers. " + ex.Message);
        }
    }
}

void StringLength(string? str)
{
    try
    {
        int length = str.Length;
        Console.WriteLine("String Length: " + length);
    }
    catch (NullReferenceException ex)
    {
        Console.WriteLine("Error: The reference is null. " + ex.Message);
    }
    catch (Exception ex)
    {
        Console.Write("An error has ocurred with getting the string length. " + ex.Message);
    }
}

void NumberAtIndex(int[] numbers, int index, int valueAtIndex)
{
    try
    {
        numbers[index] = valueAtIndex;
        Console.WriteLine("Number at index 5: " + numbers[5]);
    }
    catch (NullReferenceException ex)
    {
        Console.WriteLine("Error: The reference is null. " + ex.Message);
    }
    catch (IndexOutOfRangeException ex)
    {
        Console.WriteLine("Error: Index out of range. " + ex.Message);
    }
    catch (Exception ex)
    {
        Console.Write("An error has ocurred with getting number at index " + index + ". " + ex.Message);
    }
}

void DivideNumbers(int numerator, int denominator)
{
    try
    {
        int result2 = numerator / denominator;
        Console.WriteLine("Result: " + result2);
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine("Error: Cannot divide by zero. " + ex.Message);
    }
    catch (Exception ex)
    {
        Console.Write("An error has ocurred with dividing two numbers. " + ex.Message);
    }
}