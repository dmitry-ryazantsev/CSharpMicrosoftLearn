Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay())
{
    PlayGame();
}

void PlayGame()
{
    var play = true;

    while (play)
    {
        var target = random.Next(1, 6);
        var roll = random.Next(1, 7);

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        WinOrLose(target, roll);
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

bool ShouldPlay()
{
    string? response = Console.ReadLine();

    if (response != null)
    {
        return response.ToLower().Trim().Equals("y");
    }

    return false;
}

void WinOrLose(int target, int roll)
{
    string result = (roll > target) ? "You win!" : "You lose!";
    Console.WriteLine(result);
}