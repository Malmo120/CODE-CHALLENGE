Random random = new Random();
int daysLeft = random.Next(12);
int offerDiscount = 0;

if (daysLeft == 1)
{
    offerDiscount = 20;
}
if (daysLeft <= 5)
{
    offerDiscount = 10;
}
if (daysLeft < 1)
{
    Console.WriteLine("Your membership has expired!");
}
else if (daysLeft == 1)
{
    Console.WriteLine("Your membership expires within a day!");
    Console.WriteLine("Renew now and save " + offerDiscount + "%!");
}
else if (daysLeft <= 5)
{
    Console.WriteLine("Your membership expires in: " + daysLeft + " days.");
    Console.WriteLine("Renew now and save " + offerDiscount + "%!");
}
else if (daysLeft <= 10)
{
    Console.WriteLine("Your membership expires in: " + daysLeft + " days.");
    Console.WriteLine("Your membership will expire soon. Renew now!");
}
