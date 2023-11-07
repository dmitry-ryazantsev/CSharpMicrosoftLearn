Random dice = new Random();
int heroHealthPoints = 10;
int monsterHealthPoitns = 10;

while (heroHealthPoints > 0 && monsterHealthPoitns > 0)
{
    int attack = dice.Next(1, 11);
    monsterHealthPoitns -= attack;
    Console.WriteLine($"Monster was damaged and lost {attack} health and now has {monsterHealthPoitns} health");

    if (monsterHealthPoitns <= 0) break;

    attack = dice.Next(1, 11);
    heroHealthPoints -= attack;
    Console.WriteLine($"Hero was damaged and lost {attack} health and now has {heroHealthPoints} health");
}

Console.WriteLine(heroHealthPoints > monsterHealthPoitns ? "Hero wins!" : "Monster wins!");