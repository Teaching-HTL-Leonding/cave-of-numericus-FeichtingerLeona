Console.Clear();
var rand = new Random(4711);
var randomValue = new int[75000];
decimal average = 0; ;
for (int i = 0; i < randomValue.Length; i++)
{
    randomValue[i] = rand.Next(1, 1000000001);
}
bool doneChanges = false;
do
{
    doneChanges = false;
    for (int i = 0; i < (randomValue.Length - 1); i++)
    {
        int j = i + 1;
        if (randomValue[i] > randomValue[j])
        {
            (randomValue[i], randomValue[j]) = (randomValue[j], randomValue[i]);
            doneChanges = true;
        }

    }
}
while (doneChanges);

for (int i = 0; i < (randomValue.Length - 1); i++)
{
    int j = i + 1;
    average += (randomValue[j] - randomValue[i]);
}
average /= (randomValue.Length-1);
System.Console.WriteLine(average);
