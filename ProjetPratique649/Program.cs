// Variables declarations
using ProjetPratique649;

int[] winNbr = new int[6];
int[] chosenNbr = new int[6];
int[] uniqueArray = new int[6];
int nbr = 0;
HashSet<int> uniqueSet = new HashSet<int>();
Random random = new Random();

// Asking for user numbers | Could be done in a function for a cleaner code.
for (int i = 0; i < chosenNbr.Length; i++)
{
    do
    {
        Console.WriteLine("Please pick your numbers " + (i + 1) + "/6");
        nbr = Functions.ReadNBR(chosenNbr, i);
        if (nbr < 1 || nbr > 49)
        {
            Console.WriteLine("Your number must be between 1 and 49 inclusively.");
        }
        else
        {
            i++;
        }
    }
    while (i < 6);
}

// Clearing the console to remove all the text above.

Console.Clear();

// Showing user's numbers

Console.WriteLine("Your numbers are ");
for (int i =0; i < chosenNbr.Length; i++ )
{
    Console.Write(chosenNbr[i] + " ");
}
Console.WriteLine();

// Generating 6 uniques numbers using Hashset. Could be done in a function. I need to learn how to call a full array for that one

while (uniqueSet.Count < 6)
{
    int number = random.Next(1, 49);
    uniqueSet.Add(number);
}
uniqueSet.CopyTo(uniqueArray);

// Displaying winning numbers

Console.WriteLine("The winning numbers are ");

for(int i = 0; i < 6; i++)
{
    Console.Write(uniqueArray[i] + " ");
}

Console.ReadLine();
