using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPratique649
{
    internal class Functions
    {
        public static int ReadNBR(int[] myArray, int i)
        {
            myArray[i] = Convert.ToInt32(Console.ReadLine());
            return myArray[i];
        }

        public static int GenerateNBR(int[] myArray)
        {
            Random ran = new Random();
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = ran.Next(1, 49);
                Console.Write(myArray[i] + " ");
            }
            return myArray[5];
        }
    }

}
