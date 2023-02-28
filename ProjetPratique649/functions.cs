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

        //public static int GenerateUnique(int[] myArray, int a)
        //{
        //    HashSet<int> uniqueSet = new HashSet<int>();
        //    Random random = new Random();

        //    while (uniqueSet.Count < 6)
        //    {
        //        int number = random.Next(1, 49);
        //        uniqueSet.Add(number);
        //    }
        //    uniqueSet.CopyTo(myArray);
        //    return myArray[a];
        //}
    }

}
