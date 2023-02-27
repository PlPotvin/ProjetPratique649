// Variables instanciations
int[] numbers = new int[50];
int nbr = 0;
Random ran = new Random();

nbr = ran.Next(1, 49);

for(int i = 1; i < numbers.Length; i++)
    {
    numbers[i] = i;
    Console.Write(numbers[i] + " + ");
    }


Console.WriteLine(nbr);