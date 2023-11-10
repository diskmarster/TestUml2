
/// <summary>
/// This class contains helper methods for reading simple data input from the Console.
/// The data input can represent either a string or an int
/// </summary>
public class UserInputReader
{
    public static string ReadStringFromUser(string prompt, string valueIfBlank = "")
    {
        string value = ReadInputFromUser(prompt);

        return string.IsNullOrEmpty(value) ? valueIfBlank : value;
    }

    public static int ReadIntFromUser(string prompt, int valueIfBlank = 0)
    {
        string input = ReadInputFromUser(prompt);
        if (string.IsNullOrEmpty(input))
            return valueIfBlank;

        bool isAnInt = int.TryParse(input, out int value);

        if (isAnInt)
            return value;
        else
        {
            Console.WriteLine($"{input} is not a numeric value, please try again...");
            return ReadIntFromUser(prompt, valueIfBlank);
        }
    }

    public static double ReadDoubleFromUser(string prompt, double valueIfBlank = 0.00)
    {
        string input = ReadInputFromUser(prompt);
        if (string.IsNullOrEmpty(input))
            return valueIfBlank;

        bool isAnInt = double.TryParse(input, out double value);

        if (isAnInt)
            return value;
        else
        {
            Console.WriteLine($"{input} is not a numeric value, please try again...");
            return ReadDoubleFromUser(prompt, valueIfBlank);
        }
    }

    public static int ReadRangedIntFromUser(string prompt, int min, int max, int valueIfBlank = 0)
    {
        string input = ReadInputFromUser(prompt);
        if (string.IsNullOrEmpty(input))
            return valueIfBlank;

        bool isAnInt = int.TryParse(input, out int value);

        if (isAnInt && value >= min && value <= max)
        {
            return value;
        }
        else if (isAnInt)
        {
            Console.WriteLine($"{input} is out of range [{min}, {max}], please try again...");
            return ReadRangedIntFromUser(prompt, min, max, valueIfBlank);
        }
        else
        {
            Console.WriteLine($"{input} is not a numeric value, please try again...");
            return ReadRangedIntFromUser(prompt, min, max, valueIfBlank);
        }
    }

    /// <summary>
    /// Prompts the user with the provided prompt, 
    /// and reads the input from the Console.
    /// </summary>
    private static string ReadInputFromUser(string prompt)
    {
        Console.WriteLine();
        Console.Write($"{prompt} : ");

        string input = Console.ReadLine() ?? "";

        return input;
    }
}
