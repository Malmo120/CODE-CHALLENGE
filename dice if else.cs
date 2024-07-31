Random rng = new Random();
int die1 = rng.Next(1, 7);
int die2 = rng.Next(1, 7);
int die3 = rng.Next(1, 7);
int totalScore = die1 + die2 + die3;

Console.WriteLine($"Dice roll: {die1} + {die2} + {die3}");

if ((die1 == die2) && (die2 == die3))
{
    Console.WriteLine("Triple match! +6 points bonus!");
    totalScore += 6;
}
else if ((die1 == die2) || (die2 == die3) || (die1 == die3))
{
    Console.WriteLine("Double match! +2 points bonus!");
    totalScore += 2;
}

if (totalScore >= 15)
{
    Console.WriteLine("Congratulations, you win!");
}
else
{
    Console.WriteLine("Better luck next time, you lose.");
}
