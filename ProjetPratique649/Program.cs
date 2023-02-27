// Variables instanciations
int[] winNbr = new int[6];
Random ran = new Random();

for(int i = 0; i < winNbr.Length; i++)
    {
        winNbr[i] = ran.Next(1,49);
        Console.Write(winNbr[i] + " ");
    }
