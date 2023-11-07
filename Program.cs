string? readResult;
int numericValue = 0;
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        validNumber = int.TryParse(readResult, out numericValue);
        if (validNumber)
        {
            if (numericValue < 5 || numericValue > 10)
            {
                validNumber = false;
                Console.WriteLine($"You entered {readResult}. Please enter a number between 5 and 10.");
            }
        }
        else
            Console.WriteLine("Sorry, you entered an invalid number, please try again.");
    }
} while (validNumber == false);

Console.WriteLine($"Your input value ({numericValue}) has been accepted.");