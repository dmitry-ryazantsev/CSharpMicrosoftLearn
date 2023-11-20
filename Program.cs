// Running the program in en-US culture setting to handle a period as the decimal separator
using System.Globalization;
CultureInfo.CurrentCulture = new CultureInfo("en-US");

string[] values = { "12.3", "45", "ABC", "11", "DEF" };
string message = "";
float total = 0.0f;

foreach (string value in values)
{
    if (float.TryParse(value, out float number))
    {
        total += number;
    }
    else
    {
        message += value;
    }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");