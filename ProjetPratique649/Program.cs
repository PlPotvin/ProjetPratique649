// Variables instanciations
using ProjetPratique649;

int[] winNbr = new int[6];
int[] chosenNbr = new int[6];
int nbr = 0;

// Asking for user numbers

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

Console.WriteLine("Your numbers are ");
for (int i =0; i < chosenNbr.Length; i++ )
{
    Console.Write(chosenNbr[i] + " ");
}
Console.WriteLine();

// Displaying winning numbers

Console.WriteLine("The winning numbers are : ");
Functions.GenerateNBR(winNbr);
Console.ReadLine();
