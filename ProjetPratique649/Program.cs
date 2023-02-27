// Variables instanciations
int[] winNbr = new int[6];
int[] chosenNbr = new int[6];
Random ran = new Random();

// Asking for user numbers and making sure they are right.

for (int i = 0; i < chosenNbr.Length; i++)
{
    Console.WriteLine("Please pick your numbers " + (i + 1) + "/6");
    chosenNbr[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Your numbers are ");
for (int i =0; i < chosenNbr.Length; i++ )
{
    Console.Write(chosenNbr[i] + " ");
}
Console.WriteLine();

// Displaying winning numbers

Console.WriteLine("The winning numbers are : ");
for(int i = 0; i < winNbr.Length; i++)
{
    winNbr[i] = ran.Next(1,49);
    Console.Write(winNbr[i] + " ");
}
