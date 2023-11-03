Random random = new Random();
int coinFlip = random.Next(0, 2);
Console.WriteLine((coinFlip == 0) ? "heads" : "tails");