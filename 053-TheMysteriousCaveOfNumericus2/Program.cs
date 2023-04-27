decimal sumOfRandomNumbers = 1000000;
var rand = new Random(4711);
long randomValue = rand.Next(1, 1000000001);
decimal min = randomValue;
decimal max = randomValue;
decimal average = 0;
for (long i = 0; i < sumOfRandomNumbers; i++)
{
    randomValue = rand.Next(1, 1000000001);
    if (min > randomValue)
    {
        min = randomValue;
    }
    else if (max < randomValue)
    {
        max = randomValue;
    }
}
average = (max - min) / (sumOfRandomNumbers - 1);
System.Console.WriteLine(average);
